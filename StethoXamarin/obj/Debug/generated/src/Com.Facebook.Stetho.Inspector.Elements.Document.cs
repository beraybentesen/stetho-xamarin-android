using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/Document", DoNotGenerateAcw=true)]
	public sealed partial class Document : global::Com.Facebook.Stetho.Inspector.Helper.ThreadBoundProxy {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.AttributeListAccumulator']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/Document$AttributeListAccumulator", DoNotGenerateAcw=true)]
		public sealed partial class AttributeListAccumulator : global::Java.Util.ArrayList, global::Com.Facebook.Stetho.Inspector.Elements.IAttributeAccumulator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/Document$AttributeListAccumulator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AttributeListAccumulator); }
			}

			internal AttributeListAccumulator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.AttributeListAccumulator']/constructor[@name='Document.AttributeListAccumulator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AttributeListAccumulator ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (AttributeListAccumulator)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static IntPtr id_store_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.AttributeListAccumulator']/method[@name='store' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("store", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe void Store (string p0, string p1)
			{
				if (id_store_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_store_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "store", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_store_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ChildEventingList']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/Document$ChildEventingList", DoNotGenerateAcw=true)]
		public sealed partial class ChildEventingList : global::Java.Util.ArrayList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/Document$ChildEventingList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ChildEventingList); }
			}

			internal ChildEventingList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_acquire_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_DocumentView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ChildEventingList']/method[@name='acquire' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.facebook.stetho.inspector.elements.DocumentView']]"
			[Register ("acquire", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/DocumentView;)V", "")]
			public unsafe void Acquire (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p1)
			{
				if (id_acquire_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_DocumentView_ == IntPtr.Zero)
					id_acquire_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_DocumentView_ = JNIEnv.GetMethodID (class_ref, "acquire", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/DocumentView;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquire_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_DocumentView_, __args);
				} finally {
				}
			}

			static IntPtr id_addWithEvent_ILjava_lang_Object_Lcom_facebook_stetho_common_Accumulator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ChildEventingList']/method[@name='addWithEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.facebook.stetho.common.Accumulator&lt;java.lang.Object&gt;']]"
			[Register ("addWithEvent", "(ILjava/lang/Object;Lcom/facebook/stetho/common/Accumulator;)V", "")]
			public unsafe void AddWithEvent (int p0, global::Java.Lang.Object p1, global::Com.Facebook.Stetho.Common.IAccumulator p2)
			{
				if (id_addWithEvent_ILjava_lang_Object_Lcom_facebook_stetho_common_Accumulator_ == IntPtr.Zero)
					id_addWithEvent_ILjava_lang_Object_Lcom_facebook_stetho_common_Accumulator_ = JNIEnv.GetMethodID (class_ref, "addWithEvent", "(ILjava/lang/Object;Lcom/facebook/stetho/common/Accumulator;)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addWithEvent_ILjava_lang_Object_Lcom_facebook_stetho_common_Accumulator_, __args);
				} finally {
				}
			}

			static IntPtr id_release;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ChildEventingList']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "")]
			public unsafe void Release ()
			{
				if (id_release == IntPtr.Zero)
					id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				} finally {
				}
			}

			static IntPtr id_removeWithEvent_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ChildEventingList']/method[@name='removeWithEvent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("removeWithEvent", "(I)V", "")]
			public unsafe void RemoveWithEvent (int p0)
			{
				if (id_removeWithEvent_I == IntPtr.Zero)
					id_removeWithEvent_I = JNIEnv.GetMethodID (class_ref, "removeWithEvent", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeWithEvent_I, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.DocumentObjectIdMapper']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/Document$DocumentObjectIdMapper", DoNotGenerateAcw=true)]
		public sealed partial class DocumentObjectIdMapper : global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper {

			internal DocumentObjectIdMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ProviderListener']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/Document$ProviderListener", DoNotGenerateAcw=true)]
		public sealed partial class ProviderListener : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/Document$ProviderListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProviderListener); }
			}

			internal ProviderListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ProviderListener']/method[@name='onAttributeModified' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ProviderListener']/method[@name='onAttributeRemoved' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
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

			static IntPtr id_onInspectRequested_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ProviderListener']/method[@name='onInspectRequested' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

			static IntPtr id_onPossiblyChanged;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.ProviderListener']/method[@name='onPossiblyChanged' and count(parameter)=0]"
			[Register ("onPossiblyChanged", "()V", "")]
			public unsafe void OnPossiblyChanged ()
			{
				if (id_onPossiblyChanged == IntPtr.Zero)
					id_onPossiblyChanged = JNIEnv.GetMethodID (class_ref, "onPossiblyChanged", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPossiblyChanged);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='Document.UpdateListener']"
		[Register ("com/facebook/stetho/inspector/elements/Document$UpdateListener", "", "Com.Facebook.Stetho.Inspector.Elements.Document/IUpdateListenerInvoker")]
		public partial interface IUpdateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='Document.UpdateListener']/method[@name='onAttributeModified' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("onAttributeModified", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", "GetOnAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Elements.Document/IUpdateListenerInvoker, StethoXamarin")]
			void OnAttributeModified (global::Java.Lang.Object p0, string p1, string p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='Document.UpdateListener']/method[@name='onAttributeRemoved' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
			[Register ("onAttributeRemoved", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetOnAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Elements.Document/IUpdateListenerInvoker, StethoXamarin")]
			void OnAttributeRemoved (global::Java.Lang.Object p0, string p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='Document.UpdateListener']/method[@name='onChildNodeInserted' and count(parameter)=5 and parameter[1][@type='com.facebook.stetho.inspector.elements.DocumentView'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.facebook.stetho.common.Accumulator&lt;java.lang.Object&gt;']]"
			[Register ("onChildNodeInserted", "(Lcom/facebook/stetho/inspector/elements/DocumentView;Ljava/lang/Object;IILcom/facebook/stetho/common/Accumulator;)V", "GetOnChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_Handler:Com.Facebook.Stetho.Inspector.Elements.Document/IUpdateListenerInvoker, StethoXamarin")]
			void OnChildNodeInserted (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0, global::Java.Lang.Object p1, int p2, int p3, global::Com.Facebook.Stetho.Common.IAccumulator p4);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='Document.UpdateListener']/method[@name='onChildNodeRemoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onChildNodeRemoved", "(II)V", "GetOnChildNodeRemoved_IIHandler:Com.Facebook.Stetho.Inspector.Elements.Document/IUpdateListenerInvoker, StethoXamarin")]
			void OnChildNodeRemoved (int p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/interface[@name='Document.UpdateListener']/method[@name='onInspectRequested' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("onInspectRequested", "(Ljava/lang/Object;)V", "GetOnInspectRequested_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Inspector.Elements.Document/IUpdateListenerInvoker, StethoXamarin")]
			void OnInspectRequested (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/Document$UpdateListener", DoNotGenerateAcw=true)]
		internal class IUpdateListenerInvoker : global::Java.Lang.Object, IUpdateListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/Document$UpdateListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IUpdateListenerInvoker); }
			}

			IntPtr class_ref;

			public static IUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.elements.Document.UpdateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_;
#pragma warning disable 0169
			static Delegate GetOnChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_Handler ()
			{
				if (cb_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ == null)
					cb_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_OnChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_);
				return cb_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_;
			}

			static void n_OnChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, IntPtr native_p4)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0 = (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Common.IAccumulator p4 = (global::Com.Facebook.Stetho.Common.IAccumulator)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IAccumulator> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnChildNodeInserted (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_;
			public unsafe void OnChildNodeInserted (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0, global::Java.Lang.Object p1, int p2, int p3, global::Com.Facebook.Stetho.Common.IAccumulator p4)
			{
				if (id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ == IntPtr.Zero)
					id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ = JNIEnv.GetMethodID (class_ref, "onChildNodeInserted", "(Lcom/facebook/stetho/inspector/elements/DocumentView;Ljava/lang/Object;IILcom/facebook/stetho/common/Accumulator;)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_, __args);
			}

			static Delegate cb_onChildNodeRemoved_II;
#pragma warning disable 0169
			static Delegate GetOnChildNodeRemoved_IIHandler ()
			{
				if (cb_onChildNodeRemoved_II == null)
					cb_onChildNodeRemoved_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnChildNodeRemoved_II);
				return cb_onChildNodeRemoved_II;
			}

			static void n_OnChildNodeRemoved_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnChildNodeRemoved (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onChildNodeRemoved_II;
			public unsafe void OnChildNodeRemoved (int p0, int p1)
			{
				if (id_onChildNodeRemoved_II == IntPtr.Zero)
					id_onChildNodeRemoved_II = JNIEnv.GetMethodID (class_ref, "onChildNodeRemoved", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChildNodeRemoved_II, __args);
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
				global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		public partial class ChildNodeInsertedEventArgs : global::System.EventArgs {

			public ChildNodeInsertedEventArgs (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0, global::Java.Lang.Object p1, int p2, int p3, global::Com.Facebook.Stetho.Common.IAccumulator p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0;
			public global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}

			global::Com.Facebook.Stetho.Common.IAccumulator p4;
			public global::Com.Facebook.Stetho.Common.IAccumulator P4 {
				get { return p4; }
			}
		}

		public partial class ChildNodeRemovedEventArgs : global::System.EventArgs {

			public ChildNodeRemovedEventArgs (int p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
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

		[global::Android.Runtime.Register ("mono/com/facebook/stetho/inspector/elements/Document_UpdateListenerImplementor")]
		internal sealed partial class IUpdateListenerImplementor : global::Java.Lang.Object, IUpdateListener {

			object sender;

			public IUpdateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/stetho/inspector/elements/Document_UpdateListenerImplementor", "()V"),
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
			public EventHandler<ChildNodeInsertedEventArgs> OnChildNodeInsertedHandler;
#pragma warning restore 0649

			public void OnChildNodeInserted (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0, global::Java.Lang.Object p1, int p2, int p3, global::Com.Facebook.Stetho.Common.IAccumulator p4)
			{
				var __h = OnChildNodeInsertedHandler;
				if (__h != null)
					__h (sender, new ChildNodeInsertedEventArgs (p0, p1, p2, p3, p4));
			}
#pragma warning disable 0649
			public EventHandler<ChildNodeRemovedEventArgs> OnChildNodeRemovedHandler;
#pragma warning restore 0649

			public void OnChildNodeRemoved (int p0, int p1)
			{
				var __h = OnChildNodeRemovedHandler;
				if (__h != null)
					__h (sender, new ChildNodeRemovedEventArgs (p0, p1));
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

			internal static bool __IsEmpty (IUpdateListenerImplementor value)
			{
				return value.OnAttributeModifiedHandler == null && value.OnAttributeRemovedHandler == null && value.OnChildNodeInsertedHandler == null && value.OnChildNodeRemovedHandler == null && value.OnInspectRequestedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/Document$UpdateListenerCollection", DoNotGenerateAcw=true)]
		public partial class UpdateListenerCollection : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/Document$UpdateListenerCollection", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateListenerCollection); }
			}

			protected UpdateListenerCollection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_stetho_inspector_elements_Document_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/constructor[@name='Document.UpdateListenerCollection' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.Document']]"
			[Register (".ctor", "(Lcom/facebook/stetho/inspector/elements/Document;)V", "")]
			public unsafe UpdateListenerCollection (global::Com.Facebook.Stetho.Inspector.Elements.Document __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (UpdateListenerCollection)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
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

			static Delegate cb_add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_;
#pragma warning disable 0169
			static Delegate GetAdd_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_Handler ()
			{
				if (cb_add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ == null)
					cb_add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_);
				return cb_add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_;
			}

			static void n_Add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener p0 = (global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0);
			}
#pragma warning restore 0169

			static IntPtr id_add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.Document.UpdateListener']]"
			[Register ("add", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V", "GetAdd_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_Handler")]
			public virtual unsafe void Add (global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener p0)
			{
				if (id_add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ == IntPtr.Zero)
					id_add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_clear;
#pragma warning disable 0169
			static Delegate GetClearHandler ()
			{
				if (cb_clear == null)
					cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
				return cb_clear;
			}

			static void n_Clear (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			static IntPtr id_clear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public virtual unsafe void Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
				} finally {
				}
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
				global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnAttributeModified (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/method[@name='onAttributeModified' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("onAttributeModified", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", "GetOnAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void OnAttributeModified (global::Java.Lang.Object p0, string p1, string p2)
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

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttributeModified_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAttributeModified", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
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
				global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnAttributeRemoved (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/method[@name='onAttributeRemoved' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
			[Register ("onAttributeRemoved", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetOnAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_Handler")]
			public virtual unsafe void OnAttributeRemoved (global::Java.Lang.Object p0, string p1)
			{
				if (id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
					id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAttributeRemoved", "(Ljava/lang/Object;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttributeRemoved_Ljava_lang_Object_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAttributeRemoved", "(Ljava/lang/Object;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_;
#pragma warning disable 0169
			static Delegate GetOnChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_Handler ()
			{
				if (cb_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ == null)
					cb_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_OnChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_);
				return cb_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_;
			}

			static void n_OnChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, IntPtr native_p4)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0 = (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Common.IAccumulator p4 = (global::Com.Facebook.Stetho.Common.IAccumulator)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.IAccumulator> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnChildNodeInserted (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			static IntPtr id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/method[@name='onChildNodeInserted' and count(parameter)=5 and parameter[1][@type='com.facebook.stetho.inspector.elements.DocumentView'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.facebook.stetho.common.Accumulator&lt;java.lang.Object&gt;']]"
			[Register ("onChildNodeInserted", "(Lcom/facebook/stetho/inspector/elements/DocumentView;Ljava/lang/Object;IILcom/facebook/stetho/common/Accumulator;)V", "GetOnChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_Handler")]
			public virtual unsafe void OnChildNodeInserted (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView p0, global::Java.Lang.Object p1, int p2, int p3, global::Com.Facebook.Stetho.Common.IAccumulator p4)
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

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChildNodeInserted_Lcom_facebook_stetho_inspector_elements_DocumentView_Ljava_lang_Object_IILcom_facebook_stetho_common_Accumulator_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onChildNodeInserted", "(Lcom/facebook/stetho/inspector/elements/DocumentView;Ljava/lang/Object;IILcom/facebook/stetho/common/Accumulator;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onChildNodeRemoved_II;
#pragma warning disable 0169
			static Delegate GetOnChildNodeRemoved_IIHandler ()
			{
				if (cb_onChildNodeRemoved_II == null)
					cb_onChildNodeRemoved_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnChildNodeRemoved_II);
				return cb_onChildNodeRemoved_II;
			}

			static void n_OnChildNodeRemoved_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnChildNodeRemoved (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onChildNodeRemoved_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/method[@name='onChildNodeRemoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onChildNodeRemoved", "(II)V", "GetOnChildNodeRemoved_IIHandler")]
			public virtual unsafe void OnChildNodeRemoved (int p0, int p1)
			{
				if (id_onChildNodeRemoved_II == IntPtr.Zero)
					id_onChildNodeRemoved_II = JNIEnv.GetMethodID (class_ref, "onChildNodeRemoved", "(II)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChildNodeRemoved_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onChildNodeRemoved", "(II)V"), __args);
				} finally {
				}
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
				global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInspectRequested (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onInspectRequested_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/method[@name='onInspectRequested' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("onInspectRequested", "(Ljava/lang/Object;)V", "GetOnInspectRequested_Ljava_lang_Object_Handler")]
			public virtual unsafe void OnInspectRequested (global::Java.Lang.Object p0)
			{
				if (id_onInspectRequested_Ljava_lang_Object_ == IntPtr.Zero)
					id_onInspectRequested_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onInspectRequested", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInspectRequested_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInspectRequested", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_;
#pragma warning disable 0169
			static Delegate GetRemove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_Handler ()
			{
				if (cb_remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ == null)
					cb_remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_);
				return cb_remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_;
			}

			static void n_Remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.UpdateListenerCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener p0 = (global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Remove (p0);
			}
#pragma warning restore 0169

			static IntPtr id_remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document.UpdateListenerCollection']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.Document.UpdateListener']]"
			[Register ("remove", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V", "GetRemove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_Handler")]
			public virtual unsafe void Remove (global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener p0)
			{
				if (id_remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ == IntPtr.Zero)
					id_remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/Document", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Document); }
		}

		internal Document (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/constructor[@name='Document' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.DocumentProviderFactory']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/elements/DocumentProviderFactory;)V", "")]
		public unsafe Document (global::Com.Facebook.Stetho.Inspector.Elements.IDocumentProviderFactory p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Document)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/inspector/elements/DocumentProviderFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/inspector/elements/DocumentProviderFactory;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/elements/DocumentProviderFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_elements_DocumentProviderFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_getDocumentView;
		public unsafe global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView DocumentView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='getDocumentView' and count(parameter)=0]"
			[Register ("getDocumentView", "()Lcom/facebook/stetho/inspector/elements/DocumentView;", "GetGetDocumentViewHandler")]
			get {
				if (id_getDocumentView == IntPtr.Zero)
					id_getDocumentView = JNIEnv.GetMethodID (class_ref, "getDocumentView", "()Lcom/facebook/stetho/inspector/elements/DocumentView;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDocumentView), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRootElement;
		public unsafe global::Java.Lang.Object RootElement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='getRootElement' and count(parameter)=0]"
			[Register ("getRootElement", "()Ljava/lang/Object;", "GetGetRootElementHandler")]
			get {
				if (id_getRootElement == IntPtr.Zero)
					id_getRootElement = JNIEnv.GetMethodID (class_ref, "getRootElement", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRootElement), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addRef;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='addRef' and count(parameter)=0]"
		[Register ("addRef", "()V", "")]
		public unsafe void AddRef ()
		{
			if (id_addRef == IntPtr.Zero)
				id_addRef = JNIEnv.GetMethodID (class_ref, "addRef", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRef);
			} finally {
			}
		}

		static IntPtr id_addUpdateListener_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='addUpdateListener' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.Document.UpdateListener']]"
		[Register ("addUpdateListener", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V", "")]
		public unsafe void AddUpdateListener (global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener p0)
		{
			if (id_addUpdateListener_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ == IntPtr.Zero)
				id_addUpdateListener_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ = JNIEnv.GetMethodID (class_ref, "addUpdateListener", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addUpdateListener_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_, __args);
			} finally {
			}
		}

		static IntPtr id_findMatchingElements_Ljava_lang_String_Lcom_facebook_stetho_common_Accumulator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='findMatchingElements' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.facebook.stetho.common.Accumulator&lt;java.lang.Integer&gt;']]"
		[Register ("findMatchingElements", "(Ljava/lang/String;Lcom/facebook/stetho/common/Accumulator;)V", "")]
		public unsafe void FindMatchingElements (string p0, global::Com.Facebook.Stetho.Common.IAccumulator p1)
		{
			if (id_findMatchingElements_Ljava_lang_String_Lcom_facebook_stetho_common_Accumulator_ == IntPtr.Zero)
				id_findMatchingElements_Ljava_lang_String_Lcom_facebook_stetho_common_Accumulator_ = JNIEnv.GetMethodID (class_ref, "findMatchingElements", "(Ljava/lang/String;Lcom/facebook/stetho/common/Accumulator;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_findMatchingElements_Ljava_lang_String_Lcom_facebook_stetho_common_Accumulator_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getElementAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='getElementAccessibilityStyles' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.facebook.stetho.inspector.elements.StyleAccumulator']]"
		[Register ("getElementAccessibilityStyles", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/StyleAccumulator;)V", "")]
		public unsafe void GetElementAccessibilityStyles (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator p1)
		{
			if (id_getElementAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ == IntPtr.Zero)
				id_getElementAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ = JNIEnv.GetMethodID (class_ref, "getElementAccessibilityStyles", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/StyleAccumulator;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getElementAccessibilityStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_, __args);
			} finally {
			}
		}

		static IntPtr id_getElementForNodeId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='getElementForNodeId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getElementForNodeId", "(I)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object GetElementForNodeId (int p0)
		{
			if (id_getElementForNodeId_I == IntPtr.Zero)
				id_getElementForNodeId_I = JNIEnv.GetMethodID (class_ref, "getElementForNodeId", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElementForNodeId_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getElementStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='getElementStyles' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.facebook.stetho.inspector.elements.StyleAccumulator']]"
		[Register ("getElementStyles", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/StyleAccumulator;)V", "")]
		public unsafe void GetElementStyles (global::Java.Lang.Object p0, global::Com.Facebook.Stetho.Inspector.Elements.IStyleAccumulator p1)
		{
			if (id_getElementStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ == IntPtr.Zero)
				id_getElementStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_ = JNIEnv.GetMethodID (class_ref, "getElementStyles", "(Ljava/lang/Object;Lcom/facebook/stetho/inspector/elements/StyleAccumulator;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getElementStyles_Ljava_lang_Object_Lcom_facebook_stetho_inspector_elements_StyleAccumulator_, __args);
			} finally {
			}
		}

		static IntPtr id_getNodeDescriptor_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='getNodeDescriptor' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getNodeDescriptor", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/NodeDescriptor;", "")]
		public unsafe global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor GetNodeDescriptor (global::Java.Lang.Object p0)
		{
			if (id_getNodeDescriptor_Ljava_lang_Object_ == IntPtr.Zero)
				id_getNodeDescriptor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getNodeDescriptor", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/NodeDescriptor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.INodeDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNodeDescriptor_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNodeIdForElement_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='getNodeIdForElement' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getNodeIdForElement", "(Ljava/lang/Object;)Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer GetNodeIdForElement (global::Java.Lang.Object p0)
		{
			if (id_getNodeIdForElement_Ljava_lang_Object_ == IntPtr.Zero)
				id_getNodeIdForElement_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getNodeIdForElement", "(Ljava/lang/Object;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNodeIdForElement_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hideHighlight;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='hideHighlight' and count(parameter)=0]"
		[Register ("hideHighlight", "()V", "")]
		public unsafe void HideHighlight ()
		{
			if (id_hideHighlight == IntPtr.Zero)
				id_hideHighlight = JNIEnv.GetMethodID (class_ref, "hideHighlight", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideHighlight);
			} finally {
			}
		}

		static IntPtr id_highlightElement_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='highlightElement' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("highlightElement", "(Ljava/lang/Object;I)V", "")]
		public unsafe void HighlightElement (global::Java.Lang.Object p0, int p1)
		{
			if (id_highlightElement_Ljava_lang_Object_I == IntPtr.Zero)
				id_highlightElement_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "highlightElement", "(Ljava/lang/Object;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_highlightElement_Ljava_lang_Object_I, __args);
			} finally {
			}
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
			} finally {
			}
		}

		static IntPtr id_removeUpdateListener_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='removeUpdateListener' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.Document.UpdateListener']]"
		[Register ("removeUpdateListener", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V", "")]
		public unsafe void RemoveUpdateListener (global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener p0)
		{
			if (id_removeUpdateListener_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ == IntPtr.Zero)
				id_removeUpdateListener_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_ = JNIEnv.GetMethodID (class_ref, "removeUpdateListener", "(Lcom/facebook/stetho/inspector/elements/Document$UpdateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeUpdateListener_Lcom_facebook_stetho_inspector_elements_Document_UpdateListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='setAttributesAsText' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAttributesAsText", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe void SetAttributesAsText (global::Java.Lang.Object p0, string p1)
		{
			if (id_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAttributesAsText", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttributesAsText_Ljava_lang_Object_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setInspectModeEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='Document']/method[@name='setInspectModeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInspectModeEnabled", "(Z)V", "")]
		public unsafe void SetInspectModeEnabled (bool p0)
		{
			if (id_setInspectModeEnabled_Z == IntPtr.Zero)
				id_setInspectModeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setInspectModeEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInspectModeEnabled_Z, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener"
		public event EventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.AttributeModifiedEventArgs> AttributeModified {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						__CreateIUpdateListenerImplementor,
						AddUpdateListener,
						__h => __h.OnAttributeModifiedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor.__IsEmpty,
						__v => RemoveUpdateListener (__v),
						__h => __h.OnAttributeModifiedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.AttributeRemovedEventArgs> AttributeRemoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						__CreateIUpdateListenerImplementor,
						AddUpdateListener,
						__h => __h.OnAttributeRemovedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor.__IsEmpty,
						__v => RemoveUpdateListener (__v),
						__h => __h.OnAttributeRemovedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.ChildNodeInsertedEventArgs> ChildNodeInserted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						__CreateIUpdateListenerImplementor,
						AddUpdateListener,
						__h => __h.OnChildNodeInsertedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor.__IsEmpty,
						__v => RemoveUpdateListener (__v),
						__h => __h.OnChildNodeInsertedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.ChildNodeRemovedEventArgs> ChildNodeRemoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						__CreateIUpdateListenerImplementor,
						AddUpdateListener,
						__h => __h.OnChildNodeRemovedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor.__IsEmpty,
						__v => RemoveUpdateListener (__v),
						__h => __h.OnChildNodeRemovedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.InspectRequestedEventArgs> InspectRequested {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						__CreateIUpdateListenerImplementor,
						AddUpdateListener,
						__h => __h.OnInspectRequestedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListener, global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor.__IsEmpty,
						__v => RemoveUpdateListener (__v),
						__h => __h.OnInspectRequestedHandler -= value);
			}
		}

		WeakReference weak_implementor_AddUpdateListener;

		global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor __CreateIUpdateListenerImplementor ()
		{
			return new global::Com.Facebook.Stetho.Inspector.Elements.Document.IUpdateListenerImplementor (this);
		}
#endregion
	}
}
