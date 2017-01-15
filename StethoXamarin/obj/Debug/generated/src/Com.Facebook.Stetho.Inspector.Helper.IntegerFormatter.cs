using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='IntegerFormatter']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/helper/IntegerFormatter", DoNotGenerateAcw=true)]
	public partial class IntegerFormatter : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='IntegerFormatter.IntegerFormatterWithHex']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/helper/IntegerFormatter$IntegerFormatterWithHex", DoNotGenerateAcw=true)]
		public partial class IntegerFormatterWithHex : global::Com.Facebook.Stetho.Inspector.Helper.IntegerFormatter {

			protected IntegerFormatterWithHex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/helper/IntegerFormatter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntegerFormatter); }
		}

		protected IntegerFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Facebook.Stetho.Inspector.Helper.IntegerFormatter Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='IntegerFormatter']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/facebook/stetho/inspector/helper/IntegerFormatter;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/facebook/stetho/inspector/helper/IntegerFormatter;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.IntegerFormatter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_Handler ()
		{
			if (cb_format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_ == null)
				cb_format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_);
			return cb_format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_;
		}

		static IntPtr n_Format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.IntegerFormatter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.IntegerFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewDebug.ExportedProperty p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewDebug.ExportedProperty> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='IntegerFormatter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='android.view.ViewDebug.ExportedProperty']]"
		[Register ("format", "(Ljava/lang/Integer;Landroid/view/ViewDebug$ExportedProperty;)Ljava/lang/String;", "GetFormat_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_Handler")]
		public virtual unsafe string Format (global::Java.Lang.Integer p0, global::Android.Views.ViewDebug.ExportedProperty p1)
		{
			if (id_format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_ == IntPtr.Zero)
				id_format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/lang/Integer;Landroid/view/ViewDebug$ExportedProperty;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_lang_Integer_Landroid_view_ViewDebug_ExportedProperty_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/lang/Integer;Landroid/view/ViewDebug$ExportedProperty;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
