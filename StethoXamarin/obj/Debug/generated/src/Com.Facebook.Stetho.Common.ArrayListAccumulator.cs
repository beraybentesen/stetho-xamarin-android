using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ArrayListAccumulator']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/ArrayListAccumulator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public sealed partial class ArrayListAccumulator : global::Java.Util.ArrayList, global::Com.Facebook.Stetho.Common.IAccumulator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/ArrayListAccumulator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayListAccumulator); }
		}

		internal ArrayListAccumulator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ArrayListAccumulator']/constructor[@name='ArrayListAccumulator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArrayListAccumulator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ArrayListAccumulator)) {
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

		static IntPtr id_store_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ArrayListAccumulator']/method[@name='store' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("store", "(Ljava/lang/Object;)V", "")]
		public unsafe void Store (global::Java.Lang.Object p0)
		{
			if (id_store_Ljava_lang_Object_ == IntPtr.Zero)
				id_store_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "store", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_store_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
