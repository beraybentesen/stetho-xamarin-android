using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOMStorage", DoNotGenerateAcw=true)]
	public partial class DOMStorage : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DOMStorageAssignmentException']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DOMStorageAssignmentException", DoNotGenerateAcw=true)]
		public partial class DOMStorageAssignmentException : global::Java.Lang.Exception {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DOMStorageAssignmentException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DOMStorageAssignmentException); }
			}

			protected DOMStorageAssignmentException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DOMStorageAssignmentException']/constructor[@name='DOMStorage.DOMStorageAssignmentException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe DOMStorageAssignmentException (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (DOMStorageAssignmentException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemAddedParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DomStorageItemAddedParams", DoNotGenerateAcw=true)]
		public partial class DomStorageItemAddedParams : global::Java.Lang.Object {


			static IntPtr key_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemAddedParams']/field[@name='key']"
			[Register ("key")]
			public string Key {
				get {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, key_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, key_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr newValue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemAddedParams']/field[@name='newValue']"
			[Register ("newValue")]
			public string NewValue {
				get {
					if (newValue_jfieldId == IntPtr.Zero)
						newValue_jfieldId = JNIEnv.GetFieldID (class_ref, "newValue", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, newValue_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (newValue_jfieldId == IntPtr.Zero)
						newValue_jfieldId = JNIEnv.GetFieldID (class_ref, "newValue", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, newValue_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr storageId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemAddedParams']/field[@name='storageId']"
			[Register ("storageId")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId StorageId {
				get {
					if (storageId_jfieldId == IntPtr.Zero)
						storageId_jfieldId = JNIEnv.GetFieldID (class_ref, "storageId", "Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, storageId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (storageId_jfieldId == IntPtr.Zero)
						storageId_jfieldId = JNIEnv.GetFieldID (class_ref, "storageId", "Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, storageId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DomStorageItemAddedParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DomStorageItemAddedParams); }
			}

			protected DomStorageItemAddedParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemAddedParams']/constructor[@name='DOMStorage.DomStorageItemAddedParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DomStorageItemAddedParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DomStorageItemAddedParams)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemRemovedParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DomStorageItemRemovedParams", DoNotGenerateAcw=true)]
		public partial class DomStorageItemRemovedParams : global::Java.Lang.Object {


			static IntPtr key_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemRemovedParams']/field[@name='key']"
			[Register ("key")]
			public string Key {
				get {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, key_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, key_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr storageId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemRemovedParams']/field[@name='storageId']"
			[Register ("storageId")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId StorageId {
				get {
					if (storageId_jfieldId == IntPtr.Zero)
						storageId_jfieldId = JNIEnv.GetFieldID (class_ref, "storageId", "Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, storageId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (storageId_jfieldId == IntPtr.Zero)
						storageId_jfieldId = JNIEnv.GetFieldID (class_ref, "storageId", "Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, storageId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DomStorageItemRemovedParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DomStorageItemRemovedParams); }
			}

			protected DomStorageItemRemovedParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemRemovedParams']/constructor[@name='DOMStorage.DomStorageItemRemovedParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DomStorageItemRemovedParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DomStorageItemRemovedParams)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemUpdatedParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DomStorageItemUpdatedParams", DoNotGenerateAcw=true)]
		public partial class DomStorageItemUpdatedParams : global::Java.Lang.Object {


			static IntPtr key_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemUpdatedParams']/field[@name='key']"
			[Register ("key")]
			public string Key {
				get {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, key_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (key_jfieldId == IntPtr.Zero)
						key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, key_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr newValue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemUpdatedParams']/field[@name='newValue']"
			[Register ("newValue")]
			public string NewValue {
				get {
					if (newValue_jfieldId == IntPtr.Zero)
						newValue_jfieldId = JNIEnv.GetFieldID (class_ref, "newValue", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, newValue_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (newValue_jfieldId == IntPtr.Zero)
						newValue_jfieldId = JNIEnv.GetFieldID (class_ref, "newValue", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, newValue_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr oldValue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemUpdatedParams']/field[@name='oldValue']"
			[Register ("oldValue")]
			public string OldValue {
				get {
					if (oldValue_jfieldId == IntPtr.Zero)
						oldValue_jfieldId = JNIEnv.GetFieldID (class_ref, "oldValue", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, oldValue_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (oldValue_jfieldId == IntPtr.Zero)
						oldValue_jfieldId = JNIEnv.GetFieldID (class_ref, "oldValue", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, oldValue_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr storageId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemUpdatedParams']/field[@name='storageId']"
			[Register ("storageId")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId StorageId {
				get {
					if (storageId_jfieldId == IntPtr.Zero)
						storageId_jfieldId = JNIEnv.GetFieldID (class_ref, "storageId", "Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, storageId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (storageId_jfieldId == IntPtr.Zero)
						storageId_jfieldId = JNIEnv.GetFieldID (class_ref, "storageId", "Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, storageId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DomStorageItemUpdatedParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DomStorageItemUpdatedParams); }
			}

			protected DomStorageItemUpdatedParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemUpdatedParams']/constructor[@name='DOMStorage.DomStorageItemUpdatedParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DomStorageItemUpdatedParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DomStorageItemUpdatedParams)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemsClearedParams']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DomStorageItemsClearedParams", DoNotGenerateAcw=true)]
		public partial class DomStorageItemsClearedParams : global::Java.Lang.Object {


			static IntPtr storageId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemsClearedParams']/field[@name='storageId']"
			[Register ("storageId")]
			public global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId StorageId {
				get {
					if (storageId_jfieldId == IntPtr.Zero)
						storageId_jfieldId = JNIEnv.GetFieldID (class_ref, "storageId", "Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, storageId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (storageId_jfieldId == IntPtr.Zero)
						storageId_jfieldId = JNIEnv.GetFieldID (class_ref, "storageId", "Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, storageId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOMStorage$DomStorageItemsClearedParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DomStorageItemsClearedParams); }
			}

			protected DomStorageItemsClearedParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.DomStorageItemsClearedParams']/constructor[@name='DOMStorage.DomStorageItemsClearedParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DomStorageItemsClearedParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DomStorageItemsClearedParams)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.GetDOMStorageItemsResult']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOMStorage$GetDOMStorageItemsResult", DoNotGenerateAcw=true)]
		public partial class GetDOMStorageItemsResult : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr entries_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.GetDOMStorageItemsResult']/field[@name='entries']"
			[Register ("entries")]
			public global::System.Collections.IList Entries {
				get {
					if (entries_jfieldId == IntPtr.Zero)
						entries_jfieldId = JNIEnv.GetFieldID (class_ref, "entries", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, entries_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (entries_jfieldId == IntPtr.Zero)
						entries_jfieldId = JNIEnv.GetFieldID (class_ref, "entries", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, entries_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOMStorage$GetDOMStorageItemsResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetDOMStorageItemsResult); }
			}

			protected GetDOMStorageItemsResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.StorageId']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId", DoNotGenerateAcw=true)]
		public partial class StorageId : global::Java.Lang.Object {


			static IntPtr isLocalStorage_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.StorageId']/field[@name='isLocalStorage']"
			[Register ("isLocalStorage")]
			public bool IsLocalStorage {
				get {
					if (isLocalStorage_jfieldId == IntPtr.Zero)
						isLocalStorage_jfieldId = JNIEnv.GetFieldID (class_ref, "isLocalStorage", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isLocalStorage_jfieldId);
				}
				set {
					if (isLocalStorage_jfieldId == IntPtr.Zero)
						isLocalStorage_jfieldId = JNIEnv.GetFieldID (class_ref, "isLocalStorage", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isLocalStorage_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr securityOrigin_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.StorageId']/field[@name='securityOrigin']"
			[Register ("securityOrigin")]
			public string SecurityOrigin {
				get {
					if (securityOrigin_jfieldId == IntPtr.Zero)
						securityOrigin_jfieldId = JNIEnv.GetFieldID (class_ref, "securityOrigin", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, securityOrigin_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (securityOrigin_jfieldId == IntPtr.Zero)
						securityOrigin_jfieldId = JNIEnv.GetFieldID (class_ref, "securityOrigin", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, securityOrigin_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StorageId); }
			}

			protected StorageId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage.StorageId']/constructor[@name='DOMStorage.StorageId' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe StorageId ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (StorageId)) {
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
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/DOMStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DOMStorage); }
		}

		protected DOMStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage']/constructor[@name='DOMStorage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DOMStorage (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DOMStorage)) {
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
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Disable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_disable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage']/method[@name='disable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
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
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enable_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage']/method[@name='enable' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
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

		static Delegate cb_getDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_getDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_getDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDOMStorageItems (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage']/method[@name='getDOMStorageItems' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getDOMStorageItems", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetGetDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult GetDOMStorageItems (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_getDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getDOMStorageItems", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDOMStorageItems_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDOMStorageItems", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetRemoveDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_removeDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_removeDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_removeDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_RemoveDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDOMStorageItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage']/method[@name='removeDOMStorageItem' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("removeDOMStorageItem", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetRemoveDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void RemoveDOMStorageItem (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_removeDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_removeDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "removeDOMStorageItem", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeDOMStorageItem", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_setDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_setDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static void n_SetDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDOMStorageItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='DOMStorage']/method[@name='setDOMStorageItem' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("setDOMStorageItem", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V", "GetSetDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void SetDOMStorageItem (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_setDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setDOMStorageItem", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDOMStorageItem_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDOMStorageItem", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
