using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']"
	[Register ("com/facebook/stetho/inspector/elements/NodeDescriptor", "", "Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker")]
	public partial interface INodeDescriptor : global::Com.Facebook.Stetho.Common.IThreadBound {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='getAccessibilityStyles' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.facebook.stetho.inspector.elements.StyleAccumulator']]"
		[Register ("getAccessibilityStyles", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/StyleAccumulator;)V", "GetGetAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		void GetAccessibilityStyles (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='getAttributes' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.facebook.stetho.inspector.elements.AttributeAccumulator']]"
		[Register ("getAttributes", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/AttributeAccumulator;)V", "GetGetAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		void GetAttributes (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulator p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='getChildren' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.facebook.stetho.common.Accumulator&lt;java.lang.Object&gt;']]"
		[Register ("getChildren", "(Ljava/lang/Object;Lcom/facebook/stetho/common/Accumulator;)V", "GetGetChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		void GetChildren (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Common.IAccumulator p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='getLocalName' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getLocalName", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetLocalName_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		string GetLocalName (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='getNodeName' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getNodeName", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetNodeName_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		string GetNodeName (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='getNodeType' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getNodeType", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/NodeType;", "GetGetNodeType_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		global::Com.Facebook.Stetho.Inspector.Elements.NodeType GetNodeType (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='getNodeValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getNodeValue", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetNodeValue_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		string GetNodeValue (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='getStyles' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.facebook.stetho.inspector.elements.StyleAccumulator']]"
		[Register ("getStyles", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/StyleAccumulator;)V", "GetGetStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		void GetStyles (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='hook' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("hook", "(Ljava/lang/Object;)V", "GetHook_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		void Hook (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='setAttributesAsText' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAttributesAsText", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetSetAttributesAsText_Ljava_lang_Object_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		void SetAttributesAsText (global::Java.Lang.Object p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='NodeDescriptor']/method[@name='unhook' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("unhook", "(Ljava/lang/Object;)V", "GetUnhook_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.INodeDescriptorInvoker, StethoXamarin")]
		void Unhook (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/NodeDescriptor", DoNotGenerateAcw=true)]
	internal class INodeDescriptorInvoker : global::Java.Lang.Object, INodeDescriptor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/NodeDescriptor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INodeDescriptorInvoker); }
		}

		IntPtr class_ref;

		public static INodeDescriptor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INodeDescriptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.elements.NodeDescriptor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INodeDescriptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_;
#pragma warning disable 0169
		static Delegate GetGetAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_Handler ()
		{
			if (cb_getAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ == null)
				cb_getAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_);
			return cb_getAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_;
		}

		static void n_GetAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator p1 = (global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetAccessibilityStyles (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_;
		public unsafe void GetAccessibilityStyles (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator p1)
		{
			if (id_getAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ == IntPtr.Zero)
				id_getAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ = JNIEnv.GetMethodID (class_ref, "getAccessibilityStyles", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/StyleAccumulator;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_, __args);
		}

		static Delegate cb_getAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_;
#pragma warning disable 0169
		static Delegate GetGetAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_Handler ()
		{
			if (cb_getAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_ == null)
				cb_getAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_);
			return cb_getAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_;
		}

		static void n_GetAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulator p1 = (global::Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulator)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulator> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetAttributes (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_;
		public unsafe void GetAttributes (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulator p1)
		{
			if (id_getAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_ == IntPtr.Zero)
				id_getAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_ = JNIEnv.GetMethodID (class_ref, "getAttributes", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/AttributeAccumulator;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAttributes_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_AttributeAccumulator_, __args);
		}

		static Delegate cb_getChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_;
#pragma warning disable 0169
		static Delegate GetGetChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_Handler ()
		{
			if (cb_getChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_ == null)
				cb_getChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_);
			return cb_getChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_;
		}

		static void n_GetChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Common.IAccumulator p1 = (global::Com.Facebook.Stetho.Common.IAccumulator)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IAccumulator> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetChildren (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_;
		public unsafe void GetChildren (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Common.IAccumulator p1)
		{
			if (id_getChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_ == IntPtr.Zero)
				id_getChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_ = JNIEnv.GetMethodID (class_ref, "getChildren", "(Ljava/lang/Object;Lcom/facebook/stetho/common/Accumulator;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getChildren_Ljava_lang_Object_Lcom_facebook_stetho_common_Accumulator_, __args);
		}

		static Delegate cb_getLocalName_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetLocalName_Ljava_lang_Object_Handler ()
		{
			if (cb_getLocalName_Ljava_lang_Object_ == null)
				cb_getLocalName_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLocalName_Ljava_lang_Object_);
			return cb_getLocalName_Ljava_lang_Object_;
		}

		static IntPtr n_GetLocalName_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLocalName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLocalName_Ljava_lang_Object_;
		public unsafe string GetLocalName (global::Java.Lang.Object p0)
		{
			if (id_getLocalName_Ljava_lang_Object_ == IntPtr.Zero)
				id_getLocalName_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getLocalName", "(Ljava/lang/Object;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalName_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getNodeName_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetNodeName_Ljava_lang_Object_Handler ()
		{
			if (cb_getNodeName_Ljava_lang_Object_ == null)
				cb_getNodeName_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNodeName_Ljava_lang_Object_);
			return cb_getNodeName_Ljava_lang_Object_;
		}

		static IntPtr n_GetNodeName_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetNodeName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getNodeName_Ljava_lang_Object_;
		public unsafe string GetNodeName (global::Java.Lang.Object p0)
		{
			if (id_getNodeName_Ljava_lang_Object_ == IntPtr.Zero)
				id_getNodeName_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getNodeName", "(Ljava/lang/Object;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNodeName_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getNodeType_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetNodeType_Ljava_lang_Object_Handler ()
		{
			if (cb_getNodeType_Ljava_lang_Object_ == null)
				cb_getNodeType_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNodeType_Ljava_lang_Object_);
			return cb_getNodeType_Ljava_lang_Object_;
		}

		static IntPtr n_GetNodeType_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNodeType (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getNodeType_Ljava_lang_Object_;
		public unsafe global::Com.Facebook.Stetho.Inspector.Elements.NodeType GetNodeType (global::Java.Lang.Object p0)
		{
			if (id_getNodeType_Ljava_lang_Object_ == IntPtr.Zero)
				id_getNodeType_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getNodeType", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/NodeType;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Facebook.Stetho.Inspector.Elements.NodeType __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.NodeType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNodeType_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getNodeValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetNodeValue_Ljava_lang_Object_Handler ()
		{
			if (cb_getNodeValue_Ljava_lang_Object_ == null)
				cb_getNodeValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNodeValue_Ljava_lang_Object_);
			return cb_getNodeValue_Ljava_lang_Object_;
		}

		static IntPtr n_GetNodeValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetNodeValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getNodeValue_Ljava_lang_Object_;
		public unsafe string GetNodeValue (global::Java.Lang.Object p0)
		{
			if (id_getNodeValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_getNodeValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getNodeValue", "(Ljava/lang/Object;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNodeValue_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_;
#pragma warning disable 0169
		static Delegate GetGetStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_Handler ()
		{
			if (cb_getStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ == null)
				cb_getStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_);
			return cb_getStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_;
		}

		static void n_GetStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator p1 = (global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetStyles (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_;
		public unsafe void GetStyles (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator p1)
		{
			if (id_getStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ == IntPtr.Zero)
				id_getStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ = JNIEnv.GetMethodID (class_ref, "getStyles", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/StyleAccumulator;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_, __args);
		}

		static Delegate cb_hook_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetHook_Ljava_lang_Object_Handler ()
		{
			if (cb_hook_Ljava_lang_Object_ == null)
				cb_hook_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Hook_Ljava_lang_Object_);
			return cb_hook_Ljava_lang_Object_;
		}

		static void n_Hook_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Hook (p0);
		}
#pragma warning restore 0169

		IntPtr id_hook_Ljava_lang_Object_;
		public unsafe void Hook (global::Java.Lang.Object p0)
		{
			if (id_hook_Ljava_lang_Object_ == IntPtr.Zero)
				id_hook_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "hook", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hook_Ljava_lang_Object_, __args);
		}

		static Delegate cb_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAttributesAsText_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAttributesAsText_Ljava_lang_Object_Ljava_lang_String_);
			return cb_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_SetAttributesAsText_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAttributesAsText (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_;
		public unsafe void SetAttributesAsText (global::Java.Lang.Object p0, string p1)
		{
			if (id_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAttributesAsText", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_unhook_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUnhook_Ljava_lang_Object_Handler ()
		{
			if (cb_unhook_Ljava_lang_Object_ == null)
				cb_unhook_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unhook_Ljava_lang_Object_);
			return cb_unhook_Ljava_lang_Object_;
		}

		static void n_Unhook_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Unhook (p0);
		}
#pragma warning restore 0169

		IntPtr id_unhook_Ljava_lang_Object_;
		public unsafe void Unhook (global::Java.Lang.Object p0)
		{
			if (id_unhook_Ljava_lang_Object_ == IntPtr.Zero)
				id_unhook_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "unhook", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unhook_Ljava_lang_Object_, __args);
		}

		static Delegate cb_checkThreadAccess;
#pragma warning disable 0169
		static Delegate GetCheckThreadAccessHandler ()
		{
			if (cb_checkThreadAccess == null)
				cb_checkThreadAccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckThreadAccess);
			return cb_checkThreadAccess;
		}

		static bool n_CheckThreadAccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckThreadAccess ();
		}
#pragma warning restore 0169

		IntPtr id_checkThreadAccess;
		public unsafe bool CheckThreadAccess ()
		{
			if (id_checkThreadAccess == IntPtr.Zero)
				id_checkThreadAccess = JNIEnv.GetMethodID (class_ref, "checkThreadAccess", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkThreadAccess);
		}

		static Delegate cb_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_;
#pragma warning disable 0169
		static Delegate GetPostAndWait_Lcom_facebook_stetho_common_UncheckedCallable_Handler ()
		{
			if (cb_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ == null)
				cb_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostAndWait_Lcom_facebook_stetho_common_UncheckedCallable_);
			return cb_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_;
		}

		static IntPtr n_PostAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Common.IUncheckedCallable p0 = (global::Com.Facebook.Stetho.Common.IUncheckedCallable)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IUncheckedCallable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostAndWait (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_;
		public unsafe global::Java.Lang.Object PostAndWait (global::Com.Facebook.Stetho.Common.IUncheckedCallable p0)
		{
			if (id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ == IntPtr.Zero)
				id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_ = JNIEnv.GetMethodID (class_ref, "postAndWait", "(Lcom/facebook/stetho/common/UncheckedCallable;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postAndWait_Lcom_facebook_stetho_common_UncheckedCallable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_postAndWait_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetPostAndWait_Ljava_lang_Runnable_Handler ()
		{
			if (cb_postAndWait_Ljava_lang_Runnable_ == null)
				cb_postAndWait_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostAndWait_Ljava_lang_Runnable_);
			return cb_postAndWait_Ljava_lang_Runnable_;
		}

		static void n_PostAndWait_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostAndWait (p0);
		}
#pragma warning restore 0169

		IntPtr id_postAndWait_Ljava_lang_Runnable_;
		public unsafe void PostAndWait (global::Java.Lang.IRunnable p0)
		{
			if (id_postAndWait_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postAndWait_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "postAndWait", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postAndWait_Ljava_lang_Runnable_, __args);
		}

		static Delegate cb_postDelayed_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetPostDelayed_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_postDelayed_Ljava_lang_Runnable_J == null)
				cb_postDelayed_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_PostDelayed_Ljava_lang_Runnable_J);
			return cb_postDelayed_Ljava_lang_Runnable_J;
		}

		static void n_PostDelayed_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostDelayed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_postDelayed_Ljava_lang_Runnable_J;
		public unsafe void PostDelayed (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_postDelayed_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_postDelayed_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "postDelayed", "(Ljava/lang/Runnable;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postDelayed_Ljava_lang_Runnable_J, __args);
		}

		static Delegate cb_removeCallbacks_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRemoveCallbacks_Ljava_lang_Runnable_Handler ()
		{
			if (cb_removeCallbacks_Ljava_lang_Runnable_ == null)
				cb_removeCallbacks_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCallbacks_Ljava_lang_Runnable_);
			return cb_removeCallbacks_Ljava_lang_Runnable_;
		}

		static void n_RemoveCallbacks_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallbacks (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeCallbacks_Ljava_lang_Runnable_;
		public unsafe void RemoveCallbacks (global::Java.Lang.IRunnable p0)
		{
			if (id_removeCallbacks_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_removeCallbacks_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "removeCallbacks", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallbacks_Ljava_lang_Runnable_, __args);
		}

		static Delegate cb_verifyThreadAccess;
#pragma warning disable 0169
		static Delegate GetVerifyThreadAccessHandler ()
		{
			if (cb_verifyThreadAccess == null)
				cb_verifyThreadAccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VerifyThreadAccess);
			return cb_verifyThreadAccess;
		}

		static void n_VerifyThreadAccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VerifyThreadAccess ();
		}
#pragma warning restore 0169

		IntPtr id_verifyThreadAccess;
		public unsafe void VerifyThreadAccess ()
		{
			if (id_verifyThreadAccess == IntPtr.Zero)
				id_verifyThreadAccess = JNIEnv.GetMethodID (class_ref, "verifyThreadAccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verifyThreadAccess);
		}

	}

}
