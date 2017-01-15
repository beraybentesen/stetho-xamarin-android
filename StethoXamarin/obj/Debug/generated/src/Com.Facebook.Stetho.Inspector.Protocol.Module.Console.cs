using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Console", DoNotGenerateAcw=true)]
	public partial class Console : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.CallFrame']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Console$CallFrame", DoNotGenerateAcw=true)]
		public partial class CallFrame : global::Java.Lang.Object {


			static IntPtr columnNumber_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.CallFrame']/field[@name='columnNumber']"
			[Register ("columnNumber")]
			public int ColumnNumber {
				get {
					if (columnNumber_jfieldId == IntPtr.Zero)
						columnNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "columnNumber", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, columnNumber_jfieldId);
				}
				set {
					if (columnNumber_jfieldId == IntPtr.Zero)
						columnNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "columnNumber", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, columnNumber_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr functionName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.CallFrame']/field[@name='functionName']"
			[Register ("functionName")]
			public string FunctionName {
				get {
					if (functionName_jfieldId == IntPtr.Zero)
						functionName_jfieldId = JNIEnv.GetFieldID (class_ref, "functionName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, functionName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (functionName_jfieldId == IntPtr.Zero)
						functionName_jfieldId = JNIEnv.GetFieldID (class_ref, "functionName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, functionName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr lineNumber_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.CallFrame']/field[@name='lineNumber']"
			[Register ("lineNumber")]
			public int LineNumber {
				get {
					if (lineNumber_jfieldId == IntPtr.Zero)
						lineNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "lineNumber", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lineNumber_jfieldId);
				}
				set {
					if (lineNumber_jfieldId == IntPtr.Zero)
						lineNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "lineNumber", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lineNumber_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr url_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.CallFrame']/field[@name='url']"
			[Register ("url")]
			public string Url {
				get {
					if (url_jfieldId == IntPtr.Zero)
						url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, url_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (url_jfieldId == IntPtr.Zero)
						url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, url_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Console$CallFrame", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallFrame); }
			}

			protected CallFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.CallFrame']/constructor[@name='Console.CallFrame' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CallFrame ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (CallFrame)) {
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

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.CallFrame']/constructor[@name='Console.CallFrame' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;II)V", "")]
			public unsafe CallFrame (string p0, string p1, int p2, int p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (CallFrame)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;II)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_II, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.ConsoleMessage']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Console$ConsoleMessage", DoNotGenerateAcw=true)]
		public partial class ConsoleMessage : global::Java.Lang.Object {


			static IntPtr level_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.ConsoleMessage']/field[@name='level']"
			[Register ("level")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel Level {
				get {
					if (level_jfieldId == IntPtr.Zero)
						level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, level_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (level_jfieldId == IntPtr.Zero)
						level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, level_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr source_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.ConsoleMessage']/field[@name='source']"
			[Register ("source")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Source {
				get {
					if (source_jfieldId == IntPtr.Zero)
						source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, source_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (source_jfieldId == IntPtr.Zero)
						source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, source_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.ConsoleMessage']/field[@name='text']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Console$ConsoleMessage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConsoleMessage); }
			}

			protected ConsoleMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.ConsoleMessage']/constructor[@name='Console.ConsoleMessage' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ConsoleMessage ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ConsoleMessage)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageAddedRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Console$MessageAddedRequest", DoNotGenerateAcw=true)]
		public partial class MessageAddedRequest : global::Java.Lang.Object {


			static IntPtr message_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageAddedRequest']/field[@name='message']"
			[Register ("message")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.ConsoleMessage Message {
				get {
					if (message_jfieldId == IntPtr.Zero)
						message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Lcom/facebook/stetho/inspector/protocol/module/Console$ConsoleMessage;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.ConsoleMessage> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (message_jfieldId == IntPtr.Zero)
						message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Lcom/facebook/stetho/inspector/protocol/module/Console$ConsoleMessage;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Console$MessageAddedRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageAddedRequest); }
			}

			protected MessageAddedRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageAddedRequest']/constructor[@name='Console.MessageAddedRequest' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MessageAddedRequest ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (MessageAddedRequest)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageLevel']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Console$MessageLevel", DoNotGenerateAcw=true)]
		public sealed partial class MessageLevel : global::Java.Lang.Enum {


			static IntPtr DEBUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageLevel']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel Debug {
				get {
					if (DEBUG_jfieldId == IntPtr.Zero)
						DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageLevel']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageLevel']/field[@name='LOG']"
			[Register ("LOG")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel Log {
				get {
					if (LOG_jfieldId == IntPtr.Zero)
						LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WARNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageLevel']/field[@name='WARNING']"
			[Register ("WARNING")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel Warning {
				get {
					if (WARNING_jfieldId == IntPtr.Zero)
						WARNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARNING", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Console$MessageLevel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageLevel); }
			}

			internal MessageLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getProtocolValue;
			public unsafe string ProtocolValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageLevel']/method[@name='getProtocolValue' and count(parameter)=0]"
				[Register ("getProtocolValue", "()Ljava/lang/String;", "GetGetProtocolValueHandler")]
				get {
					if (id_getProtocolValue == IntPtr.Zero)
						id_getProtocolValue = JNIEnv.GetMethodID (class_ref, "getProtocolValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProtocolValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/protocol/module/Console$MessageLevel;");
				try {
					return (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageLevel));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Console$MessageSource", DoNotGenerateAcw=true)]
		public sealed partial class MessageSource : global::Java.Lang.Enum {


			static IntPtr APPCACHE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='APPCACHE']"
			[Register ("APPCACHE")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Appcache {
				get {
					if (APPCACHE_jfieldId == IntPtr.Zero)
						APPCACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPCACHE", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPCACHE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSOLE_API_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='CONSOLE_API']"
			[Register ("CONSOLE_API")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource ConsoleApi {
				get {
					if (CONSOLE_API_jfieldId == IntPtr.Zero)
						CONSOLE_API_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSOLE_API", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSOLE_API_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CSS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='CSS']"
			[Register ("CSS")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Css {
				get {
					if (CSS_jfieldId == IntPtr.Zero)
						CSS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CSS", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CSS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr JAVASCRIPT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='JAVASCRIPT']"
			[Register ("JAVASCRIPT")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Javascript {
				get {
					if (JAVASCRIPT_jfieldId == IntPtr.Zero)
						JAVASCRIPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVASCRIPT", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVASCRIPT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NETWORK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='NETWORK']"
			[Register ("NETWORK")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Network {
				get {
					if (NETWORK_jfieldId == IntPtr.Zero)
						NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RENDERING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='RENDERING']"
			[Register ("RENDERING")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Rendering {
				get {
					if (RENDERING_jfieldId == IntPtr.Zero)
						RENDERING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RENDERING", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RENDERING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SECURITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='SECURITY']"
			[Register ("SECURITY")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Security {
				get {
					if (SECURITY_jfieldId == IntPtr.Zero)
						SECURITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURITY", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STORAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='STORAGE']"
			[Register ("STORAGE")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Storage {
				get {
					if (STORAGE_jfieldId == IntPtr.Zero)
						STORAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STORAGE", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STORAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr XML_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/field[@name='XML']"
			[Register ("XML")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource Xml {
				get {
					if (XML_jfieldId == IntPtr.Zero)
						XML_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "XML", "Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, XML_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Console$MessageSource", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageSource); }
			}

			internal MessageSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getProtocolValue;
			public unsafe string ProtocolValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/method[@name='getProtocolValue' and count(parameter)=0]"
				[Register ("getProtocolValue", "()Ljava/lang/String;", "GetGetProtocolValueHandler")]
				get {
					if (id_getProtocolValue == IntPtr.Zero)
						id_getProtocolValue = JNIEnv.GetMethodID (class_ref, "getProtocolValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProtocolValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console.MessageSource']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/protocol/module/Console$MessageSource;");
				try {
					return (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console.MessageSource));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Console", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Console); }
		}

		protected Console (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console']/constructor[@name='Console' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Console ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Console)) {
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
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Disable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console']/method[@name='disable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
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
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Console> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Console']/method[@name='enable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
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

	}
}
