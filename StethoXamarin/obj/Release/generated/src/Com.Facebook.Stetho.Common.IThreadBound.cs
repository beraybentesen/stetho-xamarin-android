using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='ThreadBound']"
	[Register ("com/facebook/stetho/common/ThreadBound", "", "Com.Facebook.Stetho.Common.IThreadBoundInvoker")]
	public partial interface IThreadBound : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='ThreadBound']/method[@name='checkThreadAccess' and count(parameter)=0]"
		[Register ("checkThreadAccess", "()Z", "GetCheckThreadAccessHandler:Com.Facebook.Stetho.Common.IThreadBoundInvoker, StethoXamarin")]
		bool CheckThreadAccess ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='ThreadBound']/method[@name='postAndWait' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.common.UncheckedCallable&lt;V&gt;']]"
		[Register ("postAndWait", "(Lcom/facebook/stetho/common/UncheckedCallable;)Ljava/lang/Object;", "GetPostAndWait_Lcom_facebook_stetho_common_UncheckedCallable_Handler:Com.Facebook.Stetho.Common.IThreadBoundInvoker, StethoXamarin")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		global::Java.Lang.Object PostAndWait (global::Com.Facebook.Stetho.Common.IUncheckedCallable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='ThreadBound']/method[@name='postAndWait' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("postAndWait", "(Ljava/lang/Runnable;)V", "GetPostAndWait_Ljava_lang_Runnable_Handler:Com.Facebook.Stetho.Common.IThreadBoundInvoker, StethoXamarin")]
		void PostAndWait (global::Java.Lang.IRunnable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='ThreadBound']/method[@name='postDelayed' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("postDelayed", "(Ljava/lang/Runnable;J)V", "GetPostDelayed_Ljava_lang_Runnable_JHandler:Com.Facebook.Stetho.Common.IThreadBoundInvoker, StethoXamarin")]
		void PostDelayed (global::Java.Lang.IRunnable p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='ThreadBound']/method[@name='removeCallbacks' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("removeCallbacks", "(Ljava/lang/Runnable;)V", "GetRemoveCallbacks_Ljava_lang_Runnable_Handler:Com.Facebook.Stetho.Common.IThreadBoundInvoker, StethoXamarin")]
		void RemoveCallbacks (global::Java.Lang.IRunnable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='ThreadBound']/method[@name='verifyThreadAccess' and count(parameter)=0]"
		[Register ("verifyThreadAccess", "()V", "GetVerifyThreadAccessHandler:Com.Facebook.Stetho.Common.IThreadBoundInvoker, StethoXamarin")]
		void VerifyThreadAccess ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/ThreadBound", DoNotGenerateAcw=true)]
	internal class IThreadBoundInvoker : global::Java.Lang.Object, IThreadBound {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/ThreadBound");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IThreadBoundInvoker); }
		}

		IntPtr class_ref;

		public static IThreadBound GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThreadBound> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.ThreadBound"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThreadBoundInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_checkThreadAccess;
#pragma warning disable 0169
		static Delegate GetCheckThreadAccessHandler ()
		{
			if (cb_checkThreadAccess == null)
				cb_checkThreadAccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckThreadAccess);
			return cb_checkThreadAccess;
		}

		static bool n_CheckThreadAccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.IThreadBound __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IThreadBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckThreadAccess ();
		}
#pragma warning restore 0169

		IntPtr id_checkThreadAccess;
		public unsafe bool CheckThreadAccess ()
		{
			if (id_checkThreadAccess == IntPtr.Zero)
				id_checkThreadAccess = JNIEnv.GetMethodID (class_ref, "checkThreadAccess", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkThreadAccess);
		}

		static Delegate cb_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_;
#pragma warning disable 0169
		static Delegate GetPostAndWait_Lcom_facebook_stetho_common_UncheckedCallable_Handler ()
		{
			if (cb_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ == null)
				cb_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostAndWait_Lcom_facebook_stetho_common_UncheckedCallable_);
			return cb_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_;
		}

		static IntPtr n_PostAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.IThreadBound __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IThreadBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Common.IUncheckedCallable p0 = (global::Com.Facebook.Stetho.Common.IUncheckedCallable)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IUncheckedCallable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostAndWait (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_;
		public unsafe global::Java.Lang.Object PostAndWait (global::Com.Facebook.Stetho.Common.IUncheckedCallable p0)
		{
			if (id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ == IntPtr.Zero)
				id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ = JNIEnv.GetMethodID (class_ref, "postAndWait", "(Lcom/facebook/stetho/common/UncheckedCallable;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_postAndWait_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetPostAndWait_Ljava_lang_Runnable_Handler ()
		{
			if (cb_postAndWait_Ljava_lang_Runnable_ == null)
				cb_postAndWait_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostAndWait_Ljava_lang_Runnable_);
			return cb_postAndWait_Ljava_lang_Runnable_;
		}

		static void n_PostAndWait_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.IThreadBound __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IThreadBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostAndWait (p0);
		}
#pragma warning restore 0169

		IntPtr id_postAndWait_Ljava_lang_Runnable_;
		public unsafe void PostAndWait (global::Java.Lang.IRunnable p0)
		{
			if (id_postAndWait_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postAndWait_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "postAndWait", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postAndWait_Ljava_lang_Runnable_, __args);
		}

		static Delegate cb_postDelayed_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetPostDelayed_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_postDelayed_Ljava_lang_Runnable_J == null)
				cb_postDelayed_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_PostDelayed_Ljava_lang_Runnable_J);
			return cb_postDelayed_Ljava_lang_Runnable_J;
		}

		static void n_PostDelayed_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Facebook.Stetho.Common.IThreadBound __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IThreadBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostDelayed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_postDelayed_Ljava_lang_Runnable_J;
		public unsafe void PostDelayed (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_postDelayed_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_postDelayed_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "postDelayed", "(Ljava/lang/Runnable;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postDelayed_Ljava_lang_Runnable_J, __args);
		}

		static Delegate cb_removeCallbacks_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRemoveCallbacks_Ljava_lang_Runnable_Handler ()
		{
			if (cb_removeCallbacks_Ljava_lang_Runnable_ == null)
				cb_removeCallbacks_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCallbacks_Ljava_lang_Runnable_);
			return cb_removeCallbacks_Ljava_lang_Runnable_;
		}

		static void n_RemoveCallbacks_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.IThreadBound __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IThreadBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallbacks (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeCallbacks_Ljava_lang_Runnable_;
		public unsafe void RemoveCallbacks (global::Java.Lang.IRunnable p0)
		{
			if (id_removeCallbacks_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_removeCallbacks_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "removeCallbacks", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallbacks_Ljava_lang_Runnable_, __args);
		}

		static Delegate cb_verifyThreadAccess;
#pragma warning disable 0169
		static Delegate GetVerifyThreadAccessHandler ()
		{
			if (cb_verifyThreadAccess == null)
				cb_verifyThreadAccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VerifyThreadAccess);
			return cb_verifyThreadAccess;
		}

		static void n_VerifyThreadAccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.IThreadBound __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IThreadBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VerifyThreadAccess ();
		}
#pragma warning restore 0169

		IntPtr id_verifyThreadAccess;
		public unsafe void VerifyThreadAccess ()
		{
			if (id_verifyThreadAccess == IntPtr.Zero)
				id_verifyThreadAccess = JNIEnv.GetMethodID (class_ref, "verifyThreadAccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verifyThreadAccess);
		}

	}

}
