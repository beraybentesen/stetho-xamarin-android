using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho']"
	[global::Android.Runtime.Register ("com/facebook/stetho/Stetho", DoNotGenerateAcw=true)]
	public partial class Stetho : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.BuilderBasedInitializer']"
		[global::Android.Runtime.Register ("com/facebook/stetho/Stetho$BuilderBasedInitializer", DoNotGenerateAcw=true)]
		public partial class BuilderBasedInitializer : global::Com.Facebook.Stetho.Stetho.Initializer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/Stetho$BuilderBasedInitializer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BuilderBasedInitializer); }
			}

			protected BuilderBasedInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getDumperPlugins;
#pragma warning disable 0169
			static Delegate GetGetDumperPluginsHandler ()
			{
				if (cb_getDumperPlugins == null)
					cb_getDumperPlugins = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDumperPlugins);
				return cb_getDumperPlugins;
			}

			static IntPtr n_GetDumperPlugins (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Stetho.BuilderBasedInitializer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.BuilderBasedInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DumperPlugins);
			}
#pragma warning restore 0169

			static IntPtr id_getDumperPlugins;
			protected override unsafe global::Java.Lang.IIterable DumperPlugins {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.BuilderBasedInitializer']/method[@name='getDumperPlugins' and count(parameter)=0]"
				[Register ("getDumperPlugins", "()Ljava/lang/Iterable;", "GetGetDumperPluginsHandler")]
				get {
					if (id_getDumperPlugins == IntPtr.Zero)
						id_getDumperPlugins = JNIEnv.GetMethodID (class_ref, "getDumperPlugins", "()Ljava/lang/Iterable;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDumperPlugins), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDumperPlugins", "()Ljava/lang/Iterable;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getInspectorModules;
#pragma warning disable 0169
			static Delegate GetGetInspectorModulesHandler ()
			{
				if (cb_getInspectorModules == null)
					cb_getInspectorModules = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInspectorModules);
				return cb_getInspectorModules;
			}

			static IntPtr n_GetInspectorModules (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Stetho.BuilderBasedInitializer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.BuilderBasedInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InspectorModules);
			}
#pragma warning restore 0169

			static IntPtr id_getInspectorModules;
			protected override unsafe global::Java.Lang.IIterable InspectorModules {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.BuilderBasedInitializer']/method[@name='getInspectorModules' and count(parameter)=0]"
				[Register ("getInspectorModules", "()Ljava/lang/Iterable;", "GetGetInspectorModulesHandler")]
				get {
					if (id_getInspectorModules == IntPtr.Zero)
						id_getInspectorModules = JNIEnv.GetMethodID (class_ref, "getInspectorModules", "()Ljava/lang/Iterable;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInspectorModules), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInspectorModules", "()Ljava/lang/Iterable;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultDumperPluginsBuilder']"
		[global::Android.Runtime.Register ("com/facebook/stetho/Stetho$DefaultDumperPluginsBuilder", DoNotGenerateAcw=true)]
		public sealed partial class DefaultDumperPluginsBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/Stetho$DefaultDumperPluginsBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultDumperPluginsBuilder); }
			}

			internal DefaultDumperPluginsBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultDumperPluginsBuilder']/constructor[@name='Stetho.DefaultDumperPluginsBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe DefaultDumperPluginsBuilder (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (DefaultDumperPluginsBuilder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static IntPtr id_finish;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultDumperPluginsBuilder']/method[@name='finish' and count(parameter)=0]"
			[Register ("finish", "()Ljava/lang/Iterable;", "")]
			public unsafe global::Java.Lang.IIterable Finish ()
			{
				if (id_finish == IntPtr.Zero)
					id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()Ljava/lang/Iterable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finish), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_remove_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultDumperPluginsBuilder']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("remove", "(Ljava/lang/String;)Lcom/facebook/stetho/Stetho$DefaultDumperPluginsBuilder;", "")]
			public unsafe global::Com.Facebook.Stetho.Stetho.DefaultDumperPluginsBuilder Remove (string p0)
			{
				if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
					id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Lcom/facebook/stetho/Stetho$DefaultDumperPluginsBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Facebook.Stetho.Stetho.DefaultDumperPluginsBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.DefaultDumperPluginsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']"
		[global::Android.Runtime.Register ("com/facebook/stetho/Stetho$DefaultInspectorModulesBuilder", DoNotGenerateAcw=true)]
		public sealed partial class DefaultInspectorModulesBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/Stetho$DefaultInspectorModulesBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultInspectorModulesBuilder); }
			}

			internal DefaultInspectorModulesBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']/constructor[@name='Stetho.DefaultInspectorModulesBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe DefaultInspectorModulesBuilder (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (DefaultInspectorModulesBuilder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static IntPtr id_databaseFiles_Lcom_facebook_stetho_inspector_database_DatabaseFilesProvider_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']/method[@name='databaseFiles' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.database.DatabaseFilesProvider']]"
			[Obsolete (@"deprecated")]
			[Register ("databaseFiles", "(Lcom/facebook/stetho/inspector/database/DatabaseFilesProvider;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;", "")]
			public unsafe global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder DatabaseFiles (global::Com.Facebook.Stetho.Inspector.Database.IDatabaseFilesProvider p0)
			{
				if (id_databaseFiles_Lcom_facebook_stetho_inspector_database_DatabaseFilesProvider_ == IntPtr.Zero)
					id_databaseFiles_Lcom_facebook_stetho_inspector_database_DatabaseFilesProvider_ = JNIEnv.GetMethodID (class_ref, "databaseFiles", "(Lcom/facebook/stetho/inspector/database/DatabaseFilesProvider;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_databaseFiles_Lcom_facebook_stetho_inspector_database_DatabaseFilesProvider_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_documentProvider_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']/method[@name='documentProvider' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.DocumentProviderFactory']]"
			[Register ("documentProvider", "(Lcom/facebook/stetho/inspector/elements/DocumentProviderFactory;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;", "")]
			public unsafe global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder DocumentProvider (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderFactory p0)
			{
				if (id_documentProvider_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_ == IntPtr.Zero)
					id_documentProvider_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_ = JNIEnv.GetMethodID (class_ref, "documentProvider", "(Lcom/facebook/stetho/inspector/elements/DocumentProviderFactory;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_documentProvider_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_finish;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']/method[@name='finish' and count(parameter)=0]"
			[Register ("finish", "()Ljava/lang/Iterable;", "")]
			public unsafe global::Java.Lang.IIterable Finish ()
			{
				if (id_finish == IntPtr.Zero)
					id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()Ljava/lang/Iterable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finish), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_provide_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']/method[@name='provide' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.protocol.ChromeDevtoolsDomain']]"
			[Obsolete (@"deprecated")]
			[Register ("provide", "(Lcom/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;", "")]
			public unsafe global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder Provide (global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain p0)
			{
				if (id_provide_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_ == IntPtr.Zero)
					id_provide_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_ = JNIEnv.GetMethodID (class_ref, "provide", "(Lcom/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_provide_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_provideDatabaseDriver_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']/method[@name='provideDatabaseDriver' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.protocol.module.Database.DatabaseDriver']]"
			[Register ("provideDatabaseDriver", "(Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;", "")]
			public unsafe global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder ProvideDatabaseDriver (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver p0)
			{
				if (id_provideDatabaseDriver_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ == IntPtr.Zero)
					id_provideDatabaseDriver_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ = JNIEnv.GetMethodID (class_ref, "provideDatabaseDriver", "(Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_provideDatabaseDriver_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_remove_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Obsolete (@"deprecated")]
			[Register ("remove", "(Ljava/lang/String;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;", "")]
			public unsafe global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder Remove (string p0)
			{
				if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
					id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_runtimeRepl_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.DefaultInspectorModulesBuilder']/method[@name='runtimeRepl' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.console.RuntimeReplFactory']]"
			[Register ("runtimeRepl", "(Lcom/facebook/stetho/inspector/console/RuntimeReplFactory;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;", "")]
			public unsafe global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder RuntimeRepl (global::Com.Facebook.Stetho.Inspector.Console.IRuntimeReplFactory p0)
			{
				if (id_runtimeRepl_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_ == IntPtr.Zero)
					id_runtimeRepl_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_ = JNIEnv.GetMethodID (class_ref, "runtimeRepl", "(Lcom/facebook/stetho/inspector/console/RuntimeReplFactory;)Lcom/facebook/stetho/Stetho$DefaultInspectorModulesBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.DefaultInspectorModulesBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_runtimeRepl_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.Initializer']"
		[global::Android.Runtime.Register ("com/facebook/stetho/Stetho$Initializer", DoNotGenerateAcw=true)]
		public abstract partial class Initializer : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.Initializer.RealSocketHandlerFactory']"
			[global::Android.Runtime.Register ("com/facebook/stetho/Stetho$Initializer$RealSocketHandlerFactory", DoNotGenerateAcw=true)]
			public partial class RealSocketHandlerFactory : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.ISocketHandlerFactory {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/facebook/stetho/Stetho$Initializer$RealSocketHandlerFactory", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (RealSocketHandlerFactory); }
				}

				protected RealSocketHandlerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_create;
#pragma warning disable 0169
				static Delegate GetCreateHandler ()
				{
					if (cb_create == null)
						cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Create);
					return cb_create;
				}

				static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Facebook.Stetho.Stetho.Initializer.RealSocketHandlerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.Initializer.RealSocketHandlerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.Create ());
				}
#pragma warning restore 0169

				static IntPtr id_create;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.Initializer.RealSocketHandlerFactory']/method[@name='create' and count(parameter)=0]"
				[Register ("create", "()Lcom/facebook/stetho/server/SocketHandler;", "GetCreateHandler")]
				public virtual unsafe global::Com.Facebook.Stetho.Server.ISocketHandler Create ()
				{
					if (id_create == IntPtr.Zero)
						id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lcom/facebook/stetho/server/SocketHandler;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ISocketHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ISocketHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "()Lcom/facebook/stetho/server/SocketHandler;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/Stetho$Initializer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Initializer); }
			}

			protected Initializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.Initializer']/constructor[@name='Stetho.Initializer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			protected unsafe Initializer (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Initializer)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static Delegate cb_getDumperPlugins;
#pragma warning disable 0169
			static Delegate GetGetDumperPluginsHandler ()
			{
				if (cb_getDumperPlugins == null)
					cb_getDumperPlugins = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDumperPlugins);
				return cb_getDumperPlugins;
			}

			static IntPtr n_GetDumperPlugins (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Stetho.Initializer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.Initializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DumperPlugins);
			}
#pragma warning restore 0169

			protected abstract global::Java.Lang.IIterable DumperPlugins {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.Initializer']/method[@name='getDumperPlugins' and count(parameter)=0]"
				[Register ("getDumperPlugins", "()Ljava/lang/Iterable;", "GetGetDumperPluginsHandler")] get;
			}

			static Delegate cb_getInspectorModules;
#pragma warning disable 0169
			static Delegate GetGetInspectorModulesHandler ()
			{
				if (cb_getInspectorModules == null)
					cb_getInspectorModules = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInspectorModules);
				return cb_getInspectorModules;
			}

			static IntPtr n_GetInspectorModules (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Stetho.Initializer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.Initializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InspectorModules);
			}
#pragma warning restore 0169

			protected abstract global::Java.Lang.IIterable InspectorModules {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.Initializer']/method[@name='getInspectorModules' and count(parameter)=0]"
				[Register ("getInspectorModules", "()Ljava/lang/Iterable;", "GetGetInspectorModulesHandler")] get;
			}

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/Stetho$Initializer", DoNotGenerateAcw=true)]
		internal partial class InitializerInvoker : Initializer {

			public InitializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (InitializerInvoker); }
			}

			static IntPtr id_getDumperPlugins;
			protected override unsafe global::Java.Lang.IIterable DumperPlugins {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.Initializer']/method[@name='getDumperPlugins' and count(parameter)=0]"
				[Register ("getDumperPlugins", "()Ljava/lang/Iterable;", "GetGetDumperPluginsHandler")]
				get {
					if (id_getDumperPlugins == IntPtr.Zero)
						id_getDumperPlugins = JNIEnv.GetMethodID (class_ref, "getDumperPlugins", "()Ljava/lang/Iterable;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDumperPlugins), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getInspectorModules;
			protected override unsafe global::Java.Lang.IIterable InspectorModules {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.Initializer']/method[@name='getInspectorModules' and count(parameter)=0]"
				[Register ("getInspectorModules", "()Ljava/lang/Iterable;", "GetGetInspectorModulesHandler")]
				get {
					if (id_getInspectorModules == IntPtr.Zero)
						id_getInspectorModules = JNIEnv.GetMethodID (class_ref, "getInspectorModules", "()Ljava/lang/Iterable;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInspectorModules), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.InitializerBuilder']"
		[global::Android.Runtime.Register ("com/facebook/stetho/Stetho$InitializerBuilder", DoNotGenerateAcw=true)]
		public partial class InitializerBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/Stetho$InitializerBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InitializerBuilder); }
			}

			protected InitializerBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Stetho.InitializerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.InitializerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.InitializerBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/stetho/Stetho$Initializer;", "GetBuildHandler")]
			public virtual unsafe global::Com.Facebook.Stetho.Stetho.Initializer Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/stetho/Stetho$Initializer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.Initializer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.Initializer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/facebook/stetho/Stetho$Initializer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_enableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_;
#pragma warning disable 0169
			static Delegate GetEnableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_Handler ()
			{
				if (cb_enableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_ == null)
					cb_enableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EnableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_);
				return cb_enableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_;
			}

			static IntPtr n_EnableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Stetho.InitializerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.InitializerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.IDumperPluginsProvider p0 = (global::Com.Facebook.Stetho.IDumperPluginsProvider)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.IDumperPluginsProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EnableDumpapp (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_enableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.InitializerBuilder']/method[@name='enableDumpapp' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.DumperPluginsProvider']]"
			[Register ("enableDumpapp", "(Lcom/facebook/stetho/DumperPluginsProvider;)Lcom/facebook/stetho/Stetho$InitializerBuilder;", "GetEnableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_Handler")]
			public virtual unsafe global::Com.Facebook.Stetho.Stetho.InitializerBuilder EnableDumpapp (global::Com.Facebook.Stetho.IDumperPluginsProvider p0)
			{
				if (id_enableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_ == IntPtr.Zero)
					id_enableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_ = JNIEnv.GetMethodID (class_ref, "enableDumpapp", "(Lcom/facebook/stetho/DumperPluginsProvider;)Lcom/facebook/stetho/Stetho$InitializerBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Facebook.Stetho.Stetho.InitializerBuilder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.InitializerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableDumpapp_Lcom_facebook_stetho_DumperPluginsProvider_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.InitializerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableDumpapp", "(Lcom/facebook/stetho/DumperPluginsProvider;)Lcom/facebook/stetho/Stetho$InitializerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_enableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_;
#pragma warning disable 0169
			static Delegate GetEnableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_Handler ()
			{
				if (cb_enableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_ == null)
					cb_enableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EnableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_);
				return cb_enableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_;
			}

			static IntPtr n_EnableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Stetho.InitializerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.InitializerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.IInspectorModulesProvider p0 = (global::Com.Facebook.Stetho.IInspectorModulesProvider)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.IInspectorModulesProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EnableWebKitInspector (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_enableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.InitializerBuilder']/method[@name='enableWebKitInspector' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.InspectorModulesProvider']]"
			[Register ("enableWebKitInspector", "(Lcom/facebook/stetho/InspectorModulesProvider;)Lcom/facebook/stetho/Stetho$InitializerBuilder;", "GetEnableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_Handler")]
			public virtual unsafe global::Com.Facebook.Stetho.Stetho.InitializerBuilder EnableWebKitInspector (global::Com.Facebook.Stetho.IInspectorModulesProvider p0)
			{
				if (id_enableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_ == IntPtr.Zero)
					id_enableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_ = JNIEnv.GetMethodID (class_ref, "enableWebKitInspector", "(Lcom/facebook/stetho/InspectorModulesProvider;)Lcom/facebook/stetho/Stetho$InitializerBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Facebook.Stetho.Stetho.InitializerBuilder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.InitializerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableWebKitInspector_Lcom_facebook_stetho_InspectorModulesProvider_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.InitializerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableWebKitInspector", "(Lcom/facebook/stetho/InspectorModulesProvider;)Lcom/facebook/stetho/Stetho$InitializerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.PluginBuilder']"
		[global::Android.Runtime.Register ("com/facebook/stetho/Stetho$PluginBuilder", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class PluginBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/Stetho$PluginBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PluginBuilder); }
			}

			protected PluginBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_finish;
#pragma warning disable 0169
			static Delegate GetFinishHandler ()
			{
				if (cb_finish == null)
					cb_finish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Finish);
				return cb_finish;
			}

			static IntPtr n_Finish (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Stetho.PluginBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.PluginBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Finish ());
			}
#pragma warning restore 0169

			static IntPtr id_finish;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.PluginBuilder']/method[@name='finish' and count(parameter)=0]"
			[Register ("finish", "()Ljava/lang/Iterable;", "GetFinishHandler")]
			public virtual unsafe global::Java.Lang.IIterable Finish ()
			{
				if (id_finish == IntPtr.Zero)
					id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()Ljava/lang/Iterable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finish), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finish", "()Ljava/lang/Iterable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_provide_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetProvide_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_provide_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_provide_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Provide_Ljava_lang_String_Ljava_lang_Object_);
				return cb_provide_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_Provide_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Facebook.Stetho.Stetho.PluginBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.PluginBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Provide (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_provide_Ljava_lang_String_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.PluginBuilder']/method[@name='provide' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
			[Register ("provide", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetProvide_Ljava_lang_String_Ljava_lang_Object_Handler")]
			public virtual unsafe void Provide (string p0, global::Java.Lang.Object p1)
			{
				if (id_provide_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_provide_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "provide", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_provide_Ljava_lang_String_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "provide", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_provideIfDesired_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetProvideIfDesired_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_provideIfDesired_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_provideIfDesired_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProvideIfDesired_Ljava_lang_String_Ljava_lang_Object_);
				return cb_provideIfDesired_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_ProvideIfDesired_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Facebook.Stetho.Stetho.PluginBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.PluginBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ProvideIfDesired (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_provideIfDesired_Ljava_lang_String_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.PluginBuilder']/method[@name='provideIfDesired' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
			[Register ("provideIfDesired", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetProvideIfDesired_Ljava_lang_String_Ljava_lang_Object_Handler")]
			public virtual unsafe void ProvideIfDesired (string p0, global::Java.Lang.Object p1)
			{
				if (id_provideIfDesired_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_provideIfDesired_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "provideIfDesired", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_provideIfDesired_Ljava_lang_String_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "provideIfDesired", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemove_Ljava_lang_String_Handler ()
			{
				if (cb_remove_Ljava_lang_String_ == null)
					cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
				return cb_remove_Ljava_lang_String_;
			}

			static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Stetho.PluginBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.PluginBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Remove (p0);
			}
#pragma warning restore 0169

			static IntPtr id_remove_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho.PluginBuilder']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
			public virtual unsafe void Remove (string p0)
			{
				if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
					id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/Stetho", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Stetho); }
		}

		protected Stetho (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_defaultDumperPluginsProvider_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho']/method[@name='defaultDumperPluginsProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("defaultDumperPluginsProvider", "(Landroid/content/Context;)Lcom/facebook/stetho/DumperPluginsProvider;", "")]
		public static unsafe global::Com.Facebook.Stetho.IDumperPluginsProvider DefaultDumperPluginsProvider (global::Android.Content.Context p0)
		{
			if (id_defaultDumperPluginsProvider_Landroid_content_Context_ == IntPtr.Zero)
				id_defaultDumperPluginsProvider_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "defaultDumperPluginsProvider", "(Landroid/content/Context;)Lcom/facebook/stetho/DumperPluginsProvider;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Facebook.Stetho.IDumperPluginsProvider __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.IDumperPluginsProvider> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultDumperPluginsProvider_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_defaultInspectorModulesProvider_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho']/method[@name='defaultInspectorModulesProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("defaultInspectorModulesProvider", "(Landroid/content/Context;)Lcom/facebook/stetho/InspectorModulesProvider;", "")]
		public static unsafe global::Com.Facebook.Stetho.IInspectorModulesProvider DefaultInspectorModulesProvider (global::Android.Content.Context p0)
		{
			if (id_defaultInspectorModulesProvider_Landroid_content_Context_ == IntPtr.Zero)
				id_defaultInspectorModulesProvider_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "defaultInspectorModulesProvider", "(Landroid/content/Context;)Lcom/facebook/stetho/InspectorModulesProvider;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Facebook.Stetho.IInspectorModulesProvider __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.IInspectorModulesProvider> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultInspectorModulesProvider_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initialize_Lcom_facebook_stetho_Stetho_Initializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.Stetho.Initializer']]"
		[Register ("initialize", "(Lcom/facebook/stetho/Stetho$Initializer;)V", "")]
		public static unsafe void Initialize (global::Com.Facebook.Stetho.Stetho.Initializer p0)
		{
			if (id_initialize_Lcom_facebook_stetho_Stetho_Initializer_ == IntPtr.Zero)
				id_initialize_Lcom_facebook_stetho_Stetho_Initializer_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Lcom/facebook/stetho/Stetho$Initializer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Lcom_facebook_stetho_Stetho_Initializer_, __args);
			} finally {
			}
		}

		static IntPtr id_initializeWithDefaults_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho']/method[@name='initializeWithDefaults' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initializeWithDefaults", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitializeWithDefaults (global::Android.Content.Context p0)
		{
			if (id_initializeWithDefaults_Landroid_content_Context_ == IntPtr.Zero)
				id_initializeWithDefaults_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initializeWithDefaults", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeWithDefaults_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_newInitializerBuilder_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/class[@name='Stetho']/method[@name='newInitializerBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newInitializerBuilder", "(Landroid/content/Context;)Lcom/facebook/stetho/Stetho$InitializerBuilder;", "")]
		public static unsafe global::Com.Facebook.Stetho.Stetho.InitializerBuilder NewInitializerBuilder (global::Android.Content.Context p0)
		{
			if (id_newInitializerBuilder_Landroid_content_Context_ == IntPtr.Zero)
				id_newInitializerBuilder_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "newInitializerBuilder", "(Landroid/content/Context;)Lcom/facebook/stetho/Stetho$InitializerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Facebook.Stetho.Stetho.InitializerBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Stetho.InitializerBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInitializerBuilder_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
