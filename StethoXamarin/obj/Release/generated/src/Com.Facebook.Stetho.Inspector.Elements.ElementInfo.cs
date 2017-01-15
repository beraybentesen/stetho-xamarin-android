using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ElementInfo']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/ElementInfo", DoNotGenerateAcw=true)]
	public sealed partial class ElementInfo : global::Java.Lang.Object {


		static IntPtr children_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ElementInfo']/field[@name='children']"
		[Register ("children")]
		public global::System.Collections.IList Children {
			get {
				if (children_jfieldId == IntPtr.Zero)
					children_jfieldId = JNIEnv.GetFieldID (class_ref, "children", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, children_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (children_jfieldId == IntPtr.Zero)
					children_jfieldId = JNIEnv.GetFieldID (class_ref, "children", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, children_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr element_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ElementInfo']/field[@name='element']"
		[Register ("element")]
		public global::Java.Lang.Object Element {
			get {
				if (element_jfieldId == IntPtr.Zero)
					element_jfieldId = JNIEnv.GetFieldID (class_ref, "element", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, element_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (element_jfieldId == IntPtr.Zero)
					element_jfieldId = JNIEnv.GetFieldID (class_ref, "element", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, element_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr parentElement_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ElementInfo']/field[@name='parentElement']"
		[Register ("parentElement")]
		public global::Java.Lang.Object ParentElement {
			get {
				if (parentElement_jfieldId == IntPtr.Zero)
					parentElement_jfieldId = JNIEnv.GetFieldID (class_ref, "parentElement", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, parentElement_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (parentElement_jfieldId == IntPtr.Zero)
					parentElement_jfieldId = JNIEnv.GetFieldID (class_ref, "parentElement", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, parentElement_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/ElementInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ElementInfo); }
		}

		internal ElementInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
