//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JAdijasok.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JAdijasok.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to -- CREATE DATABASE jadijasok;
        ///-- USE jadijasok;
        ///
        ///CREATE TABLE szemely (
        ///	id INT PRIMARY KEY,
        ///	nev VARCHAR(100) UNIQUE);
        ///
        ///CREATE TABLE foglalkozas (
        ///	id INT FOREIGN KEY REFERENCES szemely(id),
        ///	megnevezes VARCHAR(50));
        ///
        ///CREATE TABLE kituntetes (
        ///	id INT PRIMARY KEY,
        ///	szemelyId INT FOREIGN KEY REFERENCES szemely(id),
        ///	ev INT);
        ///	
        ///INSERT INTO szemely VALUES
        ///(1, &apos;Ablonczy László Ferenc&apos;),
        ///(2, &apos;Abody Béla&apos;),
        ///(3, &apos;Ács Margit&apos;),
        ///(4, &apos;Aczél Géza&apos;),
        ///(5, &apos;Agárdi Péter&apos;),
        ///(6, &apos;Ágh István&apos;),
        ///(7, &apos; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string jadijasok {
            get {
                return ResourceManager.GetString("jadijasok", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] vf14sz {
            get {
                object obj = ResourceManager.GetObject("vf14sz", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
