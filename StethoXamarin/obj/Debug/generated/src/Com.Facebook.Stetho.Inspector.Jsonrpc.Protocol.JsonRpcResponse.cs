using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcResponse']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcResponse", DoNotGenerateAcw=true)]
	public partial class JsonRpcResponse : global::Java.Lang.Object {


		static IntPtr error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcResponse']/field[@name='error']"
		[Register ("error")]
		public global::Org.Json.JSONObject Error {
			get {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, error_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcResponse']/field[@name='id']"
		[Register ("id")]
		public long Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr result_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcResponse']/field[@name='result']"
		[Register ("result")]
		public global::Org.Json.JSONObject Result {
			get {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, result_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, result_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonRpcResponse); }
		}

		protected JsonRpcResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcResponse']/constructor[@name='JsonRpcResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonRpcResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JsonRpcResponse)) {
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

	}
}
