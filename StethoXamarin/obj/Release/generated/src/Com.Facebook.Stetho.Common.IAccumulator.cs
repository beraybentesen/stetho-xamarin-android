using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='Accumulator']"
	[Register ("com/facebook/stetho/common/Accumulator", "", "Com.Facebook.Stetho.Common.IAccumulatorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public partial interface IAccumulator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='Accumulator']/method[@name='store' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("store", "(Ljava/lang/Object;)V", "GetStore_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.IAccumulatorInvoker, StethoXamarin")]
		void Store (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/Accumulator", DoNotGenerateAcw=true)]
	internal class IAccumulatorInvoker : global::Java.Lang.Object, IAccumulator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/Accumulator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAccumulatorInvoker); }
		}

		IntPtr class_ref;

		public static IAccumulator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAccumulator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.Accumulator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAccumulatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_store_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetStore_Ljava_lang_Object_Handler ()
		{
			if (cb_store_Ljava_lang_Object_ == null)
				cb_store_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Store_Ljava_lang_Object_);
			return cb_store_Ljava_lang_Object_;
		}

		static void n_Store_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.IAccumulator __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IAccumulator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Store (p0);
		}
#pragma warning restore 0169

		IntPtr id_store_Ljava_lang_Object_;
		public unsafe void Store (global::Java.Lang.Object p0)
		{
			if (id_store_Ljava_lang_Object_ == IntPtr.Zero)
				id_store_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "store", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_store_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
