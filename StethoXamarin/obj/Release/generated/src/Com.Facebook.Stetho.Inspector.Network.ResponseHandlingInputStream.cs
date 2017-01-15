using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseHandlingInputStream']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/ResponseHandlingInputStream", DoNotGenerateAcw=true)]
	public sealed partial class ResponseHandlingInputStream : global::Java.IO.FilterInputStream {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResponseHandlingInputStream']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "ResponseHandlingInputStream";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/ResponseHandlingInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseHandlingInputStream); }
		}

		internal ResponseHandlingInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
