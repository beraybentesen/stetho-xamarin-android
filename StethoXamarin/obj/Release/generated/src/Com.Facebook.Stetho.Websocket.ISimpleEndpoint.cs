using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Websocket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleEndpoint']"
	[Register ("com/facebook/stetho/websocket/SimpleEndpoint", "", "Com.Facebook.Stetho.Websocket.ISimpleEndpointInvoker")]
	public partial interface ISimpleEndpoint : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleEndpoint']/method[@name='onClose' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onClose", "(Lcom/facebook/stetho/websocket/SimpleSession;ILjava/lang/String;)V", "GetOnClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_Handler:Com.Facebook.Stetho.Websocket.ISimpleEndpointInvoker, StethoXamarin")]
		void OnClose (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, int p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleEndpoint']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onError", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/Throwable;)V", "GetOnError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_Handler:Com.Facebook.Stetho.Websocket.ISimpleEndpointInvoker, StethoXamarin")]
		void OnError (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleEndpoint']/method[@name='onMessage' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;[BI)V", "GetOnMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBIHandler:Com.Facebook.Stetho.Websocket.ISimpleEndpointInvoker, StethoXamarin")]
		void OnMessage (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, byte[] p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleEndpoint']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession'] and parameter[2][@type='java.lang.String']]"
		[Register ("onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/String;)V", "GetOnMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_Handler:Com.Facebook.Stetho.Websocket.ISimpleEndpointInvoker, StethoXamarin")]
		void OnMessage (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleEndpoint']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.websocket.SimpleSession']]"
		[Register ("onOpen", "(Lcom/facebook/stetho/websocket/SimpleSession;)V", "GetOnOpen_Lcom_facebook_stetho_websocket_SimpleSession_Handler:Com.Facebook.Stetho.Websocket.ISimpleEndpointInvoker, StethoXamarin")]
		void OnOpen (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/websocket/SimpleEndpoint", DoNotGenerateAcw=true)]
	internal class ISimpleEndpointInvoker : global::Java.Lang.Object, ISimpleEndpoint {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/websocket/SimpleEndpoint");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISimpleEndpointInvoker); }
		}

		IntPtr class_ref;

		public static ISimpleEndpoint GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISimpleEndpoint> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.websocket.SimpleEndpoint"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISimpleEndpointInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnClose (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_;
		public unsafe void OnClose (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, int p1, string p2)
		{
			if (id_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_ == IntPtr.Zero)
				id_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onClose", "(Lcom/facebook/stetho/websocket/SimpleSession;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClose_Lcom_facebook_stetho_websocket_SimpleSession_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, global::Java.Lang.Throwable p1)
		{
			if (id_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_Throwable_, __args);
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
			global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnMessage (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI;
		public unsafe void OnMessage (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, byte[] p1, int p2)
		{
			if (id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI == IntPtr.Zero)
				id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI = JNIEnv.GetMethodID (class_ref, "onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;[BI)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_arrayBI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_;
		public unsafe void OnMessage (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0, string p1)
		{
			if (id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Lcom/facebook/stetho/websocket/SimpleSession;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Lcom_facebook_stetho_websocket_SimpleSession_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Websocket.ISimpleSession p0 = (global::Com.Facebook.Stetho.Websocket.ISimpleSession)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_;
		public unsafe void OnOpen (global::Com.Facebook.Stetho.Websocket.ISimpleSession p0)
		{
			if (id_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_ == IntPtr.Zero)
				id_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Lcom/facebook/stetho/websocket/SimpleSession;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpen_Lcom_facebook_stetho_websocket_SimpleSession_, __args);
		}

	}

}
