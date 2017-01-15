using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MismatchedResponseException']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/MismatchedResponseException", DoNotGenerateAcw=true)]
	public partial class MismatchedResponseException : global::Com.Facebook.Stetho.Inspector.MessageHandlingException {


		static IntPtr mRequestId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MismatchedResponseException']/field[@name='mRequestId']"
		[Register ("mRequestId")]
		public long MRequestId {
			get {
				if (mRequestId_jfieldId == IntPtr.Zero)
					mRequestId_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestId", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Throwable) this).Handle, mRequestId_jfieldId);
			}
			set {
				if (mRequestId_jfieldId == IntPtr.Zero)
					mRequestId_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestId", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Throwable) this).Handle, mRequestId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/MismatchedResponseException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MismatchedResponseException); }
		}

		protected MismatchedResponseException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MismatchedResponseException']/constructor[@name='MismatchedResponseException' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MismatchedResponseException (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MismatchedResponseException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRequestId);
			return cb_getRequestId;
		}

		static long n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.MismatchedResponseException __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.MismatchedResponseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestId;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		public virtual unsafe long RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector']/class[@name='MismatchedResponseException']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()J", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Throwable) this).Handle, id_getRequestId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()J"));
				} finally {
				}
			}
		}

	}
}
