using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ResourcesUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/ResourcesUtil", DoNotGenerateAcw=true)]
	public partial class ResourcesUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/android/ResourcesUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourcesUtil); }
		}

		protected ResourcesUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getIdString_Landroid_content_res_Resources_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ResourcesUtil']/method[@name='getIdString' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='int']]"
		[Register ("getIdString", "(Landroid/content/res/Resources;I)Ljava/lang/String;", "")]
		public static unsafe string GetIdString (global::Android.Content.Res.Resources p0, int p1)
		{
			if (id_getIdString_Landroid_content_res_Resources_I == IntPtr.Zero)
				id_getIdString_Landroid_content_res_Resources_I = JNIEnv.GetStaticMethodID (class_ref, "getIdString", "(Landroid/content/res/Resources;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIdString_Landroid_content_res_Resources_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getIdStringQuietly_Ljava_lang_Object_Landroid_content_res_Resources_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ResourcesUtil']/method[@name='getIdStringQuietly' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.content.res.Resources'] and parameter[3][@type='int']]"
		[Register ("getIdStringQuietly", "(Ljava/lang/Object;Landroid/content/res/Resources;I)Ljava/lang/String;", "")]
		public static unsafe string GetIdStringQuietly (global::Java.Lang.Object p0, global::Android.Content.Res.Resources p1, int p2)
		{
			if (id_getIdStringQuietly_Ljava_lang_Object_Landroid_content_res_Resources_I == IntPtr.Zero)
				id_getIdStringQuietly_Ljava_lang_Object_Landroid_content_res_Resources_I = JNIEnv.GetStaticMethodID (class_ref, "getIdStringQuietly", "(Ljava/lang/Object;Landroid/content/res/Resources;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIdStringQuietly_Ljava_lang_Object_Landroid_content_res_Resources_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
