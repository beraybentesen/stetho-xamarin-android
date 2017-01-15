using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompatUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/FragmentCompatUtil", DoNotGenerateAcw=true)]
	public sealed partial class FragmentCompatUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/android/FragmentCompatUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FragmentCompatUtil); }
		}

		internal FragmentCompatUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_findFragmentForView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompatUtil']/method[@name='findFragmentForView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("findFragmentForView", "(Landroid/view/View;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object FindFragmentForView (global::Android.Views.View p0)
		{
			if (id_findFragmentForView_Landroid_view_View_ == IntPtr.Zero)
				id_findFragmentForView_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "findFragmentForView", "(Landroid/view/View;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findFragmentForView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isDialogFragment_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompatUtil']/method[@name='isDialogFragment' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isDialogFragment", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsDialogFragment (global::Java.Lang.Object p0)
		{
			if (id_isDialogFragment_Ljava_lang_Object_ == IntPtr.Zero)
				id_isDialogFragment_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isDialogFragment", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDialogFragment_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
