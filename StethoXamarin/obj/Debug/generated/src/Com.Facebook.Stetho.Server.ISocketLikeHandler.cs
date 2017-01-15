using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.server']/interface[@name='SocketLikeHandler']"
	[Register ("com/facebook/stetho/server/SocketLikeHandler", "", "Com.Facebook.Stetho.Server.ISocketLikeHandlerInvoker")]
	public partial interface ISocketLikeHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/interface[@name='SocketLikeHandler']/method[@name='onAccepted' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.server.SocketLike']]"
		[Register ("onAccepted", "(Lcom/facebook/stetho/server/SocketLike;)V", "GetOnAccepted_Lcom_facebook_stetho_server_SocketLike_Handler:Com.Facebook.Stetho.Server.ISocketLikeHandlerInvoker, StethoXamarin")]
		void OnAccepted (global::Com.Facebook.Stetho.Server.SocketLike p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/server/SocketLikeHandler", DoNotGenerateAcw=true)]
	internal class ISocketLikeHandlerInvoker : global::Java.Lang.Object, ISocketLikeHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/server/SocketLikeHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISocketLikeHandlerInvoker); }
		}

		IntPtr class_ref;

		public static ISocketLikeHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketLikeHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.server.SocketLikeHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketLikeHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
#pragma warning disable 0169
		static Delegate GetOnAccepted_Lcom_facebook_stetho_server_SocketLike_Handler ()
		{
			if (cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_ == null)
				cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAccepted_Lcom_facebook_stetho_server_SocketLike_);
			return cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
		}

		static void n_OnAccepted_Lcom_facebook_stetho_server_SocketLike_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Server.ISocketLikeHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ISocketLikeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.SocketLike p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccepted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
		public unsafe void OnAccepted (global::Com.Facebook.Stetho.Server.SocketLike p0)
		{
			if (id_onAccepted_Lcom_facebook_stetho_server_SocketLike_ == IntPtr.Zero)
				id_onAccepted_Lcom_facebook_stetho_server_SocketLike_ = JNIEnv.GetMethodID (class_ref, "onAccepted", "(Lcom/facebook/stetho/server/SocketLike;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccepted_Lcom_facebook_stetho_server_SocketLike_, __args);
		}

	}

}
