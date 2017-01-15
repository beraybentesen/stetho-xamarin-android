using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM", DoNotGenerateAcw=true)]
	public partial class DOM : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.AttributeModifiedEvent']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$AttributeModifiedEvent", DoNotGenerateAcw=true)]
		public partial class AttributeModifiedEvent : global::Java.Lang.Object {


			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.AttributeModifiedEvent']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.AttributeModifiedEvent']/field[@name='nodeId']"
			[Register ("nodeId")]
			public int NodeId {
				get {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId);
				}
				set {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.AttributeModifiedEvent']/field[@name='value']"
			[Register ("value")]
			public string Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$AttributeModifiedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AttributeModifiedEvent); }
			}

			protected AttributeModifiedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.AttributeRemovedEvent']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$AttributeRemovedEvent", DoNotGenerateAcw=true)]
		public partial class AttributeRemovedEvent : global::Java.Lang.Object {


			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.AttributeRemovedEvent']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.AttributeRemovedEvent']/field[@name='nodeId']"
			[Register ("nodeId")]
			public int NodeId {
				get {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId);
				}
				set {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$AttributeRemovedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AttributeRemovedEvent); }
			}

			protected AttributeRemovedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ChildNodeInsertedEvent']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$ChildNodeInsertedEvent", DoNotGenerateAcw=true)]
		public partial class ChildNodeInsertedEvent : global::Java.Lang.Object {


			static IntPtr node_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ChildNodeInsertedEvent']/field[@name='node']"
			[Register ("node")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.Node Node {
				get {
					if (node_jfieldId == IntPtr.Zero)
						node_jfieldId = JNIEnv.GetFieldID (class_ref, "node", "Lcom/facebook/stetho/inspector/protocol/module/DOM$Node;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, node_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.Node> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (node_jfieldId == IntPtr.Zero)
						node_jfieldId = JNIEnv.GetFieldID (class_ref, "node", "Lcom/facebook/stetho/inspector/protocol/module/DOM$Node;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, node_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr parentNodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ChildNodeInsertedEvent']/field[@name='parentNodeId']"
			[Register ("parentNodeId")]
			public int ParentNodeId {
				get {
					if (parentNodeId_jfieldId == IntPtr.Zero)
						parentNodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "parentNodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, parentNodeId_jfieldId);
				}
				set {
					if (parentNodeId_jfieldId == IntPtr.Zero)
						parentNodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "parentNodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, parentNodeId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr previousNodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ChildNodeInsertedEvent']/field[@name='previousNodeId']"
			[Register ("previousNodeId")]
			public int PreviousNodeId {
				get {
					if (previousNodeId_jfieldId == IntPtr.Zero)
						previousNodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "previousNodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, previousNodeId_jfieldId);
				}
				set {
					if (previousNodeId_jfieldId == IntPtr.Zero)
						previousNodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "previousNodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, previousNodeId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$ChildNodeInsertedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ChildNodeInsertedEvent); }
			}

			protected ChildNodeInsertedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ChildNodeRemovedEvent']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$ChildNodeRemovedEvent", DoNotGenerateAcw=true)]
		public partial class ChildNodeRemovedEvent : global::Java.Lang.Object {


			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ChildNodeRemovedEvent']/field[@name='nodeId']"
			[Register ("nodeId")]
			public int NodeId {
				get {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId);
				}
				set {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr parentNodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ChildNodeRemovedEvent']/field[@name='parentNodeId']"
			[Register ("parentNodeId")]
			public int ParentNodeId {
				get {
					if (parentNodeId_jfieldId == IntPtr.Zero)
						parentNodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "parentNodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, parentNodeId_jfieldId);
				}
				set {
					if (parentNodeId_jfieldId == IntPtr.Zero)
						parentNodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "parentNodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, parentNodeId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$ChildNodeRemovedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ChildNodeRemovedEvent); }
			}

			protected ChildNodeRemovedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.DiscardSearchResultsRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$DiscardSearchResultsRequest", DoNotGenerateAcw=true)]
		public partial class DiscardSearchResultsRequest : global::Java.Lang.Object {


			static IntPtr searchId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.DiscardSearchResultsRequest']/field[@name='searchId']"
			[Register ("searchId")]
			public string SearchId {
				get {
					if (searchId_jfieldId == IntPtr.Zero)
						searchId_jfieldId = JNIEnv.GetFieldID (class_ref, "searchId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, searchId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (searchId_jfieldId == IntPtr.Zero)
						searchId_jfieldId = JNIEnv.GetFieldID (class_ref, "searchId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, searchId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$DiscardSearchResultsRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DiscardSearchResultsRequest); }
			}

			protected DiscardSearchResultsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.DocumentUpdateListener']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$DocumentUpdateListener", DoNotGenerateAcw=true)]
		public sealed partial class DocumentUpdateListener : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$DocumentUpdateListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DocumentUpdateListener); }
			}

			internal DocumentUpdateListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.DocumentUpdateListener']/method[@name='onAttributeModified' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("onAttributeModified", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe void OnAttributeModified (global::Java.Lang.Object p0, string p1, string p2)
			{
				if (id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAttributeModified", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static IntPtr id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.DocumentUpdateListener']/method[@name='onAttributeRemoved' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
			[Register ("onAttributeRemoved", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
			public unsafe void OnAttributeRemoved (global::Java.Lang.Object p0, string p1)
			{
				if (id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
					id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAttributeRemoved", "(Ljava/lang/Object;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.DocumentUpdateListener']/method[@name='onChildNodeInserted' and count(parameter)=5 and parameter[1][@type='com.facebook.stetho.inspector.elements.DocumentView'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.facebook.stetho.common.Accumulator&lt;java.lang.Object&gt;']]"
			[Register ("onChildNodeInserted", "(Lcom/facebook/stetho/inspector/elements/DocumentView;Ljava/lang/Object;IILcom/facebook/stetho/common/Accumulator;)V", "")]
			public unsafe void OnChildNodeInserted (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0, global::Java.Lang.Object p1, int p2, int p3, global::Com.Facebook.Stetho.Common.IAccumulator p4)
			{
				if (id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ == IntPtr.Zero)
					id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ = JNIEnv.GetMethodID (class_ref, "onChildNodeInserted", "(Lcom/facebook/stetho/inspector/elements/DocumentView;Ljava/lang/Object;IILcom/facebook/stetho/common/Accumulator;)V");
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_, __args);
				} finally {
				}
			}

			static IntPtr id_onChildNodeRemoved_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.DocumentUpdateListener']/method[@name='onChildNodeRemoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onChildNodeRemoved", "(II)V", "")]
			public unsafe void OnChildNodeRemoved (int p0, int p1)
			{
				if (id_onChildNodeRemoved_II == IntPtr.Zero)
					id_onChildNodeRemoved_II = JNIEnv.GetMethodID (class_ref, "onChildNodeRemoved", "(II)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChildNodeRemoved_II, __args);
				} finally {
				}
			}

			static IntPtr id_onInspectRequested_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.DocumentUpdateListener']/method[@name='onInspectRequested' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("onInspectRequested", "(Ljava/lang/Object;)V", "")]
			public unsafe void OnInspectRequested (global::Java.Lang.Object p0)
			{
				if (id_onInspectRequested_Ljava_lang_Object_ == IntPtr.Zero)
					id_onInspectRequested_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onInspectRequested", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInspectRequested_Ljava_lang_Object_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.GetDocumentResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$GetDocumentResponse", DoNotGenerateAcw=true)]
		public partial class GetDocumentResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr root_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.GetDocumentResponse']/field[@name='root']"
			[Register ("root")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.Node Root {
				get {
					if (root_jfieldId == IntPtr.Zero)
						root_jfieldId = JNIEnv.GetFieldID (class_ref, "root", "Lcom/facebook/stetho/inspector/protocol/module/DOM$Node;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, root_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.Node> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (root_jfieldId == IntPtr.Zero)
						root_jfieldId = JNIEnv.GetFieldID (class_ref, "root", "Lcom/facebook/stetho/inspector/protocol/module/DOM$Node;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, root_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$GetDocumentResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetDocumentResponse); }
			}

			protected GetDocumentResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.GetSearchResultsRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$GetSearchResultsRequest", DoNotGenerateAcw=true)]
		public partial class GetSearchResultsRequest : global::Java.Lang.Object {


			static IntPtr fromIndex_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.GetSearchResultsRequest']/field[@name='fromIndex']"
			[Register ("fromIndex")]
			public int FromIndex {
				get {
					if (fromIndex_jfieldId == IntPtr.Zero)
						fromIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "fromIndex", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, fromIndex_jfieldId);
				}
				set {
					if (fromIndex_jfieldId == IntPtr.Zero)
						fromIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "fromIndex", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fromIndex_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr searchId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.GetSearchResultsRequest']/field[@name='searchId']"
			[Register ("searchId")]
			public string SearchId {
				get {
					if (searchId_jfieldId == IntPtr.Zero)
						searchId_jfieldId = JNIEnv.GetFieldID (class_ref, "searchId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, searchId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (searchId_jfieldId == IntPtr.Zero)
						searchId_jfieldId = JNIEnv.GetFieldID (class_ref, "searchId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, searchId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr toIndex_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.GetSearchResultsRequest']/field[@name='toIndex']"
			[Register ("toIndex")]
			public int ToIndex {
				get {
					if (toIndex_jfieldId == IntPtr.Zero)
						toIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "toIndex", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, toIndex_jfieldId);
				}
				set {
					if (toIndex_jfieldId == IntPtr.Zero)
						toIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "toIndex", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, toIndex_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$GetSearchResultsRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetSearchResultsRequest); }
			}

			protected GetSearchResultsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.GetSearchResultsResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$GetSearchResultsResponse", DoNotGenerateAcw=true)]
		public partial class GetSearchResultsResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr nodeIds_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.GetSearchResultsResponse']/field[@name='nodeIds']"
			[Register ("nodeIds")]
			public global::System.Collections.IList NodeIds {
				get {
					if (nodeIds_jfieldId == IntPtr.Zero)
						nodeIds_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeIds", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nodeIds_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeIds_jfieldId == IntPtr.Zero)
						nodeIds_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeIds", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeIds_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$GetSearchResultsResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetSearchResultsResponse); }
			}

			protected GetSearchResultsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.HighlightConfig']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$HighlightConfig", DoNotGenerateAcw=true)]
		public partial class HighlightConfig : global::Java.Lang.Object {


			static IntPtr contentColor_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.HighlightConfig']/field[@name='contentColor']"
			[Register ("contentColor")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.RGBAColor ContentColor {
				get {
					if (contentColor_jfieldId == IntPtr.Zero)
						contentColor_jfieldId = JNIEnv.GetFieldID (class_ref, "contentColor", "Lcom/facebook/stetho/inspector/protocol/module/DOM$RGBAColor;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, contentColor_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.RGBAColor> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (contentColor_jfieldId == IntPtr.Zero)
						contentColor_jfieldId = JNIEnv.GetFieldID (class_ref, "contentColor", "Lcom/facebook/stetho/inspector/protocol/module/DOM$RGBAColor;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, contentColor_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$HighlightConfig", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HighlightConfig); }
			}

			protected HighlightConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.HighlightNodeRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$HighlightNodeRequest", DoNotGenerateAcw=true)]
		public partial class HighlightNodeRequest : global::Java.Lang.Object {


			static IntPtr highlightConfig_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.HighlightNodeRequest']/field[@name='highlightConfig']"
			[Register ("highlightConfig")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.HighlightConfig HighlightConfig {
				get {
					if (highlightConfig_jfieldId == IntPtr.Zero)
						highlightConfig_jfieldId = JNIEnv.GetFieldID (class_ref, "highlightConfig", "Lcom/facebook/stetho/inspector/protocol/module/DOM$HighlightConfig;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, highlightConfig_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.HighlightConfig> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (highlightConfig_jfieldId == IntPtr.Zero)
						highlightConfig_jfieldId = JNIEnv.GetFieldID (class_ref, "highlightConfig", "Lcom/facebook/stetho/inspector/protocol/module/DOM$HighlightConfig;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, highlightConfig_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.HighlightNodeRequest']/field[@name='nodeId']"
			[Register ("nodeId")]
			public global::Java.Lang.Integer NodeId {
				get {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "Ljava/lang/Integer;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "Ljava/lang/Integer;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr objectId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.HighlightNodeRequest']/field[@name='objectId']"
			[Register ("objectId")]
			public string ObjectId {
				get {
					if (objectId_jfieldId == IntPtr.Zero)
						objectId_jfieldId = JNIEnv.GetFieldID (class_ref, "objectId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, objectId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (objectId_jfieldId == IntPtr.Zero)
						objectId_jfieldId = JNIEnv.GetFieldID (class_ref, "objectId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, objectId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$HighlightNodeRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HighlightNodeRequest); }
			}

			protected HighlightNodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.InspectNodeRequestedEvent']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$InspectNodeRequestedEvent", DoNotGenerateAcw=true)]
		public partial class InspectNodeRequestedEvent : global::Java.Lang.Object {


			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.InspectNodeRequestedEvent']/field[@name='nodeId']"
			[Register ("nodeId")]
			public int NodeId {
				get {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId);
				}
				set {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$InspectNodeRequestedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InspectNodeRequestedEvent); }
			}

			protected InspectNodeRequestedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$Node", DoNotGenerateAcw=true)]
		public partial class Node : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr attributes_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']/field[@name='attributes']"
			[Register ("attributes")]
			public global::System.Collections.IList Attributes {
				get {
					if (attributes_jfieldId == IntPtr.Zero)
						attributes_jfieldId = JNIEnv.GetFieldID (class_ref, "attributes", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, attributes_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (attributes_jfieldId == IntPtr.Zero)
						attributes_jfieldId = JNIEnv.GetFieldID (class_ref, "attributes", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, attributes_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr childNodeCount_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']/field[@name='childNodeCount']"
			[Register ("childNodeCount")]
			public global::Java.Lang.Integer ChildNodeCount {
				get {
					if (childNodeCount_jfieldId == IntPtr.Zero)
						childNodeCount_jfieldId = JNIEnv.GetFieldID (class_ref, "childNodeCount", "Ljava/lang/Integer;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, childNodeCount_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (childNodeCount_jfieldId == IntPtr.Zero)
						childNodeCount_jfieldId = JNIEnv.GetFieldID (class_ref, "childNodeCount", "Ljava/lang/Integer;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, childNodeCount_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr children_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']/field[@name='children']"
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

			static IntPtr localName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']/field[@name='localName']"
			[Register ("localName")]
			public string LocalName {
				get {
					if (localName_jfieldId == IntPtr.Zero)
						localName_jfieldId = JNIEnv.GetFieldID (class_ref, "localName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, localName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (localName_jfieldId == IntPtr.Zero)
						localName_jfieldId = JNIEnv.GetFieldID (class_ref, "localName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, localName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']/field[@name='nodeId']"
			[Register ("nodeId")]
			public int NodeId {
				get {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId);
				}
				set {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr nodeName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']/field[@name='nodeName']"
			[Register ("nodeName")]
			public string NodeName {
				get {
					if (nodeName_jfieldId == IntPtr.Zero)
						nodeName_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nodeName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeName_jfieldId == IntPtr.Zero)
						nodeName_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nodeType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']/field[@name='nodeType']"
			[Register ("nodeType")]
			public global::Com.Facebook.Stetho.Inspector.Elements.NodeType NodeType {
				get {
					if (nodeType_jfieldId == IntPtr.Zero)
						nodeType_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeType", "Lcom/facebook/stetho/inspector/elements/NodeType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nodeType_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeType_jfieldId == IntPtr.Zero)
						nodeType_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeType", "Lcom/facebook/stetho/inspector/elements/NodeType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeType_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nodeValue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.Node']/field[@name='nodeValue']"
			[Register ("nodeValue")]
			public string NodeValue {
				get {
					if (nodeValue_jfieldId == IntPtr.Zero)
						nodeValue_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeValue", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nodeValue_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeValue_jfieldId == IntPtr.Zero)
						nodeValue_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeValue", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeValue_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$Node", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Node); }
			}

			protected Node (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PeerManagerListener']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$PeerManagerListener", DoNotGenerateAcw=true)]
		public sealed partial class PeerManagerListener : global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$PeerManagerListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PeerManagerListener); }
			}

			internal PeerManagerListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_onFirstPeerRegistered;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PeerManagerListener']/method[@name='onFirstPeerRegistered' and count(parameter)=0]"
			[Register ("onFirstPeerRegistered", "()V", "")]
			protected override unsafe void OnFirstPeerRegistered ()
			{
				if (id_onFirstPeerRegistered == IntPtr.Zero)
					id_onFirstPeerRegistered = JNIEnv.GetMethodID (class_ref, "onFirstPeerRegistered", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFirstPeerRegistered);
				} finally {
				}
			}

			static IntPtr id_onLastPeerUnregistered;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PeerManagerListener']/method[@name='onLastPeerUnregistered' and count(parameter)=0]"
			[Register ("onLastPeerUnregistered", "()V", "")]
			protected override unsafe void OnLastPeerUnregistered ()
			{
				if (id_onLastPeerUnregistered == IntPtr.Zero)
					id_onLastPeerUnregistered = JNIEnv.GetMethodID (class_ref, "onLastPeerUnregistered", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLastPeerUnregistered);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PerformSearchRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$PerformSearchRequest", DoNotGenerateAcw=true)]
		public partial class PerformSearchRequest : global::Java.Lang.Object {


			static IntPtr includeUserAgentShadowDOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PerformSearchRequest']/field[@name='includeUserAgentShadowDOM']"
			[Register ("includeUserAgentShadowDOM")]
			public global::Java.Lang.Boolean IncludeUserAgentShadowDOM {
				get {
					if (includeUserAgentShadowDOM_jfieldId == IntPtr.Zero)
						includeUserAgentShadowDOM_jfieldId = JNIEnv.GetFieldID (class_ref, "includeUserAgentShadowDOM", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, includeUserAgentShadowDOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (includeUserAgentShadowDOM_jfieldId == IntPtr.Zero)
						includeUserAgentShadowDOM_jfieldId = JNIEnv.GetFieldID (class_ref, "includeUserAgentShadowDOM", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, includeUserAgentShadowDOM_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr query_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PerformSearchRequest']/field[@name='query']"
			[Register ("query")]
			public string Query {
				get {
					if (query_jfieldId == IntPtr.Zero)
						query_jfieldId = JNIEnv.GetFieldID (class_ref, "query", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, query_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (query_jfieldId == IntPtr.Zero)
						query_jfieldId = JNIEnv.GetFieldID (class_ref, "query", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, query_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$PerformSearchRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PerformSearchRequest); }
			}

			protected PerformSearchRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PerformSearchResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$PerformSearchResponse", DoNotGenerateAcw=true)]
		public partial class PerformSearchResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr resultCount_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PerformSearchResponse']/field[@name='resultCount']"
			[Register ("resultCount")]
			public int ResultCount {
				get {
					if (resultCount_jfieldId == IntPtr.Zero)
						resultCount_jfieldId = JNIEnv.GetFieldID (class_ref, "resultCount", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, resultCount_jfieldId);
				}
				set {
					if (resultCount_jfieldId == IntPtr.Zero)
						resultCount_jfieldId = JNIEnv.GetFieldID (class_ref, "resultCount", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, resultCount_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr searchId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.PerformSearchResponse']/field[@name='searchId']"
			[Register ("searchId")]
			public string SearchId {
				get {
					if (searchId_jfieldId == IntPtr.Zero)
						searchId_jfieldId = JNIEnv.GetFieldID (class_ref, "searchId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, searchId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (searchId_jfieldId == IntPtr.Zero)
						searchId_jfieldId = JNIEnv.GetFieldID (class_ref, "searchId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, searchId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$PerformSearchResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PerformSearchResponse); }
			}

			protected PerformSearchResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.RGBAColor']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$RGBAColor", DoNotGenerateAcw=true)]
		public partial class RGBAColor : global::Java.Lang.Object {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.RGBAColor']/field[@name='a']"
			[Register ("a")]
			public global::Java.Lang.Double A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Double;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/Double;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.RGBAColor']/field[@name='b']"
			[Register ("b")]
			public int B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr g_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.RGBAColor']/field[@name='g']"
			[Register ("g")]
			public int G {
				get {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, g_jfieldId);
				}
				set {
					if (g_jfieldId == IntPtr.Zero)
						g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, g_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr r_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.RGBAColor']/field[@name='r']"
			[Register ("r")]
			public int R {
				get {
					if (r_jfieldId == IntPtr.Zero)
						r_jfieldId = JNIEnv.GetFieldID (class_ref, "r", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, r_jfieldId);
				}
				set {
					if (r_jfieldId == IntPtr.Zero)
						r_jfieldId = JNIEnv.GetFieldID (class_ref, "r", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, r_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$RGBAColor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RGBAColor); }
			}

			protected RGBAColor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getColor;
#pragma warning disable 0169
			static Delegate GetGetColorHandler ()
			{
				if (cb_getColor == null)
					cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
				return cb_getColor;
			}

			static int n_GetColor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.RGBAColor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.RGBAColor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Color;
			}
#pragma warning restore 0169

			static IntPtr id_getColor;
			public virtual unsafe int Color {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.RGBAColor']/method[@name='getColor' and count(parameter)=0]"
				[Register ("getColor", "()I", "GetGetColorHandler")]
				get {
					if (id_getColor == IntPtr.Zero)
						id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ResolveNodeRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$ResolveNodeRequest", DoNotGenerateAcw=true)]
		public partial class ResolveNodeRequest : global::Java.Lang.Object {


			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ResolveNodeRequest']/field[@name='nodeId']"
			[Register ("nodeId")]
			public int NodeId {
				get {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId);
				}
				set {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr objectGroup_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ResolveNodeRequest']/field[@name='objectGroup']"
			[Register ("objectGroup")]
			public string ObjectGroup {
				get {
					if (objectGroup_jfieldId == IntPtr.Zero)
						objectGroup_jfieldId = JNIEnv.GetFieldID (class_ref, "objectGroup", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, objectGroup_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (objectGroup_jfieldId == IntPtr.Zero)
						objectGroup_jfieldId = JNIEnv.GetFieldID (class_ref, "objectGroup", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, objectGroup_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$ResolveNodeRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResolveNodeRequest); }
			}

			protected ResolveNodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ResolveNodeResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$ResolveNodeResponse", DoNotGenerateAcw=true)]
		public partial class ResolveNodeResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr object_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.ResolveNodeResponse']/field[@name='object']"
			[Register ("object")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject Object {
				get {
					if (object_jfieldId == IntPtr.Zero)
						object_jfieldId = JNIEnv.GetFieldID (class_ref, "object", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, object_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (object_jfieldId == IntPtr.Zero)
						object_jfieldId = JNIEnv.GetFieldID (class_ref, "object", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, object_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$ResolveNodeResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResolveNodeResponse); }
			}

			protected ResolveNodeResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.SetAttributesAsTextRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$SetAttributesAsTextRequest", DoNotGenerateAcw=true)]
		public partial class SetAttributesAsTextRequest : global::Java.Lang.Object {


			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.SetAttributesAsTextRequest']/field[@name='nodeId']"
			[Register ("nodeId")]
			public int NodeId {
				get {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId);
				}
				set {
					if (nodeId_jfieldId == IntPtr.Zero)
						nodeId_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nodeId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.SetAttributesAsTextRequest']/field[@name='text']"
			[Register ("text")]
			public string Text {
				get {
					if (text_jfieldId == IntPtr.Zero)
						text_jfieldId = JNIEnv.GetFieldID (class_ref, "text", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, text_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (text_jfieldId == IntPtr.Zero)
						text_jfieldId = JNIEnv.GetFieldID (class_ref, "text", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, text_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$SetAttributesAsTextRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SetAttributesAsTextRequest); }
			}

			protected SetAttributesAsTextRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.SetInspectModeEnabledRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOM$SetInspectModeEnabledRequest", DoNotGenerateAcw=true)]
		public partial class SetInspectModeEnabledRequest : global::Java.Lang.Object {


			static IntPtr enabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.SetInspectModeEnabledRequest']/field[@name='enabled']"
			[Register ("enabled")]
			public bool Enabled {
				get {
					if (enabled_jfieldId == IntPtr.Zero)
						enabled_jfieldId = JNIEnv.GetFieldID (class_ref, "enabled", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enabled_jfieldId);
				}
				set {
					if (enabled_jfieldId == IntPtr.Zero)
						enabled_jfieldId = JNIEnv.GetFieldID (class_ref, "enabled", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enabled_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr highlightConfig_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.SetInspectModeEnabledRequest']/field[@name='highlightConfig']"
			[Register ("highlightConfig")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.HighlightConfig HighlightConfig {
				get {
					if (highlightConfig_jfieldId == IntPtr.Zero)
						highlightConfig_jfieldId = JNIEnv.GetFieldID (class_ref, "highlightConfig", "Lcom/facebook/stetho/inspector/protocol/module/DOM$HighlightConfig;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, highlightConfig_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM.HighlightConfig> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (highlightConfig_jfieldId == IntPtr.Zero)
						highlightConfig_jfieldId = JNIEnv.GetFieldID (class_ref, "highlightConfig", "Lcom/facebook/stetho/inspector/protocol/module/DOM$HighlightConfig;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, highlightConfig_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr inspectShadowDOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM.SetInspectModeEnabledRequest']/field[@name='inspectShadowDOM']"
			[Register ("inspectShadowDOM")]
			public global::Java.Lang.Boolean InspectShadowDOM {
				get {
					if (inspectShadowDOM_jfieldId == IntPtr.Zero)
						inspectShadowDOM_jfieldId = JNIEnv.GetFieldID (class_ref, "inspectShadowDOM", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, inspectShadowDOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (inspectShadowDOM_jfieldId == IntPtr.Zero)
						inspectShadowDOM_jfieldId = JNIEnv.GetFieldID (class_ref, "inspectShadowDOM", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, inspectShadowDOM_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM$SetInspectModeEnabledRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SetInspectModeEnabledRequest); }
			}

			protected SetInspectModeEnabledRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOM", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DOM); }
		}

		protected DOM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_elements_Document_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/constructor[@name='DOM' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.Document']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/elements/Document;)V", "")]
		public unsafe DOM (global::Com.Facebook.Stetho.Inspector.Elements.Document p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DOM)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/inspector/elements/Document;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/inspector/elements/Document;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_inspector_elements_Document_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_inspector_elements_Document_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/elements/Document;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_elements_Document_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_elements_Document_, __args);
			} finally {
			}
		}

		static Delegate cb_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetDisable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_Disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Disable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/method[@name='disable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("disable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetDisable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Disable (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "disable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_discardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetDiscardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_discardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_discardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DiscardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_discardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_DiscardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DiscardSearchResults (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_discardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/method[@name='discardSearchResults' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("discardSearchResults", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetDiscardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void DiscardSearchResults (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_discardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_discardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "discardSearchResults", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_discardSearchResults_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "discardSearchResults", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetEnable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_Enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/method[@name='enable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("enable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetEnable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Enable (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "enable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_getDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_getDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDocument (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/method[@name='getDocument' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getDocument", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetGetDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult GetDocument (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_getDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getDocument", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDocument_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocument", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetHideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_hideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_hideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_hideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_HideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HideHighlight (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_hideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/method[@name='hideHighlight' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("hideHighlight", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetHideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void HideHighlight (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_hideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_hideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "hideHighlight", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideHighlight_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideHighlight", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_highlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetHighlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_highlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_highlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HighlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_highlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_HighlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HighlightNode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_highlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/method[@name='highlightNode' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("highlightNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetHighlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void HighlightNode (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_highlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_highlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "highlightNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_highlightNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "highlightNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_setAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_setAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_SetAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAttributesAsText (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/method[@name='setAttributesAsText' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("setAttributesAsText", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetSetAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void SetAttributesAsText (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_setAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setAttributesAsText", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttributesAsText_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttributesAsText", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_setInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_setInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_SetInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetInspectModeEnabled (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOM']/method[@name='setInspectModeEnabled' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("setInspectModeEnabled", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetSetInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void SetInspectModeEnabled (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_setInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setInspectModeEnabled", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInspectModeEnabled_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInspectModeEnabled", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
