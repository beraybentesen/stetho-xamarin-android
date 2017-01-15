using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/ShadowDocument", DoNotGenerateAcw=true)]
	public sealed partial class ShadowDocument : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/ShadowDocument$Update", DoNotGenerateAcw=true)]
		public sealed partial class Update : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Elements.IDocumentView {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/ShadowDocument$Update", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Update); }
			}

			internal Update (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_Ljava_util_Map_Ljava_util_Set_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/constructor[@name='ShadowDocument.Update' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.inspector.elements.ShadowDocument'] and parameter[2][@type='java.util.Map&lt;java.lang.Object, com.facebook.stetho.inspector.elements.ElementInfo&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.Object&gt;']]"
			[Register (".ctor", "(Lcom/facebook/stetho/inspector/elements/ShadowDocument;Ljava/util/Map;Ljava/util/Set;)V", "")]
			public unsafe Update (global::Com.Facebook.Stetho.Inspector.Elements.ShadowDocument __self, global::System.Collections.Generic.IDictionary<global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo> p0, global::System.Collections.Generic.ICollection<global::Java.Lang.Object> p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo>.ToLocalJniHandle (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaSet<global::Java.Lang.Object>.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p0);
					__args [2] = new JValue (native_p1);
					if (GetType () != typeof (Update)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/util/Map;Ljava/util/Set;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/util/Map;Ljava/util/Set;)V", __args);
						return;
					}

					if (id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_Ljava_util_Map_Ljava_util_Set_ == IntPtr.Zero)
						id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_Ljava_util_Map_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/elements/ShadowDocument;Ljava/util/Map;Ljava/util/Set;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_Ljava_util_Map_Ljava_util_Set_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_Ljava_util_Map_Ljava_util_Set_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_isEmpty;
			public unsafe bool IsEmpty {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/method[@name='isEmpty' and count(parameter)=0]"
				[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
				get {
					if (id_isEmpty == IntPtr.Zero)
						id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					} finally {
					}
				}
			}

			static IntPtr id_getRootElement;
			public unsafe global::Java.Lang.Object RootElement {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/method[@name='getRootElement' and count(parameter)=0]"
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

			static IntPtr id_abandon;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/method[@name='abandon' and count(parameter)=0]"
			[Register ("abandon", "()V", "")]
			public unsafe void Abandon ()
			{
				if (id_abandon == IntPtr.Zero)
					id_abandon = JNIEnv.GetMethodID (class_ref, "abandon", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abandon);
				} finally {
				}
			}

			static IntPtr id_commit;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/method[@name='commit' and count(parameter)=0]"
			[Register ("commit", "()V", "")]
			public unsafe void Commit ()
			{
				if (id_commit == IntPtr.Zero)
					id_commit = JNIEnv.GetMethodID (class_ref, "commit", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commit);
				} finally {
				}
			}

			static IntPtr id_getChangedElements_Lcom_facebook_stetho_common_Accumulator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/method[@name='getChangedElements' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.common.Accumulator&lt;java.lang.Object&gt;']]"
			[Register ("getChangedElements", "(Lcom/facebook/stetho/common/Accumulator;)V", "")]
			public unsafe void GetChangedElements (global::Com.Facebook.Stetho.Common.IAccumulator p0)
			{
				if (id_getChangedElements_Lcom_facebook_stetho_common_Accumulator_ == IntPtr.Zero)
					id_getChangedElements_Lcom_facebook_stetho_common_Accumulator_ = JNIEnv.GetMethodID (class_ref, "getChangedElements", "(Lcom/facebook/stetho/common/Accumulator;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getChangedElements_Lcom_facebook_stetho_common_Accumulator_, __args);
				} finally {
				}
			}

			static IntPtr id_getElementInfo_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/method[@name='getElementInfo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("getElementInfo", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/ElementInfo;", "")]
			public unsafe global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo GetElementInfo (global::Java.Lang.Object p0)
			{
				if (id_getElementInfo_Ljava_lang_Object_ == IntPtr.Zero)
					id_getElementInfo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getElementInfo", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/ElementInfo;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElementInfo_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_getGarbageElements_Lcom_facebook_stetho_common_Accumulator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/method[@name='getGarbageElements' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.common.Accumulator&lt;java.lang.Object&gt;']]"
			[Register ("getGarbageElements", "(Lcom/facebook/stetho/common/Accumulator;)V", "")]
			public unsafe void GetGarbageElements (global::Com.Facebook.Stetho.Common.IAccumulator p0)
			{
				if (id_getGarbageElements_Lcom_facebook_stetho_common_Accumulator_ == IntPtr.Zero)
					id_getGarbageElements_Lcom_facebook_stetho_common_Accumulator_ = JNIEnv.GetMethodID (class_ref, "getGarbageElements", "(Lcom/facebook/stetho/common/Accumulator;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGarbageElements_Lcom_facebook_stetho_common_Accumulator_, __args);
				} finally {
				}
			}

			static IntPtr id_isElementChanged_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.Update']/method[@name='isElementChanged' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("isElementChanged", "(Ljava/lang/Object;)Z", "")]
			public unsafe bool IsElementChanged (global::Java.Lang.Object p0)
			{
				if (id_isElementChanged_Ljava_lang_Object_ == IntPtr.Zero)
					id_isElementChanged_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isElementChanged", "(Ljava/lang/Object;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isElementChanged_Ljava_lang_Object_, __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.UpdateBuilder']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/ShadowDocument$UpdateBuilder", DoNotGenerateAcw=true)]
		public sealed partial class UpdateBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/ShadowDocument$UpdateBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateBuilder); }
			}

			internal UpdateBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.UpdateBuilder']/constructor[@name='ShadowDocument.UpdateBuilder' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.ShadowDocument']]"
			[Register (".ctor", "(Lcom/facebook/stetho/inspector/elements/ShadowDocument;)V", "")]
			public unsafe UpdateBuilder (global::Com.Facebook.Stetho.Inspector.Elements.ShadowDocument __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (UpdateBuilder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_ == IntPtr.Zero)
						id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/elements/ShadowDocument;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_elements_ShadowDocument_, __args);
				} finally {
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.UpdateBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/stetho/inspector/elements/ShadowDocument$Update;", "")]
			public unsafe global::Com.Facebook.Stetho.Inspector.Elements.ShadowDocument.Update Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/stetho/inspector/elements/ShadowDocument$Update;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.ShadowDocument.Update> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setElementChildren_Ljava_lang_Object_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument.UpdateBuilder']/method[@name='setElementChildren' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.List&lt;java.lang.Object&gt;']]"
			[Register ("setElementChildren", "(Ljava/lang/Object;Ljava/util/List;)V", "")]
			public unsafe void SetElementChildren (global::Java.Lang.Object p0, global::System.Collections.Generic.IList<global::Java.Lang.Object> p1)
			{
				if (id_setElementChildren_Ljava_lang_Object_Ljava_util_List_ == IntPtr.Zero)
					id_setElementChildren_Ljava_lang_Object_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setElementChildren", "(Ljava/lang/Object;Ljava/util/List;)V");
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setElementChildren_Ljava_lang_Object_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/ShadowDocument", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShadowDocument); }
		}

		internal ShadowDocument (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument']/constructor[@name='ShadowDocument' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe ShadowDocument (global::Java.Lang.Object p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ShadowDocument)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_getRootElement;
		public unsafe global::Java.Lang.Object RootElement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument']/method[@name='getRootElement' and count(parameter)=0]"
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

		static IntPtr id_beginUpdate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument']/method[@name='beginUpdate' and count(parameter)=0]"
		[Register ("beginUpdate", "()Lcom/facebook/stetho/inspector/elements/ShadowDocument$UpdateBuilder;", "")]
		public unsafe global::Com.Facebook.Stetho.Inspector.Elements.ShadowDocument.UpdateBuilder BeginUpdate ()
		{
			if (id_beginUpdate == IntPtr.Zero)
				id_beginUpdate = JNIEnv.GetMethodID (class_ref, "beginUpdate", "()Lcom/facebook/stetho/inspector/elements/ShadowDocument$UpdateBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.ShadowDocument.UpdateBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_beginUpdate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getElementInfo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements']/class[@name='ShadowDocument']/method[@name='getElementInfo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getElementInfo", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/ElementInfo;", "")]
		public unsafe global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo GetElementInfo (global::Java.Lang.Object p0)
		{
			if (id_getElementInfo_Ljava_lang_Object_ == IntPtr.Zero)
				id_getElementInfo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getElementInfo", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/elements/ElementInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.ElementInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElementInfo_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
