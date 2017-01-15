using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Helper {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/interface[@name='PeerRegistrationListener']"
	[Register ("com/facebook/stetho/inspector/helper/PeerRegistrationListener", "", "Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListenerInvoker")]
	public partial interface IPeerRegistrationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/interface[@name='PeerRegistrationListener']/method[@name='onPeerRegistered' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
		[Register ("onPeerRegistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "GetOnPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler:Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListenerInvoker, StethoXamarin")]
		void OnPeerRegistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/interface[@name='PeerRegistrationListener']/method[@name='onPeerUnregistered' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer']]"
		[Register ("onPeerUnregistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V", "GetOnPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler:Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListenerInvoker, StethoXamarin")]
		void OnPeerUnregistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/helper/PeerRegistrationListener", DoNotGenerateAcw=true)]
	internal class IPeerRegistrationListenerInvoker : global::Java.Lang.Object, IPeerRegistrationListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/helper/PeerRegistrationListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPeerRegistrationListenerInvoker); }
		}

		IntPtr class_ref;

		public static IPeerRegistrationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPeerRegistrationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.helper.PeerRegistrationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPeerRegistrationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
#pragma warning disable 0169
		static Delegate GetOnPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler ()
		{
			if (cb_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == null)
				cb_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_);
			return cb_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		}

		static void n_OnPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerRegistered (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		public unsafe void OnPeerRegistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			if (id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
				id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerRegistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPeerRegistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
		}

		static Delegate cb_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
#pragma warning disable 0169
		static Delegate GetOnPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Handler ()
		{
			if (cb_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == null)
				cb_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_);
			return cb_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		}

		static void n_OnPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.IPeerRegistrationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerUnregistered (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_;
		public unsafe void OnPeerUnregistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			if (id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ == IntPtr.Zero)
				id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerUnregistered", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPeerUnregistered_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_, __args);
		}

	}

	public partial class PeerRegisteredEventArgs : global::System.EventArgs {

		public PeerRegisteredEventArgs (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			this.p0 = p0;
		}

		global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0;
		public global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer P0 {
			get { return p0; }
		}
	}

	public partial class PeerUnregisteredEventArgs : global::System.EventArgs {

		public PeerUnregisteredEventArgs (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			this.p0 = p0;
		}

		global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0;
		public global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/stetho/inspector/helper/PeerRegistrationListenerImplementor")]
	internal sealed partial class IPeerRegistrationListenerImplementor : global::Java.Lang.Object, IPeerRegistrationListener {

		object sender;

		public IPeerRegistrationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/stetho/inspector/helper/PeerRegistrationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PeerRegisteredEventArgs> OnPeerRegisteredHandler;
#pragma warning restore 0649

		public void OnPeerRegistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			var __h = OnPeerRegisteredHandler;
			if (__h != null)
				__h (sender, new PeerRegisteredEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<PeerUnregisteredEventArgs> OnPeerUnregisteredHandler;
#pragma warning restore 0649

		public void OnPeerUnregistered (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0)
		{
			var __h = OnPeerUnregisteredHandler;
			if (__h != null)
				__h (sender, new PeerUnregisteredEventArgs (p0));
		}

		internal static bool __IsEmpty (IPeerRegistrationListenerImplementor value)
		{
			return value.OnPeerRegisteredHandler == null && value.OnPeerUnregisteredHandler == null;
		}
	}

}
