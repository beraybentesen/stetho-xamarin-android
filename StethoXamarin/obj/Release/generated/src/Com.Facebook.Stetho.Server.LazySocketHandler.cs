using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='LazySocketHandler']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/LazySocketHandler", DoNotGenerateAcw=true)]
	public partial class LazySocketHandler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.ISocketHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/LazySocketHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LazySocketHandler); }
		}

		protected LazySocketHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_server_SocketHandlerFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='LazySocketHandler']/constructor[@name='LazySocketHandler' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.server.SocketHandlerFactory']]"
		[Register (".ctor", "(Lcom/facebook/stetho/server/SocketHandlerFactory;)V", "")]
		public unsafe LazySocketHandler (global::Com.Facebook.Stetho.Server.ISocketHandlerFactory p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LazySocketHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/server/SocketHandlerFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/server/SocketHandlerFactory;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_server_SocketHandlerFactory_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_server_SocketHandlerFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/server/SocketHandlerFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_server_SocketHandlerFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_server_SocketHandlerFactory_, __args);
			} finally {
			}
		}

		static Delegate cb_onAccepted_Landroid_net_LocalSocket_;
#pragma warning disable 0169
		static Delegate GetOnAccepted_Landroid_net_LocalSocket_Handler ()
		{
			if (cb_onAccepted_Landroid_net_LocalSocket_ == null)
				cb_onAccepted_Landroid_net_LocalSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAccepted_Landroid_net_LocalSocket_);
			return cb_onAccepted_Landroid_net_LocalSocket_;
		}

		static void n_OnAccepted_Landroid_net_LocalSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Server.LazySocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.LazySocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.LocalSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Net.LocalSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccepted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAccepted_Landroid_net_LocalSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='LazySocketHandler']/method[@name='onAccepted' and count(parameter)=1 and parameter[1][@type='android.net.LocalSocket']]"
		[Register ("onAccepted", "(Landroid/net/LocalSocket;)V", "GetOnAccepted_Landroid_net_LocalSocket_Handler")]
		public virtual unsafe void OnAccepted (global::Android.Net.LocalSocket p0)
		{
			if (id_onAccepted_Landroid_net_LocalSocket_ == IntPtr.Zero)
				id_onAccepted_Landroid_net_LocalSocket_ = JNIEnv.GetMethodID (class_ref, "onAccepted", "(Landroid/net/LocalSocket;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccepted_Landroid_net_LocalSocket_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccepted", "(Landroid/net/LocalSocket;)V"), __args);
			} finally {
			}
		}

	}
}
