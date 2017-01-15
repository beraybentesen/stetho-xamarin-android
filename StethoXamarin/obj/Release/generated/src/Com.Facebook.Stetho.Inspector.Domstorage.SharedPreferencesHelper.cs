using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Domstorage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='SharedPreferencesHelper']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/domstorage/SharedPreferencesHelper", DoNotGenerateAcw=true)]
	public partial class SharedPreferencesHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/domstorage/SharedPreferencesHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SharedPreferencesHelper); }
		}

		protected SharedPreferencesHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getSharedPreferenceTags_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='SharedPreferencesHelper']/method[@name='getSharedPreferenceTags' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSharedPreferenceTags", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> GetSharedPreferenceTags (global::Android.Content.Context p0)
		{
			if (id_getSharedPreferenceTags_Landroid_content_Context_ == IntPtr.Zero)
				id_getSharedPreferenceTags_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getSharedPreferenceTags", "(Landroid/content/Context;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSharedPreferenceTags_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_valueFromString_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='SharedPreferencesHelper']/method[@name='valueFromString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("valueFromString", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ValueFromString (string p0, global::Java.Lang.Object p1)
		{
			if (id_valueFromString_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_valueFromString_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "valueFromString", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueFromString_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='SharedPreferencesHelper']/method[@name='valueToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("valueToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ValueToString (global::Java.Lang.Object p0)
		{
			if (id_valueToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_valueToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "valueToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueToString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
