﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAntGui.Gui.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int MaxRecentItems {
            get {
                return ((int)(this["MaxRecentItems"]));
            }
            set {
                this["MaxRecentItems"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HideTargetsWithoutDescription {
            get {
                return ((bool)(this["HideTargetsWithoutDescription"]));
            }
            set {
                this["HideTargetsWithoutDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point MainFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["MainFormLocation"]));
            }
            set {
                this["MainFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800, 600")]
        public global::System.Drawing.Size MainFormSize {
            get {
                return ((global::System.Drawing.Size)(this["MainFormSize"]));
            }
            set {
                this["MainFormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState MainFormState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["MainFormState"]));
            }
            set {
                this["MainFormState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alphabetical")]
        public global::System.Windows.Forms.PropertySort PropertySort {
            get {
                return ((global::System.Windows.Forms.PropertySort)(this["PropertySort"]));
            }
            set {
                this["PropertySort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>C:\\Example.build</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection RecentItems {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentItems"]));
            }
            set {
                this["RecentItems"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OpenPreviousTabs {
            get {
                return ((bool)(this["OpenPreviousTabs"]));
            }
            set {
                this["OpenPreviousTabs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string OpenScriptDir {
            get {
                return ((string)(this["OpenScriptDir"]));
            }
            set {
                this["OpenScriptDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string SaveScriptInitialDir {
            get {
                return ((string)(this["SaveScriptInitialDir"]));
            }
            set {
                this["SaveScriptInitialDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string SaveOutputInitialDir {
            get {
                return ((string)(this["SaveOutputInitialDir"]));
            }
            set {
                this["SaveOutputInitialDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WordWrapOutput {
            get {
                return ((bool)(this["WordWrapOutput"]));
            }
            set {
                this["WordWrapOutput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3, 0")]
        public global::System.Drawing.Point StandardToolStripLocation {
            get {
                return ((global::System.Drawing.Point)(this["StandardToolStripLocation"]));
            }
            set {
                this["StandardToolStripLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("286, 0")]
        public global::System.Drawing.Point BuildToolStripLocation {
            get {
                return ((global::System.Drawing.Point)(this["BuildToolStripLocation"]));
            }
            set {
                this["BuildToolStripLocation"] = value;
            }
        }
    }
}
