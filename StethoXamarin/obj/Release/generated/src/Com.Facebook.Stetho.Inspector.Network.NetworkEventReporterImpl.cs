using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/NetworkEventReporterImpl", DoNotGenerateAcw=true)]
	public partial class NetworkEventReporterImpl : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/NetworkEventReporterImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkEventReporterImpl); }
		}

		protected NetworkEventReporterImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		public virtual unsafe bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_dataReceived_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetDataReceived_Ljava_lang_String_IIHandler ()
		{
			if (cb_dataReceived_Ljava_lang_String_II == null)
				cb_dataReceived_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_DataReceived_Ljava_lang_String_II);
			return cb_dataReceived_Ljava_lang_String_II;
		}

		static void n_DataReceived_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataReceived (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_dataReceived_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='dataReceived' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dataReceived", "(Ljava/lang/String;II)V", "GetDataReceived_Ljava_lang_String_IIHandler")]
		public virtual unsafe void DataReceived (string p0, int p1, int p2)
		{
			if (id_dataReceived_Ljava_lang_String_II == IntPtr.Zero)
				id_dataReceived_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "dataReceived", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dataReceived_Ljava_lang_String_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dataReceived", "(Ljava/lang/String;II)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_dataSent_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetDataSent_Ljava_lang_String_IIHandler ()
		{
			if (cb_dataSent_Ljava_lang_String_II == null)
				cb_dataSent_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_DataSent_Ljava_lang_String_II);
			return cb_dataSent_Ljava_lang_String_II;
		}

		static void n_DataSent_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSent (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_dataSent_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='dataSent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dataSent", "(Ljava/lang/String;II)V", "GetDataSent_Ljava_lang_String_IIHandler")]
		public virtual unsafe void DataSent (string p0, int p1, int p2)
		{
			if (id_dataSent_Ljava_lang_String_II == IntPtr.Zero)
				id_dataSent_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "dataSent", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dataSent_Ljava_lang_String_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dataSent", "(Ljava/lang/String;II)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/facebook/stetho/inspector/network/NetworkEventReporter;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/facebook/stetho/inspector/network/NetworkEventReporter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHttpExchangeFailed_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpExchangeFailed_Ljava_lang_String_Ljava_lang_String_);
			return cb_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_HttpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HttpExchangeFailed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='httpExchangeFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpExchangeFailed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetHttpExchangeFailed_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void HttpExchangeFailed (string p0, string p1)
		{
			if (id_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "httpExchangeFailed", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "httpExchangeFailed", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_;
#pragma warning disable 0169
		static Delegate GetInterpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_Handler ()
		{
			if (cb_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ == null)
				cb_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InterpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_);
			return cb_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_;
		}

		static IntPtr n_InterpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p3 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler p4 = (global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InterpretResponseStream (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='interpretResponseStream' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.io.InputStream'] and parameter[5][@type='com.facebook.stetho.inspector.network.ResponseHandler']]"
		[Register ("interpretResponseStream", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;Lcom/facebook/stetho/inspector/network/ResponseHandler;)Ljava/io/InputStream;", "GetInterpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_Handler")]
		public virtual unsafe global::System.IO.Stream InterpretResponseStream (string p0, string p1, string p2, global::System.IO.Stream p3, global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler p4)
		{
			if (id_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ == IntPtr.Zero)
				id_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ = JNIEnv.GetMethodID (class_ref, "interpretResponseStream", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;Lcom/facebook/stetho/inspector/network/ResponseHandler;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "interpretResponseStream", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;Lcom/facebook/stetho/inspector/network/ResponseHandler;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_;
#pragma warning disable 0169
		static Delegate GetRequestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_Handler ()
		{
			if (cb_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ == null)
				cb_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_);
			return cb_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_;
		}

		static void n_RequestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest p0 = (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestWillBeSent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='requestWillBeSent' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.network.NetworkEventReporter.InspectorRequest']]"
		[Register ("requestWillBeSent", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorRequest;)V", "GetRequestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_Handler")]
		public virtual unsafe void RequestWillBeSent (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest p0)
		{
			if (id_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ == IntPtr.Zero)
				id_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ = JNIEnv.GetMethodID (class_ref, "requestWillBeSent", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestWillBeSent", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorRequest;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_;
#pragma warning disable 0169
		static Delegate GetResponseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_Handler ()
		{
			if (cb_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ == null)
				cb_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResponseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_);
			return cb_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_;
		}

		static void n_ResponseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse p0 = (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseHeadersReceived (p0);
		}
#pragma warning restore 0169

		static IntPtr id_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='responseHeadersReceived' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.network.NetworkEventReporter.InspectorResponse']]"
		[Register ("responseHeadersReceived", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorResponse;)V", "GetResponseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_Handler")]
		public virtual unsafe void ResponseHeadersReceived (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse p0)
		{
			if (id_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ == IntPtr.Zero)
				id_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ = JNIEnv.GetMethodID (class_ref, "responseHeadersReceived", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseHeadersReceived", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorResponse;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_responseReadFailed_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResponseReadFailed_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_responseReadFailed_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_responseReadFailed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResponseReadFailed_Ljava_lang_String_Ljava_lang_String_);
			return cb_responseReadFailed_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ResponseReadFailed_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ResponseReadFailed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_responseReadFailed_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='responseReadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("responseReadFailed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetResponseReadFailed_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ResponseReadFailed (string p0, string p1)
		{
			if (id_responseReadFailed_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_responseReadFailed_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "responseReadFailed", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_responseReadFailed_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseReadFailed", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_responseReadFinished_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResponseReadFinished_Ljava_lang_String_Handler ()
		{
			if (cb_responseReadFinished_Ljava_lang_String_ == null)
				cb_responseReadFinished_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResponseReadFinished_Ljava_lang_String_);
			return cb_responseReadFinished_Ljava_lang_String_;
		}

		static void n_ResponseReadFinished_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkEventReporterImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseReadFinished (p0);
		}
#pragma warning restore 0169

		static IntPtr id_responseReadFinished_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkEventReporterImpl']/method[@name='responseReadFinished' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("responseReadFinished", "(Ljava/lang/String;)V", "GetResponseReadFinished_Ljava_lang_String_Handler")]
		public virtual unsafe void ResponseReadFinished (string p0)
		{
			if (id_responseReadFinished_Ljava_lang_String_ == IntPtr.Zero)
				id_responseReadFinished_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "responseReadFinished", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_responseReadFinished_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseReadFinished", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
