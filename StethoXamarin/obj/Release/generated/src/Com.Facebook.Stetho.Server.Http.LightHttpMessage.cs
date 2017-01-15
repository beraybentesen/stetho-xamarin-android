using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpMessage']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpMessage", DoNotGenerateAcw=true)]
	public partial class LightHttpMessage : global::Java.Lang.Object {


		static IntPtr headerNames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpMessage']/field[@name='headerNames']"
		[Register ("headerNames")]
		public global::System.Collections.IList HeaderNames {
			get {
				if (headerNames_jfieldId == IntPtr.Zero)
					headerNames_jfieldId = JNIEnv.GetFieldID (class_ref, "headerNames", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headerNames_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (headerNames_jfieldId == IntPtr.Zero)
					headerNames_jfieldId = JNIEnv.GetFieldID (class_ref, "headerNames", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headerNames_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr headerValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpMessage']/field[@name='headerValues']"
		[Register ("headerValues")]
		public global::System.Collections.IList HeaderValues {
			get {
				if (headerValues_jfieldId == IntPtr.Zero)
					headerValues_jfieldId = JNIEnv.GetFieldID (class_ref, "headerValues", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headerValues_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (headerValues_jfieldId == IntPtr.Zero)
					headerValues_jfieldId = JNIEnv.GetFieldID (class_ref, "headerValues", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headerValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/http/LightHttpMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LightHttpMessage); }
		}

		protected LightHttpMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpMessage']/constructor[@name='LightHttpMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LightHttpMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LightHttpMessage)) {
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

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Server.Http.LightHttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpMessage']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getFirstHeaderValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFirstHeaderValue_Ljava_lang_String_Handler ()
		{
			if (cb_getFirstHeaderValue_Ljava_lang_String_ == null)
				cb_getFirstHeaderValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFirstHeaderValue_Ljava_lang_String_);
			return cb_getFirstHeaderValue_Ljava_lang_String_;
		}

		static IntPtr n_GetFirstHeaderValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Server.Http.LightHttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFirstHeaderValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstHeaderValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpMessage']/method[@name='getFirstHeaderValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFirstHeaderValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetFirstHeaderValue_Ljava_lang_String_Handler")]
		public virtual unsafe string GetFirstHeaderValue (string p0)
		{
			if (id_getFirstHeaderValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getFirstHeaderValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFirstHeaderValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstHeaderValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstHeaderValue", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Server.Http.LightHttpMessage __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpMessage']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
