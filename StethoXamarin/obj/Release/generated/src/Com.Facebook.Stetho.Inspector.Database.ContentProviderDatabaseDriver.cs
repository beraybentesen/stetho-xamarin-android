using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderDatabaseDriver']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/ContentProviderDatabaseDriver", DoNotGenerateAcw=true)]
	public partial class ContentProviderDatabaseDriver : global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/ContentProviderDatabaseDriver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentProviderDatabaseDriver); }
		}

		protected ContentProviderDatabaseDriver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_arrayLcom_facebook_stetho_inspector_database_ContentProviderSchema_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderDatabaseDriver']/constructor[@name='ContentProviderDatabaseDriver' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.stetho.inspector.database.ContentProviderSchema...']]"
		[Register (".ctor", "(Landroid/content/Context;[Lcom/facebook/stetho/inspector/database/ContentProviderSchema;)V", "")]
		public unsafe ContentProviderDatabaseDriver (global::Android.Content.Context p0, params global:: Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (ContentProviderDatabaseDriver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;[Lcom/facebook/stetho/inspector/database/ContentProviderSchema;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;[Lcom/facebook/stetho/inspector/database/ContentProviderSchema;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_arrayLcom_facebook_stetho_inspector_database_ContentProviderSchema_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_arrayLcom_facebook_stetho_inspector_database_ContentProviderSchema_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;[Lcom/facebook/stetho/inspector/database/ContentProviderSchema;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_arrayLcom_facebook_stetho_inspector_database_ContentProviderSchema_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_arrayLcom_facebook_stetho_inspector_database_ContentProviderSchema_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_getDatabaseNames;
#pragma warning disable 0169
		static Delegate GetGetDatabaseNamesHandler ()
		{
			if (cb_getDatabaseNames == null)
				cb_getDatabaseNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDatabaseNames);
			return cb_getDatabaseNames;
		}

		static IntPtr n_GetDatabaseNames (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Database.ContentProviderDatabaseDriver __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderDatabaseDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.DatabaseNames);
		}
#pragma warning restore 0169

		static IntPtr id_getDatabaseNames;
		public override unsafe global::System.Collections.Generic.IList<string> DatabaseNames {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderDatabaseDriver']/method[@name='getDatabaseNames' and count(parameter)=0]"
			[Register ("getDatabaseNames", "()Ljava/util/List;", "GetGetDatabaseNamesHandler")]
			get {
				if (id_getDatabaseNames == IntPtr.Zero)
					id_getDatabaseNames = JNIEnv.GetMethodID (class_ref, "getDatabaseNames", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDatabaseNames), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDatabaseNames", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_;
#pragma warning disable 0169
		static Delegate GetExecuteSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_Handler ()
		{
			if (cb_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_ == null)
				cb_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ExecuteSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_);
			return cb_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_;
		}

		static IntPtr n_ExecuteSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.Database.ContentProviderDatabaseDriver __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderDatabaseDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler p2 = (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExecuteSQL (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderDatabaseDriver']/method[@name='executeSQL' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.stetho.inspector.protocol.module.Database.DatabaseDriver.ExecuteResultHandler&lt;com.facebook.stetho.inspector.protocol.module.Database.ExecuteSQLResponse&gt;']]"
		[Register ("executeSQL", "(Ljava/lang/String;Ljava/lang/String;Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver$ExecuteResultHandler;)Lcom/facebook/stetho/inspector/protocol/module/Database$ExecuteSQLResponse;", "GetExecuteSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_Handler")]
		public override unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse ExecuteSQL (string p0, string p1, global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler p2)
		{
			if (id_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_ == IntPtr.Zero)
				id_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_ = JNIEnv.GetMethodID (class_ref, "executeSQL", "(Ljava/lang/String;Ljava/lang/String;Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver$ExecuteResultHandler;)Lcom/facebook/stetho/inspector/protocol/module/Database$ExecuteSQLResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeSQL", "(Ljava/lang/String;Ljava/lang/String;Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver$ExecuteResultHandler;)Lcom/facebook/stetho/inspector/protocol/module/Database$ExecuteSQLResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getTableNames_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTableNames_Ljava_lang_String_Handler ()
		{
			if (cb_getTableNames_Ljava_lang_String_ == null)
				cb_getTableNames_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTableNames_Ljava_lang_String_);
			return cb_getTableNames_Ljava_lang_String_;
		}

		static IntPtr n_GetTableNames_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Database.ContentProviderDatabaseDriver __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderDatabaseDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetTableNames (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTableNames_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderDatabaseDriver']/method[@name='getTableNames' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTableNames", "(Ljava/lang/String;)Ljava/util/List;", "GetGetTableNames_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<string> GetTableNames (string p0)
		{
			if (id_getTableNames_Ljava_lang_String_ == IntPtr.Zero)
				id_getTableNames_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTableNames", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<string> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTableNames_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTableNames", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
