using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpHandler']"
	[Register ("com/facebook/stetho/server/http/HttpHandler", "", "Com.Facebook.Stetho.Server.Http.IHttpHandlerInvoker")]
	public partial interface IHttpHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpHandler']/method[@name='handleRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.server.SocketLike'] and parameter[2][@type='com.facebook.stetho.server.http.LightHttpRequest'] and parameter[3][@type='com.facebook.stetho.server.http.LightHttpResponse']]"
		[Register ("handleRequest", "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/http/LightHttpRequest;Lcom/facebook/stetho/server/http/LightHttpResponse;)Z", "GetHandleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_Handler:Com.Facebook.Stetho.Server.Http.IHttpHandlerInvoker, StethoXamarin")]
		bool HandleRequest (global::Com.Facebook.Stetho.Server.SocketLike p0, global::Com.Facebook.Stetho.Server.Http.LightHttpRequest p1, global::Com.Facebook.Stetho.Server.Http.LightHttpResponse p2);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/HttpHandler", DoNotGenerateAcw=true)]
	internal class IHttpHandlerInvoker : global::Java.Lang.Object, IHttpHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/server/http/HttpHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHttpHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IHttpHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.server.http.HttpHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Stetho.Server.Http.IHttpHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.IHttpHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.SocketLike p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.LightHttpRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.Http.LightHttpResponse p2 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpResponse> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleRequest (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_;
		public unsafe bool HandleRequest (global::Com.Facebook.Stetho.Server.SocketLike p0, global::Com.Facebook.Stetho.Server.Http.LightHttpRequest p1, global::Com.Facebook.Stetho.Server.Http.LightHttpResponse p2)
		{
			if (id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_ == IntPtr.Zero)
				id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_ = JNIEnv.GetMethodID (class_ref, "handleRequest", "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/http/LightHttpRequest;Lcom/facebook/stetho/server/http/LightHttpResponse;)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_, __args);
			return __ret;
		}

	}

}
