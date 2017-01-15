using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Dumpapp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='ArgsHelper']"
	[global::Android.Runtime.Register ("com/facebook/stetho/dumpapp/ArgsHelper", DoNotGenerateAcw=true)]
	public partial class ArgsHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/dumpapp/ArgsHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArgsHelper); }
		}

		protected ArgsHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='ArgsHelper']/constructor[@name='ArgsHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArgsHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ArgsHelper)) {
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

		static IntPtr id_drainToArray_Ljava_util_Iterator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='ArgsHelper']/method[@name='drainToArray' and count(parameter)=1 and parameter[1][@type='java.util.Iterator&lt;java.lang.String&gt;']]"
		[Register ("drainToArray", "(Ljava/util/Iterator;)[Ljava/lang/String;", "")]
		public static unsafe string[] DrainToArray (global::Java.Util.IIterator p0)
		{
			if (id_drainToArray_Ljava_util_Iterator_ == IntPtr.Zero)
				id_drainToArray_Ljava_util_Iterator_ = JNIEnv.GetStaticMethodID (class_ref, "drainToArray", "(Ljava/util/Iterator;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_drainToArray_Ljava_util_Iterator_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_nextArg_Ljava_util_Iterator_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='ArgsHelper']/method[@name='nextArg' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("nextArg", "(Ljava/util/Iterator;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string NextArg (global::Java.Util.IIterator p0, string p1)
		{
			if (id_nextArg_Ljava_util_Iterator_Ljava_lang_String_ == IntPtr.Zero)
				id_nextArg_Ljava_util_Iterator_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "nextArg", "(Ljava/util/Iterator;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_nextArg_Ljava_util_Iterator_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_nextOptionalArg_Ljava_util_Iterator_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='ArgsHelper']/method[@name='nextOptionalArg' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("nextOptionalArg", "(Ljava/util/Iterator;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string NextOptionalArg (global::Java.Util.IIterator p0, string p1)
		{
			if (id_nextOptionalArg_Ljava_util_Iterator_Ljava_lang_String_ == IntPtr.Zero)
				id_nextOptionalArg_Ljava_util_Iterator_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "nextOptionalArg", "(Ljava/util/Iterator;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_nextOptionalArg_Ljava_util_Iterator_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
