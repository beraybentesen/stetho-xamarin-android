using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='Predicate']"
	[Register ("com/facebook/stetho/common/Predicate", "", "Com.Facebook.Stetho.Common.IPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IPredicate : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='Predicate']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("apply", "(Ljava/lang/Object;)Z", "GetApply_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.IPredicateInvoker, StethoXamarin")]
		bool Apply (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/Predicate", DoNotGenerateAcw=true)]
	internal class IPredicateInvoker : global::Java.Lang.Object, IPredicate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/Predicate");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPredicateInvoker); }
		}

		IntPtr class_ref;

		public static IPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.Predicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApply_Ljava_lang_Object_Handler ()
		{
			if (cb_apply_Ljava_lang_Object_ == null)
				cb_apply_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Apply_Ljava_lang_Object_);
			return cb_apply_Ljava_lang_Object_;
		}

		static bool n_Apply_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.IPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Apply (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Ljava_lang_Object_;
		public unsafe bool Apply (global::Java.Lang.Object p0)
		{
			if (id_apply_Ljava_lang_Object_ == IntPtr.Zero)
				id_apply_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "apply", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_apply_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
