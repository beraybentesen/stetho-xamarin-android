using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/helper/ChromePeerManager", DoNotGenerateAcw=true)]
	public partial class ChromePeerManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager.UnregisterOnDisconnect']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/helper/ChromePeerManager$UnregisterOnDisconnect", DoNotGenerateAcw=true)]
		public partial class UnregisterOnDisconnect : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/helper/ChromePeerManager$UnregisterOnDisconnect", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UnregisterOnDisconnect); }
			}

			protected UnregisterOnDisconnect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager.UnregisterOnDisconnect']/constructor[@name='ChromePeerManager.UnregisterOnDisconnect' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.helper.ChromePeerManager'] and parameter[2][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
			[Register (".ctor", "(Lcom/facebook/stetho/inspector/helper/ChromePeerManager;Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "")]
			public unsafe UnregisterOnDisconnect (global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager __self, global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (UnregisterOnDisconnect)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", __args);
						return;
					}

					if (id_ctor_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
						id_ctor_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/helper/ChromePeerManager;Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_helper_ChromePeerManager_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
				} finally {
				}
			}

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
				global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager.UnregisterOnDisconnect __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager.UnregisterOnDisconnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDisconnect ();
			}
#pragma warning restore 0169

			static IntPtr id_onDisconnect;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager.UnregisterOnDisconnect']/method[@name='onDisconnect' and count(parameter)=0]"
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
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/helper/ChromePeerManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChromePeerManager); }
		}

		protected ChromePeerManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager']/constructor[@name='ChromePeerManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChromePeerManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ChromePeerManager)) {
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

		static Delegate cb_hasRegisteredPeers;
#pragma warning disable 0169
		static Delegate GetHasRegisteredPeersHandler ()
		{
			if (cb_hasRegisteredPeers == null)
				cb_hasRegisteredPeers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasRegisteredPeers);
			return cb_hasRegisteredPeers;
		}

		static bool n_HasRegisteredPeers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRegisteredPeers;
		}
#pragma warning restore 0169

		static IntPtr id_hasRegisteredPeers;
		public virtual unsafe bool HasRegisteredPeers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager']/method[@name='hasRegisteredPeers' and count(parameter)=0]"
			[Register ("hasRegisteredPeers", "()Z", "GetHasRegisteredPeersHandler")]
			get {
				if (id_hasRegisteredPeers == IntPtr.Zero)
					id_hasRegisteredPeers = JNIEnv.GetMethodID (class_ref, "hasRegisteredPeers", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasRegisteredPeers);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasRegisteredPeers", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
#pragma warning disable 0169
		static Delegate GetAddPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler ()
		{
			if (cb_addPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == null)
				cb_addPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_);
			return cb_addPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		}

		static bool n_AddPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPeer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager']/method[@name='addPeer' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
		[Register ("addPeer", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)Z", "GetAddPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler")]
		public virtual unsafe bool AddPeer (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			if (id_addPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
				id_addPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "addPeer", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addPeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPeer", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_invokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_;
#pragma warning disable 0169
		static Delegate GetInvokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_Handler ()
		{
			if (cb_invokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ == null)
				cb_invokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_);
			return cb_invokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_;
		}

		static void n_InvokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback p2 = (global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InvokeMethodOnPeers (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_invokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager']/method[@name='invokeMethodOnPeers' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.facebook.stetho.inspector.jsonrpc.PendingRequestCallback']]"
		[Register ("invokeMethodOnPeers", "(Ljava/lang/String;Ljava/lang/Object;Lcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V", "GetInvokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_Handler")]
		public virtual unsafe void InvokeMethodOnPeers (string p0, global::Java.Lang.Object p1, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IPendingRequestCallback p2)
		{
			if (id_invokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ == IntPtr.Zero)
				id_invokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_ = JNIEnv.GetMethodID (class_ref, "invokeMethodOnPeers", "(Ljava/lang/String;Ljava/lang/Object;Lcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invokeMethodOnPeers_Ljava_lang_String_Ljava_lang_Object_Lcom_facebook_stetho_inspector_jsonrpc_PendingRequestCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invokeMethodOnPeers", "(Ljava/lang/String;Ljava/lang/Object;Lcom/facebook/stetho/inspector/jsonrpc/PendingRequestCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
#pragma warning disable 0169
		static Delegate GetRemovePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler ()
		{
			if (cb_removePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == null)
				cb_removePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemovePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_);
			return cb_removePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		}

		static void n_RemovePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemovePeer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager']/method[@name='removePeer' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
		[Register ("removePeer", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "GetRemovePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler")]
		public virtual unsafe void RemovePeer (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			if (id_removePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
				id_removePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "removePeer", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removePeer_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePeer", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_sendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_sendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_);
			return cb_sendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendNotificationToPeers (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager']/method[@name='sendNotificationToPeers' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("sendNotificationToPeers", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SendNotificationToPeers (string p0, global::Java.Lang.Object p1)
		{
			if (id_sendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_sendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "sendNotificationToPeers", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendNotificationToPeers_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendNotificationToPeers", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_Handler ()
		{
			if (cb_setListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_ == null)
				cb_setListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_);
			return cb_setListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_;
		}

		static void n_SetListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener p0 = (global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ChromePeerManager']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.helper.PeerRegistrationListener']]"
		[Register ("setListener", "(Lcom/facebook/stetho/inspector/helper/PeerRegistrationListener;)V", "GetSetListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener p0)
		{
			if (id_setListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_ == IntPtr.Zero)
				id_setListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/facebook/stetho/inspector/helper/PeerRegistrationListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_facebook_stetho_inspector_helper_PeerRegistrationListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/facebook/stetho/inspector/helper/PeerRegistrationListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener"

		global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListenerImplementor __CreateIPeerRegistrationListenerImplementor ()
		{
			return new global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListenerImplementor (this);
		}
#endregion
	}
}
