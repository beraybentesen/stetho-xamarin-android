using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDevtoolsServer']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/ChromeDevtoolsServer", DoNotGenerateAcw=true)]
	public partial class ChromeDevtoolsServer : global::Java.Lang.Object, global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDevtoolsServer']/field[@name='PATH']"
		[Register ("PATH")]
		public const string Path = (string) "/inspector";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/ChromeDevtoolsServer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChromeDevtoolsServer); }
		}

		protected ChromeDevtoolsServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Iterable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDevtoolsServer']/constructor[@name='ChromeDevtoolsServer' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;com.facebook.stetho.inspector.protocol.ChromeDevtoolsDomain&gt;']]"
		[Register (".ctor", "(Ljava/lang/Iterable;)V", "")]
		public unsafe ChromeDevtoolsServer (global::Java.Lang.IIterable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ChromeDevtoolsServer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Iterable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Iterable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Iterable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Iterable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Iterable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Iterable_, __args);
			} finally {
			}
		}

		static Delegate cb_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_Handler ()
		{
			if (cb_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_ == null)
				cb_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_);
			return cb_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_;
		}

		static void n_OnClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnClose (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDevtoolsServer']/method[@name='onClose' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onClose", "(Lcom/facebook/stetho/websocket/SimpleSession;ILjava/lang/String;)V", "GetOnClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_Handler")]
		public virtual unsafe void OnClose (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, int p1, string p2)
		{
			if (id_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_ == IntPtr.Zero)
				id_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onClose", "(Lcom/facebook/stetho/websocket/SimpleSession;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClose", "(Lcom/facebook/stetho/websocket/SimpleSession;ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_ == null)
				cb_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_);
			return cb_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_;
		}

		static void n_OnError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDevtoolsServer']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onError", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/Throwable;)V", "GetOnError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnError (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, global::Java.Lang.Throwable p1)
		{
			if (id_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI;
#pragma warning disable 0169
		static Delegate GetOnMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBIHandler ()
		{
			if (cb_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI == null)
				cb_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI);
			return cb_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI;
		}

		static void n_OnMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnMessage (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDevtoolsServer']/method[@name='onMessage' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;[BI)V", "GetOnMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBIHandler")]
		public virtual unsafe void OnMessage (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, byte[] p1, int p2)
		{
			if (id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI == IntPtr.Zero)
				id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI = JNIEnv.GetMethodID (class_ref, "onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;[BI)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;[BI)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_Handler ()
		{
			if (cb_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_ == null)
				cb_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_);
			return cb_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_;
		}

		static void n_OnMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDevtoolsServer']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession'] and parameter[2][@type='java.lang.String']]"
		[Register ("onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/String;)V", "GetOnMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_Handler")]
		public virtual unsafe void OnMessage (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, string p1)
		{
			if (id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_;
#pragma warning disable 0169
		static Delegate GetOnOpen_Lcom_facebook_stetho_websocket_SimpleSession_Handler ()
		{
			if (cb_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_ == null)
				cb_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOpen_Lcom_facebook_stetho_websocket_SimpleSession_);
			return cb_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_;
		}

		static void n_OnOpen_Lcom_facebook_stetho_websocket_SimpleSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.ChromeDevtoolsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='ChromeDevtoolsServer']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession']]"
		[Register ("onOpen", "(Lcom/facebook/stetho/websocket/SimpleSession;)V", "GetOnOpen_Lcom_facebook_stetho_websocket_SimpleSession_Handler")]
		public virtual unsafe void OnOpen (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0)
		{
			if (id_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_ == IntPtr.Zero)
				id_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Lcom/facebook/stetho/websocket/SimpleSession;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOpen", "(Lcom/facebook/stetho/websocket/SimpleSession;)V"), __args);
			} finally {
			}
		}

	}
}
