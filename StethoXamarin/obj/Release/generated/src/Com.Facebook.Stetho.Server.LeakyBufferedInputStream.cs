using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='LeakyBufferedInputStream']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/LeakyBufferedInputStream", DoNotGenerateAcw=true)]
	public partial class LeakyBufferedInputStream : global::Java.IO.BufferedInputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/LeakyBufferedInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LeakyBufferedInputStream); }
		}

		protected LeakyBufferedInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='LeakyBufferedInputStream']/constructor[@name='LeakyBufferedInputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/InputStream;I)V", "")]
		public unsafe LeakyBufferedInputStream (global::System.IO.Stream p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LeakyBufferedInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_I == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leakBufferAndStream;
#pragma warning disable 0169
		static Delegate GetLeakBufferAndStreamHandler ()
		{
			if (cb_leakBufferAndStream == null)
				cb_leakBufferAndStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LeakBufferAndStream);
			return cb_leakBufferAndStream;
		}

		static IntPtr n_LeakBufferAndStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Server.LeakyBufferedInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.LeakyBufferedInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.LeakBufferAndStream ());
		}
#pragma warning restore 0169

		static IntPtr id_leakBufferAndStream;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='LeakyBufferedInputStream']/method[@name='leakBufferAndStream' and count(parameter)=0]"
		[Register ("leakBufferAndStream", "()Ljava/io/InputStream;", "GetLeakBufferAndStreamHandler")]
		public virtual unsafe global::System.IO.Stream LeakBufferAndStream ()
		{
			if (id_leakBufferAndStream == IntPtr.Zero)
				id_leakBufferAndStream = JNIEnv.GetMethodID (class_ref, "leakBufferAndStream", "()Ljava/io/InputStream;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_leakBufferAndStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leakBufferAndStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
