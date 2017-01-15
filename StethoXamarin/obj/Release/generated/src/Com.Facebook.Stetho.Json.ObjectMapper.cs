using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Json {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.json']/class[@name='ObjectMapper']"
	[global::Android.Runtime.Register ("com/facebook/stetho/json/ObjectMapper", DoNotGenerateAcw=true)]
	public partial class ObjectMapper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/json/ObjectMapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectMapper); }
		}

		protected ObjectMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.json']/class[@name='ObjectMapper']/constructor[@name='ObjectMapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectMapper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ObjectMapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_convertValue_Ljava_lang_Object_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetConvertValue_Ljava_lang_Object_Ljava_lang_Class_Handler ()
		{
			if (cb_convertValue_Ljava_lang_Object_Ljava_lang_Class_ == null)
				cb_convertValue_Ljava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConvertValue_Ljava_lang_Object_Ljava_lang_Class_);
			return cb_convertValue_Ljava_lang_Object_Ljava_lang_Class_;
		}

		static IntPtr n_ConvertValue_Ljava_lang_Object_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Json.ObjectMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Json.ObjectMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convertValue_Ljava_lang_Object_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.json']/class[@name='ObjectMapper']/method[@name='convertValue' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("convertValue", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "GetConvertValue_Ljava_lang_Object_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object ConvertValue (global::Java.Lang.Object p0, global::Java.Lang.Class p1)
		{
			if (id_convertValue_Ljava_lang_Object_Ljava_lang_Class_ == IntPtr.Zero)
				id_convertValue_Ljava_lang_Object_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "convertValue", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertValue_Ljava_lang_Object_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertValue", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
