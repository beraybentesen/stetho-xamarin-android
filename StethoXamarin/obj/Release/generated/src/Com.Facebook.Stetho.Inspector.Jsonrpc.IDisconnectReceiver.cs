using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/interface[@name='DisconnectReceiver']"
	[Register ("com/facebook/stetho/inspector/jsonrpc/DisconnectReceiver", "", "Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiverInvoker")]
	public partial interface IDisconnectReceiver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/interface[@name='DisconnectReceiver']/method[@name='onDisconnect' and count(parameter)=0]"
		[Register ("onDisconnect", "()V", "GetOnDisconnectHandler:Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiverInvoker, StethoXamarin")]
		void OnDisconnect ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/DisconnectReceiver", DoNotGenerateAcw=true)]
	internal class IDisconnectReceiverInvoker : global::Java.Lang.Object, IDisconnectReceiver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/DisconnectReceiver");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDisconnectReceiverInvoker); }
		}

		IntPtr class_ref;

		public static IDisconnectReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDisconnectReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.jsonrpc.DisconnectReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDisconnectReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IDisconnectReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnect ();
		}
#pragma warning restore 0169

		IntPtr id_onDisconnect;
		public unsafe void OnDisconnect ()
		{
			if (id_onDisconnect == IntPtr.Zero)
				id_onDisconnect = JNIEnv.GetMethodID (class_ref, "onDisconnect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnect);
		}

	}

}
