using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyFileManager']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/ResponseBodyFileManager", DoNotGenerateAcw=true)]
	public partial class ResponseBodyFileManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/ResponseBodyFileManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseBodyFileManager); }
		}

		protected ResponseBodyFileManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyFileManager']/constructor[@name='ResponseBodyFileManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ResponseBodyFileManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ResponseBodyFileManager)) {
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

		static Delegate cb_associateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_;
#pragma warning disable 0169
		static Delegate GetAssociateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_Handler ()
		{
			if (cb_associateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_ == null)
				cb_associateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AssociateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_);
			return cb_associateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_;
		}

		static void n_AssociateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter p1 = (global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AssociateAsyncPrettyPrinterWithId (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_associateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyFileManager']/method[@name='associateAsyncPrettyPrinterWithId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.facebook.stetho.inspector.network.AsyncPrettyPrinter']]"
		[Register ("associateAsyncPrettyPrinterWithId", "(Ljava/lang/String;Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinter;)V", "GetAssociateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_Handler")]
		public virtual unsafe void AssociateAsyncPrettyPrinterWithId (string p0, global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter p1)
		{
			if (id_associateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_ == IntPtr.Zero)
				id_associateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_ = JNIEnv.GetMethodID (class_ref, "associateAsyncPrettyPrinterWithId", "(Ljava/lang/String;Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinter;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_associateAsyncPrettyPrinterWithId_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "associateAsyncPrettyPrinterWithId", "(Ljava/lang/String;Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinter;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cleanupFiles;
#pragma warning disable 0169
		static Delegate GetCleanupFilesHandler ()
		{
			if (cb_cleanupFiles == null)
				cb_cleanupFiles = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CleanupFiles);
			return cb_cleanupFiles;
		}

		static void n_CleanupFiles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanupFiles ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanupFiles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyFileManager']/method[@name='cleanupFiles' and count(parameter)=0]"
		[Register ("cleanupFiles", "()V", "GetCleanupFilesHandler")]
		public virtual unsafe void CleanupFiles ()
		{
			if (id_cleanupFiles == IntPtr.Zero)
				id_cleanupFiles = JNIEnv.GetMethodID (class_ref, "cleanupFiles", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cleanupFiles);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanupFiles", "()V"));
			} finally {
			}
		}

		static Delegate cb_openResponseBodyFile_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOpenResponseBodyFile_Ljava_lang_String_ZHandler ()
		{
			if (cb_openResponseBodyFile_Ljava_lang_String_Z == null)
				cb_openResponseBodyFile_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_OpenResponseBodyFile_Ljava_lang_String_Z);
			return cb_openResponseBodyFile_Ljava_lang_String_Z;
		}

		static IntPtr n_OpenResponseBodyFile_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OpenResponseBodyFile (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openResponseBodyFile_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyFileManager']/method[@name='openResponseBodyFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("openResponseBodyFile", "(Ljava/lang/String;Z)Ljava/io/OutputStream;", "GetOpenResponseBodyFile_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::System.IO.Stream OpenResponseBodyFile (string p0, bool p1)
		{
			if (id_openResponseBodyFile_Ljava_lang_String_Z == IntPtr.Zero)
				id_openResponseBodyFile_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "openResponseBodyFile", "(Ljava/lang/String;Z)Ljava/io/OutputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openResponseBodyFile_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openResponseBodyFile", "(Ljava/lang/String;Z)Ljava/io/OutputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_readFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadFile_Ljava_lang_String_Handler ()
		{
			if (cb_readFile_Ljava_lang_String_ == null)
				cb_readFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadFile_Ljava_lang_String_);
			return cb_readFile_Ljava_lang_String_;
		}

		static IntPtr n_ReadFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyFileManager']/method[@name='readFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readFile", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/ResponseBodyData;", "GetReadFile_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyData ReadFile (string p0)
		{
			if (id_readFile_Ljava_lang_String_ == IntPtr.Zero)
				id_readFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readFile", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/ResponseBodyData;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyData __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFile", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/ResponseBodyData;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
