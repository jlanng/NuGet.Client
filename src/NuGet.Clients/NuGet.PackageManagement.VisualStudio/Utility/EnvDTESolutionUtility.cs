﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuGet.VisualStudio;
using Task = System.Threading.Tasks.Task;

namespace NuGet.PackageManagement.VisualStudio
{
    public static class EnvDTESolutionUtility
    {
        /// <summary>
        /// Get the list of all supported projects in the current solution. This method
        /// recursively iterates through all projects.
        /// </summary>
        public static IEnumerable<EnvDTE.Project> GetAllEnvDTEProjects(EnvDTE.DTE dte)
        {
            return NuGetUIThreadHelper.JoinableTaskFactory.Run(async delegate
                {
                    var result = await GetAllEnvDTEProjectsAsync(dte);
                    return result;
                });
        }

        public static async Task<IEnumerable<EnvDTE.Project>> GetAllEnvDTEProjectsAsync(EnvDTE.DTE dte)
        {
            await NuGetUIThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

            var envDTESolution = dte.Solution;
            if (envDTESolution == null
                || !envDTESolution.IsOpen)
            {
                return Enumerable.Empty<EnvDTE.Project>();
            }

            var envDTEProjects = new Stack<EnvDTE.Project>();
            foreach (EnvDTE.Project envDTEProject in envDTESolution.Projects)
            {
                if (!EnvDTEProjectUtility.IsExplicitlyUnsupported(envDTEProject))
                {
                    envDTEProjects.Push(envDTEProject);
                }
            }

            var resultantEnvDTEProjects = new List<EnvDTE.Project>();
            while (envDTEProjects.Any())
            {
                var envDTEProject = envDTEProjects.Pop();

                if (EnvDTEProjectUtility.IsSupported(envDTEProject))
                {
                    resultantEnvDTEProjects.Add(envDTEProject);
                }
                else if (EnvDTEProjectUtility.IsExplicitlyUnsupported(envDTEProject))
                {
                    // do not drill down further if this project is explicitly unsupported, e.g. LightSwitch projects
                    continue;
                }

                EnvDTE.ProjectItems envDTEProjectItems = null;
                try
                {
                    // bug 1138: Oracle Database Project doesn't implement the ProjectItems property
                    envDTEProjectItems = envDTEProject.ProjectItems;
                }
                catch (NotImplementedException)
                {
                    continue;
                }

                // ProjectItems property can be null if the project is unloaded
                if (envDTEProjectItems != null)
                {
                    foreach (EnvDTE.ProjectItem envDTEProjectItem in envDTEProjectItems)
                    {
                        try
                        {
                            if (envDTEProjectItem.SubProject != null)
                            {
                                envDTEProjects.Push(envDTEProjectItem.SubProject);
                            }
                        }
                        catch (NotImplementedException)
                        {
                            // Some project system don't implement the SubProject property,
                            // just ignore those
                        }
                    }
                }
            }

            return resultantEnvDTEProjects;
        }

        public static Task<Dictionary<string, EnvDTE.Project>> GetPathToDTEProjectLookupAsync(EnvDTE.DTE dte)
        {
            var pathToProject = new Dictionary<string, EnvDTE.Project>(StringComparer.OrdinalIgnoreCase);

            var supportedProjects = dte.Solution.Projects.Cast<EnvDTE.Project>();

            foreach (var solutionProject in supportedProjects)
            {
                var solutionProjectPath = EnvDTEProjectInfoUtility.GetFullProjectPath(solutionProject);

                if (!string.IsNullOrEmpty(solutionProjectPath) &&
                    !pathToProject.ContainsKey(solutionProjectPath))
                {
                    pathToProject.Add(solutionProjectPath, solutionProject);
                }
            }

            return Task.FromResult(pathToProject);
        }
    }
}
