using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='AddressNameHelper']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/AddressNameHelper", DoNotGenerateAcw=true)]
	public partial class AddressNameHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/AddressNameHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddressNameHelper); }
		}

		protected AddressNameHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='AddressNameHelper']/constructor[@name='AddressNameHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AddressNameHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AddressNameHelper)) {
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

		static IntPtr id_createCustomAddress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='AddressNameHelper']/method[@name='createCustomAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createCustomAddress", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CreateCustomAddress (string p0)
		{
			if (id_createCustomAddress_Ljava_lang_String_ == IntPtr.Zero)
				id_createCustomAddress_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createCustomAddress", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCustomAddress_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
