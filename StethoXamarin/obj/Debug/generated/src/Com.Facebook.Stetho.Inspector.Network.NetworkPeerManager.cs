using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkPeerManager']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/NetworkPeerManager", DoNotGenerateAcw=true)]
	public partial class NetworkPeerManager : global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/NetworkPeerManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkPeerManager); }
		}

		protected NetworkPeerManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_network_ResponseBodyFileManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkPeerManager']/constructor[@name='NetworkPeerManager' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.network.ResponseBodyFileManager']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/network/ResponseBodyFileManager;)V", "")]
		public unsafe NetworkPeerManager (global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (NetworkPeerManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/inspector/network/ResponseBodyFileManager;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/inspector/network/ResponseBodyFileManager;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_inspector_network_ResponseBodyFileManager_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_inspector_network_ResponseBodyFileManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/network/ResponseBodyFileManager;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_network_ResponseBodyFileManager_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_network_ResponseBodyFileManager_, __args);
			} finally {
			}
		}

		static Delegate cb_getAsyncPrettyPrinterRegistry;
#pragma warning disable 0169
		static Delegate GetGetAsyncPrettyPrinterRegistryHandler ()
		{
			if (cb_getAsyncPrettyPrinterRegistry == null)
				cb_getAsyncPrettyPrinterRegistry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsyncPrettyPrinterRegistry);
			return cb_getAsyncPrettyPrinterRegistry;
		}

		static IntPtr n_GetAsyncPrettyPrinterRegistry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsyncPrettyPrinterRegistry);
		}
#pragma warning restore 0169

		static IntPtr id_getAsyncPrettyPrinterRegistry;
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Network.AsyncPrettyPrinterRegistry AsyncPrettyPrinterRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkPeerManager']/method[@name='getAsyncPrettyPrinterRegistry' and count(parameter)=0]"
			[Register ("getAsyncPrettyPrinterRegistry", "()Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinterRegistry;", "GetGetAsyncPrettyPrinterRegistryHandler")]
			get {
				if (id_getAsyncPrettyPrinterRegistry == IntPtr.Zero)
					id_getAsyncPrettyPrinterRegistry = JNIEnv.GetMethodID (class_ref, "getAsyncPrettyPrinterRegistry", "()Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinterRegistry;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.AsyncPrettyPrinterRegistry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsyncPrettyPrinterRegistry), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.AsyncPrettyPrinterRegistry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsyncPrettyPrinterRegistry", "()Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinterRegistry;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstanceOrNull;
		public static unsafe global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager InstanceOrNull {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkPeerManager']/method[@name='getInstanceOrNull' and count(parameter)=0]"
			[Register ("getInstanceOrNull", "()Lcom/facebook/stetho/inspector/network/NetworkPeerManager;", "GetGetInstanceOrNullHandler")]
			get {
				if (id_getInstanceOrNull == IntPtr.Zero)
					id_getInstanceOrNull = JNIEnv.GetStaticMethodID (class_ref, "getInstanceOrNull", "()Lcom/facebook/stetho/inspector/network/NetworkPeerManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstanceOrNull), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseBodyFileManager;
#pragma warning disable 0169
		static Delegate GetGetResponseBodyFileManagerHandler ()
		{
			if (cb_getResponseBodyFileManager == null)
				cb_getResponseBodyFileManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseBodyFileManager);
			return cb_getResponseBodyFileManager;
		}

		static IntPtr n_GetResponseBodyFileManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseBodyFileManager);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseBodyFileManager;
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager ResponseBodyFileManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkPeerManager']/method[@name='getResponseBodyFileManager' and count(parameter)=0]"
			[Register ("getResponseBodyFileManager", "()Lcom/facebook/stetho/inspector/network/ResponseBodyFileManager;", "GetGetResponseBodyFileManagerHandler")]
			get {
				if (id_getResponseBodyFileManager == IntPtr.Zero)
					id_getResponseBodyFileManager = JNIEnv.GetMethodID (class_ref, "getResponseBodyFileManager", "()Lcom/facebook/stetho/inspector/network/ResponseBodyFileManager;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseBodyFileManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResponseBodyFileManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseBodyFileManager", "()Lcom/facebook/stetho/inspector/network/ResponseBodyFileManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOrCreateInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkPeerManager']/method[@name='getOrCreateInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOrCreateInstance", "(Landroid/content/Context;)Lcom/facebook/stetho/inspector/network/NetworkPeerManager;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager GetOrCreateInstance (global::Android.Content.Context p0)
		{
			if (id_getOrCreateInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getOrCreateInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getOrCreateInstance", "(Landroid/content/Context;)Lcom/facebook/stetho/inspector/network/NetworkPeerManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOrCreateInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.NetworkPeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer p0 = (global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterInitializer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPrettyPrinterInitializer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPrettyPrinterInitializer_Lcom_facebook_stetho_inspector_network_AsyncPrettyPrinterInitializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='NetworkPeerManager']/method[@name='setPrettyPrinterInitializer' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.network.AsyncPrettyPrinterInitializer']]"
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

	}
}
