using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='HandlerRegistry']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/HandlerRegistry", DoNotGenerateAcw=true)]
	public partial class HandlerRegistry : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/http/HandlerRegistry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandlerRegistry); }
		}

		protected HandlerRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='HandlerRegistry']/constructor[@name='HandlerRegistry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HandlerRegistry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HandlerRegistry)) {
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

		static Delegate cb_lookup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLookup_Ljava_lang_String_Handler ()
		{
			if (cb_lookup_Ljava_lang_String_ == null)
				cb_lookup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Lookup_Ljava_lang_String_);
			return cb_lookup_Ljava_lang_String_;
		}

		static IntPtr n_Lookup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Server.Http.HandlerRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.HandlerRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Lookup (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lookup_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='HandlerRegistry']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lookup", "(Ljava/lang/String;)Lcom/facebook/stetho/server/http/HttpHandler;", "GetLookup_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Server.Http.IHttpHandler Lookup (string p0)
		{
			if (id_lookup_Ljava_lang_String_ == IntPtr.Zero)
				id_lookup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "lookup", "(Ljava/lang/String;)Lcom/facebook/stetho/server/http/HttpHandler;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Facebook.Stetho.Server.Http.IHttpHandler __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.IHttpHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lookup_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.IHttpHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lookup", "(Ljava/lang/String;)Lcom/facebook/stetho/server/http/HttpHandler;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_;
#pragma warning disable 0169
		static Delegate GetRegister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_Handler ()
		{
			if (cb_register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ == null)
				cb_register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_);
			return cb_register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_;
		}

		static void n_Register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Server.Http.HandlerRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.HandlerRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.IPathMatcher p0 = (global::Com.Facebook.Stetho.Server.Http.IPathMatcher)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.IPathMatcher> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.IHttpHandler p1 = (global::Com.Facebook.Stetho.Server.Http.IHttpHandler)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.IHttpHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='HandlerRegistry']/method[@name='register' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.server.http.PathMatcher'] and parameter[2][@type='com.facebook.stetho.server.http.HttpHandler']]"
		[Register ("register", "(Lcom/facebook/stetho/server/http/PathMatcher;Lcom/facebook/stetho/server/http/HttpHandler;)V", "GetRegister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_Handler")]
		public virtual unsafe void Register (global::Com.Facebook.Stetho.Server.Http.IPathMatcher p0, global::Com.Facebook.Stetho.Server.Http.IHttpHandler p1)
		{
			if (id_register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ == IntPtr.Zero)
				id_register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ = JNIEnv.GetMethodID (class_ref, "register", "(Lcom/facebook/stetho/server/http/PathMatcher;Lcom/facebook/stetho/server/http/HttpHandler;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Lcom/facebook/stetho/server/http/PathMatcher;Lcom/facebook/stetho/server/http/HttpHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_;
#pragma warning disable 0169
		static Delegate GetUnregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_Handler ()
		{
			if (cb_unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ == null)
				cb_unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_);
			return cb_unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_;
		}

		static bool n_Unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Server.Http.HandlerRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.HandlerRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.IPathMatcher p0 = (global::Com.Facebook.Stetho.Server.Http.IPathMatcher)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.IPathMatcher> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.IHttpHandler p1 = (global::Com.Facebook.Stetho.Server.Http.IHttpHandler)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.IHttpHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Unregister (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='HandlerRegistry']/method[@name='unregister' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.server.http.PathMatcher'] and parameter[2][@type='com.facebook.stetho.server.http.HttpHandler']]"
		[Register ("unregister", "(Lcom/facebook/stetho/server/http/PathMatcher;Lcom/facebook/stetho/server/http/HttpHandler;)Z", "GetUnregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_Handler")]
		public virtual unsafe bool Unregister (global::Com.Facebook.Stetho.Server.Http.IPathMatcher p0, global::Com.Facebook.Stetho.Server.Http.IHttpHandler p1)
		{
			if (id_unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ == IntPtr.Zero)
				id_unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Lcom/facebook/stetho/server/http/PathMatcher;Lcom/facebook/stetho/server/http/HttpHandler;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_unregister_Lcom_facebook_stetho_server_http_PathMatcher_Lcom_facebook_stetho_server_http_HttpHandler_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "(Lcom/facebook/stetho/server/http/PathMatcher;Lcom/facebook/stetho/server/http/HttpHandler;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
