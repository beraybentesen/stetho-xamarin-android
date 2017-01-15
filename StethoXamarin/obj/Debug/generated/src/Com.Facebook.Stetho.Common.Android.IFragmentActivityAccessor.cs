using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentActivityAccessor']"
	[Register ("com/facebook/stetho/common/android/FragmentActivityAccessor", "", "Com.Facebook.Stetho.Common.Android.IFragmentActivityAccessorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"FRAGMENT_ACTIVITY extends android.app.Activity", "FRAGMENT_MANAGER"})]
	public partial interface IFragmentActivityAccessor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentActivityAccessor']/method[@name='getFragmentManager' and count(parameter)=1 and parameter[1][@type='FRAGMENT_ACTIVITY']]"
		[Register ("getFragmentManager", "(Landroid/app/Activity;)Ljava/lang/Object;", "GetGetFragmentManager_Landroid_app_Activity_Handler:Com.Facebook.Stetho.Common.Android.IFragmentActivityAccessorInvoker, StethoXamarin")]
		global::Java.Lang.Object GetFragmentManager (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/FragmentActivityAccessor", DoNotGenerateAcw=true)]
	internal class IFragmentActivityAccessorInvoker : global::Java.Lang.Object, IFragmentActivityAccessor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/android/FragmentActivityAccessor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFragmentActivityAccessorInvoker); }
		}

		IntPtr class_ref;

		public static IFragmentActivityAccessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFragmentActivityAccessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.android.FragmentActivityAccessor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFragmentActivityAccessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getFragmentManager_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetGetFragmentManager_Landroid_app_Activity_Handler ()
		{
			if (cb_getFragmentManager_Landroid_app_Activity_ == null)
				cb_getFragmentManager_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFragmentManager_Landroid_app_Activity_);
			return cb_getFragmentManager_Landroid_app_Activity_;
		}

		static IntPtr n_GetFragmentManager_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IFragmentActivityAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentActivityAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFragmentManager (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFragmentManager_Landroid_app_Activity_;
		public unsafe global::Java.Lang.Object GetFragmentManager (global::Java.Lang.Object p0)
		{
			if (id_getFragmentManager_Landroid_app_Activity_ == IntPtr.Zero)
				id_getFragmentManager_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "getFragmentManager", "(Landroid/app/Activity;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFragmentManager_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
