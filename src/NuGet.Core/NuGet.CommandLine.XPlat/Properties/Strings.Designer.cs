// <auto-generated />
namespace NuGet.CommandLine.XPlat
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("NuGet.CommandLine.XPlat.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// NuGet Command Line
        /// </summary>
        internal static string App_FullName
        {
            get { return GetString("App_FullName"); }
        }

        /// <summary>
        /// NuGet Command Line
        /// </summary>
        internal static string FormatApp_FullName()
        {
            return GetString("App_FullName");
        }

        /// <summary>
        /// Committing restore...
        /// </summary>
        internal static string Log_Committing
        {
            get { return GetString("Log_Committing"); }
        }

        /// <summary>
        /// Committing restore...
        /// </summary>
        internal static string FormatLog_Committing()
        {
            return GetString("Log_Committing");
        }

        /// <summary>
        /// Found project root directory: {0}.
        /// </summary>
        internal static string Log_FoundProjectRoot
        {
            get { return GetString("Log_FoundProjectRoot"); }
        }

        /// <summary>
        /// Found project root directory: {0}.
        /// </summary>
        internal static string FormatLog_FoundProjectRoot(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_FoundProjectRoot"), p0);
        }

        /// <summary>
        /// Loaded project {0} from {1}.
        /// </summary>
        internal static string Log_LoadedProject
        {
            get { return GetString("Log_LoadedProject"); }
        }

        /// <summary>
        /// Loaded project {0} from {1}.
        /// </summary>
        internal static string FormatLog_LoadedProject(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_LoadedProject"), p0, p1);
        }

        /// <summary>
        /// Reading project file {0}.
        /// </summary>
        internal static string Log_ReadingProject
        {
            get { return GetString("Log_ReadingProject"); }
        }

        /// <summary>
        /// Reading project file {0}.
        /// </summary>
        internal static string FormatLog_ReadingProject(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_ReadingProject"), p0);
        }

        /// <summary>
        /// Restore completed in {0}ms.
        /// </summary>
        internal static string Log_RestoreComplete
        {
            get { return GetString("Log_RestoreComplete"); }
        }

        /// <summary>
        /// Restore completed in {0}ms.
        /// </summary>
        internal static string FormatLog_RestoreComplete(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_RestoreComplete"), p0);
        }

        /// <summary>
        /// Restore failed in {0}ms.
        /// </summary>
        internal static string Log_RestoreFailed
        {
            get { return GetString("Log_RestoreFailed"); }
        }

        /// <summary>
        /// Restore failed in {0}ms.
        /// </summary>
        internal static string FormatLog_RestoreFailed(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_RestoreFailed"), p0);
        }

        /// <summary>
        /// Running non-parallel restore.
        /// </summary>
        internal static string Log_RunningNonParallelRestore
        {
            get { return GetString("Log_RunningNonParallelRestore"); }
        }

        /// <summary>
        /// Running non-parallel restore.
        /// </summary>
        internal static string FormatLog_RunningNonParallelRestore()
        {
            return GetString("Log_RunningNonParallelRestore");
        }

        /// <summary>
        /// Running restore with {0} concurrent jobs.
        /// </summary>
        internal static string Log_RunningParallelRestore
        {
            get { return GetString("Log_RunningParallelRestore"); }
        }

        /// <summary>
        /// Running restore with {0} concurrent jobs.
        /// </summary>
        internal static string FormatLog_RunningParallelRestore(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_RunningParallelRestore"), p0);
        }

        /// <summary>
        /// Using packages directory: {0}.
        /// </summary>
        internal static string Log_UsingPackagesDirectory
        {
            get { return GetString("Log_UsingPackagesDirectory"); }
        }

        /// <summary>
        /// Using packages directory: {0}.
        /// </summary>
        internal static string FormatLog_UsingPackagesDirectory(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_UsingPackagesDirectory"), p0);
        }

        /// <summary>
        /// The path to the project to restore for, either a project.json or the directory containing it. Defaults to the current directory.
        /// </summary>
        internal static string Restore_Arg_ProjectName_Description
        {
            get { return GetString("Restore_Arg_ProjectName_Description"); }
        }

        /// <summary>
        /// The path to the project to restore for, either a project.json or the directory containing it. Defaults to the current directory.
        /// </summary>
        internal static string FormatRestore_Arg_ProjectName_Description()
        {
            return GetString("Restore_Arg_ProjectName_Description");
        }

        /// <summary>
        /// Restores packages for a project and writes a lock file.
        /// </summary>
        internal static string Restore_Description
        {
            get { return GetString("Restore_Description"); }
        }

        /// <summary>
        /// Restores packages for a project and writes a lock file.
        /// </summary>
        internal static string FormatRestore_Description()
        {
            return GetString("Restore_Description");
        }

        /// <summary>
        /// A list of packages sources to use as a fallback.
        /// </summary>
        internal static string Restore_Switch_Fallback_Description
        {
            get { return GetString("Restore_Switch_Fallback_Description"); }
        }

        /// <summary>
        /// A list of packages sources to use as a fallback.
        /// </summary>
        internal static string FormatRestore_Switch_Fallback_Description()
        {
            return GetString("Restore_Switch_Fallback_Description");
        }

        /// <summary>
        /// Directory to install packages in.
        /// </summary>
        internal static string Restore_Switch_Packages_Description
        {
            get { return GetString("Restore_Switch_Packages_Description"); }
        }

        /// <summary>
        /// Directory to install packages in.
        /// </summary>
        internal static string FormatRestore_Switch_Packages_Description()
        {
            return GetString("Restore_Switch_Packages_Description");
        }

        /// <summary>
        /// The number of concurrent tasks to use when restoring. Defaults to {0}; pass 'none' to run without concurrency.
        /// </summary>
        internal static string Restore_Switch_Parallel_Description
        {
            get { return GetString("Restore_Switch_Parallel_Description"); }
        }

        /// <summary>
        /// The number of concurrent tasks to use when restoring. Defaults to {0}; pass 'none' to run without concurrency.
        /// </summary>
        internal static string FormatRestore_Switch_Parallel_Description(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Restore_Switch_Parallel_Description"), p0);
        }

        /// <summary>
        /// Specifies a NuGet package source to use during the restore.
        /// </summary>
        internal static string Restore_Switch_Source_Description
        {
            get { return GetString("Restore_Switch_Source_Description"); }
        }

        /// <summary>
        /// Specifies a NuGet package source to use during the restore.
        /// </summary>
        internal static string FormatRestore_Switch_Source_Description()
        {
            return GetString("Restore_Switch_Source_Description");
        }

        /// <summary>
        /// The verbosity of logging to use. Allowed values: Debug, Verbose, Information, Warning, Error.
        /// </summary>
        internal static string Switch_Verbosity
        {
            get { return GetString("Switch_Verbosity"); }
        }

        /// <summary>
        /// The verbosity of logging to use. Allowed values: Debug, Verbose, Information, Warning, Error.
        /// </summary>
        internal static string FormatSwitch_Verbosity()
        {
            return GetString("Switch_Verbosity");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
