using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SocketLike']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/SocketLike", DoNotGenerateAcw=true)]
	public partial class SocketLike : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/SocketLike", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketLike); }
		}

		protected SocketLike (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_LeakyBufferedInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SocketLike']/constructor[@name='SocketLike' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.server.SocketLike'] and parameter[2][@type='com.facebook.stetho.server.LeakyBufferedInputStream']]"
		[Register (".ctor", "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/LeakyBufferedInputStream;)V", "")]
		public unsafe SocketLike (global::Com.Facebook.Stetho.Server.SocketLike p0, global::Com.Facebook.Stetho.Server.LeakyBufferedInputStream p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SocketLike)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/LeakyBufferedInputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/LeakyBufferedInputStream;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_LeakyBufferedInputStream_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_LeakyBufferedInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/server/SocketLike;Lcom/facebook/stetho/server/LeakyBufferedInputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_LeakyBufferedInputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_server_SocketLike_Lcom_facebook_stetho_server_LeakyBufferedInputStream_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_net_LocalSocket_Lcom_facebook_stetho_server_LeakyBufferedInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SocketLike']/constructor[@name='SocketLike' and count(parameter)=2 and parameter[1][@type='android.net.LocalSocket'] and parameter[2][@type='com.facebook.stetho.server.LeakyBufferedInputStream']]"
		[Register (".ctor", "(Landroid/net/LocalSocket;Lcom/facebook/stetho/server/LeakyBufferedInputStream;)V", "")]
		public unsafe SocketLike (global::Android.Net.LocalSocket p0, global::Com.Facebook.Stetho.Server.LeakyBufferedInputStream p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SocketLike)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/LocalSocket;Lcom/facebook/stetho/server/LeakyBufferedInputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/net/LocalSocket;Lcom/facebook/stetho/server/LeakyBufferedInputStream;)V", __args);
					return;
				}

				if (id_ctor_Landroid_net_LocalSocket_Lcom_facebook_stetho_server_LeakyBufferedInputStream_ == IntPtr.Zero)
					id_ctor_Landroid_net_LocalSocket_Lcom_facebook_stetho_server_LeakyBufferedInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/LocalSocket;Lcom/facebook/stetho/server/LeakyBufferedInputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_LocalSocket_Lcom_facebook_stetho_server_LeakyBufferedInputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_net_LocalSocket_Lcom_facebook_stetho_server_LeakyBufferedInputStream_, __args);
			} finally {
			}
		}

		static Delegate cb_getInput;
#pragma warning disable 0169
		static Delegate GetGetInputHandler ()
		{
			if (cb_getInput == null)
				cb_getInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInput);
			return cb_getInput;
		}

		static IntPtr n_GetInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Server.SocketLike __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Input);
		}
#pragma warning restore 0169

		static IntPtr id_getInput;
		public virtual unsafe global::System.IO.Stream Input {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SocketLike']/method[@name='getInput' and count(parameter)=0]"
			[Register ("getInput", "()Ljava/io/InputStream;", "GetGetInputHandler")]
			get {
				if (id_getInput == IntPtr.Zero)
					id_getInput = JNIEnv.GetMethodID (class_ref, "getInput", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInput), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInput", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOutput;
#pragma warning disable 0169
		static Delegate GetGetOutputHandler ()
		{
			if (cb_getOutput == null)
				cb_getOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutput);
			return cb_getOutput;
		}

		static IntPtr n_GetOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Server.SocketLike __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Output);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput;
		public virtual unsafe global::System.IO.Stream Output {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='SocketLike']/method[@name='getOutput' and count(parameter)=0]"
			[Register ("getOutput", "()Ljava/io/OutputStream;", "GetGetOutputHandler")]
			get {
				if (id_getOutput == IntPtr.Zero)
					id_getOutput = JNIEnv.GetMethodID (class_ref, "getOutput", "()Ljava/io/OutputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutput), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "()Ljava/io/OutputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
