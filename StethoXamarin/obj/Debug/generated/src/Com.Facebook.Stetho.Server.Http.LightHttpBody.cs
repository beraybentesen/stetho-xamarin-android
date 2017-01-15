using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpBody", DoNotGenerateAcw=true)]
	public abstract partial class LightHttpBody : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/http/LightHttpBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LightHttpBody); }
		}

		protected LightHttpBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/constructor[@name='LightHttpBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LightHttpBody ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LightHttpBody)) {
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

		static Delegate cb_contentLength;
#pragma warning disable 0169
		static Delegate GetContentLengthHandler ()
		{
			if (cb_contentLength == null)
				cb_contentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ContentLength);
			return cb_contentLength;
		}

		static int n_ContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Server.Http.LightHttpBody __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()I", "GetContentLengthHandler")]
		public abstract int ContentLength ();

		static Delegate cb_contentType;
#pragma warning disable 0169
		static Delegate GetContentTypeHandler ()
		{
			if (cb_contentType == null)
				cb_contentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ContentType);
			return cb_contentType;
		}

		static IntPtr n_ContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Server.Http.LightHttpBody __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Ljava/lang/String;", "GetContentTypeHandler")]
		public abstract string ContentType ();

		static IntPtr id_create_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "([BLjava/lang/String;)Lcom/facebook/stetho/server/http/LightHttpBody;", "")]
		public static unsafe global::Com.Facebook.Stetho.Server.Http.LightHttpBody Create (byte[] p0, string p1)
		{
			if (id_create_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_create_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "([BLjava/lang/String;)Lcom/facebook/stetho/server/http/LightHttpBody;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Facebook.Stetho.Server.Http.LightHttpBody __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_create_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/server/http/LightHttpBody;", "")]
		public static unsafe global::Com.Facebook.Stetho.Server.Http.LightHttpBody Create (string p0, string p1)
		{
			if (id_create_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/server/http/LightHttpBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Facebook.Stetho.Server.Http.LightHttpBody __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_writeTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeTo_Ljava_io_OutputStream_ == null)
				cb_writeTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Ljava_io_OutputStream_);
			return cb_writeTo_Ljava_io_OutputStream_;
		}

		static void n_WriteTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Server.Http.LightHttpBody __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public abstract void WriteTo (global::System.IO.Stream p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpBody", DoNotGenerateAcw=true)]
	internal partial class LightHttpBodyInvoker : LightHttpBody {

		public LightHttpBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LightHttpBodyInvoker); }
		}

		static IntPtr id_contentLength;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/method[@name='contentLength' and count(parameter)=0]"
		[Register ("contentLength", "()I", "GetContentLengthHandler")]
		public override unsafe int ContentLength ()
		{
			if (id_contentLength == IntPtr.Zero)
				id_contentLength = JNIEnv.GetMethodID (class_ref, "contentLength", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_contentLength);
			} finally {
			}
		}

		static IntPtr id_contentType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Ljava/lang/String;", "GetContentTypeHandler")]
		public override unsafe string ContentType ()
		{
			if (id_contentType == IntPtr.Zero)
				id_contentType = JNIEnv.GetMethodID (class_ref, "contentType", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contentType), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpBody']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public override unsafe void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeTo_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
