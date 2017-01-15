using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='DevtoolsSocketHandler']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/DevtoolsSocketHandler", DoNotGenerateAcw=true)]
	public partial class DevtoolsSocketHandler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.ISocketLikeHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/DevtoolsSocketHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DevtoolsSocketHandler); }
		}

		protected DevtoolsSocketHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Iterable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='DevtoolsSocketHandler']/constructor[@name='DevtoolsSocketHandler' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Iterable&lt;com.facebook.stetho.inspector.protocol.ChromeDevtoolsDomain&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Iterable;)V", "")]
		public unsafe DevtoolsSocketHandler (global::Android.Content.Context p0, global::Java.Lang.IIterable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DevtoolsSocketHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/Iterable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/Iterable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_Iterable_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/Iterable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Iterable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Iterable_, __args);
			} finally {
			}
		}

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
			global::Com.Facebook.Stetho.Inspector.DevtoolsSocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.DevtoolsSocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.SocketLike p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccepted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAccepted_Lcom_facebook_stetho_server_SocketLike_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='DevtoolsSocketHandler']/method[@name='onAccepted' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.server.SocketLike']]"
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
