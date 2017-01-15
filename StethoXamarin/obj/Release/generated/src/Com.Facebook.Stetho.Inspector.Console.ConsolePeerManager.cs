using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Console {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/class[@name='ConsolePeerManager']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/console/ConsolePeerManager", DoNotGenerateAcw=true)]
	public partial class ConsolePeerManager : global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/console/ConsolePeerManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConsolePeerManager); }
		}

		protected ConsolePeerManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstanceOrNull;
		public static unsafe global::Com.Facebook.Stetho.Inspector.Console.ConsolePeerManager InstanceOrNull {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/class[@name='ConsolePeerManager']/method[@name='getInstanceOrNull' and count(parameter)=0]"
			[Register ("getInstanceOrNull", "()Lcom/facebook/stetho/inspector/console/ConsolePeerManager;", "GetGetInstanceOrNullHandler")]
			get {
				if (id_getInstanceOrNull == IntPtr.Zero)
					id_getInstanceOrNull = JNIEnv.GetStaticMethodID (class_ref, "getInstanceOrNull", "()Lcom/facebook/stetho/inspector/console/ConsolePeerManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Console.ConsolePeerManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstanceOrNull), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOrCreateInstance;
		public static unsafe global::Com.Facebook.Stetho.Inspector.Console.ConsolePeerManager OrCreateInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.console']/class[@name='ConsolePeerManager']/method[@name='getOrCreateInstance' and count(parameter)=0]"
			[Register ("getOrCreateInstance", "()Lcom/facebook/stetho/inspector/console/ConsolePeerManager;", "GetGetOrCreateInstanceHandler")]
			get {
				if (id_getOrCreateInstance == IntPtr.Zero)
					id_getOrCreateInstance = JNIEnv.GetStaticMethodID (class_ref, "getOrCreateInstance", "()Lcom/facebook/stetho/inspector/console/ConsolePeerManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Console.ConsolePeerManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOrCreateInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
