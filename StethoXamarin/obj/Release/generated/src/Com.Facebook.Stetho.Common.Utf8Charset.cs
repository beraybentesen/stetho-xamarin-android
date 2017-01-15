using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Utf8Charset']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/Utf8Charset", DoNotGenerateAcw=true)]
	public partial class Utf8Charset : global::Java.Lang.Object {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Utf8Charset']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Java.Nio.Charset.Charset Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Utf8Charset']/field[@name='NAME']"
		[Register ("NAME")]
		public const string Name = (string) "UTF-8";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/Utf8Charset", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utf8Charset); }
		}

		protected Utf8Charset (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Utf8Charset']/constructor[@name='Utf8Charset' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utf8Charset ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Utf8Charset)) {
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

		static IntPtr id_decodeUTF8_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Utf8Charset']/method[@name='decodeUTF8' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeUTF8", "([B)Ljava/lang/String;", "")]
		public static unsafe string DecodeUTF8 (byte[] p0)
		{
			if (id_decodeUTF8_arrayB == IntPtr.Zero)
				id_decodeUTF8_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeUTF8", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeUTF8_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeUTF8_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Utf8Charset']/method[@name='encodeUTF8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeUTF8", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] EncodeUTF8 (string p0)
		{
			if (id_encodeUTF8_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeUTF8_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeUTF8", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeUTF8_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
