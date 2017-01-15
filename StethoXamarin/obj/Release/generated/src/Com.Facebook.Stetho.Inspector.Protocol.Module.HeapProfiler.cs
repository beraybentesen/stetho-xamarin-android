using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='HeapProfiler']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/HeapProfiler", DoNotGenerateAcw=true)]
	public partial class HeapProfiler : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Protocol.IChromeDevtoolsDomain {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='HeapProfiler.ProfileHeader']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/HeapProfiler$ProfileHeader", DoNotGenerateAcw=true)]
		public partial class ProfileHeader : global::Java.Lang.Object {


			static IntPtr title_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='HeapProfiler.ProfileHeader']/field[@name='title']"
			[Register ("title")]
			public string Title {
				get {
					if (title_jfieldId == IntPtr.Zero)
						title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, title_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (title_jfieldId == IntPtr.Zero)
						title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, title_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr uid_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='HeapProfiler.ProfileHeader']/field[@name='uid']"
			[Register ("uid")]
			public int Uid {
				get {
					if (uid_jfieldId == IntPtr.Zero)
						uid_jfieldId = JNIEnv.GetFieldID (class_ref, "uid", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, uid_jfieldId);
				}
				set {
					if (uid_jfieldId == IntPtr.Zero)
						uid_jfieldId = JNIEnv.GetFieldID (class_ref, "uid", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, uid_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/HeapProfiler$ProfileHeader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProfileHeader); }
			}

			protected ProfileHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='HeapProfiler.ProfileHeaderResponse']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/protocol/module/HeapProfiler$ProfileHeaderResponse", DoNotGenerateAcw=true)]
		public partial class ProfileHeaderResponse : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult {


			static IntPtr headers_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='HeapProfiler.ProfileHeaderResponse']/field[@name='headers']"
			[Register ("headers")]
			public global::System.Collections.IList Headers {
				get {
					if (headers_jfieldId == IntPtr.Zero)
						headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headers_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (headers_jfieldId == IntPtr.Zero)
						headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headers_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/HeapProfiler$ProfileHeaderResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProfileHeaderResponse); }
			}

			protected ProfileHeaderResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/protocol/module/HeapProfiler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeapProfiler); }
		}

		protected HeapProfiler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='HeapProfiler']/constructor[@name='HeapProfiler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HeapProfiler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HeapProfiler)) {
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

		static Delegate cb_getProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == null)
				cb_getProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_);
			return cb_getProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.HeapProfiler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.HeapProfiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProfileHeaders (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/class[@name='HeapProfiler']/method[@name='getProfileHeaders' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getProfileHeaders", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;", "GetGetProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult GetProfileHeaders (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Org.Json.JSONObject p1)
		{
			if (id_getProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getProfileHeaders", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProfileHeaders_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Jsonrpc.IJsonRpcResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProfileHeaders", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lorg/json/JSONObject;)Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
