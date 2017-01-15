using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentView']"
	[Register ("com/facebook/stetho/inspector/elements/DocumentView", "", "Com.Facebook.Stetho.Inspector.Elements.IDocumentViewInvoker")]
	public partial interface IDocumentView : IJavaObject {

		global::Java.Lang.Object RootElement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentView']/method[@name='getRootElement' and count(parameter)=0]"
			[Register ("getRootElement", "()Ljava/lang/Object;", "GetGetRootElementHandler:Com.Facebook.Stetho.Inspector.Elements.IDocumentViewInvoker, StethoXamarin")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentView']/method[@name='getElementInfo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getElementInfo", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/ElementInfo;", "GetGetElementInfo_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.IDocumentViewInvoker, StethoXamarin")]
		global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo GetElementInfo (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/DocumentView", DoNotGenerateAcw=true)]
	internal class IDocumentViewInvoker : global::Java.Lang.Object, IDocumentView {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/DocumentView");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDocumentViewInvoker); }
		}

		IntPtr class_ref;

		public static IDocumentView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDocumentView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.elements.DocumentView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDocumentViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getElementInfo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetElementInfo_Ljava_lang_Object_Handler ()
		{
			if (cb_getElementInfo_Ljava_lang_Object_ == null)
				cb_getElementInfo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetElementInfo_Ljava_lang_Object_);
			return cb_getElementInfo_Ljava_lang_Object_;
		}

		static IntPtr n_GetElementInfo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetElementInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getElementInfo_Ljava_lang_Object_;
		public unsafe global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo GetElementInfo (global::Java.Lang.Object p0)
		{
			if (id_getElementInfo_Ljava_lang_Object_ == IntPtr.Zero)
				id_getElementInfo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getElementInfo", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/ElementInfo;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElementInfo_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
