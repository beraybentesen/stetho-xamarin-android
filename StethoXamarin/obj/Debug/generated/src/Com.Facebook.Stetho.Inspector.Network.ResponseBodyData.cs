using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyData']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/ResponseBodyData", DoNotGenerateAcw=true)]
	public partial class ResponseBodyData : global::Java.Lang.Object {


		static IntPtr base64Encoded_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyData']/field[@name='base64Encoded']"
		[Register ("base64Encoded")]
		public bool Base64Encoded {
			get {
				if (base64Encoded_jfieldId == IntPtr.Zero)
					base64Encoded_jfieldId = JNIEnv.GetFieldID (class_ref, "base64Encoded", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, base64Encoded_jfieldId);
			}
			set {
				if (base64Encoded_jfieldId == IntPtr.Zero)
					base64Encoded_jfieldId = JNIEnv.GetFieldID (class_ref, "base64Encoded", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, base64Encoded_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyData']/field[@name='data']"
		[Register ("data")]
		public string Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/ResponseBodyData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseBodyData); }
		}

		protected ResponseBodyData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseBodyData']/constructor[@name='ResponseBodyData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseBodyData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ResponseBodyData)) {
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

	}
}
