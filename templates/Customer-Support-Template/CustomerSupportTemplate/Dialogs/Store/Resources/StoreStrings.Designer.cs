﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerSupportTemplate.Dialogs.Store.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class StoreStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StoreStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CustomerSupportTemplate.Dialogs.Store.Resources.StoreStrings", typeof(StoreStrings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like me to place the item on hold?.
        /// </summary>
        public static string HoldItemPrompt {
            get {
                return ResourceManager.GetString("HoldItemPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I have placed the item on hold for you..
        /// </summary>
        public static string HoldItemSuccessMessage {
            get {
                return ResourceManager.GetString("HoldItemSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I am happy to help. What is the item number you are looking for?.
        /// </summary>
        public static string ItemIdPrompt {
            get {
                return ResourceManager.GetString("ItemIdPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, I didn&apos;t understand that. The item id is a 9 digit code found in the product description..
        /// </summary>
        public static string ItemIdReprompt {
            get {
                return ResourceManager.GetString("ItemIdReprompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Here are the closest stores to you carrying this product:.
        /// </summary>
        public static string NearbyStoresMessage {
            get {
                return ResourceManager.GetString("NearbyStoresMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What is your zip code?.
        /// </summary>
        public static string ZipCodePrompt {
            get {
                return ResourceManager.GetString("ZipCodePrompt", resourceCulture);
            }
        }
    }
}
