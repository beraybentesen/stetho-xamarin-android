using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpResponse']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpResponse", DoNotGenerateAcw=true)]
	public partial class LightHttpResponse : global::Com.Facebook.Stetho.Server.Http.LightHttpMessage {


		static IntPtr body_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpResponse']/field[@name='body']"
		[Register ("body")]
		public global::Com.Facebook.Stetho.Server.Http.LightHttpBody Body {
			get {
				if (body_jfieldId == IntPtr.Zero)
					body_jfieldId = JNIEnv.GetFieldID (class_ref, "body", "Lcom/facebook/stetho/server/http/LightHttpBody;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, body_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpBody> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (body_jfieldId == IntPtr.Zero)
					body_jfieldId = JNIEnv.GetFieldID (class_ref, "body", "Lcom/facebook/stetho/server/http/LightHttpBody;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, body_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpResponse']/field[@name='code']"
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

		static IntPtr reasonPhrase_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpResponse']/field[@name='reasonPhrase']"
		[Register ("reasonPhrase")]
		public string ReasonPhrase {
			get {
				if (reasonPhrase_jfieldId == IntPtr.Zero)
					reasonPhrase_jfieldId = JNIEnv.GetFieldID (class_ref, "reasonPhrase", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, reasonPhrase_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (reasonPhrase_jfieldId == IntPtr.Zero)
					reasonPhrase_jfieldId = JNIEnv.GetFieldID (class_ref, "reasonPhrase", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, reasonPhrase_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/http/LightHttpResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LightHttpResponse); }
		}

		protected LightHttpResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpResponse']/constructor[@name='LightHttpResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LightHttpResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LightHttpResponse)) {
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

		static Delegate cb_prepare;
#pragma warning disable 0169
		static Delegate GetPrepareHandler ()
		{
			if (cb_prepare == null)
				cb_prepare = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Prepare);
			return cb_prepare;
		}

		static void n_Prepare (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Server.Http.LightHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Prepare ();
		}
#pragma warning restore 0169

		static IntPtr id_prepare;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpResponse']/method[@name='prepare' and count(parameter)=0]"
		[Register ("prepare", "()V", "GetPrepareHandler")]
		public virtual unsafe void Prepare ()
		{
			if (id_prepare == IntPtr.Zero)
				id_prepare = JNIEnv.GetMethodID (class_ref, "prepare", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepare", "()V"));
			} finally {
			}
		}

	}
}
