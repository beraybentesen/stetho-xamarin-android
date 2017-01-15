using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime", DoNotGenerateAcw=true)]
	public partial class Runtime : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallArgument']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$CallArgument", DoNotGenerateAcw=true)]
		public partial class CallArgument : global::Java.Lang.Object {


			static IntPtr objectId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallArgument']/field[@name='objectId']"
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

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallArgument']/field[@name='type']"
			[Register ("type")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallArgument']/field[@name='value']"
			[Register ("value")]
			public global::Java.Lang.Object Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/Object;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/Object;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$CallArgument", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallArgument); }
			}

			protected CallArgument (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$CallFunctionOnRequest", DoNotGenerateAcw=true)]
		public partial class CallFunctionOnRequest : global::Java.Lang.Object {


			static IntPtr arguments_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnRequest']/field[@name='arguments']"
			[Register ("arguments")]
			public global::System.Collections.IList Arguments {
				get {
					if (arguments_jfieldId == IntPtr.Zero)
						arguments_jfieldId = JNIEnv.GetFieldID (class_ref, "arguments", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, arguments_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (arguments_jfieldId == IntPtr.Zero)
						arguments_jfieldId = JNIEnv.GetFieldID (class_ref, "arguments", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, arguments_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr doNotPauseOnExceptionsAndMuteConsole_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnRequest']/field[@name='doNotPauseOnExceptionsAndMuteConsole']"
			[Register ("doNotPauseOnExceptionsAndMuteConsole")]
			public global::Java.Lang.Boolean DoNotPauseOnExceptionsAndMuteConsole {
				get {
					if (doNotPauseOnExceptionsAndMuteConsole_jfieldId == IntPtr.Zero)
						doNotPauseOnExceptionsAndMuteConsole_jfieldId = JNIEnv.GetFieldID (class_ref, "doNotPauseOnExceptionsAndMuteConsole", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, doNotPauseOnExceptionsAndMuteConsole_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (doNotPauseOnExceptionsAndMuteConsole_jfieldId == IntPtr.Zero)
						doNotPauseOnExceptionsAndMuteConsole_jfieldId = JNIEnv.GetFieldID (class_ref, "doNotPauseOnExceptionsAndMuteConsole", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, doNotPauseOnExceptionsAndMuteConsole_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr functionDeclaration_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnRequest']/field[@name='functionDeclaration']"
			[Register ("functionDeclaration")]
			public string FunctionDeclaration {
				get {
					if (functionDeclaration_jfieldId == IntPtr.Zero)
						functionDeclaration_jfieldId = JNIEnv.GetFieldID (class_ref, "functionDeclaration", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, functionDeclaration_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (functionDeclaration_jfieldId == IntPtr.Zero)
						functionDeclaration_jfieldId = JNIEnv.GetFieldID (class_ref, "functionDeclaration", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, functionDeclaration_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr generatePreview_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnRequest']/field[@name='generatePreview']"
			[Register ("generatePreview")]
			public global::Java.Lang.Boolean GeneratePreview {
				get {
					if (generatePreview_jfieldId == IntPtr.Zero)
						generatePreview_jfieldId = JNIEnv.GetFieldID (class_ref, "generatePreview", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, generatePreview_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (generatePreview_jfieldId == IntPtr.Zero)
						generatePreview_jfieldId = JNIEnv.GetFieldID (class_ref, "generatePreview", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, generatePreview_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr objectId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnRequest']/field[@name='objectId']"
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

			static IntPtr returnByValue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnRequest']/field[@name='returnByValue']"
			[Register ("returnByValue")]
			public global::Java.Lang.Boolean ReturnByValue {
				get {
					if (returnByValue_jfieldId == IntPtr.Zero)
						returnByValue_jfieldId = JNIEnv.GetFieldID (class_ref, "returnByValue", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, returnByValue_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (returnByValue_jfieldId == IntPtr.Zero)
						returnByValue_jfieldId = JNIEnv.GetFieldID (class_ref, "returnByValue", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, returnByValue_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$CallFunctionOnRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallFunctionOnRequest); }
			}

			protected CallFunctionOnRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$CallFunctionOnResponse", DoNotGenerateAcw=true)]
		public partial class CallFunctionOnResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr result_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnResponse']/field[@name='result']"
			[Register ("result")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject Result {
				get {
					if (result_jfieldId == IntPtr.Zero)
						result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, result_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (result_jfieldId == IntPtr.Zero)
						result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, result_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr wasThrown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.CallFunctionOnResponse']/field[@name='wasThrown']"
			[Register ("wasThrown")]
			public global::Java.Lang.Boolean WasThrown {
				get {
					if (wasThrown_jfieldId == IntPtr.Zero)
						wasThrown_jfieldId = JNIEnv.GetFieldID (class_ref, "wasThrown", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, wasThrown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (wasThrown_jfieldId == IntPtr.Zero)
						wasThrown_jfieldId = JNIEnv.GetFieldID (class_ref, "wasThrown", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, wasThrown_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$CallFunctionOnResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallFunctionOnResponse); }
			}

			protected CallFunctionOnResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.EvaluateRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$EvaluateRequest", DoNotGenerateAcw=true)]
		public partial class EvaluateRequest : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr expression_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.EvaluateRequest']/field[@name='expression']"
			[Register ("expression")]
			public string Expression {
				get {
					if (expression_jfieldId == IntPtr.Zero)
						expression_jfieldId = JNIEnv.GetFieldID (class_ref, "expression", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, expression_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (expression_jfieldId == IntPtr.Zero)
						expression_jfieldId = JNIEnv.GetFieldID (class_ref, "expression", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, expression_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr objectGroup_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.EvaluateRequest']/field[@name='objectGroup']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$EvaluateRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EvaluateRequest); }
			}

			protected EvaluateRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.EvaluateResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$EvaluateResponse", DoNotGenerateAcw=true)]
		public partial class EvaluateResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr exceptionDetails_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.EvaluateResponse']/field[@name='exceptionDetails']"
			[Register ("exceptionDetails")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ExceptionDetails ExceptionDetails {
				get {
					if (exceptionDetails_jfieldId == IntPtr.Zero)
						exceptionDetails_jfieldId = JNIEnv.GetFieldID (class_ref, "exceptionDetails", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ExceptionDetails;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, exceptionDetails_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ExceptionDetails> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (exceptionDetails_jfieldId == IntPtr.Zero)
						exceptionDetails_jfieldId = JNIEnv.GetFieldID (class_ref, "exceptionDetails", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ExceptionDetails;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, exceptionDetails_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr result_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.EvaluateResponse']/field[@name='result']"
			[Register ("result")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject Result {
				get {
					if (result_jfieldId == IntPtr.Zero)
						result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, result_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (result_jfieldId == IntPtr.Zero)
						result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, result_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr wasThrown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.EvaluateResponse']/field[@name='wasThrown']"
			[Register ("wasThrown")]
			public bool WasThrown {
				get {
					if (wasThrown_jfieldId == IntPtr.Zero)
						wasThrown_jfieldId = JNIEnv.GetFieldID (class_ref, "wasThrown", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, wasThrown_jfieldId);
				}
				set {
					if (wasThrown_jfieldId == IntPtr.Zero)
						wasThrown_jfieldId = JNIEnv.GetFieldID (class_ref, "wasThrown", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, wasThrown_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$EvaluateResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EvaluateResponse); }
			}

			protected EvaluateResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ExceptionDetails']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$ExceptionDetails", DoNotGenerateAcw=true)]
		public partial class ExceptionDetails : global::Java.Lang.Object {


			static IntPtr text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ExceptionDetails']/field[@name='text']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$ExceptionDetails", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExceptionDetails); }
			}

			protected ExceptionDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.GetPropertiesRequest']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$GetPropertiesRequest", DoNotGenerateAcw=true)]
		public partial class GetPropertiesRequest : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr objectId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.GetPropertiesRequest']/field[@name='objectId']"
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

			static IntPtr ownProperties_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.GetPropertiesRequest']/field[@name='ownProperties']"
			[Register ("ownProperties")]
			public bool OwnProperties {
				get {
					if (ownProperties_jfieldId == IntPtr.Zero)
						ownProperties_jfieldId = JNIEnv.GetFieldID (class_ref, "ownProperties", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, ownProperties_jfieldId);
				}
				set {
					if (ownProperties_jfieldId == IntPtr.Zero)
						ownProperties_jfieldId = JNIEnv.GetFieldID (class_ref, "ownProperties", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ownProperties_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$GetPropertiesRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetPropertiesRequest); }
			}

			protected GetPropertiesRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.GetPropertiesResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$GetPropertiesResponse", DoNotGenerateAcw=true)]
		public partial class GetPropertiesResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr result_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.GetPropertiesResponse']/field[@name='result']"
			[Register ("result")]
			public global::System.Collections.IList Result {
				get {
					if (result_jfieldId == IntPtr.Zero)
						result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, result_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (result_jfieldId == IntPtr.Zero)
						result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, result_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$GetPropertiesResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetPropertiesResponse); }
			}

			protected GetPropertiesResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectProtoContainer']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$ObjectProtoContainer", DoNotGenerateAcw=true)]
		public partial class ObjectProtoContainer : global::Java.Lang.Object {


			static IntPtr object_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectProtoContainer']/field[@name='object']"
			[Register ("object")]
			public global::Java.Lang.Object Object {
				get {
					if (object_jfieldId == IntPtr.Zero)
						object_jfieldId = JNIEnv.GetFieldID (class_ref, "object", "Ljava/lang/Object;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, object_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (object_jfieldId == IntPtr.Zero)
						object_jfieldId = JNIEnv.GetFieldID (class_ref, "object", "Ljava/lang/Object;");
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$ObjectProtoContainer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ObjectProtoContainer); }
			}

			protected ObjectProtoContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectProtoContainer']/constructor[@name='Runtime.ObjectProtoContainer' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe ObjectProtoContainer (global::Java.Lang.Object p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ObjectProtoContainer)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType", DoNotGenerateAcw=true)]
		public sealed partial class ObjectSubType : global::Java.Lang.Enum {


			static IntPtr ARRAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='ARRAY']"
			[Register ("ARRAY")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Array {
				get {
					if (ARRAY_jfieldId == IntPtr.Zero)
						ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ARRAY", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ARRAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='DATE']"
			[Register ("DATE")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Date {
				get {
					if (DATE_jfieldId == IntPtr.Zero)
						DATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATE", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GENERATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='GENERATOR']"
			[Register ("GENERATOR")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Generator {
				get {
					if (GENERATOR_jfieldId == IntPtr.Zero)
						GENERATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERATOR", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ITERATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='ITERATOR']"
			[Register ("ITERATOR")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Iterator {
				get {
					if (ITERATOR_jfieldId == IntPtr.Zero)
						ITERATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ITERATOR", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ITERATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MAP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='MAP']"
			[Register ("MAP")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Map {
				get {
					if (MAP_jfieldId == IntPtr.Zero)
						MAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAP", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='NODE']"
			[Register ("NODE")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Node {
				get {
					if (NODE_jfieldId == IntPtr.Zero)
						NODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NODE", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NULL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='NULL']"
			[Register ("NULL")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Null {
				get {
					if (NULL_jfieldId == IntPtr.Zero)
						NULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NULL", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NULL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REGEXP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='REGEXP']"
			[Register ("REGEXP")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Regexp {
				get {
					if (REGEXP_jfieldId == IntPtr.Zero)
						REGEXP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGEXP", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGEXP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/field[@name='SET']"
			[Register ("SET")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Set {
				get {
					if (SET_jfieldId == IntPtr.Zero)
						SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SET", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ObjectSubType); }
			}

			internal ObjectSubType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getProtocolValue;
			public unsafe string ProtocolValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/method[@name='getProtocolValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectSubType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
				try {
					return (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$ObjectType", DoNotGenerateAcw=true)]
		public sealed partial class ObjectType : global::Java.Lang.Enum {


			static IntPtr BOOLEAN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/field[@name='BOOLEAN']"
			[Register ("BOOLEAN")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType Boolean {
				get {
					if (BOOLEAN_jfieldId == IntPtr.Zero)
						BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOLEAN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FUNCTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/field[@name='FUNCTION']"
			[Register ("FUNCTION")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType Function {
				get {
					if (FUNCTION_jfieldId == IntPtr.Zero)
						FUNCTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FUNCTION", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FUNCTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NUMBER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/field[@name='NUMBER']"
			[Register ("NUMBER")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType Number {
				get {
					if (NUMBER_jfieldId == IntPtr.Zero)
						NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMBER", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMBER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OBJECT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/field[@name='OBJECT']"
			[Register ("OBJECT")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType Object {
				get {
					if (OBJECT_jfieldId == IntPtr.Zero)
						OBJECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OBJECT", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OBJECT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/field[@name='STRING']"
			[Register ("STRING")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType String {
				get {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SYMBOL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/field[@name='SYMBOL']"
			[Register ("SYMBOL")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType Symbol {
				get {
					if (SYMBOL_jfieldId == IntPtr.Zero)
						SYMBOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYMBOL", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYMBOL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNDEFINED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/field[@name='UNDEFINED']"
			[Register ("UNDEFINED")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType Undefined {
				get {
					if (UNDEFINED_jfieldId == IntPtr.Zero)
						UNDEFINED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDEFINED", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNDEFINED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$ObjectType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ObjectType); }
			}

			internal ObjectType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getProtocolValue;
			public unsafe string ProtocolValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/method[@name='getProtocolValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.ObjectType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
				try {
					return (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.PropertyDescriptor']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$PropertyDescriptor", DoNotGenerateAcw=true)]
		public partial class PropertyDescriptor : global::Java.Lang.Object {


			static IntPtr configurable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.PropertyDescriptor']/field[@name='configurable']"
			[Register ("configurable")]
			public bool Configurable {
				get {
					if (configurable_jfieldId == IntPtr.Zero)
						configurable_jfieldId = JNIEnv.GetFieldID (class_ref, "configurable", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, configurable_jfieldId);
				}
				set {
					if (configurable_jfieldId == IntPtr.Zero)
						configurable_jfieldId = JNIEnv.GetFieldID (class_ref, "configurable", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, configurable_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr enumerable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.PropertyDescriptor']/field[@name='enumerable']"
			[Register ("enumerable")]
			public bool Enumerable {
				get {
					if (enumerable_jfieldId == IntPtr.Zero)
						enumerable_jfieldId = JNIEnv.GetFieldID (class_ref, "enumerable", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enumerable_jfieldId);
				}
				set {
					if (enumerable_jfieldId == IntPtr.Zero)
						enumerable_jfieldId = JNIEnv.GetFieldID (class_ref, "enumerable", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enumerable_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr isOwn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.PropertyDescriptor']/field[@name='isOwn']"
			[Register ("isOwn")]
			public bool IsOwn {
				get {
					if (isOwn_jfieldId == IntPtr.Zero)
						isOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "isOwn", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isOwn_jfieldId);
				}
				set {
					if (isOwn_jfieldId == IntPtr.Zero)
						isOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "isOwn", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isOwn_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.PropertyDescriptor']/field[@name='name']"
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

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.PropertyDescriptor']/field[@name='value']"
			[Register ("value")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr writable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.PropertyDescriptor']/field[@name='writable']"
			[Register ("writable")]
			public bool Writable {
				get {
					if (writable_jfieldId == IntPtr.Zero)
						writable_jfieldId = JNIEnv.GetFieldID (class_ref, "writable", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, writable_jfieldId);
				}
				set {
					if (writable_jfieldId == IntPtr.Zero)
						writable_jfieldId = JNIEnv.GetFieldID (class_ref, "writable", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, writable_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$PropertyDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PropertyDescriptor); }
			}

			protected PropertyDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.RemoteObject']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject", DoNotGenerateAcw=true)]
		public partial class RemoteObject : global::Java.Lang.Object {


			static IntPtr className_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.RemoteObject']/field[@name='className']"
			[Register ("className")]
			public string ClassName {
				get {
					if (className_jfieldId == IntPtr.Zero)
						className_jfieldId = JNIEnv.GetFieldID (class_ref, "className", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, className_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (className_jfieldId == IntPtr.Zero)
						className_jfieldId = JNIEnv.GetFieldID (class_ref, "className", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, className_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr description_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.RemoteObject']/field[@name='description']"
			[Register ("description")]
			public string Description {
				get {
					if (description_jfieldId == IntPtr.Zero)
						description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, description_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (description_jfieldId == IntPtr.Zero)
						description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, description_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr objectId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.RemoteObject']/field[@name='objectId']"
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

			static IntPtr subtype_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.RemoteObject']/field[@name='subtype']"
			[Register ("subtype")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType Subtype {
				get {
					if (subtype_jfieldId == IntPtr.Zero)
						subtype_jfieldId = JNIEnv.GetFieldID (class_ref, "subtype", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, subtype_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectSubType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (subtype_jfieldId == IntPtr.Zero)
						subtype_jfieldId = JNIEnv.GetFieldID (class_ref, "subtype", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectSubType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, subtype_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.RemoteObject']/field[@name='type']"
			[Register ("type")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Runtime$ObjectType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.RemoteObject']/field[@name='value']"
			[Register ("value")]
			public global::Java.Lang.Object Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/Object;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/Object;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RemoteObject); }
			}

			protected RemoteObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.RemoteObject']/constructor[@name='Runtime.RemoteObject' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RemoteObject ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (RemoteObject)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.Session']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Runtime$Session", DoNotGenerateAcw=true)]
		public partial class Session : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime$Session", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Session); }
			}

			protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getObjects;
#pragma warning disable 0169
			static Delegate GetGetObjectsHandler ()
			{
				if (cb_getObjects == null)
					cb_getObjects = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjects);
				return cb_getObjects;
			}

			static IntPtr n_GetObjects (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.Session __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Objects);
			}
#pragma warning restore 0169

			static IntPtr id_getObjects;
			public virtual unsafe global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper Objects {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.Session']/method[@name='getObjects' and count(parameter)=0]"
				[Register ("getObjects", "()Lcom/facebook/stetho/inspector/helper/ObjectIdMapper;", "GetGetObjectsHandler")]
				get {
					if (id_getObjects == IntPtr.Zero)
						id_getObjects = JNIEnv.GetMethodID (class_ref, "getObjects", "()Lcom/facebook/stetho/inspector/helper/ObjectIdMapper;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObjects), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjects", "()Lcom/facebook/stetho/inspector/helper/ObjectIdMapper;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getObjectOrThrow_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetObjectOrThrow_Ljava_lang_String_Handler ()
			{
				if (cb_getObjectOrThrow_Ljava_lang_String_ == null)
					cb_getObjectOrThrow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetObjectOrThrow_Ljava_lang_String_);
				return cb_getObjectOrThrow_Ljava_lang_String_;
			}

			static IntPtr n_GetObjectOrThrow_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.Session __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetObjectOrThrow (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getObjectOrThrow_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.Session']/method[@name='getObjectOrThrow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getObjectOrThrow", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetObjectOrThrow_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object GetObjectOrThrow (string p0)
			{
				if (id_getObjectOrThrow_Ljava_lang_String_ == IntPtr.Zero)
					id_getObjectOrThrow_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getObjectOrThrow", "(Ljava/lang/String;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObjectOrThrow_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectOrThrow", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_objectForRemote_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetObjectForRemote_Ljava_lang_Object_Handler ()
			{
				if (cb_objectForRemote_Ljava_lang_Object_ == null)
					cb_objectForRemote_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ObjectForRemote_Ljava_lang_Object_);
				return cb_objectForRemote_Ljava_lang_Object_;
			}

			static IntPtr n_ObjectForRemote_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.Session __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ObjectForRemote (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_objectForRemote_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime.Session']/method[@name='objectForRemote' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("objectForRemote", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;", "GetObjectForRemote_Ljava_lang_Object_Handler")]
			public virtual unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject ObjectForRemote (global::Java.Lang.Object p0)
			{
				if (id_objectForRemote_Ljava_lang_Object_ == IntPtr.Zero)
					id_objectForRemote_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "objectForRemote", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_objectForRemote_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime.RemoteObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "objectForRemote", "(Ljava/lang/Object;)Lcom/facebook/stetho/inspector/protocol/module/Runtime$RemoteObject;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Runtime", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Runtime); }
		}

		protected Runtime (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']/constructor[@name='Runtime' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.console.RuntimeReplFactory']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/console/RuntimeReplFactory;)V", "")]
		public unsafe Runtime (global::Com.Facebook.Stetho.Inspector.Console.IRuntimeReplFactory p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Runtime)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/inspector/console/RuntimeReplFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/inspector/console/RuntimeReplFactory;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/console/RuntimeReplFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_console_RuntimeReplFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']/constructor[@name='Runtime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Runtime (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Runtime)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']/constructor[@name='Runtime' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Runtime ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Runtime)) {
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

		static Delegate cb_evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetEvaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_Evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Evaluate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']/method[@name='evaluate' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("evaluate", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetEvaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult Evaluate (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "evaluate", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_evaluate_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "evaluate", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_getProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_getProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperties (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']/method[@name='getProperties' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getProperties", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetGetProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult GetProperties (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_getProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getProperties", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProperties_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperties", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mapObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']/method[@name='mapObject' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='java.lang.Object']]"
		[Register ("mapObject", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Ljava/lang/Object;)I", "")]
		public static unsafe int MapObject (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Java.Lang.Object p1)
		{
			if (id_mapObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_Object_ == IntPtr.Zero)
				id_mapObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "mapObject", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_mapObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_releaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetReleaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_releaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_releaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReleaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_releaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_ReleaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseObject (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_releaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']/method[@name='releaseObject' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("releaseObject", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetReleaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void ReleaseObject (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_releaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_releaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "releaseObject", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseObject_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseObject", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_releaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetReleaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_releaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_releaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReleaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_releaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_ReleaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Runtime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseObjectGroup (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_releaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Runtime']/method[@name='releaseObjectGroup' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("releaseObjectGroup", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetReleaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void ReleaseObjectGroup (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_releaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_releaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "releaseObjectGroup", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseObjectGroup_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseObjectGroup", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
