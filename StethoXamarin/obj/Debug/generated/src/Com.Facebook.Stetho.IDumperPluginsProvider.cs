using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho']/interface[@name='DumperPluginsProvider']"
	[Register ("com/facebook/stetho/DumperPluginsProvider", "", "Com.Facebook.Stetho.IDumperPluginsProviderInvoker")]
	public partial interface IDumperPluginsProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho']/interface[@name='DumperPluginsProvider']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Iterable;", "GetGetHandler:Com.Facebook.Stetho.IDumperPluginsProviderInvoker, StethoXamarin")]
		global::Java.Lang.IIterable Get ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/DumperPluginsProvider", DoNotGenerateAcw=true)]
	internal class IDumperPluginsProviderInvoker : global::Java.Lang.Object, IDumperPluginsProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/DumperPluginsProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDumperPluginsProviderInvoker); }
		}

		IntPtr class_ref;

		public static IDumperPluginsProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDumperPluginsProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.DumperPluginsProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDumperPluginsProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.IDumperPluginsProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.IDumperPluginsProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		IntPtr id_get;
		public unsafe global::Java.Lang.IIterable Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Iterable;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
		}

	}

}
