using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='AttributeAccumulator']"
	[Register ("com/facebook/stetho/inspector/elements/AttributeAccumulator", "", "Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulatorInvoker")]
	public partial interface IAttributeAccumulator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='AttributeAccumulator']/method[@name='store' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("store", "(Ljava/lang/String;Ljava/lang/String;)V", "GetStore_Ljava_lang_String_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulatorInvoker, StethoXamarin")]
		void Store (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/AttributeAccumulator", DoNotGenerateAcw=true)]
	internal class IAttributeAccumulatorInvoker : global::Java.Lang.Object, IAttributeAccumulator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/AttributeAccumulator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAttributeAccumulatorInvoker); }
		}

		IntPtr class_ref;

		public static IAttributeAccumulator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAttributeAccumulator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.elements.AttributeAccumulator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAttributeAccumulatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_store_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStore_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_store_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_store_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Store_Ljava_lang_String_Ljava_lang_String_);
			return cb_store_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Store_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulator __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Store (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_store_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Store (string p0, string p1)
		{
			if (id_store_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_store_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "store", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_store_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
