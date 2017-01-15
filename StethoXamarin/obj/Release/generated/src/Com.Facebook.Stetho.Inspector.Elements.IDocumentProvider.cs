using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']"
	[Register ("com/facebook/stetho/inspector/elements/DocumentProvider", "", "Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker")]
	public partial interface IDocumentProvider : global::Com.Facebook.Stetho.Common.IThreadBound {

		global::Java.Lang.Object RootElement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']/method[@name='getRootElement' and count(parameter)=0]"
			[Register ("getRootElement", "()Ljava/lang/Object;", "GetGetRootElementHandler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker, StethoXamarin")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker, StethoXamarin")]
		void Dispose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']/method[@name='getNodeDescriptor' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getNodeDescriptor", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/NodeDescriptor;", "GetGetNodeDescriptor_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker, StethoXamarin")]
		global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor GetNodeDescriptor (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']/method[@name='hideHighlight' and count(parameter)=0]"
		[Register ("hideHighlight", "()V", "GetHideHighlightHandler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker, StethoXamarin")]
		void HideHighlight ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']/method[@name='highlightElement' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("highlightElement", "(Ljava/lang/Object;I)V", "GetHighlightElement_Ljava_lang_Object_IHandler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker, StethoXamarin")]
		void HighlightElement (global::Java.Lang.Object p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']/method[@name='setAttributesAsText' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAttributesAsText", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetSetAttributesAsText_Ljava_lang_Object_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker, StethoXamarin")]
		void SetAttributesAsText (global::Java.Lang.Object p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']/method[@name='setInspectModeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInspectModeEnabled", "(Z)V", "GetSetInspectModeEnabled_ZHandler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker, StethoXamarin")]
		void SetInspectModeEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProvider']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.DocumentProviderListener']]"
		[Register ("setListener", "(Lcom/facebook/stetho/inspector/elements/DocumentProviderListener;)V", "GetSetListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_Handler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderInvoker, StethoXamarin")]
		void SetListener (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/DocumentProvider", DoNotGenerateAcw=true)]
	internal class IDocumentProviderInvoker : global::Java.Lang.Object, IDocumentProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/DocumentProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDocumentProviderInvoker); }
		}

		IntPtr class_ref;

		public static IDocumentProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDocumentProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.elements.DocumentProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDocumentProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getRootElement;
#pragma warning disable 0169
		static Delegate GetGetRootElementHandler ()
		{
			if (cb_getRootElement == null)
				cb_getRootElement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRootElement);
			return cb_getRootElement;
		}

		static IntPtr n_GetRootElement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RootElement);
		}
#pragma warning restore 0169

		IntPtr id_getRootElement;
		public unsafe global::Java.Lang.Object RootElement {
			get {
				if (id_getRootElement == IntPtr.Zero)
					id_getRootElement = JNIEnv.GetMethodID (class_ref, "getRootElement", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRootElement), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		IntPtr id_dispose;
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
		}

		static Delegate cb_getNodeDescriptor_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetNodeDescriptor_Ljava_lang_Object_Handler ()
		{
			if (cb_getNodeDescriptor_Ljava_lang_Object_ == null)
				cb_getNodeDescriptor_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNodeDescriptor_Ljava_lang_Object_);
			return cb_getNodeDescriptor_Ljava_lang_Object_;
		}

		static IntPtr n_GetNodeDescriptor_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNodeDescriptor (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getNodeDescriptor_Ljava_lang_Object_;
		public unsafe global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor GetNodeDescriptor (global::Java.Lang.Object p0)
		{
			if (id_getNodeDescriptor_Ljava_lang_Object_ == IntPtr.Zero)
				id_getNodeDescriptor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getNodeDescriptor", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/NodeDescriptor;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNodeDescriptor_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_hideHighlight;
#pragma warning disable 0169
		static Delegate GetHideHighlightHandler ()
		{
			if (cb_hideHighlight == null)
				cb_hideHighlight = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideHighlight);
			return cb_hideHighlight;
		}

		static void n_HideHighlight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideHighlight ();
		}
#pragma warning restore 0169

		IntPtr id_hideHighlight;
		public unsafe void HideHighlight ()
		{
			if (id_hideHighlight == IntPtr.Zero)
				id_hideHighlight = JNIEnv.GetMethodID (class_ref, "hideHighlight", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideHighlight);
		}

		static Delegate cb_highlightElement_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetHighlightElement_Ljava_lang_Object_IHandler ()
		{
			if (cb_highlightElement_Ljava_lang_Object_I == null)
				cb_highlightElement_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_HighlightElement_Ljava_lang_Object_I);
			return cb_highlightElement_Ljava_lang_Object_I;
		}

		static void n_HighlightElement_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HighlightElement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_highlightElement_Ljava_lang_Object_I;
		public unsafe void HighlightElement (global::Java.Lang.Object p0, int p1)
		{
			if (id_highlightElement_Ljava_lang_Object_I == IntPtr.Zero)
				id_highlightElement_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "highlightElement", "(Ljava/lang/Object;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_highlightElement_Ljava_lang_Object_I, __args);
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
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_setInspectModeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetInspectModeEnabled_ZHandler ()
		{
			if (cb_setInspectModeEnabled_Z == null)
				cb_setInspectModeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInspectModeEnabled_Z);
			return cb_setInspectModeEnabled_Z;
		}

		static void n_SetInspectModeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInspectModeEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_setInspectModeEnabled_Z;
		public unsafe void SetInspectModeEnabled (bool p0)
		{
			if (id_setInspectModeEnabled_Z == IntPtr.Zero)
				id_setInspectModeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setInspectModeEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInspectModeEnabled_Z, __args);
		}

		static Delegate cb_setListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_Handler ()
		{
			if (cb_setListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_ == null)
				cb_setListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_);
			return cb_setListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_;
		}

		static void n_SetListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener p0 = (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_;
		public unsafe void SetListener (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener p0)
		{
			if (id_setListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_ == IntPtr.Zero)
				id_setListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/facebook/stetho/inspector/elements/DocumentProviderListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_facebook_stetho_inspector_elements_DocumentProviderListener_, __args);
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
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
