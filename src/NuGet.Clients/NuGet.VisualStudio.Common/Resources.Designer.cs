﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.VisualStudio {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.VisualStudio.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Argument cannot be null or empty.
        /// </summary>
        internal static string Argument_Cannot_Be_Null_Or_Empty {
            get {
                return ResourceManager.GetString("Argument_Cannot_Be_Null_Or_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument is not a valid GUID..
        /// </summary>
        internal static string Argument_Invalid_GUID {
            get {
                return ResourceManager.GetString("Argument_Invalid_GUID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be greater than or equal to {0}..
        /// </summary>
        internal static string Argument_Must_Be_GreaterThanOrEqualTo {
            get {
                return ResourceManager.GetString("Argument_Must_Be_GreaterThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Experiment flight &apos;{0}&apos; evaluation overridden by environment variable &apos;{1}&apos; set to &apos;{2}&apos;.
        /// </summary>
        internal static string ExperimentVariableOverrideLogText {
            get {
                return ResourceManager.GetString("ExperimentVariableOverrideLogText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ========== Finished ==========.
        /// </summary>
        internal static string Finished {
            get {
                return ResourceManager.GetString("Finished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the NuGet package manager format for {0}.
        /// </summary>
        internal static string Text_PackageFormatSelection {
            get {
                return ResourceManager.GetString("Text_PackageFormatSelection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the NuGet package manager format for this Solution.
        /// </summary>
        internal static string Text_PackageFormatSelection_Solution {
            get {
                return ResourceManager.GetString("Text_PackageFormatSelection_Solution", resourceCulture);
            }
        }
    }
}
