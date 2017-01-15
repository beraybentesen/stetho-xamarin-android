using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='AsyncPrettyPrinterFactory']"
	[Register ("com/facebook/stetho/inspector/network/AsyncPrettyPrinterFactory", "", "Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterFactoryInvoker")]
	public partial interface IAsyncPrettyPrinterFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='AsyncPrettyPrinterFactory']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinter;", "GetGetInstance_Ljava_lang_String_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterFactoryInvoker, StethoXamarin")]
		global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter GetInstance (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/AsyncPrettyPrinterFactory", DoNotGenerateAcw=true)]
	internal class IAsyncPrettyPrinterFactoryInvoker : global::Java.Lang.Object, IAsyncPrettyPrinterFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/network/AsyncPrettyPrinterFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAsyncPrettyPrinterFactoryInvoker); }
		}

		IntPtr class_ref;

		public static IAsyncPrettyPrinterFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncPrettyPrinterFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.network.AsyncPrettyPrinterFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncPrettyPrinterFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getInstance_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInstance_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getInstance_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getInstance_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInstance_Ljava_lang_String_Ljava_lang_String_);
			return cb_getInstance_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetInstance_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInstance (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInstance_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter GetInstance (string p0, string p1)
		{
			if (id_getInstance_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInstance_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
