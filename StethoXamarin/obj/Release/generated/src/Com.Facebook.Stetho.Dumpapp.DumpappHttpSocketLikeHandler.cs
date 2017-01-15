using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Dumpapp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='DumpappHttpSocketLikeHandler']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/facebook/stetho/dumpapp/DumpappHttpSocketLikeHandler", DoNotGenerateAcw=true)]
	public partial class DumpappHttpSocketLikeHandler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.ISocketLikeHandler {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='DumpappHttpSocketLikeHandler.DumpappLegacyHttpHandler']"
		[global::Android.Runtime.Register ("com/facebook/stetho/dumpapp/DumpappHttpSocketLikeHandler$DumpappLegacyHttpHandler", DoNotGenerateAcw=true)]
		public partial class DumpappLegacyHttpHandler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.Http.IHttpHandler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/dumpapp/DumpappHttpSocketLikeHandler$DumpappLegacyHttpHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DumpappLegacyHttpHandler); }
			}

			protected DumpappLegacyHttpHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Facebook.Stetho.Dumpapp.DumpappHttpSocketLikeHandler.DumpappLegacyHttpHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.DumpappHttpSocketLikeHandler.DumpappLegacyHttpHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Server.SocketLike p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Server.Http.LightHttpRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Server.Http.LightHttpResponse p2 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpResponse> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.HandleRequest (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_handleRequest_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_http_LightHttpRequest_Lcom_facebook_stetho_server_http_LightHttpResponse_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='DumpappHttpSocketLikeHandler.DumpappLegacyHttpHandler']/method[@name='handleRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.server.SocketLike'] and parameter[2][@type='com.facebook.stetho.server.http.LightHttpRequest'] and parameter[3][@type='com.facebook.stetho.server.http.LightHttpResponse']]"
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/dumpapp/DumpappHttpSocketLikeHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DumpappHttpSocketLikeHandler); }
		}

		protected DumpappHttpSocketLikeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
#pragma warning disable 0169
		static Delegate GetOnAccepted_Lcom_facebook_stetho_server_SocketLike_Handler ()
		{
			if (cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_ == null)
				cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAccepted_Lcom_facebook_stetho_server_SocketLike_);
			return cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
		}

		static void n_OnAccepted_Lcom_facebook_stetho_server_SocketLike_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Dumpapp.DumpappHttpSocketLikeHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.DumpappHttpSocketLikeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.SocketLike p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccepted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='DumpappHttpSocketLikeHandler']/method[@name='onAccepted' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.server.SocketLike']]"
		[Register ("onAccepted", "(Lcom/facebook/stetho/server/SocketLike;)V", "GetOnAccepted_Lcom_facebook_stetho_server_SocketLike_Handler")]
		public virtual unsafe void OnAccepted (global::Com.Facebook.Stetho.Server.SocketLike p0)
		{
			if (id_onAccepted_Lcom_facebook_stetho_server_SocketLike_ == IntPtr.Zero)
				id_onAccepted_Lcom_facebook_stetho_server_SocketLike_ = JNIEnv.GetMethodID (class_ref, "onAccepted", "(Lcom/facebook/stetho/server/SocketLike;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccepted_Lcom_facebook_stetho_server_SocketLike_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccepted", "(Lcom/facebook/stetho/server/SocketLike;)V"), __args);
			} finally {
			}
		}

	}
}
