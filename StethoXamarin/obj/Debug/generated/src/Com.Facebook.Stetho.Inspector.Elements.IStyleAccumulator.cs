using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='StyleAccumulator']"
	[Register ("com/facebook/stetho/inspector/elements/StyleAccumulator", "", "Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulatorInvoker")]
	public partial interface IStyleAccumulator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='StyleAccumulator']/method[@name='store' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("store", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetStore_Ljava_lang_String_Ljava_lang_String_ZHandler:Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulatorInvoker, StethoXamarin")]
		void Store (string p0, string p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/StyleAccumulator", DoNotGenerateAcw=true)]
	internal class IStyleAccumulatorInvoker : global::Java.Lang.Object, IStyleAccumulator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/StyleAccumulator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStyleAccumulatorInvoker); }
		}

		IntPtr class_ref;

		public static IStyleAccumulator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStyleAccumulator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.elements.StyleAccumulator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStyleAccumulatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_store_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetStore_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_store_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_store_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Store_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_store_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_Store_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Store (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_store_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe void Store (string p0, string p1, bool p2)
		{
			if (id_store_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_store_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "store", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_store_Ljava_lang_String_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
