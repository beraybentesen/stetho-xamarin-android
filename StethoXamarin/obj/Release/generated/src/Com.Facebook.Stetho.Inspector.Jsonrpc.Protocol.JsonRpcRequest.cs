using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcRequest']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcRequest", DoNotGenerateAcw=true)]
	public partial class JsonRpcRequest : global::Java.Lang.Object {


		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcRequest']/field[@name='id']"
		[Register ("id")]
		public global::Java.Lang.Long Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/Long;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/Long;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr method_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcRequest']/field[@name='method']"
		[Register ("method")]
		public string Method {
			get {
				if (method_jfieldId == IntPtr.Zero)
					method_jfieldId = JNIEnv.GetFieldID (class_ref, "method", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, method_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (method_jfieldId == IntPtr.Zero)
					method_jfieldId = JNIEnv.GetFieldID (class_ref, "method", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, method_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr params_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcRequest']/field[@name='params']"
		[Register ("params")]
		public global::Org.Json.JSONObject Params {
			get {
				if (params_jfieldId == IntPtr.Zero)
					params_jfieldId = JNIEnv.GetFieldID (class_ref, "params", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, params_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (params_jfieldId == IntPtr.Zero)
					params_jfieldId = JNIEnv.GetFieldID (class_ref, "params", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, params_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonRpcRequest); }
		}

		protected JsonRpcRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcRequest']/constructor[@name='JsonRpcRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonRpcRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JsonRpcRequest)) {
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

		static IntPtr id_ctor_Ljava_lang_Long_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcRequest']/constructor[@name='JsonRpcRequest' and count(parameter)=3 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Ljava/lang/Long;Ljava/lang/String;Lorg/json/JSONObject;)V", "")]
		public unsafe JsonRpcRequest (global::Java.Lang.Long p0, string p1, global::Org.Json.JSONObject p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (JsonRpcRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Long;Ljava/lang/String;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Long;Ljava/lang/String;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Long_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Long_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Long;Ljava/lang/String;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_String_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_String_Lorg_json_JSONObject_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
