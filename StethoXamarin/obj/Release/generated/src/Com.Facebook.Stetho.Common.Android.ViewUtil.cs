using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/ViewUtil", DoNotGenerateAcw=true)]
	public sealed partial class ViewUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil.ViewCompat']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/android/ViewUtil$ViewCompat", DoNotGenerateAcw=true)]
		public partial class ViewCompat : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil.ViewCompat.ViewCompatHoneycomb']"
			[global::Android.Runtime.Register ("com/facebook/stetho/common/android/ViewUtil$ViewCompat$ViewCompatHoneycomb", DoNotGenerateAcw=true)]
			public partial class ViewCompatHoneycomb : global::Com.Facebook.Stetho.Common.Android.ViewUtil.ViewCompat {

				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/facebook/stetho/common/android/ViewUtil$ViewCompat$ViewCompatHoneycomb", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (ViewCompatHoneycomb); }
				}

				protected ViewCompatHoneycomb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_getAlpha_Landroid_view_View_;
#pragma warning disable 0169
				static Delegate GetGetAlpha_Landroid_view_View_Handler ()
				{
					if (cb_getAlpha_Landroid_view_View_ == null)
						cb_getAlpha_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetAlpha_Landroid_view_View_);
					return cb_getAlpha_Landroid_view_View_;
				}

				static float n_GetAlpha_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					global::Com.Facebook.Stetho.Common.Android.ViewUtil.ViewCompat.ViewCompatHoneycomb __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.ViewUtil.ViewCompat.ViewCompatHoneycomb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
					float __ret = __this.GetAlpha (p0);
					return __ret;
				}
#pragma warning restore 0169

				static IntPtr id_getAlpha_Landroid_view_View_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil.ViewCompat.ViewCompatHoneycomb']/method[@name='getAlpha' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
				[Register ("getAlpha", "(Landroid/view/View;)F", "GetGetAlpha_Landroid_view_View_Handler")]
				public override unsafe float GetAlpha (global::Android.Views.View p0)
				{
					if (id_getAlpha_Landroid_view_View_ == IntPtr.Zero)
						id_getAlpha_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getAlpha", "(Landroid/view/View;)F");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (p0);

						float __ret;
						if (GetType () == ThresholdType)
							__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAlpha_Landroid_view_View_, __args);
						else
							__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlpha", "(Landroid/view/View;)F"), __args);
						return __ret;
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/android/ViewUtil$ViewCompat", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ViewCompat); }
			}

			protected ViewCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil.ViewCompat']/constructor[@name='ViewUtil.ViewCompat' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe ViewCompat ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ViewCompat)) {
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

			static Delegate cb_getAlpha_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetGetAlpha_Landroid_view_View_Handler ()
			{
				if (cb_getAlpha_Landroid_view_View_ == null)
					cb_getAlpha_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetAlpha_Landroid_view_View_);
				return cb_getAlpha_Landroid_view_View_;
			}

			static float n_GetAlpha_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Common.Android.ViewUtil.ViewCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.ViewUtil.ViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				float __ret = __this.GetAlpha (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getAlpha_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil.ViewCompat']/method[@name='getAlpha' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("getAlpha", "(Landroid/view/View;)F", "GetGetAlpha_Landroid_view_View_Handler")]
			public virtual unsafe float GetAlpha (global::Android.Views.View p0)
			{
				if (id_getAlpha_Landroid_view_View_ == IntPtr.Zero)
					id_getAlpha_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getAlpha", "(Landroid/view/View;)F");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					float __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAlpha_Landroid_view_View_, __args);
					else
						__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlpha", "(Landroid/view/View;)F"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/android/ViewUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewUtil); }
		}

		internal ViewUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_hitTest_Landroid_view_View_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil']/method[@name='hitTest' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("hitTest", "(Landroid/view/View;FF)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View HitTest (global::Android.Views.View p0, float p1, float p2)
		{
			if (id_hitTest_Landroid_view_View_FF == IntPtr.Zero)
				id_hitTest_Landroid_view_View_FF = JNIEnv.GetStaticMethodID (class_ref, "hitTest", "(Landroid/view/View;FF)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallStaticObjectMethod  (class_ref, id_hitTest_Landroid_view_View_FF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hitTest_Landroid_view_View_FFLcom_facebook_stetho_common_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil']/method[@name='hitTest' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.facebook.stetho.common.Predicate&lt;android.view.View&gt;']]"
		[Register ("hitTest", "(Landroid/view/View;FFLcom/facebook/stetho/common/Predicate;)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View HitTest (global::Android.Views.View p0, float p1, float p2, global::Com.Facebook.Stetho.Common.IPredicate p3)
		{
			if (id_hitTest_Landroid_view_View_FFLcom_facebook_stetho_common_Predicate_ == IntPtr.Zero)
				id_hitTest_Landroid_view_View_FFLcom_facebook_stetho_common_Predicate_ = JNIEnv.GetStaticMethodID (class_ref, "hitTest", "(Landroid/view/View;FFLcom/facebook/stetho/common/Predicate;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallStaticObjectMethod  (class_ref, id_hitTest_Landroid_view_View_FFLcom_facebook_stetho_common_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isTransformedPointInView_Landroid_view_ViewGroup_Landroid_view_View_FFLandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil']/method[@name='isTransformedPointInView' and count(parameter)=5 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='android.view.View'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.PointF']]"
		[Register ("isTransformedPointInView", "(Landroid/view/ViewGroup;Landroid/view/View;FFLandroid/graphics/PointF;)Z", "")]
		public static unsafe bool IsTransformedPointInView (global::Android.Views.ViewGroup p0, global::Android.Views.View p1, float p2, float p3, global::Android.Graphics.PointF p4)
		{
			if (id_isTransformedPointInView_Landroid_view_ViewGroup_Landroid_view_View_FFLandroid_graphics_PointF_ == IntPtr.Zero)
				id_isTransformedPointInView_Landroid_view_ViewGroup_Landroid_view_View_FFLandroid_graphics_PointF_ = JNIEnv.GetStaticMethodID (class_ref, "isTransformedPointInView", "(Landroid/view/ViewGroup;Landroid/view/View;FFLandroid/graphics/PointF;)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isTransformedPointInView_Landroid_view_ViewGroup_Landroid_view_View_FFLandroid_graphics_PointF_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_pointInView_Landroid_view_View_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil']/method[@name='pointInView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("pointInView", "(Landroid/view/View;FF)Z", "")]
		public static unsafe bool PointInView (global::Android.Views.View p0, float p1, float p2)
		{
			if (id_pointInView_Landroid_view_View_FF == IntPtr.Zero)
				id_pointInView_Landroid_view_View_FF = JNIEnv.GetStaticMethodID (class_ref, "pointInView", "(Landroid/view/View;FF)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_pointInView_Landroid_view_View_FF, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_tryGetActivity_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='ViewUtil']/method[@name='tryGetActivity' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("tryGetActivity", "(Landroid/view/View;)Landroid/app/Activity;", "")]
		public static unsafe global::Android.App.Activity TryGetActivity (global::Android.Views.View p0)
		{
			if (id_tryGetActivity_Landroid_view_View_ == IntPtr.Zero)
				id_tryGetActivity_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "tryGetActivity", "(Landroid/view/View;)Landroid/app/Activity;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.App.Activity __ret = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallStaticObjectMethod  (class_ref, id_tryGetActivity_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
