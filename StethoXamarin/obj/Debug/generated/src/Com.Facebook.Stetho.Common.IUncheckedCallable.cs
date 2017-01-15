using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='UncheckedCallable']"
	[Register ("com/facebook/stetho/common/UncheckedCallable", "", "Com.Facebook.Stetho.Common.IUncheckedCallableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
	public partial interface IUncheckedCallable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='UncheckedCallable']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Object;", "GetCallHandler:Com.Facebook.Stetho.Common.IUncheckedCallableInvoker, StethoXamarin")]
		global::Java.Lang.Object Call ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/UncheckedCallable", DoNotGenerateAcw=true)]
	internal class IUncheckedCallableInvoker : global::Java.Lang.Object, IUncheckedCallable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/UncheckedCallable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUncheckedCallableInvoker); }
		}

		IntPtr class_ref;

		public static IUncheckedCallable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUncheckedCallable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.UncheckedCallable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUncheckedCallableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.IUncheckedCallable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IUncheckedCallable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		IntPtr id_call;
		public unsafe global::Java.Lang.Object Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
		}

	}

}
