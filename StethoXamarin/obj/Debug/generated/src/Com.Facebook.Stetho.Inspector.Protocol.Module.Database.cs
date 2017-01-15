using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database", DoNotGenerateAcw=true)]
	public partial class Database : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.AddDatabaseEvent']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$AddDatabaseEvent", DoNotGenerateAcw=true)]
		public partial class AddDatabaseEvent : global::Java.Lang.Object {


			static IntPtr database_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.AddDatabaseEvent']/field[@name='database']"
			[Register ("database")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseObject Database {
				get {
					if (database_jfieldId == IntPtr.Zero)
						database_jfieldId = JNIEnv.GetFieldID (class_ref, "database", "Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, database_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (database_jfieldId == IntPtr.Zero)
						database_jfieldId = JNIEnv.GetFieldID (class_ref, "database", "Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, database_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$AddDatabaseEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AddDatabaseEvent); }
			}

			protected AddDatabaseEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.AddDatabaseEvent']/constructor[@name='Database.AddDatabaseEvent' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AddDatabaseEvent ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (AddDatabaseEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver", DoNotGenerateAcw=true)]
		public abstract partial class DatabaseDriver : global::Java.Lang.Object {


			static IntPtr mContext_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']/field[@name='mContext']"
			[Register ("mContext")]
			protected global::Android.Content.Context MContext {
				get {
					if (mContext_jfieldId == IntPtr.Zero)
						mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mContext_jfieldId == IntPtr.Zero)
						mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/interface[@name='Database.DatabaseDriver.ExecuteResultHandler']"
			[Register ("com/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver$ExecuteResultHandler", "", "Com.Facebook.Stetho.Inspector.Protocol.Module.Database/DatabaseDriver/IExecuteResultHandlerInvoker")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			public partial interface IExecuteResultHandler : IJavaObject {

				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/interface[@name='Database.DatabaseDriver.ExecuteResultHandler']/method[@name='handleInsert' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("handleInsert", "(J)Ljava/lang/Object;", "GetHandleInsert_JHandler:Com.Facebook.Stetho.Inspector.Protocol.Module.Database/DatabaseDriver/IExecuteResultHandlerInvoker, StethoXamarin")]
				global::Java.Lang.Object HandleInsert (long p0);

				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/interface[@name='Database.DatabaseDriver.ExecuteResultHandler']/method[@name='handleRawQuery' and count(parameter)=0]"
				[Register ("handleRawQuery", "()Ljava/lang/Object;", "GetHandleRawQueryHandler:Com.Facebook.Stetho.Inspector.Protocol.Module.Database/DatabaseDriver/IExecuteResultHandlerInvoker, StethoXamarin")]
				global::Java.Lang.Object HandleRawQuery ();

				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/interface[@name='Database.DatabaseDriver.ExecuteResultHandler']/method[@name='handleSelect' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
				[Register ("handleSelect", "(Landroid/database/Cursor;)Ljava/lang/Object;", "GetHandleSelect_Landroid_database_Cursor_Handler:Com.Facebook.Stetho.Inspector.Protocol.Module.Database/DatabaseDriver/IExecuteResultHandlerInvoker, StethoXamarin")]
				global::Java.Lang.Object HandleSelect (global::Android.Database.ICursor p0);

				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/interface[@name='Database.DatabaseDriver.ExecuteResultHandler']/method[@name='handleUpdateDelete' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("handleUpdateDelete", "(I)Ljava/lang/Object;", "GetHandleUpdateDelete_IHandler:Com.Facebook.Stetho.Inspector.Protocol.Module.Database/DatabaseDriver/IExecuteResultHandlerInvoker, StethoXamarin")]
				global::Java.Lang.Object HandleUpdateDelete (int p0);

			}

			[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver$ExecuteResultHandler", DoNotGenerateAcw=true)]
			internal class IExecuteResultHandlerInvoker : global::Java.Lang.Object, IExecuteResultHandler {

				static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver$ExecuteResultHandler");

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (IExecuteResultHandlerInvoker); }
				}

				IntPtr class_ref;

				public static IExecuteResultHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IExecuteResultHandler> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.protocol.module.Database.DatabaseDriver.ExecuteResultHandler"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IExecuteResultHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				static Delegate cb_handleInsert_J;
#pragma warning disable 0169
				static Delegate GetHandleInsert_JHandler ()
				{
					if (cb_handleInsert_J == null)
						cb_handleInsert_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_HandleInsert_J);
					return cb_handleInsert_J;
				}

				static IntPtr n_HandleInsert_J (IntPtr jnienv, IntPtr native__this, long p0)
				{
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.HandleInsert (p0));
				}
#pragma warning restore 0169

				IntPtr id_handleInsert_J;
				public unsafe global::Java.Lang.Object HandleInsert (long p0)
				{
					if (id_handleInsert_J == IntPtr.Zero)
						id_handleInsert_J = JNIEnv.GetMethodID (class_ref, "handleInsert", "(J)Ljava/lang/Object;");
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleInsert_J, __args), JniHandleOwnership.TransferLocalRef);
				}

				static Delegate cb_handleRawQuery;
#pragma warning disable 0169
				static Delegate GetHandleRawQueryHandler ()
				{
					if (cb_handleRawQuery == null)
						cb_handleRawQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HandleRawQuery);
					return cb_handleRawQuery;
				}

				static IntPtr n_HandleRawQuery (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.HandleRawQuery ());
				}
#pragma warning restore 0169

				IntPtr id_handleRawQuery;
				public unsafe global::Java.Lang.Object HandleRawQuery ()
				{
					if (id_handleRawQuery == IntPtr.Zero)
						id_handleRawQuery = JNIEnv.GetMethodID (class_ref, "handleRawQuery", "()Ljava/lang/Object;");
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleRawQuery), JniHandleOwnership.TransferLocalRef);
				}

				static Delegate cb_handleSelect_Landroid_database_Cursor_;
#pragma warning disable 0169
				static Delegate GetHandleSelect_Landroid_database_Cursor_Handler ()
				{
					if (cb_handleSelect_Landroid_database_Cursor_ == null)
						cb_handleSelect_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleSelect_Landroid_database_Cursor_);
					return cb_handleSelect_Landroid_database_Cursor_;
				}

				static IntPtr n_HandleSelect_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HandleSelect (p0));
					return __ret;
				}
#pragma warning restore 0169

				IntPtr id_handleSelect_Landroid_database_Cursor_;
				public unsafe global::Java.Lang.Object HandleSelect (global::Android.Database.ICursor p0)
				{
					if (id_handleSelect_Landroid_database_Cursor_ == IntPtr.Zero)
						id_handleSelect_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "handleSelect", "(Landroid/database/Cursor;)Ljava/lang/Object;");
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleSelect_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}

				static Delegate cb_handleUpdateDelete_I;
#pragma warning disable 0169
				static Delegate GetHandleUpdateDelete_IHandler ()
				{
					if (cb_handleUpdateDelete_I == null)
						cb_handleUpdateDelete_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HandleUpdateDelete_I);
					return cb_handleUpdateDelete_I;
				}

				static IntPtr n_HandleUpdateDelete_I (IntPtr jnienv, IntPtr native__this, int p0)
				{
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.HandleUpdateDelete (p0));
				}
#pragma warning restore 0169

				IntPtr id_handleUpdateDelete_I;
				public unsafe global::Java.Lang.Object HandleUpdateDelete (int p0)
				{
					if (id_handleUpdateDelete_I == IntPtr.Zero)
						id_handleUpdateDelete_I = JNIEnv.GetMethodID (class_ref, "handleUpdateDelete", "(I)Ljava/lang/Object;");
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleUpdateDelete_I, __args), JniHandleOwnership.TransferLocalRef);
				}

			}


			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabaseDriver); }
			}

			protected DatabaseDriver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']/constructor[@name='Database.DatabaseDriver' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe DatabaseDriver (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (DatabaseDriver)) {
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
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.DatabaseNames);
			}
#pragma warning restore 0169

			public abstract global::System.Collections.Generic.IList<string> DatabaseNames {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']/method[@name='getDatabaseNames' and count(parameter)=0]"
				[Register ("getDatabaseNames", "()Ljava/util/List;", "GetGetDatabaseNamesHandler")] get;
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
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler p2 = (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExecuteSQL (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']/method[@name='executeSQL' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.stetho.inspector.protocol.module.Database.DatabaseDriver.ExecuteResultHandler&lt;com.facebook.stetho.inspector.protocol.module.Database.ExecuteSQLResponse&gt;']]"
			[Register ("executeSQL", "(Ljava/lang/String;Ljava/lang/String;Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver$ExecuteResultHandler;)Lcom/facebook/stetho/inspector/protocol/module/Database$ExecuteSQLResponse;", "GetExecuteSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_Handler")]
			public abstract global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse ExecuteSQL (string p0, string p1, global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver.IExecuteResultHandler p2);

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
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetTableNames (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']/method[@name='getTableNames' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getTableNames", "(Ljava/lang/String;)Ljava/util/List;", "GetGetTableNames_Ljava_lang_String_Handler")]
			public abstract global::System.Collections.Generic.IList<string> GetTableNames (string p0);

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver", DoNotGenerateAcw=true)]
		internal partial class DatabaseDriverInvoker : DatabaseDriver {

			public DatabaseDriverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabaseDriverInvoker); }
			}

			static IntPtr id_getDatabaseNames;
			public override unsafe global::System.Collections.Generic.IList<string> DatabaseNames {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']/method[@name='getDatabaseNames' and count(parameter)=0]"
				[Register ("getDatabaseNames", "()Ljava/util/List;", "GetGetDatabaseNamesHandler")]
				get {
					if (id_getDatabaseNames == IntPtr.Zero)
						id_getDatabaseNames = JNIEnv.GetMethodID (class_ref, "getDatabaseNames", "()Ljava/util/List;");
					try {
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDatabaseNames), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']/method[@name='executeSQL' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.stetho.inspector.protocol.module.Database.DatabaseDriver.ExecuteResultHandler&lt;com.facebook.stetho.inspector.protocol.module.Database.ExecuteSQLResponse&gt;']]"
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
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.ExecuteSQLResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executeSQL_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ExecuteResultHandler_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_getTableNames_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseDriver']/method[@name='getTableNames' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getTableNames", "(Ljava/lang/String;)Ljava/util/List;", "GetGetTableNames_Ljava_lang_String_Handler")]
			public override unsafe global::System.Collections.Generic.IList<string> GetTableNames (string p0)
			{
				if (id_getTableNames_Ljava_lang_String_ == IntPtr.Zero)
					id_getTableNames_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTableNames", "(Ljava/lang/String;)Ljava/util/List;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTableNames_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseObject']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$DatabaseObject", DoNotGenerateAcw=true)]
		public partial class DatabaseObject : global::Java.Lang.Object {


			static IntPtr domain_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseObject']/field[@name='domain']"
			[Register ("domain")]
			public string Domain {
				get {
					if (domain_jfieldId == IntPtr.Zero)
						domain_jfieldId = JNIEnv.GetFieldID (class_ref, "domain", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, domain_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (domain_jfieldId == IntPtr.Zero)
						domain_jfieldId = JNIEnv.GetFieldID (class_ref, "domain", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, domain_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr id_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseObject']/field[@name='id']"
			[Register ("id")]
			public string Id {
				get {
					if (id_jfieldId == IntPtr.Zero)
						id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (id_jfieldId == IntPtr.Zero)
						id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseObject']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr version_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseObject']/field[@name='version']"
			[Register ("version")]
			public string Version {
				get {
					if (version_jfieldId == IntPtr.Zero)
						version_jfieldId = JNIEnv.GetFieldID (class_ref, "version", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, version_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (version_jfieldId == IntPtr.Zero)
						version_jfieldId = JNIEnv.GetFieldID (class_ref, "version", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, version_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$DatabaseObject", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabaseObject); }
			}

			protected DatabaseObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabaseObject']/constructor[@name='Database.DatabaseObject' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DatabaseObject ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DatabaseObject)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabasePeerRegistrationListener']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$DatabasePeerRegistrationListener", DoNotGenerateAcw=true)]
		public partial class DatabasePeerRegistrationListener : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$DatabasePeerRegistrationListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabasePeerRegistrationListener); }
			}

			protected DatabasePeerRegistrationListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
#pragma warning disable 0169
			static Delegate GetOnPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler ()
			{
				if (cb_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == null)
					cb_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_);
				return cb_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
			}

			static void n_OnPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabasePeerRegistrationListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabasePeerRegistrationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPeerRegistered (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabasePeerRegistrationListener']/method[@name='onPeerRegistered' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
			[Register ("onPeerRegistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "GetOnPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler")]
			public virtual unsafe void OnPeerRegistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
			{
				if (id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
					id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerRegistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPeerRegistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
#pragma warning disable 0169
			static Delegate GetOnPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler ()
			{
				if (cb_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == null)
					cb_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_);
				return cb_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
			}

			static void n_OnPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabasePeerRegistrationListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabasePeerRegistrationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPeerUnregistered (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.DatabasePeerRegistrationListener']/method[@name='onPeerUnregistered' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
			[Register ("onPeerUnregistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "GetOnPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler")]
			public virtual unsafe void OnPeerUnregistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
			{
				if (id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
					id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerUnregistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPeerUnregistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.Error']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$Error", DoNotGenerateAcw=true)]
		public partial class Error : global::Java.Lang.Object {


			static IntPtr code_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.Error']/field[@name='code']"
			[Register ("code")]
			public int Code {
				get {
					if (code_jfieldId == IntPtr.Zero)
						code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, code_jfieldId);
				}
				set {
					if (code_jfieldId == IntPtr.Zero)
						code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, code_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr message_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.Error']/field[@name='message']"
			[Register ("message")]
			public string Message {
				get {
					if (message_jfieldId == IntPtr.Zero)
						message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (message_jfieldId == IntPtr.Zero)
						message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$Error", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Error); }
			}

			protected Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.Error']/constructor[@name='Database.Error' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Error ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Error)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$ExecuteSQLRequest", DoNotGenerateAcw=true)]
		public partial class ExecuteSQLRequest : global::Java.Lang.Object {


			static IntPtr databaseId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLRequest']/field[@name='databaseId']"
			[Register ("databaseId")]
			public string DatabaseId {
				get {
					if (databaseId_jfieldId == IntPtr.Zero)
						databaseId_jfieldId = JNIEnv.GetFieldID (class_ref, "databaseId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, databaseId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (databaseId_jfieldId == IntPtr.Zero)
						databaseId_jfieldId = JNIEnv.GetFieldID (class_ref, "databaseId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, databaseId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr query_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLRequest']/field[@name='query']"
			[Register ("query")]
			public string Query {
				get {
					if (query_jfieldId == IntPtr.Zero)
						query_jfieldId = JNIEnv.GetFieldID (class_ref, "query", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, query_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (query_jfieldId == IntPtr.Zero)
						query_jfieldId = JNIEnv.GetFieldID (class_ref, "query", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, query_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$ExecuteSQLRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExecuteSQLRequest); }
			}

			protected ExecuteSQLRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLRequest']/constructor[@name='Database.ExecuteSQLRequest' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ExecuteSQLRequest ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ExecuteSQLRequest)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$ExecuteSQLResponse", DoNotGenerateAcw=true)]
		public partial class ExecuteSQLResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr columnNames_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLResponse']/field[@name='columnNames']"
			[Register ("columnNames")]
			public global::System.Collections.IList ColumnNames {
				get {
					if (columnNames_jfieldId == IntPtr.Zero)
						columnNames_jfieldId = JNIEnv.GetFieldID (class_ref, "columnNames", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, columnNames_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (columnNames_jfieldId == IntPtr.Zero)
						columnNames_jfieldId = JNIEnv.GetFieldID (class_ref, "columnNames", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, columnNames_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr sqlError_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLResponse']/field[@name='sqlError']"
			[Register ("sqlError")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.Error SqlError {
				get {
					if (sqlError_jfieldId == IntPtr.Zero)
						sqlError_jfieldId = JNIEnv.GetFieldID (class_ref, "sqlError", "Lcom/facebook/stetho/inspector/protocol/module/Database$Error;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sqlError_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.Error> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (sqlError_jfieldId == IntPtr.Zero)
						sqlError_jfieldId = JNIEnv.GetFieldID (class_ref, "sqlError", "Lcom/facebook/stetho/inspector/protocol/module/Database$Error;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sqlError_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr values_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLResponse']/field[@name='values']"
			[Register ("values")]
			public global::System.Collections.IList Values {
				get {
					if (values_jfieldId == IntPtr.Zero)
						values_jfieldId = JNIEnv.GetFieldID (class_ref, "values", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, values_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (values_jfieldId == IntPtr.Zero)
						values_jfieldId = JNIEnv.GetFieldID (class_ref, "values", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, values_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$ExecuteSQLResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExecuteSQLResponse); }
			}

			protected ExecuteSQLResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.ExecuteSQLResponse']/constructor[@name='Database.ExecuteSQLResponse' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ExecuteSQLResponse ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ExecuteSQLResponse)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.GetDatabaseTableNamesRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$GetDatabaseTableNamesRequest", DoNotGenerateAcw=true)]
		public partial class GetDatabaseTableNamesRequest : global::Java.Lang.Object {


			static IntPtr databaseId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.GetDatabaseTableNamesRequest']/field[@name='databaseId']"
			[Register ("databaseId")]
			public string DatabaseId {
				get {
					if (databaseId_jfieldId == IntPtr.Zero)
						databaseId_jfieldId = JNIEnv.GetFieldID (class_ref, "databaseId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, databaseId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (databaseId_jfieldId == IntPtr.Zero)
						databaseId_jfieldId = JNIEnv.GetFieldID (class_ref, "databaseId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, databaseId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$GetDatabaseTableNamesRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetDatabaseTableNamesRequest); }
			}

			protected GetDatabaseTableNamesRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.GetDatabaseTableNamesResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Database$GetDatabaseTableNamesResponse", DoNotGenerateAcw=true)]
		public partial class GetDatabaseTableNamesResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr tableNames_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database.GetDatabaseTableNamesResponse']/field[@name='tableNames']"
			[Register ("tableNames")]
			public global::System.Collections.IList TableNames {
				get {
					if (tableNames_jfieldId == IntPtr.Zero)
						tableNames_jfieldId = JNIEnv.GetFieldID (class_ref, "tableNames", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tableNames_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (tableNames_jfieldId == IntPtr.Zero)
						tableNames_jfieldId = JNIEnv.GetFieldID (class_ref, "tableNames", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tableNames_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database$GetDatabaseTableNamesResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetDatabaseTableNamesResponse); }
			}

			protected GetDatabaseTableNamesResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Database", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Database); }
		}

		protected Database (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database']/constructor[@name='Database' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Database ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Database)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_Handler ()
		{
			if (cb_add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ == null)
				cb_add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_);
			return cb_add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_;
		}

		static void n_Add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.protocol.module.Database.DatabaseDriver']]"
		[Register ("add", "(Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver;)V", "GetAdd_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_Handler")]
		public virtual unsafe void Add (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database.DatabaseDriver p0)
		{
			if (id_add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ == IntPtr.Zero)
				id_add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_facebook_stetho_inspector_protocol_module_Database_DatabaseDriver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/facebook/stetho/inspector/protocol/module/Database$DatabaseDriver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetDisable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_Disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Disable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database']/method[@name='disable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("disable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetDisable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Disable (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "disable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetEnable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_Enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database']/method[@name='enable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("enable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetEnable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Enable (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "enable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_executeSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetExecuteSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_executeSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_executeSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ExecuteSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_executeSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_ExecuteSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExecuteSQL (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_executeSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database']/method[@name='executeSQL' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("executeSQL", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetExecuteSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult ExecuteSQL (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_executeSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_executeSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "executeSQL", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executeSQL_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeSQL", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_getDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_getDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Database> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDatabaseTableNames (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Database']/method[@name='getDatabaseTableNames' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getDatabaseTableNames", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetGetDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult GetDatabaseTableNames (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_getDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getDatabaseTableNames", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDatabaseTableNames_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDatabaseTableNames", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
