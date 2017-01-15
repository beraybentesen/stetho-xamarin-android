using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/helper/PeersRegisteredListener", DoNotGenerateAcw=true)]
	public abstract partial class PeersRegisteredListener : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/helper/PeersRegisteredListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PeersRegisteredListener); }
		}

		protected PeersRegisteredListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/constructor[@name='PeersRegisteredListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PeersRegisteredListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PeersRegisteredListener)) {
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

		static Delegate cb_onFirstPeerRegistered;
#pragma warning disable 0169
		static Delegate GetOnFirstPeerRegisteredHandler ()
		{
			if (cb_onFirstPeerRegistered == null)
				cb_onFirstPeerRegistered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFirstPeerRegistered);
			return cb_onFirstPeerRegistered;
		}

		static void n_OnFirstPeerRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFirstPeerRegistered ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/method[@name='onFirstPeerRegistered' and count(parameter)=0]"
		[Register ("onFirstPeerRegistered", "()V", "GetOnFirstPeerRegisteredHandler")]
		protected abstract void OnFirstPeerRegistered ();

		static Delegate cb_onLastPeerUnregistered;
#pragma warning disable 0169
		static Delegate GetOnLastPeerUnregisteredHandler ()
		{
			if (cb_onLastPeerUnregistered == null)
				cb_onLastPeerUnregistered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLastPeerUnregistered);
			return cb_onLastPeerUnregistered;
		}

		static void n_OnLastPeerUnregistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLastPeerUnregistered ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/method[@name='onLastPeerUnregistered' and count(parameter)=0]"
		[Register ("onLastPeerUnregistered", "()V", "GetOnLastPeerUnregisteredHandler")]
		protected abstract void OnLastPeerUnregistered ();

		static Delegate cb_onPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
#pragma warning disable 0169
		static Delegate GetOnPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler ()
		{
			if (cb_onPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == null)
				cb_onPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_);
			return cb_onPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		}

		static void n_OnPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/method[@name='onPeerAdded' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
		[Register ("onPeerAdded", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "GetOnPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler")]
		protected virtual unsafe void OnPeerAdded (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			if (id_onPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
				id_onPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerAdded", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPeerAdded_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPeerAdded", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/method[@name='onPeerRegistered' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
		[Register ("onPeerRegistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "")]
		public unsafe void OnPeerRegistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			if (id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
				id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerRegistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
			} finally {
			}
		}

		static Delegate cb_onPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
#pragma warning disable 0169
		static Delegate GetOnPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler ()
		{
			if (cb_onPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == null)
				cb_onPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_);
			return cb_onPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		}

		static void n_OnPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/method[@name='onPeerRemoved' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
		[Register ("onPeerRemoved", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "GetOnPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler")]
		protected virtual unsafe void OnPeerRemoved (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			if (id_onPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
				id_onPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerRemoved", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPeerRemoved_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPeerRemoved", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/method[@name='onPeerUnregistered' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
		[Register ("onPeerUnregistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "")]
		public unsafe void OnPeerUnregistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			if (id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
				id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerUnregistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/helper/PeersRegisteredListener", DoNotGenerateAcw=true)]
	internal partial class PeersRegisteredListenerInvoker : PeersRegisteredListener {

		public PeersRegisteredListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PeersRegisteredListenerInvoker); }
		}

		static IntPtr id_onFirstPeerRegistered;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/method[@name='onFirstPeerRegistered' and count(parameter)=0]"
		[Register ("onFirstPeerRegistered", "()V", "GetOnFirstPeerRegisteredHandler")]
		protected override unsafe void OnFirstPeerRegistered ()
		{
			if (id_onFirstPeerRegistered == IntPtr.Zero)
				id_onFirstPeerRegistered = JNIEnv.GetMethodID (class_ref, "onFirstPeerRegistered", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFirstPeerRegistered);
			} finally {
			}
		}

		static IntPtr id_onLastPeerUnregistered;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='PeersRegisteredListener']/method[@name='onLastPeerUnregistered' and count(parameter)=0]"
		[Register ("onLastPeerUnregistered", "()V", "GetOnLastPeerUnregisteredHandler")]
		protected override unsafe void OnLastPeerUnregistered ()
		{
			if (id_onLastPeerUnregistered == IntPtr.Zero)
				id_onLastPeerUnregistered = JNIEnv.GetMethodID (class_ref, "onLastPeerUnregistered", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLastPeerUnregistered);
			} finally {
			}
		}

	}

}
