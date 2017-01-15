using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpServer", DoNotGenerateAcw=true)]
	public partial class LightHttpServer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageReader']"
		[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpServer$HttpMessageReader", DoNotGenerateAcw=true)]
		public partial class HttpMessageReader : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageReader.NewLineDetector']"
			[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpServer$HttpMessageReader$NewLineDetector", DoNotGenerateAcw=true)]
			public partial class NewLineDetector : global::Java.Lang.Object {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/facebook/stetho/server/http/LightHttpServer$HttpMessageReader$NewLineDetector", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (NewLineDetector); }
				}

				protected NewLineDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_accept_C;
#pragma warning disable 0169
				static Delegate GetAccept_CHandler ()
				{
					if (cb_accept_C == null)
						cb_accept_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_Accept_C);
					return cb_accept_C;
				}

				static void n_Accept_C (IntPtr jnienv, IntPtr native__this, char p0)
				{
					global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageReader.NewLineDetector __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageReader.NewLineDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.Accept (p0);
				}
#pragma warning restore 0169

				static IntPtr id_accept_C;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageReader.NewLineDetector']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='char']]"
				[Register ("accept", "(C)V", "GetAccept_CHandler")]
				public virtual unsafe void Accept (char p0)
				{
					if (id_accept_C == IntPtr.Zero)
						id_accept_C = JNIEnv.GetMethodID (class_ref, "accept", "(C)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (p0);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_C, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(C)V"), __args);
					} finally {
					}
				}

				static Delegate cb_state;
#pragma warning disable 0169
				static Delegate GetStateHandler ()
				{
					if (cb_state == null)
						cb_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_State);
					return cb_state;
				}

				static int n_State (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageReader.NewLineDetector __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageReader.NewLineDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.State ();
				}
#pragma warning restore 0169

				static IntPtr id_state;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageReader.NewLineDetector']/method[@name='state' and count(parameter)=0]"
				[Register ("state", "()I", "GetStateHandler")]
				public virtual unsafe int State ()
				{
					if (id_state == IntPtr.Zero)
						id_state = JNIEnv.GetMethodID (class_ref, "state", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_state);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "state", "()I"));
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/server/http/LightHttpServer$HttpMessageReader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpMessageReader); }
			}

			protected HttpMessageReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_BufferedInputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageReader']/constructor[@name='LightHttpServer.HttpMessageReader' and count(parameter)=1 and parameter[1][@type='java.io.BufferedInputStream']]"
			[Register (".ctor", "(Ljava/io/BufferedInputStream;)V", "")]
			public unsafe HttpMessageReader (global::Java.IO.BufferedInputStream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (HttpMessageReader)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/BufferedInputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/BufferedInputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_BufferedInputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_BufferedInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/BufferedInputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_BufferedInputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_BufferedInputStream_, __args);
				} finally {
				}
			}

			static Delegate cb_readLine;
#pragma warning disable 0169
			static Delegate GetReadLineHandler ()
			{
				if (cb_readLine == null)
					cb_readLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadLine);
				return cb_readLine;
			}

			static IntPtr n_ReadLine (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageReader __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ReadLine ());
			}
#pragma warning restore 0169

			static IntPtr id_readLine;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageReader']/method[@name='readLine' and count(parameter)=0]"
			[Register ("readLine", "()Ljava/lang/String;", "GetReadLineHandler")]
			public virtual unsafe string ReadLine ()
			{
				if (id_readLine == IntPtr.Zero)
					id_readLine = JNIEnv.GetMethodID (class_ref, "readLine", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readLine), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLine", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageWriter']"
		[global::Android.Runtime.Register ("com/facebook/stetho/server/http/LightHttpServer$HttpMessageWriter", DoNotGenerateAcw=true)]
		public partial class HttpMessageWriter : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/server/http/LightHttpServer$HttpMessageWriter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpMessageWriter); }
			}

			protected HttpMessageWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_BufferedOutputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageWriter']/constructor[@name='LightHttpServer.HttpMessageWriter' and count(parameter)=1 and parameter[1][@type='java.io.BufferedOutputStream']]"
			[Register (".ctor", "(Ljava/io/BufferedOutputStream;)V", "")]
			public unsafe HttpMessageWriter (global::Java.IO.BufferedOutputStream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (HttpMessageWriter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/BufferedOutputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/BufferedOutputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_BufferedOutputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_BufferedOutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/BufferedOutputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_BufferedOutputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_BufferedOutputStream_, __args);
				} finally {
				}
			}

			static Delegate cb_flush;
#pragma warning disable 0169
			static Delegate GetFlushHandler ()
			{
				if (cb_flush == null)
					cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
				return cb_flush;
			}

			static void n_Flush (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageWriter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Flush ();
			}
#pragma warning restore 0169

			static IntPtr id_flush;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageWriter']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "GetFlushHandler")]
			public virtual unsafe void Flush ()
			{
				if (id_flush == IntPtr.Zero)
					id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flush", "()V"));
				} finally {
				}
			}

			static Delegate cb_writeLine;
#pragma warning disable 0169
			static Delegate GetWriteLineHandler ()
			{
				if (cb_writeLine == null)
					cb_writeLine = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteLine);
				return cb_writeLine;
			}

			static void n_WriteLine (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageWriter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WriteLine ();
			}
#pragma warning restore 0169

			static IntPtr id_writeLine;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageWriter']/method[@name='writeLine' and count(parameter)=0]"
			[Register ("writeLine", "()V", "GetWriteLineHandler")]
			public virtual unsafe void WriteLine ()
			{
				if (id_writeLine == IntPtr.Zero)
					id_writeLine = JNIEnv.GetMethodID (class_ref, "writeLine", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeLine);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLine", "()V"));
				} finally {
				}
			}

			static Delegate cb_writeLine_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWriteLine_Ljava_lang_String_Handler ()
			{
				if (cb_writeLine_Ljava_lang_String_ == null)
					cb_writeLine_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteLine_Ljava_lang_String_);
				return cb_writeLine_Ljava_lang_String_;
			}

			static void n_WriteLine_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageWriter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WriteLine (p0);
			}
#pragma warning restore 0169

			static IntPtr id_writeLine_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer.HttpMessageWriter']/method[@name='writeLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("writeLine", "(Ljava/lang/String;)V", "GetWriteLine_Ljava_lang_String_Handler")]
			public virtual unsafe void WriteLine (string p0)
			{
				if (id_writeLine_Ljava_lang_String_ == IntPtr.Zero)
					id_writeLine_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeLine", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeLine_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLine", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/http/LightHttpServer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LightHttpServer); }
		}

		protected LightHttpServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_server_http_HandlerRegistry_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer']/constructor[@name='LightHttpServer' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.server.http.HandlerRegistry']]"
		[Register (".ctor", "(Lcom/facebook/stetho/server/http/HandlerRegistry;)V", "")]
		public unsafe LightHttpServer (global::Com.Facebook.Stetho.Server.Http.HandlerRegistry p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LightHttpServer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/server/http/HandlerRegistry;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/server/http/HandlerRegistry;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_server_http_HandlerRegistry_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_server_http_HandlerRegistry_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/server/http/HandlerRegistry;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_server_http_HandlerRegistry_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_server_http_HandlerRegistry_, __args);
			} finally {
			}
		}

		static Delegate cb_serve_Lcom_facebook_stetho_server_SocketLike_;
#pragma warning disable 0169
		static Delegate GetServe_Lcom_facebook_stetho_server_SocketLike_Handler ()
		{
			if (cb_serve_Lcom_facebook_stetho_server_SocketLike_ == null)
				cb_serve_Lcom_facebook_stetho_server_SocketLike_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Serve_Lcom_facebook_stetho_server_SocketLike_);
			return cb_serve_Lcom_facebook_stetho_server_SocketLike_;
		}

		static void n_Serve_Lcom_facebook_stetho_server_SocketLike_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Server.Http.LightHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.LightHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.SocketLike p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.SocketLike> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Serve (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serve_Lcom_facebook_stetho_server_SocketLike_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer']/method[@name='serve' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.server.SocketLike']]"
		[Register ("serve", "(Lcom/facebook/stetho/server/SocketLike;)V", "GetServe_Lcom_facebook_stetho_server_SocketLike_Handler")]
		public virtual unsafe void Serve (global::Com.Facebook.Stetho.Server.SocketLike p0)
		{
			if (id_serve_Lcom_facebook_stetho_server_SocketLike_ == IntPtr.Zero)
				id_serve_Lcom_facebook_stetho_server_SocketLike_ = JNIEnv.GetMethodID (class_ref, "serve", "(Lcom/facebook/stetho/server/SocketLike;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serve_Lcom_facebook_stetho_server_SocketLike_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serve", "(Lcom/facebook/stetho/server/SocketLike;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_writeResponseMessage_Lcom_facebook_stetho_server_http_LightHttpResponse_Lcom_facebook_stetho_server_http_LightHttpServer_HttpMessageWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='LightHttpServer']/method[@name='writeResponseMessage' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.server.http.LightHttpResponse'] and parameter[2][@type='com.facebook.stetho.server.http.LightHttpServer.HttpMessageWriter']]"
		[Register ("writeResponseMessage", "(Lcom/facebook/stetho/server/http/LightHttpResponse;Lcom/facebook/stetho/server/http/LightHttpServer$HttpMessageWriter;)V", "")]
		public static unsafe void WriteResponseMessage (global::Com.Facebook.Stetho.Server.Http.LightHttpResponse p0, global::Com.Facebook.Stetho.Server.Http.LightHttpServer.HttpMessageWriter p1)
		{
			if (id_writeResponseMessage_Lcom_facebook_stetho_server_http_LightHttpResponse_Lcom_facebook_stetho_server_http_LightHttpServer_HttpMessageWriter_ == IntPtr.Zero)
				id_writeResponseMessage_Lcom_facebook_stetho_server_http_LightHttpResponse_Lcom_facebook_stetho_server_http_LightHttpServer_HttpMessageWriter_ = JNIEnv.GetStaticMethodID (class_ref, "writeResponseMessage", "(Lcom/facebook/stetho/server/http/LightHttpResponse;Lcom/facebook/stetho/server/http/LightHttpServer$HttpMessageWriter;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeResponseMessage_Lcom_facebook_stetho_server_http_LightHttpResponse_Lcom_facebook_stetho_server_http_LightHttpServer_HttpMessageWriter_, __args);
			} finally {
			}
		}

	}
}
