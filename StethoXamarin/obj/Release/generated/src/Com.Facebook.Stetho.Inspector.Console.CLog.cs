using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Console {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/class[@name='CLog']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/console/CLog", DoNotGenerateAcw=true)]
	public partial class CLog : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/console/CLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CLog); }
		}

		protected CLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/class[@name='CLog']/constructor[@name='CLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CLog)) {
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

		static IntPtr id_writeToConsole_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageLevel_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageSource_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/class[@name='CLog']/method[@name='writeToConsole' and count(parameter)=4 and parameter[1][@type='com.facebook.stetho.inspector.helper.ChromePeerManager'] and parameter[2][@type='com.facebook.stetho.inspector.protocol.module.Console.MessageLevel'] and parameter[3][@type='com.facebook.stetho.inspector.protocol.module.Console.MessageSource'] and parameter[4][@type='java.lang.String']]"
		[Register ("writeToConsole", "(Lcom/facebook/stetho/inspector/helper/ChromePeerManager;Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;Ljava/lang/String;)V", "")]
		public static unsafe void WriteToConsole (global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager p0, global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel p1, global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource p2, string p3)
		{
			if (id_writeToConsole_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageLevel_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageSource_Ljava_lang_String_ == IntPtr.Zero)
				id_writeToConsole_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageLevel_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageSource_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeToConsole", "(Lcom/facebook/stetho/inspector/helper/ChromePeerManager;Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeToConsole_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageLevel_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageSource_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_writeToConsole_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageLevel_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageSource_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/class[@name='CLog']/method[@name='writeToConsole' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.inspector.protocol.module.Console.MessageLevel'] and parameter[2][@type='com.facebook.stetho.inspector.protocol.module.Console.MessageSource'] and parameter[3][@type='java.lang.String']]"
		[Register ("writeToConsole", "(Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;Ljava/lang/String;)V", "")]
		public static unsafe void WriteToConsole (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel p0, global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource p1, string p2)
		{
			if (id_writeToConsole_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageLevel_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageSource_Ljava_lang_String_ == IntPtr.Zero)
				id_writeToConsole_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageLevel_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageSource_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeToConsole", "(Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeToConsole_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageLevel_Lcom_facebook_stetho_inspector_protocol_module_Console_MessageSource_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
