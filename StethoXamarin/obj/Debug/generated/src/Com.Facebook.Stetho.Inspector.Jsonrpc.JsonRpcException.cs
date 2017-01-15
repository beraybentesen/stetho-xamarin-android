using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcException']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/JsonRpcException", DoNotGenerateAcw=true)]
	public partial class JsonRpcException : global::Java.Lang.Exception {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/JsonRpcException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonRpcException); }
		}

		protected JsonRpcException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcException']/constructor[@name='JsonRpcException' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.protocol.JsonRpcError']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError;)V", "")]
		public unsafe JsonRpcException (global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (JsonRpcException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_, __args);
			} finally {
			}
		}

		static Delegate cb_getErrorMessage;
#pragma warning disable 0169
		static Delegate GetGetErrorMessageHandler ()
		{
			if (cb_getErrorMessage == null)
				cb_getErrorMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorMessage);
			return cb_getErrorMessage;
		}

		static IntPtr n_GetErrorMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcException __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorMessage;
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcException']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError;", "GetGetErrorMessageHandler")]
			get {
				if (id_getErrorMessage == IntPtr.Zero)
					id_getErrorMessage = JNIEnv.GetMethodID (class_ref, "getErrorMessage", "()Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getErrorMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorMessage", "()Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
