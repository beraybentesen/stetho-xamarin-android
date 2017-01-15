using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/interface[@name='PendingRequestCallback']"
	[Register ("com/facebook/stetho/inspector/jsonrpc/PendingRequestCallback", "", "Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallbackInvoker")]
	public partial interface IPendingRequestCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/interface[@name='PendingRequestCallback']/method[@name='onResponse' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='com.facebook.stetho.inspector.jsonrpc.protocol.JsonRpcResponse']]"
		[Register ("onResponse", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcResponse;)V", "GetOnResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_Handler:Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallbackInvoker, StethoXamarin")]
		void OnResponse (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcResponse p1);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/PendingRequestCallback", DoNotGenerateAcw=true)]
	internal class IPendingRequestCallbackInvoker : global::Java.Lang.Object, IPendingRequestCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/PendingRequestCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPendingRequestCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IPendingRequestCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPendingRequestCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.jsonrpc.PendingRequestCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPendingRequestCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_Handler ()
		{
			if (cb_onResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_ == null)
				cb_onResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_);
			return cb_onResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_;
		}

		static void n_OnResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcResponse p1 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_;
		public unsafe void OnResponse (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcResponse p1)
		{
			if (id_onResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_ == IntPtr.Zero)
				id_onResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcResponse;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcResponse_, __args);
		}

	}

}
