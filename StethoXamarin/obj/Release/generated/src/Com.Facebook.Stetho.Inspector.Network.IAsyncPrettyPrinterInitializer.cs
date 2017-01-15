using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='AsyncPrettyPrinterInitializer']"
	[Register ("com/facebook/stetho/inspector/network/AsyncPrettyPrinterInitializer", "", "Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializerInvoker")]
	public partial interface IAsyncPrettyPrinterInitializer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='AsyncPrettyPrinterInitializer']/method[@name='populatePrettyPrinters' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.network.AsyncPrettyPrinterRegistry']]"
		[Register ("populatePrettyPrinters", "(Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinterRegistry;)V", "GetPopulatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_Handler:Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializerInvoker, StethoXamarin")]
		void PopulatePrettyPrinters (global::Com.Facebook.Stetho.Inspector.Network.AsyncPrettyPrinterRegistry p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/AsyncPrettyPrinterInitializer", DoNotGenerateAcw=true)]
	internal class IAsyncPrettyPrinterInitializerInvoker : global::Java.Lang.Object, IAsyncPrettyPrinterInitializer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/network/AsyncPrettyPrinterInitializer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAsyncPrettyPrinterInitializerInvoker); }
		}

		IntPtr class_ref;

		public static IAsyncPrettyPrinterInitializer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncPrettyPrinterInitializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.network.AsyncPrettyPrinterInitializer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncPrettyPrinterInitializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_populatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_;
#pragma warning disable 0169
		static Delegate GetPopulatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_Handler ()
		{
			if (cb_populatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_ == null)
				cb_populatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PopulatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_);
			return cb_populatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_;
		}

		static void n_PopulatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.AsyncPrettyPrinterRegistry p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.AsyncPrettyPrinterRegistry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PopulatePrettyPrinters (p0);
		}
#pragma warning restore 0169

		IntPtr id_populatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_;
		public unsafe void PopulatePrettyPrinters (global::Com.Facebook.Stetho.Inspector.Network.AsyncPrettyPrinterRegistry p0)
		{
			if (id_populatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_ == IntPtr.Zero)
				id_populatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_ = JNIEnv.GetMethodID (class_ref, "populatePrettyPrinters", "(Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinterRegistry;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_populatePrettyPrinters_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterRegistry_, __args);
		}

	}

}
