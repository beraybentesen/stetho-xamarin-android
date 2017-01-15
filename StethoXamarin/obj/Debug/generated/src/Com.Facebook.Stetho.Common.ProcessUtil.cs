using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ProcessUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/ProcessUtil", DoNotGenerateAcw=true)]
	public partial class ProcessUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/ProcessUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProcessUtil); }
		}

		protected ProcessUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ProcessUtil']/constructor[@name='ProcessUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProcessUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ProcessUtil)) {
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

		static IntPtr id_getProcessName;
		public static unsafe string ProcessName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ProcessUtil']/method[@name='getProcessName' and count(parameter)=0]"
			[Register ("getProcessName", "()Ljava/lang/String;", "GetGetProcessNameHandler")]
			get {
				if (id_getProcessName == IntPtr.Zero)
					id_getProcessName = JNIEnv.GetStaticMethodID (class_ref, "getProcessName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProcessName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
