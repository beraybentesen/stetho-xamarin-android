using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol']/interface[@name='ChromeDevtoolsDomain']"
	[Register ("com/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain", "", "Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomainInvoker")]
	public partial interface IChromeDevtoolsDomain : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain", DoNotGenerateAcw=true)]
	internal class IChromeDevtoolsDomainInvoker : global::Java.Lang.Object, IChromeDevtoolsDomain {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/ChromeDevtoolsDomain");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IChromeDevtoolsDomainInvoker); }
		}

		IntPtr class_ref;

		public static IChromeDevtoolsDomain GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChromeDevtoolsDomain> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.protocol.ChromeDevtoolsDomain"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChromeDevtoolsDomainInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
