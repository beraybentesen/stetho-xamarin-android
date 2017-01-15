using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError", DoNotGenerateAcw=true)]
	public partial class JsonRpcError : global::Java.Lang.Object {


		static IntPtr code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError']/field[@name='code']"
		[Register ("code")]
		public global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode Code {
			get {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, code_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, code_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError']/field[@name='data']"
		[Register ("data")]
		public global::Org.Json.JSONObject Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class ErrorCode : global::Java.Lang.Enum {


			static IntPtr INTERNAL_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']/field[@name='INTERNAL_ERROR']"
			[Register ("INTERNAL_ERROR")]
			public static global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode InternalError {
				get {
					if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
						INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_PARAMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']/field[@name='INVALID_PARAMS']"
			[Register ("INVALID_PARAMS")]
			public static global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode InvalidParams {
				get {
					if (INVALID_PARAMS_jfieldId == IntPtr.Zero)
						INVALID_PARAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_PARAMS", "Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_PARAMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']/field[@name='INVALID_REQUEST']"
			[Register ("INVALID_REQUEST")]
			public static global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode InvalidRequest {
				get {
					if (INVALID_REQUEST_jfieldId == IntPtr.Zero)
						INVALID_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_REQUEST", "Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr METHOD_NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']/field[@name='METHOD_NOT_FOUND']"
			[Register ("METHOD_NOT_FOUND")]
			public static global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode MethodNotFound {
				get {
					if (METHOD_NOT_FOUND_jfieldId == IntPtr.Zero)
						METHOD_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METHOD_NOT_FOUND", "Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, METHOD_NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PARSER_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']/field[@name='PARSER_ERROR']"
			[Register ("PARSER_ERROR")]
			public static global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode ParserError {
				get {
					if (PARSER_ERROR_jfieldId == IntPtr.Zero)
						PARSER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARSER_ERROR", "Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARSER_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ErrorCode); }
			}

			internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getProtocolValue;
			public unsafe int ProtocolValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']/method[@name='getProtocolValue' and count(parameter)=0]"
				[Register ("getProtocolValue", "()I", "GetGetProtocolValueHandler")]
				get {
					if (id_getProtocolValue == IntPtr.Zero)
						id_getProtocolValue = JNIEnv.GetMethodID (class_ref, "getProtocolValue", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getProtocolValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError.ErrorCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;");
				try {
					return (global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonRpcError); }
		}

		protected JsonRpcError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError']/constructor[@name='JsonRpcError' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonRpcError ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JsonRpcError)) {
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

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_ErrorCode_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc.protocol']/class[@name='JsonRpcError']/constructor[@name='JsonRpcError' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.protocol.JsonRpcError.ErrorCode'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;Ljava/lang/String;Lorg/json/JSONObject;)V", "")]
		public unsafe JsonRpcError (global::Com.Facebook.Stetho.Inspector.Jsonrpc.Protocol.JsonRpcError.ErrorCode p0, string p1, global::Org.Json.JSONObject p2)
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
				if (GetType () != typeof (JsonRpcError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;Ljava/lang/String;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;Ljava/lang/String;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_ErrorCode_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_ErrorCode_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/jsonrpc/protocol/JsonRpcError$ErrorCode;Ljava/lang/String;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_ErrorCode_Ljava_lang_String_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_jsonrpc_protocol_JsonRpcError_ErrorCode_Ljava_lang_String_Lorg_json_JSONObject_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
