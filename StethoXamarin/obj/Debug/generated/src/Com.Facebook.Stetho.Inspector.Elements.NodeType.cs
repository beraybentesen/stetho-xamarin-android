using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/NodeType", DoNotGenerateAcw=true)]
	public sealed partial class NodeType : global::Java.Lang.Enum {


		static IntPtr COMMENT_NODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/field[@name='COMMENT_NODE']"
		[Register ("COMMENT_NODE")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.NodeType CommentNode {
			get {
				if (COMMENT_NODE_jfieldId == IntPtr.Zero)
					COMMENT_NODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMENT_NODE", "Lcom/facebook/stetho/inspector/elements/NodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMENT_NODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOCUMENT_FRAGMENT_NODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/field[@name='DOCUMENT_FRAGMENT_NODE']"
		[Register ("DOCUMENT_FRAGMENT_NODE")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.NodeType DocumentFragmentNode {
			get {
				if (DOCUMENT_FRAGMENT_NODE_jfieldId == IntPtr.Zero)
					DOCUMENT_FRAGMENT_NODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOCUMENT_FRAGMENT_NODE", "Lcom/facebook/stetho/inspector/elements/NodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOCUMENT_FRAGMENT_NODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOCUMENT_NODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/field[@name='DOCUMENT_NODE']"
		[Register ("DOCUMENT_NODE")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.NodeType DocumentNode {
			get {
				if (DOCUMENT_NODE_jfieldId == IntPtr.Zero)
					DOCUMENT_NODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOCUMENT_NODE", "Lcom/facebook/stetho/inspector/elements/NodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOCUMENT_NODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOCUMENT_TYPE_NODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/field[@name='DOCUMENT_TYPE_NODE']"
		[Register ("DOCUMENT_TYPE_NODE")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.NodeType DocumentTypeNode {
			get {
				if (DOCUMENT_TYPE_NODE_jfieldId == IntPtr.Zero)
					DOCUMENT_TYPE_NODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOCUMENT_TYPE_NODE", "Lcom/facebook/stetho/inspector/elements/NodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOCUMENT_TYPE_NODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ELEMENT_NODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/field[@name='ELEMENT_NODE']"
		[Register ("ELEMENT_NODE")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.NodeType ElementNode {
			get {
				if (ELEMENT_NODE_jfieldId == IntPtr.Zero)
					ELEMENT_NODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ELEMENT_NODE", "Lcom/facebook/stetho/inspector/elements/NodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ELEMENT_NODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PROCESSING_INSTRUCTION_NODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/field[@name='PROCESSING_INSTRUCTION_NODE']"
		[Register ("PROCESSING_INSTRUCTION_NODE")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.NodeType ProcessingInstructionNode {
			get {
				if (PROCESSING_INSTRUCTION_NODE_jfieldId == IntPtr.Zero)
					PROCESSING_INSTRUCTION_NODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROCESSING_INSTRUCTION_NODE", "Lcom/facebook/stetho/inspector/elements/NodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROCESSING_INSTRUCTION_NODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_NODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/field[@name='TEXT_NODE']"
		[Register ("TEXT_NODE")]
		public static global::Com.Facebook.Stetho.Inspector.Elements.NodeType TextNode {
			get {
				if (TEXT_NODE_jfieldId == IntPtr.Zero)
					TEXT_NODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_NODE", "Lcom/facebook/stetho/inspector/elements/NodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_NODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/NodeType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NodeType); }
		}

		internal NodeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getProtocolValue;
		public unsafe int ProtocolValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/method[@name='getProtocolValue' and count(parameter)=0]"
			[Register ("getProtocolValue", "()I", "GetGetProtocolValueHandler")]
			get {
				if (id_getProtocolValue == IntPtr.Zero)
					id_getProtocolValue = JNIEnv.GetMethodID (class_ref, "getProtocolValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getProtocolValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/elements/NodeType;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Elements.NodeType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/elements/NodeType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Facebook.Stetho.Inspector.Elements.NodeType __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='NodeType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/stetho/inspector/elements/NodeType;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Elements.NodeType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/elements/NodeType;");
			try {
				return (global::Com.Facebook.Stetho.Inspector.Elements.NodeType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Elements.NodeType));
			} finally {
			}
		}

	}
}
