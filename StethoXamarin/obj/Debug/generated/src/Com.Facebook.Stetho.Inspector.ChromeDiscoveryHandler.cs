using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDiscoveryHandler']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/ChromeDiscoveryHandler", DoNotGenerateAcw=true)]
	public partial class ChromeDiscoveryHandler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.Http.IHttpHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/ChromeDiscoveryHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChromeDiscoveryHandler); }
		}

		protected ChromeDiscoveryHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDiscoveryHandler']/constructor[@name='ChromeDiscoveryHandler' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe ChromeDiscoveryHandler (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (ChromeDiscoveryHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_;
#pragma warning disable 0169
		static Delegate GetHandleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_Handler ()
		{
			if (cb_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_ == null)
				cb_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_);
			return cb_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_;
		}

		static bool n_HandleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.ChromeDiscoveryHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.ChromeDiscoveryHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.SocketLike p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.LightHttpRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.LightHttpResponse p2 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpResponse> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleRequest (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDiscoveryHandler']/method[@name='handleRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.server.SocketLike'] and parameter[2][@type='com.facebook.stetho.server.http.LightHttpRequest'] and parameter[3][@type='com.facebook.stetho.server.http.LightHttpResponse']]"
		[Register ("handleRequest", "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/http/LightHttpRequest;Lcom/facebook/stetho/server/http/LightHttpResponse;)Z", "GetHandleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_Handler")]
		public virtual unsafe bool HandleRequest (global::Com.Facebook.Stetho.Server.SocketLike p0, global::Com.Facebook.Stetho.Server.Http.LightHttpRequest p1, global::Com.Facebook.Stetho.Server.Http.LightHttpResponse p2)
		{
			if (id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_ == IntPtr.Zero)
				id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_ = JNIEnv.GetMethodID (class_ref, "handleRequest", "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/http/LightHttpRequest;Lcom/facebook/stetho/server/http/LightHttpResponse;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleRequest", "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/http/LightHttpRequest;Lcom/facebook/stetho/server/http/LightHttpResponse;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_register_Lcom_facebook_stetho_server_http_HandlerRegistry_;
#pragma warning disable 0169
		static Delegate GetRegister_Lcom_facebook_stetho_server_http_HandlerRegistry_Handler ()
		{
			if (cb_register_Lcom_facebook_stetho_server_http_HandlerRegistry_ == null)
				cb_register_Lcom_facebook_stetho_server_http_HandlerRegistry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Register_Lcom_facebook_stetho_server_http_HandlerRegistry_);
			return cb_register_Lcom_facebook_stetho_server_http_HandlerRegistry_;
		}

		static void n_Register_Lcom_facebook_stetho_server_http_HandlerRegistry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.ChromeDiscoveryHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.ChromeDiscoveryHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.HandlerRegistry p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.HandlerRegistry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0);
		}
#pragma warning restore 0169

		static IntPtr id_register_Lcom_facebook_stetho_server_http_HandlerRegistry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDiscoveryHandler']/method[@name='register' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.server.http.HandlerRegistry']]"
		[Register ("register", "(Lcom/facebook/stetho/server/http/HandlerRegistry;)V", "GetRegister_Lcom_facebook_stetho_server_http_HandlerRegistry_Handler")]
		public virtual unsafe void Register (global::Com.Facebook.Stetho.Server.Http.HandlerRegistry p0)
		{
			if (id_register_Lcom_facebook_stetho_server_http_HandlerRegistry_ == IntPtr.Zero)
				id_register_Lcom_facebook_stetho_server_http_HandlerRegistry_ = JNIEnv.GetMethodID (class_ref, "register", "(Lcom/facebook/stetho/server/http/HandlerRegistry;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Lcom_facebook_stetho_server_http_HandlerRegistry_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Lcom/facebook/stetho/server/http/HandlerRegistry;)V"), __args);
			} finally {
			}
		}

	}
}
