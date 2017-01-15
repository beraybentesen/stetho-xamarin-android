using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Console {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/interface[@name='RuntimeRepl']"
	[Register ("com/facebook/stetho/inspector/console/RuntimeRepl", "", "Com.Facebook.Stetho.Inspector.Console.IRuntimeReplInvoker")]
	public partial interface IRuntimeRepl : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/interface[@name='RuntimeRepl']/method[@name='evaluate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("evaluate", "(Ljava/lang/String;)Ljava/lang/Object;", "GetEvaluate_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Console.IRuntimeReplInvoker, StethoXamarin")]
		global::Java.Lang.Object Evaluate (string p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/console/RuntimeRepl", DoNotGenerateAcw=true)]
	internal class IRuntimeReplInvoker : global::Java.Lang.Object, IRuntimeRepl {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/console/RuntimeRepl");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRuntimeReplInvoker); }
		}

		IntPtr class_ref;

		public static IRuntimeRepl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRuntimeRepl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.console.RuntimeRepl"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRuntimeReplInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_evaluate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEvaluate_Ljava_lang_String_Handler ()
		{
			if (cb_evaluate_Ljava_lang_String_ == null)
				cb_evaluate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Evaluate_Ljava_lang_String_);
			return cb_evaluate_Ljava_lang_String_;
		}

		static IntPtr n_Evaluate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Console.IRuntimeRepl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Console.IRuntimeRepl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Evaluate (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_evaluate_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object Evaluate (string p0)
		{
			if (id_evaluate_Ljava_lang_String_ == IntPtr.Zero)
				id_evaluate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "evaluate", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_evaluate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
