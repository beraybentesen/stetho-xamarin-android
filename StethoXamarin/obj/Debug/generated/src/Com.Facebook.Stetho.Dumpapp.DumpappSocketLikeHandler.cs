using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Dumpapp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='DumpappSocketLikeHandler']"
	[global::Android.Runtime.Register ("com/facebook/stetho/dumpapp/DumpappSocketLikeHandler", DoNotGenerateAcw=true)]
	public partial class DumpappSocketLikeHandler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.ISocketLikeHandler {


		static IntPtr PROTOCOL_MAGIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='DumpappSocketLikeHandler']/field[@name='PROTOCOL_MAGIC']"
		[Register ("PROTOCOL_MAGIC")]
		public static IList<byte> ProtocolMagic {
			get {
				if (PROTOCOL_MAGIC_jfieldId == IntPtr.Zero)
					PROTOCOL_MAGIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_MAGIC", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_MAGIC_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='DumpappSocketLikeHandler']/field[@name='PROTOCOL_VERSION']"
		[Register ("PROTOCOL_VERSION")]
		public const int ProtocolVersion = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/dumpapp/DumpappSocketLikeHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DumpappSocketLikeHandler); }
		}

		protected DumpappSocketLikeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
#pragma warning disable 0169
		static Delegate GetOnAccepted_Lcom_facebook_stetho_server_SocketLike_Handler ()
		{
			if (cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_ == null)
				cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAccepted_Lcom_facebook_stetho_server_SocketLike_);
			return cb_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
		}

		static void n_OnAccepted_Lcom_facebook_stetho_server_SocketLike_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Dumpapp.DumpappSocketLikeHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.DumpappSocketLikeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.SocketLike p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccepted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.dumpapp']/class[@name='DumpappSocketLikeHandler']/method[@name='onAccepted' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.server.SocketLike']]"
		[Register ("onAccepted", "(Lcom/facebook/stetho/server/SocketLike;)V", "GetOnAccepted_Lcom_facebook_stetho_server_SocketLike_Handler")]
		public virtual unsafe void OnAccepted (global::Com.Facebook.Stetho.Server.SocketLike p0)
		{
			if (id_onAccepted_Lcom_facebook_stetho_server_SocketLike_ == IntPtr.Zero)
				id_onAccepted_Lcom_facebook_stetho_server_SocketLike_ = JNIEnv.GetMethodID (class_ref, "onAccepted", "(Lcom/facebook/stetho/server/SocketLike;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccepted_Lcom_facebook_stetho_server_SocketLike_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccepted", "(Lcom/facebook/stetho/server/SocketLike;)V"), __args);
			} finally {
			}
		}

	}
}
