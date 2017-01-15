using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MethodDispatcher']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/MethodDispatcher", DoNotGenerateAcw=true)]
	public partial class MethodDispatcher : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MethodDispatcher.MethodDispatchHelper']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/MethodDispatcher$MethodDispatchHelper", DoNotGenerateAcw=true)]
		public partial class MethodDispatchHelper : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/MethodDispatcher$MethodDispatchHelper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MethodDispatchHelper); }
			}

			protected MethodDispatchHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_Ljava_lang_reflect_Method_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MethodDispatcher.MethodDispatchHelper']/constructor[@name='MethodDispatcher.MethodDispatchHelper' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.json.ObjectMapper'] and parameter[2][@type='com.facebook.stetho.inspector.protocol.ChromeDevtoolsDomain'] and parameter[3][@type='java.lang.reflect.Method']]"
			[Register (".ctor", "(Lcom/facebook/stetho/json/ObjectMapper;Lcom/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain;Ljava/lang/reflect/Method;)V", "")]
			public unsafe MethodDispatchHelper (global::Com.Facebook.Stetho.Json.ObjectMapper p0, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain p1, global::Java.Lang.Reflect.Method p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (MethodDispatchHelper)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/json/ObjectMapper;Lcom/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain;Ljava/lang/reflect/Method;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/json/ObjectMapper;Lcom/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain;Ljava/lang/reflect/Method;)V", __args);
						return;
					}

					if (id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_Ljava_lang_reflect_Method_ == IntPtr.Zero)
						id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_Ljava_lang_reflect_Method_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/json/ObjectMapper;Lcom/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain;Ljava/lang/reflect/Method;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_Ljava_lang_reflect_Method_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_inspector_protocol_ChromeDevtoolsDomain_Ljava_lang_reflect_Method_, __args);
				} finally {
				}
			}

			static Delegate cb_invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetInvoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
			{
				if (cb_invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
					cb_invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
				return cb_invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
			}

			static IntPtr n_Invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Facebook.Stetho.Inspector.MethodDispatcher.MethodDispatchHelper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.MethodDispatcher.MethodDispatchHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MethodDispatcher.MethodDispatchHelper']/method[@name='invoke' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
			[Register ("invoke", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "GetInvoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
			public virtual unsafe global::Org.Json.JSONObject Invoke (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
			{
				if (id_invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Org.Json.JSONObject __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/MethodDispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MethodDispatcher); }
		}

		protected MethodDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Ljava_lang_Iterable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MethodDispatcher']/constructor[@name='MethodDispatcher' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.json.ObjectMapper'] and parameter[2][@type='java.lang.Iterable&lt;com.facebook.stetho.inspector.protocol.ChromeDevtoolsDomain&gt;']]"
		[Register (".ctor", "(Lcom/facebook/stetho/json/ObjectMapper;Ljava/lang/Iterable;)V", "")]
		public unsafe MethodDispatcher (global::Com.Facebook.Stetho.Json.ObjectMapper p0, global::Java.Lang.IIterable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MethodDispatcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/json/ObjectMapper;Ljava/lang/Iterable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/json/ObjectMapper;Ljava/lang/Iterable;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Ljava_lang_Iterable_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/json/ObjectMapper;Ljava/lang/Iterable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Ljava_lang_Iterable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Ljava_lang_Iterable_, __args);
			} finally {
			}
		}

		static Delegate cb_dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetDispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static IntPtr n_Dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.MethodDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.MethodDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Dispatch (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MethodDispatcher']/method[@name='dispatch' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("dispatch", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "GetDispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Org.Json.JSONObject Dispatch (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, string p1, global::Org.Json.JSONObject p2)
		{
			if (id_dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "dispatch", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Org.Json.JSONObject __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dispatch_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_String_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatch", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
