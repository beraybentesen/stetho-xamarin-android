using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ReflectionUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/ReflectionUtil", DoNotGenerateAcw=true)]
	public sealed partial class ReflectionUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/ReflectionUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReflectionUtil); }
		}

		internal ReflectionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFieldValue_Ljava_lang_reflect_Field_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ReflectionUtil']/method[@name='getFieldValue' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getFieldValue", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetFieldValue (global::Java.Lang.Reflect.Field p0, global::Java.Lang.Object p1)
		{
			if (id_getFieldValue_Ljava_lang_reflect_Field_Ljava_lang_Object_ == IntPtr.Zero)
				id_getFieldValue_Ljava_lang_reflect_Field_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "getFieldValue", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFieldValue_Ljava_lang_reflect_Field_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_tryGetClassForName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ReflectionUtil']/method[@name='tryGetClassForName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("tryGetClassForName", "(Ljava/lang/String;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class TryGetClassForName (string p0)
		{
			if (id_tryGetClassForName_Ljava_lang_String_ == IntPtr.Zero)
				id_tryGetClassForName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "tryGetClassForName", "(Ljava/lang/String;)Ljava/lang/Class;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_tryGetClassForName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_tryGetDeclaredField_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ReflectionUtil']/method[@name='tryGetDeclaredField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("tryGetDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field TryGetDeclaredField (global::Java.Lang.Class p0, string p1)
		{
			if (id_tryGetDeclaredField_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_tryGetDeclaredField_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "tryGetDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.Lang.Reflect.Field __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_tryGetDeclaredField_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
