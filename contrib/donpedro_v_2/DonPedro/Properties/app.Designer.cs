﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DonPedro.Properties {
	
	
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("ICSharpCode.SettingsEditor.SettingsCodeGeneratorTool", "4.2.2.8818")]
	internal sealed partial class app : global::System.Configuration.ApplicationSettingsBase {
		
		private static app defaultInstance = ((app)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new app())));
		
		public static app Default {
			get {
				return defaultInstance;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string api_key {
			get {
				return ((string)(this["api_key"]));
			}
			set {
				this["api_key"] = value;
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("/api/v0.9/windowsdevice")]
		public string api_path {
			get {
				return ((string)(this["api_path"]));
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string api_user {
			get {
				return ((string)(this["api_user"]));
			}
			set {
				this["api_user"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("5")]
		public int max_tries {
			get {
				return ((int)(this["max_tries"]));
			}
			set {
				this["max_tries"] = value;
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("3600")]
		public int notifications_interval {
			get {
				return ((int)(this["notifications_interval"]));
			}
		}
		
		[global::System.Configuration.ApplicationScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("")]
		public string ralph_url {
			get {
				return ((string)(this["ralph_url"]));
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("300")]
		public int tries_interval {
			get {
				return ((int)(this["tries_interval"]));
			}
			set {
				this["tries_interval"] = value;
			}
		}
	}
}
