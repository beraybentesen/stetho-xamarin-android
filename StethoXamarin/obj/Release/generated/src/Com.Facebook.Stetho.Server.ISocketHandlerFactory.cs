using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.server']/interface[@name='SocketHandlerFactory']"
	[Register ("com/facebook/stetho/server/SocketHandlerFactory", "", "Com.Facebook.Stetho.Server.ISocketHandlerFactoryInvoker")]
	public partial interface ISocketHandlerFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/interface[@name='SocketHandlerFactory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/facebook/stetho/server/SocketHandler;", "GetCreateHandler:Com.Facebook.Stetho.Server.ISocketHandlerFactoryInvoker, StethoXamarin")]
		global::Com.Facebook.Stetho.Server.ISocketHandler Create ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/server/SocketHandlerFactory", DoNotGenerateAcw=true)]
	internal class ISocketHandlerFactoryInvoker : global::Java.Lang.Object, ISocketHandlerFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/server/SocketHandlerFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISocketHandlerFactoryInvoker); }
		}

		IntPtr class_ref;

		public static ISocketHandlerFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketHandlerFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.server.SocketHandlerFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketHandlerFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Create);
			return cb_create;
		}

		static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Server.ISocketHandlerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ISocketHandlerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Create ());
		}
#pragma warning restore 0169

		IntPtr id_create;
		public unsafe global::Com.Facebook.Stetho.Server.ISocketHandler Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lcom/facebook/stetho/server/SocketHandler;");
			return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ISocketHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create), JniHandleOwnership.TransferLocalRef);
		}

	}

}
