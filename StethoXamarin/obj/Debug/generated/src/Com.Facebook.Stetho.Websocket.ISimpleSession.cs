using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Websocket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleSession']"
	[Register ("com/facebook/stetho/websocket/SimpleSession", "", "Com.Facebook.Stetho.Websocket.ISimpleSessionInvoker")]
	public partial interface ISimpleSession : IJavaObject {

		bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleSession']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler:Com.Facebook.Stetho.Websocket.ISimpleSessionInvoker, StethoXamarin")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleSession']/method[@name='close' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("close", "(ILjava/lang/String;)V", "GetClose_ILjava_lang_String_Handler:Com.Facebook.Stetho.Websocket.ISimpleSessionInvoker, StethoXamarin")]
		void Close (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleSession']/method[@name='sendBinary' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sendBinary", "([B)V", "GetSendBinary_arrayBHandler:Com.Facebook.Stetho.Websocket.ISimpleSessionInvoker, StethoXamarin")]
		void SendBinary (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='SimpleSession']/method[@name='sendText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendText", "(Ljava/lang/String;)V", "GetSendText_Ljava_lang_String_Handler:Com.Facebook.Stetho.Websocket.ISimpleSessionInvoker, StethoXamarin")]
		void SendText (string p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/websocket/SimpleSession", DoNotGenerateAcw=true)]
	internal class ISimpleSessionInvoker : global::Java.Lang.Object, ISimpleSession {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/websocket/SimpleSession");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISimpleSessionInvoker); }
		}

		IntPtr class_ref;

		public static ISimpleSession GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISimpleSession> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.websocket.SimpleSession"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISimpleSessionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Websocket.ISimpleSession __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		IntPtr id_isOpen;
		public unsafe bool IsOpen {
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
			}
		}

		static Delegate cb_close_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClose_ILjava_lang_String_Handler ()
		{
			if (cb_close_ILjava_lang_String_ == null)
				cb_close_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Close_ILjava_lang_String_);
			return cb_close_ILjava_lang_String_;
		}

		static void n_Close_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Websocket.ISimpleSession __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_close_ILjava_lang_String_;
		public unsafe void Close (int p0, string p1)
		{
			if (id_close_ILjava_lang_String_ == IntPtr.Zero)
				id_close_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "close", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_sendBinary_arrayB;
#pragma warning disable 0169
		static Delegate GetSendBinary_arrayBHandler ()
		{
			if (cb_sendBinary_arrayB == null)
				cb_sendBinary_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendBinary_arrayB);
			return cb_sendBinary_arrayB;
		}

		static void n_SendBinary_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Websocket.ISimpleSession __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SendBinary (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_sendBinary_arrayB;
		public unsafe void SendBinary (byte[] p0)
		{
			if (id_sendBinary_arrayB == IntPtr.Zero)
				id_sendBinary_arrayB = JNIEnv.GetMethodID (class_ref, "sendBinary", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBinary_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendText_Ljava_lang_String_Handler ()
		{
			if (cb_sendText_Ljava_lang_String_ == null)
				cb_sendText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendText_Ljava_lang_String_);
			return cb_sendText_Ljava_lang_String_;
		}

		static void n_SendText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Websocket.ISimpleSession __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Websocket.ISimpleSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendText (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendText_Ljava_lang_String_;
		public unsafe void SendText (string p0)
		{
			if (id_sendText_Ljava_lang_String_ == IntPtr.Zero)
				id_sendText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendText", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendText_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
