using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS", DoNotGenerateAcw=true)]
	public partial class CSS : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSComputedStyleProperty']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$CSSComputedStyleProperty", DoNotGenerateAcw=true)]
		public partial class CSSComputedStyleProperty : global::Java.Lang.Object {


			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSComputedStyleProperty']/field[@name='name']"
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

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSComputedStyleProperty']/field[@name='value']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$CSSComputedStyleProperty", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CSSComputedStyleProperty); }
			}

			protected CSSComputedStyleProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$CSSProperty", DoNotGenerateAcw=true)]
		public partial class CSSProperty : global::Java.Lang.Object {


			static IntPtr disabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']/field[@name='disabled']"
			[Register ("disabled")]
			public global::Java.Lang.Boolean Disabled {
				get {
					if (disabled_jfieldId == IntPtr.Zero)
						disabled_jfieldId = JNIEnv.GetFieldID (class_ref, "disabled", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, disabled_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (disabled_jfieldId == IntPtr.Zero)
						disabled_jfieldId = JNIEnv.GetFieldID (class_ref, "disabled", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, disabled_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr implicit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']/field[@name='implicit']"
			[Register ("implicit")]
			public global::Java.Lang.Boolean Implicit {
				get {
					if (implicit_jfieldId == IntPtr.Zero)
						implicit_jfieldId = JNIEnv.GetFieldID (class_ref, "implicit", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, implicit_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (implicit_jfieldId == IntPtr.Zero)
						implicit_jfieldId = JNIEnv.GetFieldID (class_ref, "implicit", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, implicit_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr important_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']/field[@name='important']"
			[Register ("important")]
			public global::Java.Lang.Boolean Important {
				get {
					if (important_jfieldId == IntPtr.Zero)
						important_jfieldId = JNIEnv.GetFieldID (class_ref, "important", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, important_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (important_jfieldId == IntPtr.Zero)
						important_jfieldId = JNIEnv.GetFieldID (class_ref, "important", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, important_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']/field[@name='name']"
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

			static IntPtr parsedOk_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']/field[@name='parsedOk']"
			[Register ("parsedOk")]
			public global::Java.Lang.Boolean ParsedOk {
				get {
					if (parsedOk_jfieldId == IntPtr.Zero)
						parsedOk_jfieldId = JNIEnv.GetFieldID (class_ref, "parsedOk", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, parsedOk_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (parsedOk_jfieldId == IntPtr.Zero)
						parsedOk_jfieldId = JNIEnv.GetFieldID (class_ref, "parsedOk", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, parsedOk_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr range_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']/field[@name='range']"
			[Register ("range")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.SourceRange Range {
				get {
					if (range_jfieldId == IntPtr.Zero)
						range_jfieldId = JNIEnv.GetFieldID (class_ref, "range", "Lcom/facebook/stetho/inspector/protocol/module/CSS$SourceRange;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, range_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.SourceRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (range_jfieldId == IntPtr.Zero)
						range_jfieldId = JNIEnv.GetFieldID (class_ref, "range", "Lcom/facebook/stetho/inspector/protocol/module/CSS$SourceRange;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, range_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']/field[@name='text']"
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

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSProperty']/field[@name='value']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$CSSProperty", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CSSProperty); }
			}

			protected CSSProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSRule']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$CSSRule", DoNotGenerateAcw=true)]
		public partial class CSSRule : global::Java.Lang.Object {


			static IntPtr origin_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSRule']/field[@name='origin']"
			[Register ("origin")]
			public global::Com.Facebook.Stetho.Inspector.Elements.Origin Origin {
				get {
					if (origin_jfieldId == IntPtr.Zero)
						origin_jfieldId = JNIEnv.GetFieldID (class_ref, "origin", "Lcom/facebook/stetho/inspector/elements/Origin;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, origin_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Origin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (origin_jfieldId == IntPtr.Zero)
						origin_jfieldId = JNIEnv.GetFieldID (class_ref, "origin", "Lcom/facebook/stetho/inspector/elements/Origin;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, origin_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr selectorList_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSRule']/field[@name='selectorList']"
			[Register ("selectorList")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.SelectorList SelectorList {
				get {
					if (selectorList_jfieldId == IntPtr.Zero)
						selectorList_jfieldId = JNIEnv.GetFieldID (class_ref, "selectorList", "Lcom/facebook/stetho/inspector/protocol/module/CSS$SelectorList;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, selectorList_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.SelectorList> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (selectorList_jfieldId == IntPtr.Zero)
						selectorList_jfieldId = JNIEnv.GetFieldID (class_ref, "selectorList", "Lcom/facebook/stetho/inspector/protocol/module/CSS$SelectorList;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, selectorList_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr style_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSRule']/field[@name='style']"
			[Register ("style")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.CSSStyle Style {
				get {
					if (style_jfieldId == IntPtr.Zero)
						style_jfieldId = JNIEnv.GetFieldID (class_ref, "style", "Lcom/facebook/stetho/inspector/protocol/module/CSS$CSSStyle;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, style_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.CSSStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (style_jfieldId == IntPtr.Zero)
						style_jfieldId = JNIEnv.GetFieldID (class_ref, "style", "Lcom/facebook/stetho/inspector/protocol/module/CSS$CSSStyle;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, style_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr styleSheetId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSRule']/field[@name='styleSheetId']"
			[Register ("styleSheetId")]
			public string StyleSheetId {
				get {
					if (styleSheetId_jfieldId == IntPtr.Zero)
						styleSheetId_jfieldId = JNIEnv.GetFieldID (class_ref, "styleSheetId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, styleSheetId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (styleSheetId_jfieldId == IntPtr.Zero)
						styleSheetId_jfieldId = JNIEnv.GetFieldID (class_ref, "styleSheetId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, styleSheetId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$CSSRule", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CSSRule); }
			}

			protected CSSRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSStyle']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$CSSStyle", DoNotGenerateAcw=true)]
		public partial class CSSStyle : global::Java.Lang.Object {


			static IntPtr cssProperties_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSStyle']/field[@name='cssProperties']"
			[Register ("cssProperties")]
			public global::System.Collections.IList CssProperties {
				get {
					if (cssProperties_jfieldId == IntPtr.Zero)
						cssProperties_jfieldId = JNIEnv.GetFieldID (class_ref, "cssProperties", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cssProperties_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cssProperties_jfieldId == IntPtr.Zero)
						cssProperties_jfieldId = JNIEnv.GetFieldID (class_ref, "cssProperties", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cssProperties_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr cssText_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSStyle']/field[@name='cssText']"
			[Register ("cssText")]
			public string CssText {
				get {
					if (cssText_jfieldId == IntPtr.Zero)
						cssText_jfieldId = JNIEnv.GetFieldID (class_ref, "cssText", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cssText_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cssText_jfieldId == IntPtr.Zero)
						cssText_jfieldId = JNIEnv.GetFieldID (class_ref, "cssText", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cssText_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr range_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSStyle']/field[@name='range']"
			[Register ("range")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.SourceRange Range {
				get {
					if (range_jfieldId == IntPtr.Zero)
						range_jfieldId = JNIEnv.GetFieldID (class_ref, "range", "Lcom/facebook/stetho/inspector/protocol/module/CSS$SourceRange;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, range_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.SourceRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (range_jfieldId == IntPtr.Zero)
						range_jfieldId = JNIEnv.GetFieldID (class_ref, "range", "Lcom/facebook/stetho/inspector/protocol/module/CSS$SourceRange;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, range_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr shorthandEntries_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSStyle']/field[@name='shorthandEntries']"
			[Register ("shorthandEntries")]
			public global::System.Collections.IList ShorthandEntries {
				get {
					if (shorthandEntries_jfieldId == IntPtr.Zero)
						shorthandEntries_jfieldId = JNIEnv.GetFieldID (class_ref, "shorthandEntries", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, shorthandEntries_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (shorthandEntries_jfieldId == IntPtr.Zero)
						shorthandEntries_jfieldId = JNIEnv.GetFieldID (class_ref, "shorthandEntries", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, shorthandEntries_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr styleSheetId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.CSSStyle']/field[@name='styleSheetId']"
			[Register ("styleSheetId")]
			public string StyleSheetId {
				get {
					if (styleSheetId_jfieldId == IntPtr.Zero)
						styleSheetId_jfieldId = JNIEnv.GetFieldID (class_ref, "styleSheetId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, styleSheetId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (styleSheetId_jfieldId == IntPtr.Zero)
						styleSheetId_jfieldId = JNIEnv.GetFieldID (class_ref, "styleSheetId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, styleSheetId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$CSSStyle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CSSStyle); }
			}

			protected CSSStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetComputedStyleForNodeRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$GetComputedStyleForNodeRequest", DoNotGenerateAcw=true)]
		public partial class GetComputedStyleForNodeRequest : global::Java.Lang.Object {


			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetComputedStyleForNodeRequest']/field[@name='nodeId']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$GetComputedStyleForNodeRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetComputedStyleForNodeRequest); }
			}

			protected GetComputedStyleForNodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetComputedStyleForNodeResult']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$GetComputedStyleForNodeResult", DoNotGenerateAcw=true)]
		public partial class GetComputedStyleForNodeResult : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr computedStyle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetComputedStyleForNodeResult']/field[@name='computedStyle']"
			[Register ("computedStyle")]
			public global::System.Collections.IList ComputedStyle {
				get {
					if (computedStyle_jfieldId == IntPtr.Zero)
						computedStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "computedStyle", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, computedStyle_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (computedStyle_jfieldId == IntPtr.Zero)
						computedStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "computedStyle", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, computedStyle_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$GetComputedStyleForNodeResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetComputedStyleForNodeResult); }
			}

			protected GetComputedStyleForNodeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetMatchedStylesForNodeRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$GetMatchedStylesForNodeRequest", DoNotGenerateAcw=true)]
		public partial class GetMatchedStylesForNodeRequest : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr excludeInherited_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetMatchedStylesForNodeRequest']/field[@name='excludeInherited']"
			[Register ("excludeInherited")]
			public global::Java.Lang.Boolean ExcludeInherited {
				get {
					if (excludeInherited_jfieldId == IntPtr.Zero)
						excludeInherited_jfieldId = JNIEnv.GetFieldID (class_ref, "excludeInherited", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, excludeInherited_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (excludeInherited_jfieldId == IntPtr.Zero)
						excludeInherited_jfieldId = JNIEnv.GetFieldID (class_ref, "excludeInherited", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, excludeInherited_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr excludePseudo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetMatchedStylesForNodeRequest']/field[@name='excludePseudo']"
			[Register ("excludePseudo")]
			public global::Java.Lang.Boolean ExcludePseudo {
				get {
					if (excludePseudo_jfieldId == IntPtr.Zero)
						excludePseudo_jfieldId = JNIEnv.GetFieldID (class_ref, "excludePseudo", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, excludePseudo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (excludePseudo_jfieldId == IntPtr.Zero)
						excludePseudo_jfieldId = JNIEnv.GetFieldID (class_ref, "excludePseudo", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, excludePseudo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nodeId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetMatchedStylesForNodeRequest']/field[@name='nodeId']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$GetMatchedStylesForNodeRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetMatchedStylesForNodeRequest); }
			}

			protected GetMatchedStylesForNodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetMatchedStylesForNodeResult']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$GetMatchedStylesForNodeResult", DoNotGenerateAcw=true)]
		public partial class GetMatchedStylesForNodeResult : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr inherited_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetMatchedStylesForNodeResult']/field[@name='inherited']"
			[Register ("inherited")]
			public global::System.Collections.IList Inherited {
				get {
					if (inherited_jfieldId == IntPtr.Zero)
						inherited_jfieldId = JNIEnv.GetFieldID (class_ref, "inherited", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, inherited_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (inherited_jfieldId == IntPtr.Zero)
						inherited_jfieldId = JNIEnv.GetFieldID (class_ref, "inherited", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, inherited_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr matchedCSSRules_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetMatchedStylesForNodeResult']/field[@name='matchedCSSRules']"
			[Register ("matchedCSSRules")]
			public global::System.Collections.IList MatchedCSSRules {
				get {
					if (matchedCSSRules_jfieldId == IntPtr.Zero)
						matchedCSSRules_jfieldId = JNIEnv.GetFieldID (class_ref, "matchedCSSRules", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, matchedCSSRules_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (matchedCSSRules_jfieldId == IntPtr.Zero)
						matchedCSSRules_jfieldId = JNIEnv.GetFieldID (class_ref, "matchedCSSRules", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, matchedCSSRules_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr pseudoElements_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.GetMatchedStylesForNodeResult']/field[@name='pseudoElements']"
			[Register ("pseudoElements")]
			public global::System.Collections.IList PseudoElements {
				get {
					if (pseudoElements_jfieldId == IntPtr.Zero)
						pseudoElements_jfieldId = JNIEnv.GetFieldID (class_ref, "pseudoElements", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, pseudoElements_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (pseudoElements_jfieldId == IntPtr.Zero)
						pseudoElements_jfieldId = JNIEnv.GetFieldID (class_ref, "pseudoElements", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pseudoElements_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$GetMatchedStylesForNodeResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetMatchedStylesForNodeResult); }
			}

			protected GetMatchedStylesForNodeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.InheritedStyleEntry']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$InheritedStyleEntry", DoNotGenerateAcw=true)]
		public partial class InheritedStyleEntry : global::Java.Lang.Object {


			static IntPtr inlineStyle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.InheritedStyleEntry']/field[@name='inlineStyle']"
			[Register ("inlineStyle")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.CSSStyle InlineStyle {
				get {
					if (inlineStyle_jfieldId == IntPtr.Zero)
						inlineStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "inlineStyle", "Lcom/facebook/stetho/inspector/protocol/module/CSS$CSSStyle;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, inlineStyle_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.CSSStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (inlineStyle_jfieldId == IntPtr.Zero)
						inlineStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "inlineStyle", "Lcom/facebook/stetho/inspector/protocol/module/CSS$CSSStyle;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, inlineStyle_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr matchedCSSRules_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.InheritedStyleEntry']/field[@name='matchedCSSRules']"
			[Register ("matchedCSSRules")]
			public global::System.Collections.IList MatchedCSSRules {
				get {
					if (matchedCSSRules_jfieldId == IntPtr.Zero)
						matchedCSSRules_jfieldId = JNIEnv.GetFieldID (class_ref, "matchedCSSRules", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, matchedCSSRules_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (matchedCSSRules_jfieldId == IntPtr.Zero)
						matchedCSSRules_jfieldId = JNIEnv.GetFieldID (class_ref, "matchedCSSRules", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, matchedCSSRules_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$InheritedStyleEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InheritedStyleEntry); }
			}

			protected InheritedStyleEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.PeerManagerListener']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$PeerManagerListener", DoNotGenerateAcw=true)]
		public sealed partial class PeerManagerListener : global::Com.Facebook.Stetho.Inspector.Helper.PeersRegisteredListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$PeerManagerListener", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.PeerManagerListener']/method[@name='onFirstPeerRegistered' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.PeerManagerListener']/method[@name='onLastPeerUnregistered' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.PseudoIdMatches']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$PseudoIdMatches", DoNotGenerateAcw=true)]
		public partial class PseudoIdMatches : global::Java.Lang.Object {


			static IntPtr matches_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.PseudoIdMatches']/field[@name='matches']"
			[Register ("matches")]
			public global::System.Collections.IList Matches {
				get {
					if (matches_jfieldId == IntPtr.Zero)
						matches_jfieldId = JNIEnv.GetFieldID (class_ref, "matches", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, matches_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (matches_jfieldId == IntPtr.Zero)
						matches_jfieldId = JNIEnv.GetFieldID (class_ref, "matches", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, matches_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr pseudoId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.PseudoIdMatches']/field[@name='pseudoId']"
			[Register ("pseudoId")]
			public int PseudoId {
				get {
					if (pseudoId_jfieldId == IntPtr.Zero)
						pseudoId_jfieldId = JNIEnv.GetFieldID (class_ref, "pseudoId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pseudoId_jfieldId);
				}
				set {
					if (pseudoId_jfieldId == IntPtr.Zero)
						pseudoId_jfieldId = JNIEnv.GetFieldID (class_ref, "pseudoId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pseudoId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$PseudoIdMatches", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PseudoIdMatches); }
			}

			protected PseudoIdMatches (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.PseudoIdMatches']/constructor[@name='CSS.PseudoIdMatches' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PseudoIdMatches ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (PseudoIdMatches)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.RuleMatch']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$RuleMatch", DoNotGenerateAcw=true)]
		public partial class RuleMatch : global::Java.Lang.Object {


			static IntPtr matchingSelectors_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.RuleMatch']/field[@name='matchingSelectors']"
			[Register ("matchingSelectors")]
			public global::System.Collections.IList MatchingSelectors {
				get {
					if (matchingSelectors_jfieldId == IntPtr.Zero)
						matchingSelectors_jfieldId = JNIEnv.GetFieldID (class_ref, "matchingSelectors", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, matchingSelectors_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (matchingSelectors_jfieldId == IntPtr.Zero)
						matchingSelectors_jfieldId = JNIEnv.GetFieldID (class_ref, "matchingSelectors", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, matchingSelectors_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr rule_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.RuleMatch']/field[@name='rule']"
			[Register ("rule")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.CSSRule Rule {
				get {
					if (rule_jfieldId == IntPtr.Zero)
						rule_jfieldId = JNIEnv.GetFieldID (class_ref, "rule", "Lcom/facebook/stetho/inspector/protocol/module/CSS$CSSRule;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rule_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.CSSRule> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (rule_jfieldId == IntPtr.Zero)
						rule_jfieldId = JNIEnv.GetFieldID (class_ref, "rule", "Lcom/facebook/stetho/inspector/protocol/module/CSS$CSSRule;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rule_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$RuleMatch", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RuleMatch); }
			}

			protected RuleMatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.Selector']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$Selector", DoNotGenerateAcw=true)]
		public partial class Selector : global::Java.Lang.Object {


			static IntPtr range_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.Selector']/field[@name='range']"
			[Register ("range")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.SourceRange Range {
				get {
					if (range_jfieldId == IntPtr.Zero)
						range_jfieldId = JNIEnv.GetFieldID (class_ref, "range", "Lcom/facebook/stetho/inspector/protocol/module/CSS$SourceRange;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, range_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS.SourceRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (range_jfieldId == IntPtr.Zero)
						range_jfieldId = JNIEnv.GetFieldID (class_ref, "range", "Lcom/facebook/stetho/inspector/protocol/module/CSS$SourceRange;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, range_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.Selector']/field[@name='value']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$Selector", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Selector); }
			}

			protected Selector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.SelectorList']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$SelectorList", DoNotGenerateAcw=true)]
		public partial class SelectorList : global::Java.Lang.Object {


			static IntPtr selectors_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.SelectorList']/field[@name='selectors']"
			[Register ("selectors")]
			public global::System.Collections.IList Selectors {
				get {
					if (selectors_jfieldId == IntPtr.Zero)
						selectors_jfieldId = JNIEnv.GetFieldID (class_ref, "selectors", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, selectors_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (selectors_jfieldId == IntPtr.Zero)
						selectors_jfieldId = JNIEnv.GetFieldID (class_ref, "selectors", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, selectors_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.SelectorList']/field[@name='text']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$SelectorList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SelectorList); }
			}

			protected SelectorList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.ShorthandEntry']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$ShorthandEntry", DoNotGenerateAcw=true)]
		public partial class ShorthandEntry : global::Java.Lang.Object {


			static IntPtr imporant_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.ShorthandEntry']/field[@name='imporant']"
			[Register ("imporant")]
			public global::Java.Lang.Boolean Imporant {
				get {
					if (imporant_jfieldId == IntPtr.Zero)
						imporant_jfieldId = JNIEnv.GetFieldID (class_ref, "imporant", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, imporant_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (imporant_jfieldId == IntPtr.Zero)
						imporant_jfieldId = JNIEnv.GetFieldID (class_ref, "imporant", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imporant_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.ShorthandEntry']/field[@name='name']"
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

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.ShorthandEntry']/field[@name='value']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$ShorthandEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ShorthandEntry); }
			}

			protected ShorthandEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.SourceRange']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/CSS$SourceRange", DoNotGenerateAcw=true)]
		public partial class SourceRange : global::Java.Lang.Object {


			static IntPtr endColumn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.SourceRange']/field[@name='endColumn']"
			[Register ("endColumn")]
			public int EndColumn {
				get {
					if (endColumn_jfieldId == IntPtr.Zero)
						endColumn_jfieldId = JNIEnv.GetFieldID (class_ref, "endColumn", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, endColumn_jfieldId);
				}
				set {
					if (endColumn_jfieldId == IntPtr.Zero)
						endColumn_jfieldId = JNIEnv.GetFieldID (class_ref, "endColumn", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endColumn_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr endLine_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.SourceRange']/field[@name='endLine']"
			[Register ("endLine")]
			public int EndLine {
				get {
					if (endLine_jfieldId == IntPtr.Zero)
						endLine_jfieldId = JNIEnv.GetFieldID (class_ref, "endLine", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, endLine_jfieldId);
				}
				set {
					if (endLine_jfieldId == IntPtr.Zero)
						endLine_jfieldId = JNIEnv.GetFieldID (class_ref, "endLine", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endLine_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr startColumn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.SourceRange']/field[@name='startColumn']"
			[Register ("startColumn")]
			public int StartColumn {
				get {
					if (startColumn_jfieldId == IntPtr.Zero)
						startColumn_jfieldId = JNIEnv.GetFieldID (class_ref, "startColumn", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, startColumn_jfieldId);
				}
				set {
					if (startColumn_jfieldId == IntPtr.Zero)
						startColumn_jfieldId = JNIEnv.GetFieldID (class_ref, "startColumn", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startColumn_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr startLine_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS.SourceRange']/field[@name='startLine']"
			[Register ("startLine")]
			public int StartLine {
				get {
					if (startLine_jfieldId == IntPtr.Zero)
						startLine_jfieldId = JNIEnv.GetFieldID (class_ref, "startLine", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, startLine_jfieldId);
				}
				set {
					if (startLine_jfieldId == IntPtr.Zero)
						startLine_jfieldId = JNIEnv.GetFieldID (class_ref, "startLine", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startLine_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS$SourceRange", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SourceRange); }
			}

			protected SourceRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/CSS", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CSS); }
		}

		protected CSS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_elements_Document_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS']/constructor[@name='CSS' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.Document']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/elements/Document;)V", "")]
		public unsafe CSS (global::Com.Facebook.Stetho.Inspector.Elements.Document p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CSS)) {
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
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Disable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS']/method[@name='disable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
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
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS']/method[@name='enable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
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

		static Delegate cb_getComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_getComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_getComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetComputedStyleForNode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS']/method[@name='getComputedStyleForNode' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getComputedStyleForNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetGetComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult GetComputedStyleForNode (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_getComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getComputedStyleForNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getComputedStyleForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getComputedStyleForNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_getMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_getMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.CSS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMatchedStylesForNode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='CSS']/method[@name='getMatchedStylesForNode' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getMatchedStylesForNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetGetMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult GetMatchedStylesForNode (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_getMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getMatchedStylesForNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMatchedStylesForNode_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMatchedStylesForNode", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
