using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='PendingRequest']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/PendingRequest", DoNotGenerateAcw=true)]
	public partial class PendingRequest : global::Java.Lang.Object {


		static IntPtr callback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='PendingRequest']/field[@name='callback']"
		[Register ("callback")]
		public global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback Callback {
			get {
				if (callback_jfieldId == IntPtr.Zero)
					callback_jfieldId = JNIEnv.GetFieldID (class_ref, "callback", "Lcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, callback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (callback_jfieldId == IntPtr.Zero)
					callback_jfieldId = JNIEnv.GetFieldID (class_ref, "callback", "Lcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, callback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr requestId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='PendingRequest']/field[@name='requestId']"
		[Register ("requestId")]
		public long RequestId {
			get {
				if (requestId_jfieldId == IntPtr.Zero)
					requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId);
			}
			set {
				if (requestId_jfieldId == IntPtr.Zero)
					requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/PendingRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PendingRequest); }
		}

		protected PendingRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JLcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='PendingRequest']/constructor[@name='PendingRequest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.facebook.stetho.inspector.jsonrpc.PendingRequestCallback']]"
		[Register (".ctor", "(JLcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V", "")]
		public unsafe PendingRequest (long p0, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PendingRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JLcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JLcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V", __args);
					return;
				}

				if (id_ctor_JLcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ == IntPtr.Zero)
					id_ctor_JLcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JLcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JLcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_, __args);
			} finally {
			}
		}

	}
}
