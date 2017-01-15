using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Jsonrpc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.jsonrpc']/interface[@name='JsonRpcResult']"
	[Register ("com/facebook/stetho/inspector/jsonrpc/JsonRpcResult", "", "Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResultInvoker")]
	public partial interface IJsonRpcResult : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/jsonrpc/JsonRpcResult", DoNotGenerateAcw=true)]
	internal class IJsonRpcResultInvoker : global::Java.Lang.Object, IJsonRpcResult {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/jsonrpc/JsonRpcResult");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJsonRpcResultInvoker); }
		}

		IntPtr class_ref;

		public static IJsonRpcResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonRpcResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.jsonrpc.JsonRpcResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonRpcResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
