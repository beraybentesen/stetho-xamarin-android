using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentManagerAccessor']"
	[Register ("com/facebook/stetho/common/android/FragmentManagerAccessor", "", "Com.Facebook.Stetho.Common.Android.IFragmentManagerAccessorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"FRAGMENT_MANAGER", "FRAGMENT"})]
	public partial interface IFragmentManagerAccessor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentManagerAccessor']/method[@name='getAddedFragments' and count(parameter)=1 and parameter[1][@type='FRAGMENT_MANAGER']]"
		[Register ("getAddedFragments", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetAddedFragments_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.Android.IFragmentManagerAccessorInvoker, StethoXamarin")]
		global::System.Collections.IList GetAddedFragments (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/FragmentManagerAccessor", DoNotGenerateAcw=true)]
	internal class IFragmentManagerAccessorInvoker : global::Java.Lang.Object, IFragmentManagerAccessor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/android/FragmentManagerAccessor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFragmentManagerAccessorInvoker); }
		}

		IntPtr class_ref;

		public static IFragmentManagerAccessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFragmentManagerAccessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.android.FragmentManagerAccessor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFragmentManagerAccessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAddedFragments_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetAddedFragments_Ljava_lang_Object_Handler ()
		{
			if (cb_getAddedFragments_Ljava_lang_Object_ == null)
				cb_getAddedFragments_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAddedFragments_Ljava_lang_Object_);
			return cb_getAddedFragments_Ljava_lang_Object_;
		}

		static IntPtr n_GetAddedFragments_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IFragmentManagerAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentManagerAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetAddedFragments (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAddedFragments_Ljava_lang_Object_;
		public unsafe global::System.Collections.IList GetAddedFragments (global::Java.Lang.Object p0)
		{
			if (id_getAddedFragments_Ljava_lang_Object_ == IntPtr.Zero)
				id_getAddedFragments_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getAddedFragments", "(Ljava/lang/Object;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddedFragments_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
