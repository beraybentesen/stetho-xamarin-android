using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Runtime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.runtime']/class[@name='RhinoDetectingRuntimeReplFactory']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/runtime/RhinoDetectingRuntimeReplFactory", DoNotGenerateAcw=true)]
	public partial class RhinoDetectingRuntimeReplFactory : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Console.IRuntimeReplFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/runtime/RhinoDetectingRuntimeReplFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RhinoDetectingRuntimeReplFactory); }
		}

		protected RhinoDetectingRuntimeReplFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.runtime']/class[@name='RhinoDetectingRuntimeReplFactory']/constructor[@name='RhinoDetectingRuntimeReplFactory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RhinoDetectingRuntimeReplFactory (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RhinoDetectingRuntimeReplFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_newInstance;
#pragma warning disable 0169
		static Delegate GetNewInstanceHandler ()
		{
			if (cb_newInstance == null)
				cb_newInstance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewInstance);
			return cb_newInstance;
		}

		static IntPtr n_NewInstance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Runtime.RhinoDetectingRuntimeReplFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Runtime.RhinoDetectingRuntimeReplFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewInstance ());
		}
#pragma warning restore 0169

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.runtime']/class[@name='RhinoDetectingRuntimeReplFactory']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/facebook/stetho/inspector/console/RuntimeRepl;", "GetNewInstanceHandler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Console.IRuntimeRepl NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetMethodID (class_ref, "newInstance", "()Lcom/facebook/stetho/inspector/console/RuntimeRepl;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Console.IRuntimeRepl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newInstance), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Console.IRuntimeRepl> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newInstance", "()Lcom/facebook/stetho/inspector/console/RuntimeRepl;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
