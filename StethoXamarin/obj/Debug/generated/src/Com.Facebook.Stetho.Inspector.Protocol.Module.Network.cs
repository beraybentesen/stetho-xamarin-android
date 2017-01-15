using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network", DoNotGenerateAcw=true)]
	public partial class Network : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.DataReceivedParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$DataReceivedParams", DoNotGenerateAcw=true)]
		public partial class DataReceivedParams : global::Java.Lang.Object {


			static IntPtr dataLength_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.DataReceivedParams']/field[@name='dataLength']"
			[Register ("dataLength")]
			public int DataLength {
				get {
					if (dataLength_jfieldId == IntPtr.Zero)
						dataLength_jfieldId = JNIEnv.GetFieldID (class_ref, "dataLength", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, dataLength_jfieldId);
				}
				set {
					if (dataLength_jfieldId == IntPtr.Zero)
						dataLength_jfieldId = JNIEnv.GetFieldID (class_ref, "dataLength", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataLength_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr encodedDataLength_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.DataReceivedParams']/field[@name='encodedDataLength']"
			[Register ("encodedDataLength")]
			public int EncodedDataLength {
				get {
					if (encodedDataLength_jfieldId == IntPtr.Zero)
						encodedDataLength_jfieldId = JNIEnv.GetFieldID (class_ref, "encodedDataLength", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, encodedDataLength_jfieldId);
				}
				set {
					if (encodedDataLength_jfieldId == IntPtr.Zero)
						encodedDataLength_jfieldId = JNIEnv.GetFieldID (class_ref, "encodedDataLength", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, encodedDataLength_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr requestId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.DataReceivedParams']/field[@name='requestId']"
			[Register ("requestId")]
			public string RequestId {
				get {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.DataReceivedParams']/field[@name='timestamp']"
			[Register ("timestamp")]
			public double Timestamp {
				get {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
				}
				set {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$DataReceivedParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DataReceivedParams); }
			}

			protected DataReceivedParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.DataReceivedParams']/constructor[@name='Network.DataReceivedParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DataReceivedParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DataReceivedParams)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.GetResponseBodyResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$GetResponseBodyResponse", DoNotGenerateAcw=true)]
		public partial class GetResponseBodyResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr base64Encoded_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.GetResponseBodyResponse']/field[@name='base64Encoded']"
			[Register ("base64Encoded")]
			public bool Base64Encoded {
				get {
					if (base64Encoded_jfieldId == IntPtr.Zero)
						base64Encoded_jfieldId = JNIEnv.GetFieldID (class_ref, "base64Encoded", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, base64Encoded_jfieldId);
				}
				set {
					if (base64Encoded_jfieldId == IntPtr.Zero)
						base64Encoded_jfieldId = JNIEnv.GetFieldID (class_ref, "base64Encoded", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, base64Encoded_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr body_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.GetResponseBodyResponse']/field[@name='body']"
			[Register ("body")]
			public string Body {
				get {
					if (body_jfieldId == IntPtr.Zero)
						body_jfieldId = JNIEnv.GetFieldID (class_ref, "body", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, body_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (body_jfieldId == IntPtr.Zero)
						body_jfieldId = JNIEnv.GetFieldID (class_ref, "body", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, body_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$GetResponseBodyResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetResponseBodyResponse); }
			}

			protected GetResponseBodyResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Initiator']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$Initiator", DoNotGenerateAcw=true)]
		public partial class Initiator : global::Java.Lang.Object {


			static IntPtr stackTrace_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Initiator']/field[@name='stackTrace']"
			[Register ("stackTrace")]
			public global::System.Collections.IList StackTrace {
				get {
					if (stackTrace_jfieldId == IntPtr.Zero)
						stackTrace_jfieldId = JNIEnv.GetFieldID (class_ref, "stackTrace", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, stackTrace_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (stackTrace_jfieldId == IntPtr.Zero)
						stackTrace_jfieldId = JNIEnv.GetFieldID (class_ref, "stackTrace", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, stackTrace_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Initiator']/field[@name='type']"
			[Register ("type")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$Initiator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Initiator); }
			}

			protected Initiator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Initiator']/constructor[@name='Network.Initiator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Initiator ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Initiator)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.InitiatorType']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$InitiatorType", DoNotGenerateAcw=true)]
		public sealed partial class InitiatorType : global::Java.Lang.Enum {


			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.InitiatorType']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PARSER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.InitiatorType']/field[@name='PARSER']"
			[Register ("PARSER")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType Parser {
				get {
					if (PARSER_jfieldId == IntPtr.Zero)
						PARSER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARSER", "Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARSER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SCRIPT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.InitiatorType']/field[@name='SCRIPT']"
			[Register ("SCRIPT")]
			public static global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType Script {
				get {
					if (SCRIPT_jfieldId == IntPtr.Zero)
						SCRIPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCRIPT", "Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCRIPT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$InitiatorType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InitiatorType); }
			}

			internal InitiatorType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getProtocolValue;
			public unsafe string ProtocolValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.InitiatorType']/method[@name='getProtocolValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.InitiatorType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.InitiatorType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;", "")]
			public static unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/stetho/inspector/protocol/module/Network$InitiatorType;");
				try {
					return (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.InitiatorType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFailedParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$LoadingFailedParams", DoNotGenerateAcw=true)]
		public partial class LoadingFailedParams : global::Java.Lang.Object {


			static IntPtr errorText_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFailedParams']/field[@name='errorText']"
			[Register ("errorText")]
			public string ErrorText {
				get {
					if (errorText_jfieldId == IntPtr.Zero)
						errorText_jfieldId = JNIEnv.GetFieldID (class_ref, "errorText", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, errorText_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (errorText_jfieldId == IntPtr.Zero)
						errorText_jfieldId = JNIEnv.GetFieldID (class_ref, "errorText", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, errorText_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr requestId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFailedParams']/field[@name='requestId']"
			[Register ("requestId")]
			public string RequestId {
				get {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFailedParams']/field[@name='timestamp']"
			[Register ("timestamp")]
			public double Timestamp {
				get {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
				}
				set {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFailedParams']/field[@name='type']"
			[Register ("type")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$LoadingFailedParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadingFailedParams); }
			}

			protected LoadingFailedParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFailedParams']/constructor[@name='Network.LoadingFailedParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe LoadingFailedParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (LoadingFailedParams)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFinishedParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$LoadingFinishedParams", DoNotGenerateAcw=true)]
		public partial class LoadingFinishedParams : global::Java.Lang.Object {


			static IntPtr requestId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFinishedParams']/field[@name='requestId']"
			[Register ("requestId")]
			public string RequestId {
				get {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFinishedParams']/field[@name='timestamp']"
			[Register ("timestamp")]
			public double Timestamp {
				get {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
				}
				set {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$LoadingFinishedParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadingFinishedParams); }
			}

			protected LoadingFinishedParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.LoadingFinishedParams']/constructor[@name='Network.LoadingFinishedParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe LoadingFinishedParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (LoadingFinishedParams)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Request']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$Request", DoNotGenerateAcw=true)]
		public partial class Request : global::Java.Lang.Object {


			static IntPtr headers_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Request']/field[@name='headers']"
			[Register ("headers")]
			public global::Org.Json.JSONObject Headers {
				get {
					if (headers_jfieldId == IntPtr.Zero)
						headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Lorg/json/JSONObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headers_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (headers_jfieldId == IntPtr.Zero)
						headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Lorg/json/JSONObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headers_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr method_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Request']/field[@name='method']"
			[Register ("method")]
			public string Method {
				get {
					if (method_jfieldId == IntPtr.Zero)
						method_jfieldId = JNIEnv.GetFieldID (class_ref, "method", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, method_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (method_jfieldId == IntPtr.Zero)
						method_jfieldId = JNIEnv.GetFieldID (class_ref, "method", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, method_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr postData_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Request']/field[@name='postData']"
			[Register ("postData")]
			public string PostData {
				get {
					if (postData_jfieldId == IntPtr.Zero)
						postData_jfieldId = JNIEnv.GetFieldID (class_ref, "postData", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, postData_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (postData_jfieldId == IntPtr.Zero)
						postData_jfieldId = JNIEnv.GetFieldID (class_ref, "postData", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, postData_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr url_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Request']/field[@name='url']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$Request", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Request); }
			}

			protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Request']/constructor[@name='Network.Request' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Request ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Request)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$RequestWillBeSentParams", DoNotGenerateAcw=true)]
		public partial class RequestWillBeSentParams : global::Java.Lang.Object {


			static IntPtr documentURL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='documentURL']"
			[Register ("documentURL")]
			public string DocumentURL {
				get {
					if (documentURL_jfieldId == IntPtr.Zero)
						documentURL_jfieldId = JNIEnv.GetFieldID (class_ref, "documentURL", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, documentURL_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (documentURL_jfieldId == IntPtr.Zero)
						documentURL_jfieldId = JNIEnv.GetFieldID (class_ref, "documentURL", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, documentURL_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr frameId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='frameId']"
			[Register ("frameId")]
			public string FrameId {
				get {
					if (frameId_jfieldId == IntPtr.Zero)
						frameId_jfieldId = JNIEnv.GetFieldID (class_ref, "frameId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frameId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (frameId_jfieldId == IntPtr.Zero)
						frameId_jfieldId = JNIEnv.GetFieldID (class_ref, "frameId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr initiator_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='initiator']"
			[Register ("initiator")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.Initiator Initiator {
				get {
					if (initiator_jfieldId == IntPtr.Zero)
						initiator_jfieldId = JNIEnv.GetFieldID (class_ref, "initiator", "Lcom/facebook/stetho/inspector/protocol/module/Network$Initiator;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, initiator_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.Initiator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (initiator_jfieldId == IntPtr.Zero)
						initiator_jfieldId = JNIEnv.GetFieldID (class_ref, "initiator", "Lcom/facebook/stetho/inspector/protocol/module/Network$Initiator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, initiator_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr loaderId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='loaderId']"
			[Register ("loaderId")]
			public string LoaderId {
				get {
					if (loaderId_jfieldId == IntPtr.Zero)
						loaderId_jfieldId = JNIEnv.GetFieldID (class_ref, "loaderId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, loaderId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (loaderId_jfieldId == IntPtr.Zero)
						loaderId_jfieldId = JNIEnv.GetFieldID (class_ref, "loaderId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, loaderId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr redirectResponse_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='redirectResponse']"
			[Register ("redirectResponse")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.Response RedirectResponse {
				get {
					if (redirectResponse_jfieldId == IntPtr.Zero)
						redirectResponse_jfieldId = JNIEnv.GetFieldID (class_ref, "redirectResponse", "Lcom/facebook/stetho/inspector/protocol/module/Network$Response;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, redirectResponse_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.Response> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (redirectResponse_jfieldId == IntPtr.Zero)
						redirectResponse_jfieldId = JNIEnv.GetFieldID (class_ref, "redirectResponse", "Lcom/facebook/stetho/inspector/protocol/module/Network$Response;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, redirectResponse_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr request_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='request']"
			[Register ("request")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.Request Request {
				get {
					if (request_jfieldId == IntPtr.Zero)
						request_jfieldId = JNIEnv.GetFieldID (class_ref, "request", "Lcom/facebook/stetho/inspector/protocol/module/Network$Request;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, request_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.Request> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (request_jfieldId == IntPtr.Zero)
						request_jfieldId = JNIEnv.GetFieldID (class_ref, "request", "Lcom/facebook/stetho/inspector/protocol/module/Network$Request;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, request_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr requestId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='requestId']"
			[Register ("requestId")]
			public string RequestId {
				get {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='timestamp']"
			[Register ("timestamp")]
			public double Timestamp {
				get {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
				}
				set {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/field[@name='type']"
			[Register ("type")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$RequestWillBeSentParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RequestWillBeSentParams); }
			}

			protected RequestWillBeSentParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.RequestWillBeSentParams']/constructor[@name='Network.RequestWillBeSentParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RequestWillBeSentParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (RequestWillBeSentParams)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$ResourceTiming", DoNotGenerateAcw=true)]
		public partial class ResourceTiming : global::Java.Lang.Object {


			static IntPtr connectionEnd_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='connectionEnd']"
			[Register ("connectionEnd")]
			public double ConnectionEnd {
				get {
					if (connectionEnd_jfieldId == IntPtr.Zero)
						connectionEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionEnd", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, connectionEnd_jfieldId);
				}
				set {
					if (connectionEnd_jfieldId == IntPtr.Zero)
						connectionEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionEnd", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectionEnd_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr connectionStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='connectionStart']"
			[Register ("connectionStart")]
			public double ConnectionStart {
				get {
					if (connectionStart_jfieldId == IntPtr.Zero)
						connectionStart_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionStart", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, connectionStart_jfieldId);
				}
				set {
					if (connectionStart_jfieldId == IntPtr.Zero)
						connectionStart_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionStart", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectionStart_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr dnsEnd_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='dnsEnd']"
			[Register ("dnsEnd")]
			public double DnsEnd {
				get {
					if (dnsEnd_jfieldId == IntPtr.Zero)
						dnsEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "dnsEnd", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, dnsEnd_jfieldId);
				}
				set {
					if (dnsEnd_jfieldId == IntPtr.Zero)
						dnsEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "dnsEnd", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dnsEnd_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr dnsStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='dnsStart']"
			[Register ("dnsStart")]
			public double DnsStart {
				get {
					if (dnsStart_jfieldId == IntPtr.Zero)
						dnsStart_jfieldId = JNIEnv.GetFieldID (class_ref, "dnsStart", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, dnsStart_jfieldId);
				}
				set {
					if (dnsStart_jfieldId == IntPtr.Zero)
						dnsStart_jfieldId = JNIEnv.GetFieldID (class_ref, "dnsStart", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dnsStart_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr proxyEnd_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='proxyEnd']"
			[Register ("proxyEnd")]
			public double ProxyEnd {
				get {
					if (proxyEnd_jfieldId == IntPtr.Zero)
						proxyEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "proxyEnd", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, proxyEnd_jfieldId);
				}
				set {
					if (proxyEnd_jfieldId == IntPtr.Zero)
						proxyEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "proxyEnd", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, proxyEnd_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr proxyStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='proxyStart']"
			[Register ("proxyStart")]
			public double ProxyStart {
				get {
					if (proxyStart_jfieldId == IntPtr.Zero)
						proxyStart_jfieldId = JNIEnv.GetFieldID (class_ref, "proxyStart", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, proxyStart_jfieldId);
				}
				set {
					if (proxyStart_jfieldId == IntPtr.Zero)
						proxyStart_jfieldId = JNIEnv.GetFieldID (class_ref, "proxyStart", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, proxyStart_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr receivedHeadersEnd_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='receivedHeadersEnd']"
			[Register ("receivedHeadersEnd")]
			public double ReceivedHeadersEnd {
				get {
					if (receivedHeadersEnd_jfieldId == IntPtr.Zero)
						receivedHeadersEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "receivedHeadersEnd", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, receivedHeadersEnd_jfieldId);
				}
				set {
					if (receivedHeadersEnd_jfieldId == IntPtr.Zero)
						receivedHeadersEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "receivedHeadersEnd", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, receivedHeadersEnd_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr requestTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='requestTime']"
			[Register ("requestTime")]
			public double RequestTime {
				get {
					if (requestTime_jfieldId == IntPtr.Zero)
						requestTime_jfieldId = JNIEnv.GetFieldID (class_ref, "requestTime", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, requestTime_jfieldId);
				}
				set {
					if (requestTime_jfieldId == IntPtr.Zero)
						requestTime_jfieldId = JNIEnv.GetFieldID (class_ref, "requestTime", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestTime_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sendEnd_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='sendEnd']"
			[Register ("sendEnd")]
			public double SendEnd {
				get {
					if (sendEnd_jfieldId == IntPtr.Zero)
						sendEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "sendEnd", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, sendEnd_jfieldId);
				}
				set {
					if (sendEnd_jfieldId == IntPtr.Zero)
						sendEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "sendEnd", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sendEnd_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sendStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='sendStart']"
			[Register ("sendStart")]
			public double SendStart {
				get {
					if (sendStart_jfieldId == IntPtr.Zero)
						sendStart_jfieldId = JNIEnv.GetFieldID (class_ref, "sendStart", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, sendStart_jfieldId);
				}
				set {
					if (sendStart_jfieldId == IntPtr.Zero)
						sendStart_jfieldId = JNIEnv.GetFieldID (class_ref, "sendStart", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sendStart_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sslEnd_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='sslEnd']"
			[Register ("sslEnd")]
			public double SslEnd {
				get {
					if (sslEnd_jfieldId == IntPtr.Zero)
						sslEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "sslEnd", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, sslEnd_jfieldId);
				}
				set {
					if (sslEnd_jfieldId == IntPtr.Zero)
						sslEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "sslEnd", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sslEnd_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sslStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/field[@name='sslStart']"
			[Register ("sslStart")]
			public double SslStart {
				get {
					if (sslStart_jfieldId == IntPtr.Zero)
						sslStart_jfieldId = JNIEnv.GetFieldID (class_ref, "sslStart", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, sslStart_jfieldId);
				}
				set {
					if (sslStart_jfieldId == IntPtr.Zero)
						sslStart_jfieldId = JNIEnv.GetFieldID (class_ref, "sslStart", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sslStart_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$ResourceTiming", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResourceTiming); }
			}

			protected ResourceTiming (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResourceTiming']/constructor[@name='Network.ResourceTiming' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ResourceTiming ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ResourceTiming)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$Response", DoNotGenerateAcw=true)]
		public partial class Response : global::Java.Lang.Object {


			static IntPtr connectionId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='connectionId']"
			[Register ("connectionId")]
			public int ConnectionId {
				get {
					if (connectionId_jfieldId == IntPtr.Zero)
						connectionId_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, connectionId_jfieldId);
				}
				set {
					if (connectionId_jfieldId == IntPtr.Zero)
						connectionId_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectionId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr connectionReused_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='connectionReused']"
			[Register ("connectionReused")]
			public bool ConnectionReused {
				get {
					if (connectionReused_jfieldId == IntPtr.Zero)
						connectionReused_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionReused", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, connectionReused_jfieldId);
				}
				set {
					if (connectionReused_jfieldId == IntPtr.Zero)
						connectionReused_jfieldId = JNIEnv.GetFieldID (class_ref, "connectionReused", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connectionReused_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr fromDiskCache_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='fromDiskCache']"
			[Register ("fromDiskCache")]
			public global::Java.Lang.Boolean FromDiskCache {
				get {
					if (fromDiskCache_jfieldId == IntPtr.Zero)
						fromDiskCache_jfieldId = JNIEnv.GetFieldID (class_ref, "fromDiskCache", "Ljava/lang/Boolean;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, fromDiskCache_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (fromDiskCache_jfieldId == IntPtr.Zero)
						fromDiskCache_jfieldId = JNIEnv.GetFieldID (class_ref, "fromDiskCache", "Ljava/lang/Boolean;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fromDiskCache_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr headers_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='headers']"
			[Register ("headers")]
			public global::Org.Json.JSONObject Headers {
				get {
					if (headers_jfieldId == IntPtr.Zero)
						headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Lorg/json/JSONObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headers_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (headers_jfieldId == IntPtr.Zero)
						headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Lorg/json/JSONObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headers_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr headersText_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='headersText']"
			[Register ("headersText")]
			public string HeadersText {
				get {
					if (headersText_jfieldId == IntPtr.Zero)
						headersText_jfieldId = JNIEnv.GetFieldID (class_ref, "headersText", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headersText_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (headersText_jfieldId == IntPtr.Zero)
						headersText_jfieldId = JNIEnv.GetFieldID (class_ref, "headersText", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headersText_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr mimeType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='mimeType']"
			[Register ("mimeType")]
			public string MimeType {
				get {
					if (mimeType_jfieldId == IntPtr.Zero)
						mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mimeType_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mimeType_jfieldId == IntPtr.Zero)
						mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mimeType_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr requestHeaders_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='requestHeaders']"
			[Register ("requestHeaders")]
			public global::Org.Json.JSONObject RequestHeaders {
				get {
					if (requestHeaders_jfieldId == IntPtr.Zero)
						requestHeaders_jfieldId = JNIEnv.GetFieldID (class_ref, "requestHeaders", "Lorg/json/JSONObject;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, requestHeaders_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (requestHeaders_jfieldId == IntPtr.Zero)
						requestHeaders_jfieldId = JNIEnv.GetFieldID (class_ref, "requestHeaders", "Lorg/json/JSONObject;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestHeaders_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr requestHeadersTest_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='requestHeadersTest']"
			[Register ("requestHeadersTest")]
			public string RequestHeadersTest {
				get {
					if (requestHeadersTest_jfieldId == IntPtr.Zero)
						requestHeadersTest_jfieldId = JNIEnv.GetFieldID (class_ref, "requestHeadersTest", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, requestHeadersTest_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (requestHeadersTest_jfieldId == IntPtr.Zero)
						requestHeadersTest_jfieldId = JNIEnv.GetFieldID (class_ref, "requestHeadersTest", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestHeadersTest_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr status_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='status']"
			[Register ("status")]
			public int Status {
				get {
					if (status_jfieldId == IntPtr.Zero)
						status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, status_jfieldId);
				}
				set {
					if (status_jfieldId == IntPtr.Zero)
						status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, status_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr statusText_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='statusText']"
			[Register ("statusText")]
			public string StatusText {
				get {
					if (statusText_jfieldId == IntPtr.Zero)
						statusText_jfieldId = JNIEnv.GetFieldID (class_ref, "statusText", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, statusText_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (statusText_jfieldId == IntPtr.Zero)
						statusText_jfieldId = JNIEnv.GetFieldID (class_ref, "statusText", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, statusText_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timing_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='timing']"
			[Register ("timing")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.ResourceTiming Timing {
				get {
					if (timing_jfieldId == IntPtr.Zero)
						timing_jfieldId = JNIEnv.GetFieldID (class_ref, "timing", "Lcom/facebook/stetho/inspector/protocol/module/Network$ResourceTiming;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, timing_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.ResourceTiming> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (timing_jfieldId == IntPtr.Zero)
						timing_jfieldId = JNIEnv.GetFieldID (class_ref, "timing", "Lcom/facebook/stetho/inspector/protocol/module/Network$ResourceTiming;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timing_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr url_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/field[@name='url']"
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
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$Response", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Response); }
			}

			protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.Response']/constructor[@name='Network.Response' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Response ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Response)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResponseReceivedParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/Network$ResponseReceivedParams", DoNotGenerateAcw=true)]
		public partial class ResponseReceivedParams : global::Java.Lang.Object {


			static IntPtr frameId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResponseReceivedParams']/field[@name='frameId']"
			[Register ("frameId")]
			public string FrameId {
				get {
					if (frameId_jfieldId == IntPtr.Zero)
						frameId_jfieldId = JNIEnv.GetFieldID (class_ref, "frameId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frameId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (frameId_jfieldId == IntPtr.Zero)
						frameId_jfieldId = JNIEnv.GetFieldID (class_ref, "frameId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr loaderId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResponseReceivedParams']/field[@name='loaderId']"
			[Register ("loaderId")]
			public string LoaderId {
				get {
					if (loaderId_jfieldId == IntPtr.Zero)
						loaderId_jfieldId = JNIEnv.GetFieldID (class_ref, "loaderId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, loaderId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (loaderId_jfieldId == IntPtr.Zero)
						loaderId_jfieldId = JNIEnv.GetFieldID (class_ref, "loaderId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, loaderId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr requestId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResponseReceivedParams']/field[@name='requestId']"
			[Register ("requestId")]
			public string RequestId {
				get {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (requestId_jfieldId == IntPtr.Zero)
						requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr response_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResponseReceivedParams']/field[@name='response']"
			[Register ("response")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.Response Response {
				get {
					if (response_jfieldId == IntPtr.Zero)
						response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "Lcom/facebook/stetho/inspector/protocol/module/Network$Response;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, response_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network.Response> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (response_jfieldId == IntPtr.Zero)
						response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "Lcom/facebook/stetho/inspector/protocol/module/Network$Response;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, response_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResponseReceivedParams']/field[@name='timestamp']"
			[Register ("timestamp")]
			public double Timestamp {
				get {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
				}
				set {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResponseReceivedParams']/field[@name='type']"
			[Register ("type")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network$ResponseReceivedParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResponseReceivedParams); }
			}

			protected ResponseReceivedParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network.ResponseReceivedParams']/constructor[@name='Network.ResponseReceivedParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ResponseReceivedParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ResponseReceivedParams)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/Network", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Network); }
		}

		protected Network (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network']/constructor[@name='Network' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Network (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Network)) {
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
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Disable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network']/method[@name='disable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
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
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network']/method[@name='enable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
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

		static Delegate cb_getResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_getResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_getResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResponseBody (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network']/method[@name='getResponseBody' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getResponseBody", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetGetResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult GetResponseBody (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_getResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getResponseBody", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseBody_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseBody", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_;
#pragma warning disable 0169
		static Delegate GetSetPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_Handler ()
		{
			if (cb_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_ == null)
				cb_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_);
			return cb_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_;
		}

		static void n_SetPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer p0 = (global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPrettyPrinterInitializer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network']/method[@name='setPrettyPrinterInitializer' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.network.AsyncPrettyPrinterInitializer']]"
		[Register ("setPrettyPrinterInitializer", "(Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinterInitializer;)V", "GetSetPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_Handler")]
		public virtual unsafe void SetPrettyPrinterInitializer (global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer p0)
		{
			if (id_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_ == IntPtr.Zero)
				id_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_ = JNIEnv.GetMethodID (class_ref, "setPrettyPrinterInitializer", "(Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinterInitializer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrettyPrinterInitializer", "(Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinterInitializer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_setUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_setUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_SetUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Network> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetUserAgentOverride (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='Network']/method[@name='setUserAgentOverride' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("setUserAgentOverride", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetSetUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void SetUserAgentOverride (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_setUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setUserAgentOverride", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserAgentOverride_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserAgentOverride", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
