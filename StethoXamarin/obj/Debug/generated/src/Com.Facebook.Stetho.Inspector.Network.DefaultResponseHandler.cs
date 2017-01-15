using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DefaultResponseHandler']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/DefaultResponseHandler", DoNotGenerateAcw=true)]
	public partial class DefaultResponseHandler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/DefaultResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultResponseHandler); }
		}

		protected DefaultResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DefaultResponseHandler']/constructor[@name='DefaultResponseHandler' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.network.NetworkEventReporter'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter;Ljava/lang/String;)V", "")]
		public unsafe DefaultResponseHandler (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DefaultResponseHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onEOF;
#pragma warning disable 0169
		static Delegate GetOnEOFHandler ()
		{
			if (cb_onEOF == null)
				cb_onEOF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnEOF);
			return cb_onEOF;
		}

		static void n_OnEOF (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.DefaultResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DefaultResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEOF ();
		}
#pragma warning restore 0169

		static IntPtr id_onEOF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DefaultResponseHandler']/method[@name='onEOF' and count(parameter)=0]"
		[Register ("onEOF", "()V", "GetOnEOFHandler")]
		public virtual unsafe void OnEOF ()
		{
			if (id_onEOF == IntPtr.Zero)
				id_onEOF = JNIEnv.GetMethodID (class_ref, "onEOF", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEOF);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onEOF", "()V"));
			} finally {
			}
		}

		static Delegate cb_onError_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_io_IOException_Handler ()
		{
			if (cb_onError_Ljava_io_IOException_ == null)
				cb_onError_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_io_IOException_);
			return cb_onError_Ljava_io_IOException_;
		}

		static void n_OnError_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.DefaultResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DefaultResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException p0 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Ljava_io_IOException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DefaultResponseHandler']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("onError", "(Ljava/io/IOException;)V", "GetOnError_Ljava_io_IOException_Handler")]
		public virtual unsafe void OnError (global::Java.IO.IOException p0)
		{
			if (id_onError_Ljava_io_IOException_ == IntPtr.Zero)
				id_onError_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/io/IOException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_io_IOException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Ljava/io/IOException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRead_I;
#pragma warning disable 0169
		static Delegate GetOnRead_IHandler ()
		{
			if (cb_onRead_I == null)
				cb_onRead_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnRead_I);
			return cb_onRead_I;
		}

		static void n_OnRead_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.DefaultResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DefaultResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRead_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DefaultResponseHandler']/method[@name='onRead' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onRead", "(I)V", "GetOnRead_IHandler")]
		public virtual unsafe void OnRead (int p0)
		{
			if (id_onRead_I == IntPtr.Zero)
				id_onRead_I = JNIEnv.GetMethodID (class_ref, "onRead", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRead", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onReadDecoded_I;
#pragma warning disable 0169
		static Delegate GetOnReadDecoded_IHandler ()
		{
			if (cb_onReadDecoded_I == null)
				cb_onReadDecoded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnReadDecoded_I);
			return cb_onReadDecoded_I;
		}

		static void n_OnReadDecoded_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.DefaultResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DefaultResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReadDecoded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onReadDecoded_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DefaultResponseHandler']/method[@name='onReadDecoded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onReadDecoded", "(I)V", "GetOnReadDecoded_IHandler")]
		public virtual unsafe void OnReadDecoded (int p0)
		{
			if (id_onReadDecoded_I == IntPtr.Zero)
				id_onReadDecoded_I = JNIEnv.GetMethodID (class_ref, "onReadDecoded", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadDecoded_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReadDecoded", "(I)V"), __args);
			} finally {
			}
		}

	}
}
