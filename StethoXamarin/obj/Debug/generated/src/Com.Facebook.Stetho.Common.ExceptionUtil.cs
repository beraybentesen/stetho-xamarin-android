using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ExceptionUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/ExceptionUtil", DoNotGenerateAcw=true)]
	public partial class ExceptionUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/ExceptionUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExceptionUtil); }
		}

		protected ExceptionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ExceptionUtil']/constructor[@name='ExceptionUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ExceptionUtil)) {
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

		static IntPtr id_propagate_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ExceptionUtil']/method[@name='propagate' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("propagate", "(Ljava/lang/Throwable;)Ljava/lang/RuntimeException;", "")]
		public static unsafe global::Java.Lang.RuntimeException Propagate (global::Java.Lang.Throwable p0)
		{
			if (id_propagate_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_propagate_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "propagate", "(Ljava/lang/Throwable;)Ljava/lang/RuntimeException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.RuntimeException __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.RuntimeException> (JNIEnv.CallStaticObjectMethod  (class_ref, id_propagate_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_propagateIfInstanceOf_Ljava_lang_Throwable_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ExceptionUtil']/method[@name='propagateIfInstanceOf' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("propagateIfInstanceOf", "(Ljava/lang/Throwable;Ljava/lang/Class;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Throwable"})]
		public static unsafe void PropagateIfInstanceOf (global::Java.Lang.Throwable p0, global::Java.Lang.Class p1)
		{
			if (id_propagateIfInstanceOf_Ljava_lang_Throwable_Ljava_lang_Class_ == IntPtr.Zero)
				id_propagateIfInstanceOf_Ljava_lang_Throwable_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "propagateIfInstanceOf", "(Ljava/lang/Throwable;Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_propagateIfInstanceOf_Ljava_lang_Throwable_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_sneakyThrow_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ExceptionUtil']/method[@name='sneakyThrow' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("sneakyThrow", "(Ljava/lang/Throwable;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Throwable"})]
		public static unsafe void SneakyThrow (global::Java.Lang.Throwable p0)
		{
			if (id_sneakyThrow_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_sneakyThrow_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "sneakyThrow", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sneakyThrow_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

	}
}
