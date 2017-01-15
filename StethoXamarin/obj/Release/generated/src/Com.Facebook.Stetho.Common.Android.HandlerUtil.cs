using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/HandlerUtil", DoNotGenerateAcw=true)]
	public sealed partial class HandlerUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil.WaitableRunnable']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/android/HandlerUtil$WaitableRunnable", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public abstract partial class WaitableRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/android/HandlerUtil$WaitableRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WaitableRunnable); }
			}

			protected WaitableRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil.WaitableRunnable']/constructor[@name='HandlerUtil.WaitableRunnable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe WaitableRunnable ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (WaitableRunnable)) {
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

			static Delegate cb_invoke_Landroid_os_Handler_;
#pragma warning disable 0169
			static Delegate GetInvoke_Landroid_os_Handler_Handler ()
			{
				if (cb_invoke_Landroid_os_Handler_ == null)
					cb_invoke_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Landroid_os_Handler_);
				return cb_invoke_Landroid_os_Handler_;
			}

			static IntPtr n_Invoke_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Common.Android.HandlerUtil.WaitableRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.HandlerUtil.WaitableRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Handler p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_invoke_Landroid_os_Handler_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil.WaitableRunnable']/method[@name='invoke' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
			[Register ("invoke", "(Landroid/os/Handler;)Ljava/lang/Object;", "GetInvoke_Landroid_os_Handler_Handler")]
			public virtual unsafe global::Java.Lang.Object Invoke (global::Android.OS.Handler p0)
			{
				if (id_invoke_Landroid_os_Handler_ == IntPtr.Zero)
					id_invoke_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Landroid/os/Handler;)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Lang.Object __ret;
					if (GetType () == ThresholdType)
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Landroid_os_Handler_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Landroid/os/Handler;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onRun;
#pragma warning disable 0169
			static Delegate GetOnRunHandler ()
			{
				if (cb_onRun == null)
					cb_onRun = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnRun);
				return cb_onRun;
			}

			static IntPtr n_OnRun (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Common.Android.HandlerUtil.WaitableRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.HandlerUtil.WaitableRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OnRun ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil.WaitableRunnable']/method[@name='onRun' and count(parameter)=0]"
			[Register ("onRun", "()Ljava/lang/Object;", "GetOnRunHandler")]
			protected abstract global::Java.Lang.Object OnRun ();

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil.WaitableRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "")]
			public unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/common/android/HandlerUtil$WaitableRunnable", DoNotGenerateAcw=true)]
		internal partial class WaitableRunnableInvoker : WaitableRunnable {

			public WaitableRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (WaitableRunnableInvoker); }
			}

			static IntPtr id_onRun;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil.WaitableRunnable']/method[@name='onRun' and count(parameter)=0]"
			[Register ("onRun", "()Ljava/lang/Object;", "GetOnRunHandler")]
			protected override unsafe global::Java.Lang.Object OnRun ()
			{
				if (id_onRun == IntPtr.Zero)
					id_onRun = JNIEnv.GetMethodID (class_ref, "onRun", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onRun), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/android/HandlerUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandlerUtil); }
		}

		internal HandlerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkThreadAccess_Landroid_os_Handler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil']/method[@name='checkThreadAccess' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("checkThreadAccess", "(Landroid/os/Handler;)Z", "")]
		public static unsafe bool CheckThreadAccess (global::Android.OS.Handler p0)
		{
			if (id_checkThreadAccess_Landroid_os_Handler_ == IntPtr.Zero)
				id_checkThreadAccess_Landroid_os_Handler_ = JNIEnv.GetStaticMethodID (class_ref, "checkThreadAccess", "(Landroid/os/Handler;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkThreadAccess_Landroid_os_Handler_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_postAndWait_Landroid_os_Handler_Lcom_facebook_stetho_common_UncheckedCallable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil']/method[@name='postAndWait' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='com.facebook.stetho.common.UncheckedCallable&lt;V&gt;']]"
		[Register ("postAndWait", "(Landroid/os/Handler;Lcom/facebook/stetho/common/UncheckedCallable;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe global::Java.Lang.Object PostAndWait (global::Android.OS.Handler p0, global::Com.Facebook.Stetho.Common.IUncheckedCallable p1)
		{
			if (id_postAndWait_Landroid_os_Handler_Lcom_facebook_stetho_common_UncheckedCallable_ == IntPtr.Zero)
				id_postAndWait_Landroid_os_Handler_Lcom_facebook_stetho_common_UncheckedCallable_ = JNIEnv.GetStaticMethodID (class_ref, "postAndWait", "(Landroid/os/Handler;Lcom/facebook/stetho/common/UncheckedCallable;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_postAndWait_Landroid_os_Handler_Lcom_facebook_stetho_common_UncheckedCallable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_postAndWait_Landroid_os_Handler_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil']/method[@name='postAndWait' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("postAndWait", "(Landroid/os/Handler;Ljava/lang/Runnable;)V", "")]
		public static unsafe void PostAndWait (global::Android.OS.Handler p0, global::Java.Lang.IRunnable p1)
		{
			if (id_postAndWait_Landroid_os_Handler_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postAndWait_Landroid_os_Handler_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "postAndWait", "(Landroid/os/Handler;Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_postAndWait_Landroid_os_Handler_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_verifyThreadAccess_Landroid_os_Handler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='HandlerUtil']/method[@name='verifyThreadAccess' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("verifyThreadAccess", "(Landroid/os/Handler;)V", "")]
		public static unsafe void VerifyThreadAccess (global::Android.OS.Handler p0)
		{
			if (id_verifyThreadAccess_Landroid_os_Handler_ == IntPtr.Zero)
				id_verifyThreadAccess_Landroid_os_Handler_ = JNIEnv.GetStaticMethodID (class_ref, "verifyThreadAccess", "(Landroid/os/Handler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_verifyThreadAccess_Landroid_os_Handler_, __args);
			} finally {
			}
		}

	}
}
