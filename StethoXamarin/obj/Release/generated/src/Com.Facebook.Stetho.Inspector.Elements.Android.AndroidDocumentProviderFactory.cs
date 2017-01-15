using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/AndroidDocumentProviderFactory", DoNotGenerateAcw=true)]
	public sealed partial class AndroidDocumentProviderFactory : global::Java.Lang.Object, global::Com.Facebook.Stetho.Common.IThreadBound, global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/android/AndroidDocumentProviderFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidDocumentProviderFactory); }
		}

		internal AndroidDocumentProviderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Application_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']/constructor[@name='AndroidDocumentProviderFactory' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register (".ctor", "(Landroid/app/Application;)V", "")]
		public unsafe AndroidDocumentProviderFactory (global::Android.App.Application p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AndroidDocumentProviderFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Application;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Application;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Application_ == IntPtr.Zero)
					id_ctor_Landroid_app_Application_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Application;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Application_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Application_, __args);
			} finally {
			}
		}

		static IntPtr id_checkThreadAccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']/method[@name='checkThreadAccess' and count(parameter)=0]"
		[Register ("checkThreadAccess", "()Z", "")]
		public unsafe bool CheckThreadAccess ()
		{
			if (id_checkThreadAccess == IntPtr.Zero)
				id_checkThreadAccess = JNIEnv.GetMethodID (class_ref, "checkThreadAccess", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkThreadAccess);
			} finally {
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/facebook/stetho/inspector/elements/DocumentProvider;", "")]
		public unsafe global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lcom/facebook/stetho/inspector/elements/DocumentProvider;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']/method[@name='postAndWait' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.common.UncheckedCallable&lt;V&gt;']]"
		[Register ("postAndWait", "(Lcom/facebook/stetho/common/UncheckedCallable;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public unsafe global::Java.Lang.Object PostAndWait (global::Com.Facebook.Stetho.Common.IUncheckedCallable p0)
		{
			if (id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ == IntPtr.Zero)
				id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ = JNIEnv.GetMethodID (class_ref, "postAndWait", "(Lcom/facebook/stetho/common/UncheckedCallable;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_postAndWait_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']/method[@name='postAndWait' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("postAndWait", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void PostAndWait (global::Java.Lang.IRunnable p0)
		{
			if (id_postAndWait_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postAndWait_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "postAndWait", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postAndWait_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_postDelayed_Ljava_lang_Runnable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']/method[@name='postDelayed' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("postDelayed", "(Ljava/lang/Runnable;J)V", "")]
		public unsafe void PostDelayed (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_postDelayed_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_postDelayed_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "postDelayed", "(Ljava/lang/Runnable;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postDelayed_Ljava_lang_Runnable_J, __args);
			} finally {
			}
		}

		static IntPtr id_removeCallbacks_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']/method[@name='removeCallbacks' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("removeCallbacks", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void RemoveCallbacks (global::Java.Lang.IRunnable p0)
		{
			if (id_removeCallbacks_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_removeCallbacks_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "removeCallbacks", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallbacks_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_verifyThreadAccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='AndroidDocumentProviderFactory']/method[@name='verifyThreadAccess' and count(parameter)=0]"
		[Register ("verifyThreadAccess", "()V", "")]
		public unsafe void VerifyThreadAccess ()
		{
			if (id_verifyThreadAccess == IntPtr.Zero)
				id_verifyThreadAccess = JNIEnv.GetMethodID (class_ref, "verifyThreadAccess", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verifyThreadAccess);
			} finally {
			}
		}

	}
}
