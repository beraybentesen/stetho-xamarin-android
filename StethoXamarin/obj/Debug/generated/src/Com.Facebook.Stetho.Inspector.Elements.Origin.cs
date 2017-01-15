using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Origin']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/Origin", DoNotGenerateAcw=true)]
	public sealed partial class Origin : global::Java.Lang.Enum {


		static IntPtr INJECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Origin']/field[@name='INJECTED']"
		[Register ("INJECTED")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.Origin Injected {
			get {
				if (INJECTED_jfieldId == IntPtr.Zero)
					INJECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INJECTED", "Lcom/facebook/stetho/inspector/elements/Origin;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INJECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Origin> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INSPECTOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Origin']/field[@name='INSPECTOR']"
		[Register ("INSPECTOR")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.Origin Inspector {
			get {
				if (INSPECTOR_jfieldId == IntPtr.Zero)
					INSPECTOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSPECTOR", "Lcom/facebook/stetho/inspector/elements/Origin;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSPECTOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Origin> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REGULAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Origin']/field[@name='REGULAR']"
		[Register ("REGULAR")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.Origin Regular {
			get {
				if (REGULAR_jfieldId == IntPtr.Zero)
					REGULAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGULAR", "Lcom/facebook/stetho/inspector/elements/Origin;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGULAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Origin> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_AGENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Origin']/field[@name='USER_AGENT']"
		[Register ("USER_AGENT")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.Origin UserAgent {
			get {
				if (USER_AGENT_jfieldId == IntPtr.Zero)
					USER_AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_AGENT", "Lcom/facebook/stetho/inspector/elements/Origin;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_AGENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Origin> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/Origin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Origin); }
		}

		internal Origin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getProtocolValue;
		public unsafe string ProtocolValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Origin']/method[@name='getProtocolValue' and count(parameter)=0]"
			[Register ("getProtocolValue", "()Ljava/lang/String;", "GetGetProtocolValueHandler")]
			get {
				if (id_getProtocolValue == IntPtr.Zero)
					id_getProtocolValue = JNIEnv.GetMethodID (class_ref, "getProtocolValue", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProtocolValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Origin']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/elements/Origin;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Elements.Origin ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/elements/Origin;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Facebook.Stetho.Inspector.Elements.Origin __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Origin> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Origin']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/stetho/inspector/elements/Origin;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Elements.Origin[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/elements/Origin;");
			try {
				return (global::Com.Facebook.Stetho.Inspector.Elements.Origin[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Elements.Origin));
			} finally {
			}
		}

	}
}
