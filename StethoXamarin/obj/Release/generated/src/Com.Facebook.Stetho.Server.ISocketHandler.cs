using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.server']/interface[@name='SocketHandler']"
	[Register ("com/facebook/stetho/server/SocketHandler", "", "Com.Facebook.Stetho.Server.ISocketHandlerInvoker")]
	public partial interface ISocketHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/interface[@name='SocketHandler']/method[@name='onAccepted' and count(parameter)=1 and parameter[1][@type='android.net.LocalSocket']]"
		[Register ("onAccepted", "(Landroid/net/LocalSocket;)V", "GetOnAccepted_Landroid_net_LocalSocket_Handler:Com.Facebook.Stetho.Server.ISocketHandlerInvoker, StethoXamarin")]
		void OnAccepted (global::Android.Net.LocalSocket p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/server/SocketHandler", DoNotGenerateAcw=true)]
	internal class ISocketHandlerInvoker : global::Java.Lang.Object, ISocketHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/server/SocketHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISocketHandlerInvoker); }
		}

		IntPtr class_ref;

		public static ISocketHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.server.SocketHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Stetho.Server.ISocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ISocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.LocalSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Net.LocalSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccepted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAccepted_Landroid_net_LocalSocket_;
		public unsafe void OnAccepted (global::Android.Net.LocalSocket p0)
		{
			if (id_onAccepted_Landroid_net_LocalSocket_ == IntPtr.Zero)
				id_onAccepted_Landroid_net_LocalSocket_ = JNIEnv.GetMethodID (class_ref, "onAccepted", "(Landroid/net/LocalSocket;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccepted_Landroid_net_LocalSocket_, __args);
		}

	}

}
