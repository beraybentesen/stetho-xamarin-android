using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SecureSocketHandler']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/SecureSocketHandler", DoNotGenerateAcw=true)]
	public abstract partial class SecureSocketHandler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.ISocketHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/SecureSocketHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SecureSocketHandler); }
		}

		protected SecureSocketHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SecureSocketHandler']/constructor[@name='SecureSocketHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SecureSocketHandler (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SecureSocketHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_onAccepted_Landroid_net_LocalSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SecureSocketHandler']/method[@name='onAccepted' and count(parameter)=1 and parameter[1][@type='android.net.LocalSocket']]"
		[Register ("onAccepted", "(Landroid/net/LocalSocket;)V", "")]
		public unsafe void OnAccepted (global::Android.Net.LocalSocket p0)
		{
			if (id_onAccepted_Landroid_net_LocalSocket_ == IntPtr.Zero)
				id_onAccepted_Landroid_net_LocalSocket_ = JNIEnv.GetMethodID (class_ref, "onAccepted", "(Landroid/net/LocalSocket;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccepted_Landroid_net_LocalSocket_, __args);
			} finally {
			}
		}

		static Delegate cb_onSecured_Landroid_net_LocalSocket_;
#pragma warning disable 0169
		static Delegate GetOnSecured_Landroid_net_LocalSocket_Handler ()
		{
			if (cb_onSecured_Landroid_net_LocalSocket_ == null)
				cb_onSecured_Landroid_net_LocalSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSecured_Landroid_net_LocalSocket_);
			return cb_onSecured_Landroid_net_LocalSocket_;
		}

		static void n_OnSecured_Landroid_net_LocalSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Server.SecureSocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SecureSocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.LocalSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Net.LocalSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSecured (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SecureSocketHandler']/method[@name='onSecured' and count(parameter)=1 and parameter[1][@type='android.net.LocalSocket']]"
		[Register ("onSecured", "(Landroid/net/LocalSocket;)V", "GetOnSecured_Landroid_net_LocalSocket_Handler")]
		protected abstract void OnSecured (global::Android.Net.LocalSocket p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/server/SecureSocketHandler", DoNotGenerateAcw=true)]
	internal partial class SecureSocketHandlerInvoker : SecureSocketHandler {

		public SecureSocketHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SecureSocketHandlerInvoker); }
		}

		static IntPtr id_onSecured_Landroid_net_LocalSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SecureSocketHandler']/method[@name='onSecured' and count(parameter)=1 and parameter[1][@type='android.net.LocalSocket']]"
		[Register ("onSecured", "(Landroid/net/LocalSocket;)V", "GetOnSecured_Landroid_net_LocalSocket_Handler")]
		protected override unsafe void OnSecured (global::Android.Net.LocalSocket p0)
		{
			if (id_onSecured_Landroid_net_LocalSocket_ == IntPtr.Zero)
				id_onSecured_Landroid_net_LocalSocket_ = JNIEnv.GetMethodID (class_ref, "onSecured", "(Landroid/net/LocalSocket;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSecured_Landroid_net_LocalSocket_, __args);
			} finally {
			}
		}

	}

}
