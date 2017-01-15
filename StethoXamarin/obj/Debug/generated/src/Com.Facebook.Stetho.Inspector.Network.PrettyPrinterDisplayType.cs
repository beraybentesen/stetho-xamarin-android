using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='PrettyPrinterDisplayType']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/PrettyPrinterDisplayType", DoNotGenerateAcw=true)]
	public sealed partial class PrettyPrinterDisplayType : global::Java.Lang.Enum {


		static IntPtr HTML_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='PrettyPrinterDisplayType']/field[@name='HTML']"
		[Register ("HTML")]
		public static global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType Html {
			get {
				if (HTML_jfieldId == IntPtr.Zero)
					HTML_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTML", "Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTML_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JSON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='PrettyPrinterDisplayType']/field[@name='JSON']"
		[Register ("JSON")]
		public static global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType Json {
			get {
				if (JSON_jfieldId == IntPtr.Zero)
					JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSON", "Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JSON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='PrettyPrinterDisplayType']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType Text {
			get {
				if (TEXT_jfieldId == IntPtr.Zero)
					TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/PrettyPrinterDisplayType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PrettyPrinterDisplayType); }
		}

		internal PrettyPrinterDisplayType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getResourceType;
		public unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType ResourceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='PrettyPrinterDisplayType']/method[@name='getResourceType' and count(parameter)=0]"
			[Register ("getResourceType", "()Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;", "GetGetResourceTypeHandler")]
			get {
				if (id_getResourceType == IntPtr.Zero)
					id_getResourceType = JNIEnv.GetMethodID (class_ref, "getResourceType", "()Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='PrettyPrinterDisplayType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='PrettyPrinterDisplayType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;");
			try {
				return (global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType));
			} finally {
			}
		}

	}
}
