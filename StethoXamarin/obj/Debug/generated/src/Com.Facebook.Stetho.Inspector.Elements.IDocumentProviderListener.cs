using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProviderListener']"
	[Register ("com/facebook/stetho/inspector/elements/DocumentProviderListener", "", "Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListenerInvoker")]
	public partial interface IDocumentProviderListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProviderListener']/method[@name='onAttributeModified' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onAttributeModified", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", "GetOnAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListenerInvoker, StethoXamarin")]
		void OnAttributeModified (global::Java.Lang.Object p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProviderListener']/method[@name='onAttributeRemoved' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAttributeRemoved", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetOnAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListenerInvoker, StethoXamarin")]
		void OnAttributeRemoved (global::Java.Lang.Object p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProviderListener']/method[@name='onInspectRequested' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onInspectRequested", "(Ljava/lang/Object;)V", "GetOnInspectRequested_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListenerInvoker, StethoXamarin")]
		void OnInspectRequested (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='DocumentProviderListener']/method[@name='onPossiblyChanged' and count(parameter)=0]"
		[Register ("onPossiblyChanged", "()V", "GetOnPossiblyChangedHandler:Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListenerInvoker, StethoXamarin")]
		void OnPossiblyChanged ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/DocumentProviderListener", DoNotGenerateAcw=true)]
	internal class IDocumentProviderListenerInvoker : global::Java.Lang.Object, IDocumentProviderListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/DocumentProviderListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDocumentProviderListenerInvoker); }
		}

		IntPtr class_ref;

		public static IDocumentProviderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDocumentProviderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.elements.DocumentProviderListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDocumentProviderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_);
			return cb_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAttributeModified (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnAttributeModified (global::Java.Lang.Object p0, string p1, string p2)
		{
			if (id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAttributeModified", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_);
			return cb_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_OnAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAttributeRemoved (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_;
		public unsafe void OnAttributeRemoved (global::Java.Lang.Object p0, string p1)
		{
			if (id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAttributeRemoved", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onInspectRequested_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnInspectRequested_Ljava_lang_Object_Handler ()
		{
			if (cb_onInspectRequested_Ljava_lang_Object_ == null)
				cb_onInspectRequested_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInspectRequested_Ljava_lang_Object_);
			return cb_onInspectRequested_Ljava_lang_Object_;
		}

		static void n_OnInspectRequested_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInspectRequested (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInspectRequested_Ljava_lang_Object_;
		public unsafe void OnInspectRequested (global::Java.Lang.Object p0)
		{
			if (id_onInspectRequested_Ljava_lang_Object_ == IntPtr.Zero)
				id_onInspectRequested_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onInspectRequested", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInspectRequested_Ljava_lang_Object_, __args);
		}

		static Delegate cb_onPossiblyChanged;
#pragma warning disable 0169
		static Delegate GetOnPossiblyChangedHandler ()
		{
			if (cb_onPossiblyChanged == null)
				cb_onPossiblyChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPossiblyChanged);
			return cb_onPossiblyChanged;
		}

		static void n_OnPossiblyChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPossiblyChanged ();
		}
#pragma warning restore 0169

		IntPtr id_onPossiblyChanged;
		public unsafe void OnPossiblyChanged ()
		{
			if (id_onPossiblyChanged == IntPtr.Zero)
				id_onPossiblyChanged = JNIEnv.GetMethodID (class_ref, "onPossiblyChanged", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPossiblyChanged);
		}

	}

	public partial class AttributeModifiedEventArgs : global::System.EventArgs {

		public AttributeModifiedEventArgs (global::Java.Lang.Object p0, string p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	public partial class AttributeRemovedEventArgs : global::System.EventArgs {

		public AttributeRemovedEventArgs (global::Java.Lang.Object p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class InspectRequestedEventArgs : global::System.EventArgs {

		public InspectRequestedEventArgs (global::Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/stetho/inspector/elements/DocumentProviderListenerImplementor")]
	internal sealed partial class IDocumentProviderListenerImplementor : global::Java.Lang.Object, IDocumentProviderListener {

		object sender;

		public IDocumentProviderListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/stetho/inspector/elements/DocumentProviderListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AttributeModifiedEventArgs> OnAttributeModifiedHandler;
#pragma warning restore 0649

		public void OnAttributeModified (global::Java.Lang.Object p0, string p1, string p2)
		{
			var __h = OnAttributeModifiedHandler;
			if (__h != null)
				__h (sender, new AttributeModifiedEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<AttributeRemovedEventArgs> OnAttributeRemovedHandler;
#pragma warning restore 0649

		public void OnAttributeRemoved (global::Java.Lang.Object p0, string p1)
		{
			var __h = OnAttributeRemovedHandler;
			if (__h != null)
				__h (sender, new AttributeRemovedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<InspectRequestedEventArgs> OnInspectRequestedHandler;
#pragma warning restore 0649

		public void OnInspectRequested (global::Java.Lang.Object p0)
		{
			var __h = OnInspectRequestedHandler;
			if (__h != null)
				__h (sender, new InspectRequestedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnPossiblyChangedHandler;
#pragma warning restore 0649

		public void OnPossiblyChanged ()
		{
			var __h = OnPossiblyChangedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IDocumentProviderListenerImplementor value)
		{
			return value.OnAttributeModifiedHandler == null && value.OnAttributeRemovedHandler == null && value.OnInspectRequestedHandler == null && value.OnPossiblyChangedHandler == null;
		}
	}

}
