using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpRequest']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpRequest", DoNotGenerateAcw=true)]
	public partial class LightHttpRequest : global::Com.Facebook.Stetho.Server.Http.LightHttpMessage {


		static IntPtr method_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpRequest']/field[@name='method']"
		[Register ("method")]
		public string Method {
			get {
				if (method_jfieldId == IntPtr.Zero)
					method_jfieldId = JNIEnv.GetFieldID (class_ref, "method", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, method_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (method_jfieldId == IntPtr.Zero)
					method_jfieldId = JNIEnv.GetFieldID (class_ref, "method", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, method_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr protocol_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpRequest']/field[@name='protocol']"
		[Register ("protocol")]
		public string Protocol {
			get {
				if (protocol_jfieldId == IntPtr.Zero)
					protocol_jfieldId = JNIEnv.GetFieldID (class_ref, "protocol", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, protocol_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (protocol_jfieldId == IntPtr.Zero)
					protocol_jfieldId = JNIEnv.GetFieldID (class_ref, "protocol", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, protocol_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr uri_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpRequest']/field[@name='uri']"
		[Register ("uri")]
		public global::Android.Net.Uri Uri {
			get {
				if (uri_jfieldId == IntPtr.Zero)
					uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, uri_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (uri_jfieldId == IntPtr.Zero)
					uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, uri_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/http/LightHttpRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LightHttpRequest); }
		}

		protected LightHttpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpRequest']/constructor[@name='LightHttpRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LightHttpRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LightHttpRequest)) {
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
