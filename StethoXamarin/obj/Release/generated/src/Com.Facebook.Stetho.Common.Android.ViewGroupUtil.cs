using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewGroupUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/ViewGroupUtil", DoNotGenerateAcw=true)]
	public sealed partial class ViewGroupUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/android/ViewGroupUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewGroupUtil); }
		}

		internal ViewGroupUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_findChildIndex_Landroid_view_ViewGroup_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewGroupUtil']/method[@name='findChildIndex' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='android.view.View']]"
		[Register ("findChildIndex", "(Landroid/view/ViewGroup;Landroid/view/View;)I", "")]
		public static unsafe int FindChildIndex (global::Android.Views.ViewGroup p0, global::Android.Views.View p1)
		{
			if (id_findChildIndex_Landroid_view_ViewGroup_Landroid_view_View_ == IntPtr.Zero)
				id_findChildIndex_Landroid_view_ViewGroup_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "findChildIndex", "(Landroid/view/ViewGroup;Landroid/view/View;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_findChildIndex_Landroid_view_ViewGroup_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
