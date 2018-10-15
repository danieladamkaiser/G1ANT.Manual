﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace G1ANT.Manual.Sync.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/*\r\n *    Copyright (C) {company}, All rights reserved\r\n *    Solution {solution}" +
            ", Project {project}\r\n *    {website}\r\n *\r\n *    Licensed under the {license} lic" +
            "ense.\r\n *    See License.txt file in the project root for full license informati" +
            "on.\r\n *\r\n */")]
        public string CopyrightHeader {
            get {
                return ((string)(this["CopyrightHeader"]));
            }
            set {
                this["CopyrightHeader"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\n\r\n| Name | Description | Addon |\r\n| ---- | ----------- | ----- |\r\n")]
        public string ManualHeader {
            get {
                return ((string)(this["ManualHeader"]));
            }
            set {
                this["ManualHeader"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("www.g1ant.com")]
        public string DefaultWebsiteUrl {
            get {
                return ((string)(this["DefaultWebsiteUrl"]));
            }
            set {
                this["DefaultWebsiteUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("G1ANT Ltd")]
        public string DefaultCompany {
            get {
                return ((string)(this["DefaultCompany"]));
            }
            set {
                this["DefaultCompany"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("G1ANT")]
        public string DefaultLicense {
            get {
                return ((string)(this["DefaultLicense"]));
            }
            set {
                this["DefaultLicense"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("G1ANT.Manual.Log")]
        public string LogFileName {
            get {
                return ((string)(this["LogFileName"]));
            }
            set {
                this["LogFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/G1ANT-Robot/")]
        public string RepositoryUrl {
            get {
                return ((string)(this["RepositoryUrl"]));
            }
            set {
                this["RepositoryUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{0:yyyy-MM-dd HH:mm:ss} - {1}")]
        public string LogLineFormat {
            get {
                return ((string)(this["LogLineFormat"]));
            }
            set {
                this["LogLineFormat"] = value;
            }
        }
    }
}
