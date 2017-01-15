using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/JsonRpcPeer", DoNotGenerateAcw=true)]
	public partial class JsonRpcPeer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer.DisconnectObservable']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/JsonRpcPeer$DisconnectObservable", DoNotGenerateAcw=true)]
		public partial class DisconnectObservable : global::Android.Database.Observable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/JsonRpcPeer$DisconnectObservable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DisconnectObservable); }
			}

			protected DisconnectObservable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onDisconnect;
#pragma warning disable 0169
			static Delegate GetOnDisconnectHandler ()
			{
				if (cb_onDisconnect == null)
					cb_onDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDisconnect);
				return cb_onDisconnect;
			}

			static void n_OnDisconnect (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer.DisconnectObservable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer.DisconnectObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDisconnect ();
			}
#pragma warning restore 0169

			static IntPtr id_onDisconnect;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer.DisconnectObservable']/method[@name='onDisconnect' and count(parameter)=0]"
			[Register ("onDisconnect", "()V", "GetOnDisconnectHandler")]
			public virtual unsafe void OnDisconnect ()
			{
				if (id_onDisconnect == IntPtr.Zero)
					id_onDisconnect = JNIEnv.GetMethodID (class_ref, "onDisconnect", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnect);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnect", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/JsonRpcPeer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonRpcPeer); }
		}

		protected JsonRpcPeer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_websocket_SimpleSession_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer']/constructor[@name='JsonRpcPeer' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.json.ObjectMapper'] and parameter[2][@type='com.facebook.stetho.websocket.SimpleSession']]"
		[Register (".ctor", "(Lcom/facebook/stetho/json/ObjectMapper;Lcom/facebook/stetho/websocket/SimpleSession;)V", "")]
		public unsafe JsonRpcPeer (global::Com.Facebook.Stetho.Json.ObjectMapper p0, global::Com.Facebook.Stetho.Websocket.ISimpleSession p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (JsonRpcPeer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/json/ObjectMapper;Lcom/facebook/stetho/websocket/SimpleSession;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/json/ObjectMapper;Lcom/facebook/stetho/websocket/SimpleSession;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_websocket_SimpleSession_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_websocket_SimpleSession_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/json/ObjectMapper;Lcom/facebook/stetho/websocket/SimpleSession;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_websocket_SimpleSession_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_json_ObjectMapper_Lcom_facebook_stetho_websocket_SimpleSession_, __args);
			} finally {
			}
		}

		static Delegate cb_getWebSocket;
#pragma warning disable 0169
		static Delegate GetGetWebSocketHandler ()
		{
			if (cb_getWebSocket == null)
				cb_getWebSocket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWebSocket);
			return cb_getWebSocket;
		}

		static IntPtr n_GetWebSocket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WebSocket);
		}
#pragma warning restore 0169

		static IntPtr id_getWebSocket;
		public virtual unsafe global::Com.Facebook.Stetho.Websocket.ISimpleSession WebSocket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer']/method[@name='getWebSocket' and count(parameter)=0]"
			[Register ("getWebSocket", "()Lcom/facebook/stetho/websocket/SimpleSession;", "GetGetWebSocketHandler")]
			get {
				if (id_getWebSocket == IntPtr.Zero)
					id_getWebSocket = JNIEnv.GetMethodID (class_ref, "getWebSocket", "()Lcom/facebook/stetho/websocket/SimpleSession;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWebSocket), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWebSocket", "()Lcom/facebook/stetho/websocket/SimpleSession;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAndRemovePendingRequest_J;
#pragma warning disable 0169
		static Delegate GetGetAndRemovePendingRequest_JHandler ()
		{
			if (cb_getAndRemovePendingRequest_J == null)
				cb_getAndRemovePendingRequest_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetAndRemovePendingRequest_J);
			return cb_getAndRemovePendingRequest_J;
		}

		static IntPtr n_GetAndRemovePendingRequest_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAndRemovePendingRequest (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAndRemovePendingRequest_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer']/method[@name='getAndRemovePendingRequest' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getAndRemovePendingRequest", "(J)Lcom/facebook/stetho/inspector/jsonrpc/PendingRequest;", "GetGetAndRemovePendingRequest_JHandler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.PendingRequest GetAndRemovePendingRequest (long p0)
		{
			if (id_getAndRemovePendingRequest_J == IntPtr.Zero)
				id_getAndRemovePendingRequest_J = JNIEnv.GetMethodID (class_ref, "getAndRemovePendingRequest", "(J)Lcom/facebook/stetho/inspector/jsonrpc/PendingRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.PendingRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAndRemovePendingRequest_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.PendingRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndRemovePendingRequest", "(J)Lcom/facebook/stetho/inspector/jsonrpc/PendingRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_invokeDisconnectReceivers;
#pragma warning disable 0169
		static Delegate GetInvokeDisconnectReceiversHandler ()
		{
			if (cb_invokeDisconnectReceivers == null)
				cb_invokeDisconnectReceivers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InvokeDisconnectReceivers);
			return cb_invokeDisconnectReceivers;
		}

		static void n_InvokeDisconnectReceivers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvokeDisconnectReceivers ();
		}
#pragma warning restore 0169

		static IntPtr id_invokeDisconnectReceivers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer']/method[@name='invokeDisconnectReceivers' and count(parameter)=0]"
		[Register ("invokeDisconnectReceivers", "()V", "GetInvokeDisconnectReceiversHandler")]
		public virtual unsafe void InvokeDisconnectReceivers ()
		{
			if (id_invokeDisconnectReceivers == IntPtr.Zero)
				id_invokeDisconnectReceivers = JNIEnv.GetMethodID (class_ref, "invokeDisconnectReceivers", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invokeDisconnectReceivers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invokeDisconnectReceivers", "()V"));
			} finally {
			}
		}

		static Delegate cb_invokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_;
#pragma warning disable 0169
		static Delegate GetInvokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_Handler ()
		{
			if (cb_invokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ == null)
				cb_invokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_);
			return cb_invokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_;
		}

		static void n_InvokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback p2 = (global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InvokeMethod (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_invokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer']/method[@name='invokeMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.facebook.stetho.inspector.jsonrpc.PendingRequestCallback']]"
		[Register ("invokeMethod", "(Ljava/lang/String;Ljava/lang/Object;Lcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V", "GetInvokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_Handler")]
		public virtual unsafe void InvokeMethod (string p0, global::Java.Lang.Object p1, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback p2)
		{
			if (id_invokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ == IntPtr.Zero)
				id_invokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ = JNIEnv.GetMethodID (class_ref, "invokeMethod", "(Ljava/lang/String;Ljava/lang/Object;Lcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invokeMethod_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invokeMethod", "(Ljava/lang/String;Ljava/lang/Object;Lcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_;
#pragma warning disable 0169
		static Delegate GetRegisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_Handler ()
		{
			if (cb_registerDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ == null)
				cb_registerDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_);
			return cb_registerDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_;
		}

		static void n_RegisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver p0 = (global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDisconnectReceiver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer']/method[@name='registerDisconnectReceiver' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.DisconnectReceiver']]"
		[Register ("registerDisconnectReceiver", "(Lcom/facebook/stetho/inspector/jsonrpc/DisconnectReceiver;)V", "GetRegisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_Handler")]
		public virtual unsafe void RegisterDisconnectReceiver (global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver p0)
		{
			if (id_registerDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ == IntPtr.Zero)
				id_registerDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ = JNIEnv.GetMethodID (class_ref, "registerDisconnectReceiver", "(Lcom/facebook/stetho/inspector/jsonrpc/DisconnectReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerDisconnectReceiver", "(Lcom/facebook/stetho/inspector/jsonrpc/DisconnectReceiver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_;
#pragma warning disable 0169
		static Delegate GetUnregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_Handler ()
		{
			if (cb_unregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ == null)
				cb_unregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_);
			return cb_unregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_;
		}

		static void n_UnregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver p0 = (global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterDisconnectReceiver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/class[@name='JsonRpcPeer']/method[@name='unregisterDisconnectReceiver' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.DisconnectReceiver']]"
		[Register ("unregisterDisconnectReceiver", "(Lcom/facebook/stetho/inspector/jsonrpc/DisconnectReceiver;)V", "GetUnregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_Handler")]
		public virtual unsafe void UnregisterDisconnectReceiver (global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver p0)
		{
			if (id_unregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ == IntPtr.Zero)
				id_unregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_ = JNIEnv.GetMethodID (class_ref, "unregisterDisconnectReceiver", "(Lcom/facebook/stetho/inspector/jsonrpc/DisconnectReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterDisconnectReceiver_Lcom_facebook_stetho_inspector_jsonrpc_DisconnectReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterDisconnectReceiver", "(Lcom/facebook/stetho/inspector/jsonrpc/DisconnectReceiver;)V"), __args);
			} finally {
			}
		}

	}
}
