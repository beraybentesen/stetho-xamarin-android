using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='AsyncPrettyPrinter']"
	[Register ("com/facebook/stetho/inspector/network/AsyncPrettyPrinter", "", "Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInvoker")]
	public partial interface IAsyncPrettyPrinter : IJavaObject {

		global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType PrettifiedType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='AsyncPrettyPrinter']/method[@name='getPrettifiedType' and count(parameter)=0]"
			[Register ("getPrettifiedType", "()Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;", "GetGetPrettifiedTypeHandler:Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInvoker, StethoXamarin")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='AsyncPrettyPrinter']/method[@name='printTo' and count(parameter)=2 and parameter[1][@type='java.io.PrintWriter'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("printTo", "(Ljava/io/PrintWriter;Ljava/io/InputStream;)V", "GetPrintTo_Ljava_io_PrintWriter_Ljava_io_InputStream_Handler:Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInvoker, StethoXamarin")]
		void PrintTo (global::Java.IO.PrintWriter p0, global::System.IO.Stream p1);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/AsyncPrettyPrinter", DoNotGenerateAcw=true)]
	internal class IAsyncPrettyPrinterInvoker : global::Java.Lang.Object, IAsyncPrettyPrinter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/network/AsyncPrettyPrinter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAsyncPrettyPrinterInvoker); }
		}

		IntPtr class_ref;

		public static IAsyncPrettyPrinter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncPrettyPrinter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.network.AsyncPrettyPrinter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncPrettyPrinterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPrettifiedType;
#pragma warning disable 0169
		static Delegate GetGetPrettifiedTypeHandler ()
		{
			if (cb_getPrettifiedType == null)
				cb_getPrettifiedType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrettifiedType);
			return cb_getPrettifiedType;
		}

		static IntPtr n_GetPrettifiedType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrettifiedType);
		}
#pragma warning restore 0169

		IntPtr id_getPrettifiedType;
		public unsafe global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType PrettifiedType {
			get {
				if (id_getPrettifiedType == IntPtr.Zero)
					id_getPrettifiedType = JNIEnv.GetMethodID (class_ref, "getPrettifiedType", "()Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;");
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrettifiedType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_printTo_Ljava_io_PrintWriter_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetPrintTo_Ljava_io_PrintWriter_Ljava_io_InputStream_Handler ()
		{
			if (cb_printTo_Ljava_io_PrintWriter_Ljava_io_InputStream_ == null)
				cb_printTo_Ljava_io_PrintWriter_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrintTo_Ljava_io_PrintWriter_Ljava_io_InputStream_);
			return cb_printTo_Ljava_io_PrintWriter_Ljava_io_InputStream_;
		}

		static void n_PrintTo_Ljava_io_PrintWriter_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PrintWriter p0 = global::Java.Lang.Object.GetObject<global::Java.IO.PrintWriter> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintTo (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_printTo_Ljava_io_PrintWriter_Ljava_io_InputStream_;
		public unsafe void PrintTo (global::Java.IO.PrintWriter p0, global::System.IO.Stream p1)
		{
			if (id_printTo_Ljava_io_PrintWriter_Ljava_io_InputStream_ == IntPtr.Zero)
				id_printTo_Ljava_io_PrintWriter_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "printTo", "(Ljava/io/PrintWriter;Ljava/io/InputStream;)V");
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printTo_Ljava_io_PrintWriter_Ljava_io_InputStream_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
