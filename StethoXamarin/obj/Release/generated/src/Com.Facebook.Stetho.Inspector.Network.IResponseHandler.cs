using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='ResponseHandler']"
	[Register ("com/facebook/stetho/inspector/network/ResponseHandler", "", "Com.Facebook.Stetho.Inspector.Network.IResponseHandlerInvoker")]
	public partial interface IResponseHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='ResponseHandler']/method[@name='onEOF' and count(parameter)=0]"
		[Register ("onEOF", "()V", "GetOnEOFHandler:Com.Facebook.Stetho.Inspector.Network.IResponseHandlerInvoker, StethoXamarin")]
		void OnEOF ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='ResponseHandler']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("onError", "(Ljava/io/IOException;)V", "GetOnError_Ljava_io_IOException_Handler:Com.Facebook.Stetho.Inspector.Network.IResponseHandlerInvoker, StethoXamarin")]
		void OnError (global::Java.IO.IOException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='ResponseHandler']/method[@name='onRead' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onRead", "(I)V", "GetOnRead_IHandler:Com.Facebook.Stetho.Inspector.Network.IResponseHandlerInvoker, StethoXamarin")]
		void OnRead (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='ResponseHandler']/method[@name='onReadDecoded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onReadDecoded", "(I)V", "GetOnReadDecoded_IHandler:Com.Facebook.Stetho.Inspector.Network.IResponseHandlerInvoker, StethoXamarin")]
		void OnReadDecoded (int p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/ResponseHandler", DoNotGenerateAcw=true)]
	internal class IResponseHandlerInvoker : global::Java.Lang.Object, IResponseHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/network/ResponseHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResponseHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IResponseHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponseHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.network.ResponseHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEOF ();
		}
#pragma warning restore 0169

		IntPtr id_onEOF;
		public unsafe void OnEOF ()
		{
			if (id_onEOF == IntPtr.Zero)
				id_onEOF = JNIEnv.GetMethodID (class_ref, "onEOF", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEOF);
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
			global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException p0 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_io_IOException_;
		public unsafe void OnError (global::Java.IO.IOException p0)
		{
			if (id_onError_Ljava_io_IOException_ == IntPtr.Zero)
				id_onError_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/io/IOException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_io_IOException_, __args);
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
			global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRead_I;
		public unsafe void OnRead (int p0)
		{
			if (id_onRead_I == IntPtr.Zero)
				id_onRead_I = JNIEnv.GetMethodID (class_ref, "onRead", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_I, __args);
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
			global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReadDecoded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReadDecoded_I;
		public unsafe void OnReadDecoded (int p0)
		{
			if (id_onReadDecoded_I == IntPtr.Zero)
				id_onReadDecoded_I = JNIEnv.GetMethodID (class_ref, "onReadDecoded", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadDecoded_I, __args);
		}

	}

}
