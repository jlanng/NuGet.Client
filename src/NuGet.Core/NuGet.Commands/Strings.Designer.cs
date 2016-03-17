﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Commands {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Strings() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Commands.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid input &apos;{0}&apos;. The file type was not recognized..
        /// </summary>
        internal static string Error_InvalidCommandLineInput {
            get {
                return ResourceManager.GetString("Error_InvalidCommandLineInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Source parameter was not specified..
        /// </summary>
        internal static string Error_MissingSourceParameter {
            get {
                return ResourceManager.GetString("Error_MissingSourceParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The folder &apos;{0}&apos; does not contain a project to restore..
        /// </summary>
        internal static string Error_UnableToLocateRestoreTarget {
            get {
                return ResourceManager.GetString("Error_UnableToLocateRestoreTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Package &apos;{0}&apos; specifies an invalid build action &apos;{1}&apos; for file &apos;{2}&apos;..
        /// </summary>
        internal static string Error_UnknownBuildAction {
            get {
                return ResourceManager.GetString("Error_UnknownBuildAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified source &apos;{0}&apos; is invalid. Please provide a valid source..
        /// </summary>
        internal static string InvalidSource {
            get {
                return ResourceManager.GetString("InvalidSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Checking compatibility of packages on {0}..
        /// </summary>
        internal static string Log_CheckingCompatibility {
            get {
                return ResourceManager.GetString("Log_CheckingCompatibility", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Checking compatibility for {0} {1} with {2}..
        /// </summary>
        internal static string Log_CheckingPackageCompatibility {
            get {
                return ResourceManager.GetString("Log_CheckingPackageCompatibility", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Committing restore....
        /// </summary>
        internal static string Log_Committing {
            get {
                return ResourceManager.GetString("Log_Committing", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to NuGet Config files used:.
        /// </summary>
        internal static string Log_ConfigFileSummary {
            get {
                return ResourceManager.GetString("Log_ConfigFileSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cycle detected:.
        /// </summary>
        internal static string Log_CycleDetected {
            get {
                return ResourceManager.GetString("Log_CycleDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Dependency specified was {0} {1} but ended up with {2} {3}..
        /// </summary>
        internal static string Log_DependencyBumpedUp {
            get {
                return ResourceManager.GetString("Log_DependencyBumpedUp", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Detected package downgrade: {0} from {1} to {2}.
        /// </summary>
        internal static string Log_DowngradeWarning {
            get {
                return ResourceManager.GetString("Log_DowngradeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Errors in {0}.
        /// </summary>
        internal static string Log_ErrorSummary {
            get {
                return ResourceManager.GetString("Log_ErrorSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Failed to resolve conflicts for {0}..
        /// </summary>
        internal static string Log_FailedToResolveConflicts {
            get {
                return ResourceManager.GetString("Log_FailedToResolveConflicts", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Feeds used:.
        /// </summary>
        internal static string Log_FeedsUsedSummary {
            get {
                return ResourceManager.GetString("Log_FeedsUsedSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Found project root directory: {0}..
        /// </summary>
        internal static string Log_FoundProjectRoot {
            get {
                return ResourceManager.GetString("Log_FoundProjectRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Generating MSBuild file {0}..
        /// </summary>
        internal static string Log_GeneratingMsBuildFile {
            get {
                return ResourceManager.GetString("Log_GeneratingMsBuildFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Package &apos;{0}&apos; was restored using &apos;{1}&apos; instead the project target framework &apos;{2}&apos;. This may cause compatibility problems..
        /// </summary>
        internal static string Log_ImportsFallbackWarning {
            get {
                return ResourceManager.GetString("Log_ImportsFallbackWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Installed:.
        /// </summary>
        internal static string Log_InstalledSummary {
            get {
                return ResourceManager.GetString("Log_InstalledSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} package(s) to {1}.
        /// </summary>
        internal static string Log_InstalledSummaryCount {
            get {
                return ResourceManager.GetString("Log_InstalledSummaryCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Installing {0} {1}..
        /// </summary>
        internal static string Log_InstallingPackage {
            get {
                return ResourceManager.GetString("Log_InstallingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Loaded project {0} from {1}..
        /// </summary>
        internal static string Log_LoadedProject {
            get {
                return ResourceManager.GetString("Log_LoadedProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} {1} is specified in the Lock File target for {2} but is not present in the top-level Libraries list..
        /// </summary>
        internal static string Log_LockFileMissingLibraryForTargetLibrary {
            get {
                return ResourceManager.GetString("Log_LockFileMissingLibraryForTargetLibrary", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The lock file is out-of-date relative to the project file. Regenerating the lock file and re-locking..
        /// </summary>
        internal static string Log_LockFileOutOfDate {
            get {
                return ResourceManager.GetString("Log_LockFileOutOfDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Merging in runtimes defined in {0}..
        /// </summary>
        internal static string Log_MergingRuntimes {
            get {
                return ResourceManager.GetString("Log_MergingRuntimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} {1} provides a compile-time reference assembly for {2} on {3}, but there is no compatible run-time assembly..
        /// </summary>
        internal static string Log_MissingImplementationFx {
            get {
                return ResourceManager.GetString("Log_MissingImplementationFx", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} {1} provides a compile-time reference assembly for {2} on {3}, but there is no run-time assembly compatible with {4}..
        /// </summary>
        internal static string Log_MissingImplementationFxRuntime {
            get {
                return ResourceManager.GetString("Log_MissingImplementationFxRuntime", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} {1} is not compatible with {2}..
        /// </summary>
        internal static string Log_PackageNotCompatibleWithFx {
            get {
                return ResourceManager.GetString("Log_PackageNotCompatibleWithFx", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to All packages are compatible with {0}..
        /// </summary>
        internal static string Log_PackagesAreCompatible {
            get {
                return ResourceManager.GetString("Log_PackagesAreCompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Some packages are not compatible with {0}..
        /// </summary>
        internal static string Log_PackagesIncompatible {
            get {
                return ResourceManager.GetString("Log_PackagesIncompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The project &apos;{0}&apos; does not specify any target frameworks in &apos;{1}&apos;..
        /// </summary>
        internal static string Log_ProjectDoesNotSpecifyTargetFrameworks {
            get {
                return ResourceManager.GetString("Log_ProjectDoesNotSpecifyTargetFrameworks", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Reading project file {0}..
        /// </summary>
        internal static string Log_ReadingProject {
            get {
                return ResourceManager.GetString("Log_ReadingProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to satisfy conflicting requests for &apos;{0}&apos;: {1}.
        /// </summary>
        internal static string Log_ResolverConflict {
            get {
                return ResourceManager.GetString("Log_ResolverConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Resolving conflicts for {0}....
        /// </summary>
        internal static string Log_ResolvingConflicts {
            get {
                return ResourceManager.GetString("Log_ResolvingConflicts", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restore completed in {0}ms..
        /// </summary>
        internal static string Log_RestoreComplete {
            get {
                return ResourceManager.GetString("Log_RestoreComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restore failed in {0}ms..
        /// </summary>
        internal static string Log_RestoreFailed {
            get {
                return ResourceManager.GetString("Log_RestoreFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restoring packages for {0}....
        /// </summary>
        internal static string Log_RestoringPackages {
            get {
                return ResourceManager.GetString("Log_RestoringPackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restoring packages for {0} to determine compatibility....
        /// </summary>
        internal static string Log_RestoringPackagesForCompat {
            get {
                return ResourceManager.GetString("Log_RestoringPackagesForCompat", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restoring packages for tool &apos;{0}&apos; in {1}....
        /// </summary>
        internal static string Log_RestoringToolPackages {
            get {
                return ResourceManager.GetString("Log_RestoringToolPackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Running non-parallel restore..
        /// </summary>
        internal static string Log_RunningNonParallelRestore {
            get {
                return ResourceManager.GetString("Log_RunningNonParallelRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Running restore with {0} concurrent jobs..
        /// </summary>
        internal static string Log_RunningParallelRestore {
            get {
                return ResourceManager.GetString("Log_RunningParallelRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Scanning packages for runtime.json files....
        /// </summary>
        internal static string Log_ScanningForRuntimeJson {
            get {
                return ResourceManager.GetString("Log_ScanningForRuntimeJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Skipping runtime dependency walk, no runtimes defined in project.json..
        /// </summary>
        internal static string Log_SkippingRuntimeWalk {
            get {
                return ResourceManager.GetString("Log_SkippingRuntimeWalk", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unknown Compatibility Profile: {0}.
        /// </summary>
        internal static string Log_UnknownCompatibilityProfile {
            get {
                return ResourceManager.GetString("Log_UnknownCompatibilityProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to resolve {0} {1} for {2}..
        /// </summary>
        internal static string Log_UnresolvedDependency {
            get {
                return ResourceManager.GetString("Log_UnresolvedDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Using packages directory: {0}..
        /// </summary>
        internal static string Log_UsingPackagesDirectory {
            get {
                return ResourceManager.GetString("Log_UsingPackagesDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Using source {0}..
        /// </summary>
        internal static string Log_UsingSource {
            get {
                return ResourceManager.GetString("Log_UsingSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Version conflict detected for {0}..
        /// </summary>
        internal static string Log_VersionConflict {
            get {
                return ResourceManager.GetString("Log_VersionConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Packages containing MSBuild targets and props files cannot be fully installed in projects targeting multiple frameworks. The MSBuild targets and props files have been ignored..
        /// </summary>
        internal static string MSBuildWarning_MultiTarget {
            get {
                return ResourceManager.GetString("MSBuildWarning_MultiTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} (via {1}).
        /// </summary>
        internal static string ResolverRequest_ToStringFormat {
            get {
                return ResourceManager.GetString("ResolverRequest_ToStringFormat", resourceCulture);
            }
        }
    }
}
