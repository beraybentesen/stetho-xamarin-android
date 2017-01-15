using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Util ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Util)) {
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

		static IntPtr id_awaitUninterruptibly_Ljava_util_concurrent_CountDownLatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='awaitUninterruptibly' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.CountDownLatch']]"
		[Register ("awaitUninterruptibly", "(Ljava/util/concurrent/CountDownLatch;)V", "")]
		public static unsafe void AwaitUninterruptibly (global::Java.Util.Concurrent.CountDownLatch p0)
		{
			if (id_awaitUninterruptibly_Ljava_util_concurrent_CountDownLatch_ == IntPtr.Zero)
				id_awaitUninterruptibly_Ljava_util_concurrent_CountDownLatch_ = JNIEnv.GetStaticMethodID (class_ref, "awaitUninterruptibly", "(Ljava/util/concurrent/CountDownLatch;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_awaitUninterruptibly_Ljava_util_concurrent_CountDownLatch_, __args);
			} finally {
			}
		}

		static IntPtr id_close_Ljava_io_Closeable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='close' and count(parameter)=2 and parameter[1][@type='java.io.Closeable'] and parameter[2][@type='boolean']]"
		[Register ("close", "(Ljava/io/Closeable;Z)V", "")]
		public static unsafe void Close (global::Java.IO.ICloseable p0, bool p1)
		{
			if (id_close_Ljava_io_Closeable_Z == IntPtr.Zero)
				id_close_Ljava_io_Closeable_Z = JNIEnv.GetStaticMethodID (class_ref, "close", "(Ljava/io/Closeable;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_close_Ljava_io_Closeable_Z, __args);
			} finally {
			}
		}

		static IntPtr id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='byte[]']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;[B)V", "")]
		public static unsafe void Copy (global::System.IO.Stream p0, global::System.IO.Stream p1, byte[] p2)
		{
			if (id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_arrayB == IntPtr.Zero)
				id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_arrayB = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;[B)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_getUninterruptibly_Ljava_util_concurrent_Future_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='getUninterruptibly' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Future&lt;T&gt;']]"
		[Register ("getUninterruptibly", "(Ljava/util/concurrent/Future;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUninterruptibly (global::Java.Util.Concurrent.IFuture p0)
		{
			if (id_getUninterruptibly_Ljava_util_concurrent_Future_ == IntPtr.Zero)
				id_getUninterruptibly_Ljava_util_concurrent_Future_ = JNIEnv.GetStaticMethodID (class_ref, "getUninterruptibly", "(Ljava/util/concurrent/Future;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUninterruptibly_Ljava_util_concurrent_Future_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUninterruptibly_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='getUninterruptibly' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Future&lt;T&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("getUninterruptibly", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUninterruptibly (global::Java.Util.Concurrent.IFuture p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			if (id_getUninterruptibly_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_getUninterruptibly_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "getUninterruptibly", "(Ljava/util/concurrent/Future;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUninterruptibly_Ljava_util_concurrent_Future_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_joinUninterruptibly_Ljava_lang_Thread_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='joinUninterruptibly' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
		[Register ("joinUninterruptibly", "(Ljava/lang/Thread;)V", "")]
		public static unsafe void JoinUninterruptibly (global::Java.Lang.Thread p0)
		{
			if (id_joinUninterruptibly_Ljava_lang_Thread_ == IntPtr.Zero)
				id_joinUninterruptibly_Ljava_lang_Thread_ = JNIEnv.GetStaticMethodID (class_ref, "joinUninterruptibly", "(Ljava/lang/Thread;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_joinUninterruptibly_Ljava_lang_Thread_, __args);
			} finally {
			}
		}

		static IntPtr id_readAsUTF8_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='readAsUTF8' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readAsUTF8", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string ReadAsUTF8 (global::System.IO.Stream p0)
		{
			if (id_readAsUTF8_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readAsUTF8_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readAsUTF8", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readAsUTF8_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sleepUninterruptibly_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='sleepUninterruptibly' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("sleepUninterruptibly", "(J)V", "")]
		public static unsafe void SleepUninterruptibly (long p0)
		{
			if (id_sleepUninterruptibly_J == IntPtr.Zero)
				id_sleepUninterruptibly_J = JNIEnv.GetStaticMethodID (class_ref, "sleepUninterruptibly", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sleepUninterruptibly_J, __args);
			} finally {
			}
		}

		static IntPtr id_throwIf_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='throwIf' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("throwIf", "(Z)V", "")]
		public static unsafe void ThrowIf (bool p0)
		{
			if (id_throwIf_Z == IntPtr.Zero)
				id_throwIf_Z = JNIEnv.GetStaticMethodID (class_ref, "throwIf", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwIf_Z, __args);
			} finally {
			}
		}

		static IntPtr id_throwIfNot_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='throwIfNot' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("throwIfNot", "(Z)V", "")]
		public static unsafe void ThrowIfNot (bool p0)
		{
			if (id_throwIfNot_Z == IntPtr.Zero)
				id_throwIfNot_Z = JNIEnv.GetStaticMethodID (class_ref, "throwIfNot", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwIfNot_Z, __args);
			} finally {
			}
		}

		static IntPtr id_throwIfNot_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='throwIfNot' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("throwIfNot", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void ThrowIfNot (bool p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_throwIfNot_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_throwIfNot_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "throwIfNot", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwIfNot_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_throwIfNotNull_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='throwIfNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("throwIfNotNull", "(Ljava/lang/Object;)V", "")]
		public static unsafe void ThrowIfNotNull (global::Java.Lang.Object p0)
		{
			if (id_throwIfNotNull_Ljava_lang_Object_ == IntPtr.Zero)
				id_throwIfNotNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "throwIfNotNull", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwIfNotNull_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_throwIfNull_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='throwIfNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("throwIfNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object ThrowIfNull (global::Java.Lang.Object p0)
		{
			if (id_throwIfNull_Ljava_lang_Object_ == IntPtr.Zero)
				id_throwIfNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "throwIfNull", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_throwIfNull_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_throwIfNull_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='throwIfNull' and count(parameter)=2 and parameter[1][@type='T1'] and parameter[2][@type='T2']]"
		[Register ("throwIfNull", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2"})]
		public static unsafe void ThrowIfNull (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_throwIfNull_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_throwIfNull_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "throwIfNull", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwIfNull_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_throwIfNull_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='Util']/method[@name='throwIfNull' and count(parameter)=3 and parameter[1][@type='T1'] and parameter[2][@type='T2'] and parameter[3][@type='T3']]"
		[Register ("throwIfNull", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1", "T2", "T3"})]
		public static unsafe void ThrowIfNull (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_throwIfNull_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_throwIfNull_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "throwIfNull", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwIfNull_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
