using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Console {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/interface[@name='RuntimeReplFactory']"
	[Register ("com/facebook/stetho/inspector/console/RuntimeReplFactory", "", "Com.Facebook.Stetho.Inspector.Console.IRuntimeReplFactoryInvoker")]
	public partial interface IRuntimeReplFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/interface[@name='RuntimeReplFactory']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/facebook/stetho/inspector/console/RuntimeRepl;", "GetNewInstanceHandler:Com.Facebook.Stetho.Inspector.Console.IRuntimeReplFactoryInvoker, StethoXamarin")]
		global::Com.Facebook.Stetho.Inspector.Console.IRuntimeRepl NewInstance ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/console/RuntimeReplFactory", DoNotGenerateAcw=true)]
	internal class IRuntimeReplFactoryInvoker : global::Java.Lang.Object, IRuntimeReplFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/console/RuntimeReplFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRuntimeReplFactoryInvoker); }
		}

		IntPtr class_ref;

		public static IRuntimeReplFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRuntimeReplFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.console.RuntimeReplFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRuntimeReplFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_newInstance;
#pragma warning disable 0169
		static Delegate GetNewInstanceHandler ()
		{
			if (cb_newInstance == null)
				cb_newInstance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewInstance);
			return cb_newInstance;
		}

		static IntPtr n_NewInstance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Console.IRuntimeReplFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Console.IRuntimeReplFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInstance ());
		}
#pragma warning restore 0169

		IntPtr id_newInstance;
		public unsafe global::Com.Facebook.Stetho.Inspector.Console.IRuntimeRepl NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetMethodID (class_ref, "newInstance", "()Lcom/facebook/stetho/inspector/console/RuntimeRepl;");
			return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Console.IRuntimeRepl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newInstance), JniHandleOwnership.TransferLocalRef);
		}

	}

}
