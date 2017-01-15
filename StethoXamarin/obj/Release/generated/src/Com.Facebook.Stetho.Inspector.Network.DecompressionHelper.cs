using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DecompressionHelper']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/DecompressionHelper", DoNotGenerateAcw=true)]
	public partial class DecompressionHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/DecompressionHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecompressionHelper); }
		}

		protected DecompressionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DecompressionHelper']/constructor[@name='DecompressionHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DecompressionHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DecompressionHelper)) {
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

		static IntPtr id_teeInputWithDecompression_Lcom_facebook_stetho_inspector_network_NetworkPeerManager_Ljava_lang_String_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_ResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DecompressionHelper']/method[@name='teeInputWithDecompression' and count(parameter)=6 and parameter[1][@type='com.facebook.stetho.inspector.network.NetworkPeerManager'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.io.InputStream'] and parameter[4][@type='java.io.OutputStream'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.facebook.stetho.inspector.network.ResponseHandler']]"
		[Register ("teeInputWithDecompression", "(Lcom/facebook/stetho/inspector/network/NetworkPeerManager;Ljava/lang/String;Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/lang/String;Lcom/facebook/stetho/inspector/network/ResponseHandler;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream TeeInputWithDecompression (global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager p0, string p1, global::System.IO.Stream p2, global::System.IO.Stream p3, string p4, global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler p5)
		{
			if (id_teeInputWithDecompression_Lcom_facebook_stetho_inspector_network_NetworkPeerManager_Ljava_lang_String_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_ResponseHandler_ == IntPtr.Zero)
				id_teeInputWithDecompression_Lcom_facebook_stetho_inspector_network_NetworkPeerManager_Ljava_lang_String_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_ResponseHandler_ = JNIEnv.GetStaticMethodID (class_ref, "teeInputWithDecompression", "(Lcom/facebook/stetho/inspector/network/NetworkPeerManager;Ljava/lang/String;Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/lang/String;Lcom/facebook/stetho/inspector/network/ResponseHandler;)Ljava/io/InputStream;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_teeInputWithDecompression_Lcom_facebook_stetho_inspector_network_NetworkPeerManager_Ljava_lang_String_Ljava_io_InputStream_Ljava_io_OutputStream_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_ResponseHandler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
