using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Domstorage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/domstorage/DOMStoragePeerManager", DoNotGenerateAcw=true)]
	public partial class DOMStoragePeerManager : global::Com.Facebook.Stetho.Inspector.Helper.ChromePeerManager {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager.DevToolsSharedPreferencesListener']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/domstorage/DOMStoragePeerManager$DevToolsSharedPreferencesListener", DoNotGenerateAcw=true)]
		public partial class DevToolsSharedPreferencesListener : global::Java.Lang.Object, global::Android.Content.ISharedPreferencesOnSharedPreferenceChangeListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/domstorage/DOMStoragePeerManager$DevToolsSharedPreferencesListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DevToolsSharedPreferencesListener); }
			}

			protected DevToolsSharedPreferencesListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_stetho_inspector_domstorage_DOMStoragePeerManager_Landroid_content_SharedPreferences_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager.DevToolsSharedPreferencesListener']/constructor[@name='DOMStoragePeerManager.DevToolsSharedPreferencesListener' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.inspector.domstorage.DOMStoragePeerManager'] and parameter[2][@type='android.content.SharedPreferences'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/facebook/stetho/inspector/domstorage/DOMStoragePeerManager;Landroid/content/SharedPreferences;Ljava/lang/String;)V", "")]
			public unsafe DevToolsSharedPreferencesListener (global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager __self, global::Android.Content.ISharedPreferences p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					if (GetType () != typeof (DevToolsSharedPreferencesListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/SharedPreferences;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/SharedPreferences;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_facebook_stetho_inspector_domstorage_DOMStoragePeerManager_Landroid_content_SharedPreferences_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_facebook_stetho_inspector_domstorage_DOMStoragePeerManager_Landroid_content_SharedPreferences_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/domstorage/DOMStoragePeerManager;Landroid/content/SharedPreferences;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_domstorage_DOMStoragePeerManager_Landroid_content_SharedPreferences_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_domstorage_DOMStoragePeerManager_Landroid_content_SharedPreferences_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_Handler ()
			{
				if (cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ == null)
					cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_);
				return cb_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_;
			}

			static void n_OnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager.DevToolsSharedPreferencesListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager.DevToolsSharedPreferencesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.ISharedPreferences p0 = (global::Android.Content.ISharedPreferences)global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSharedPreferenceChanged (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager.DevToolsSharedPreferencesListener']/method[@name='onSharedPreferenceChanged' and count(parameter)=2 and parameter[1][@type='android.content.SharedPreferences'] and parameter[2][@type='java.lang.String']]"
			[Register ("onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V", "GetOnSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_Handler")]
			public virtual unsafe void OnSharedPreferenceChanged (global::Android.Content.ISharedPreferences p0, string p1)
			{
				if (id_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ == IntPtr.Zero)
					id_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSharedPreferenceChanged_Landroid_content_SharedPreferences_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_unregister;
#pragma warning disable 0169
			static Delegate GetUnregisterHandler ()
			{
				if (cb_unregister == null)
					cb_unregister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unregister);
				return cb_unregister;
			}

			static void n_Unregister (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager.DevToolsSharedPreferencesListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager.DevToolsSharedPreferencesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Unregister ();
			}
#pragma warning restore 0169

			static IntPtr id_unregister;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager.DevToolsSharedPreferencesListener']/method[@name='unregister' and count(parameter)=0]"
			[Register ("unregister", "()V", "GetUnregisterHandler")]
			public virtual unsafe void Unregister ()
			{
				if (id_unregister == IntPtr.Zero)
					id_unregister = JNIEnv.GetMethodID (class_ref, "unregister", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/domstorage/DOMStoragePeerManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DOMStoragePeerManager); }
		}

		protected DOMStoragePeerManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager']/constructor[@name='DOMStoragePeerManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DOMStoragePeerManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DOMStoragePeerManager)) {
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

		static Delegate cb_signalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSignalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_signalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_signalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SignalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_);
			return cb_signalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SignalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SignalItemAdded (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_signalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager']/method[@name='signalItemAdded' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.inspector.protocol.module.DOMStorage.StorageId'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("signalItemAdded", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;Ljava/lang/String;)V", "GetSignalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SignalItemAdded (global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId p0, string p1, string p2)
		{
			if (id_signalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_signalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "signalItemAdded", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signalItemAdded_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signalItemAdded", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_signalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSignalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Handler ()
		{
			if (cb_signalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_ == null)
				cb_signalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SignalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_);
			return cb_signalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_;
		}

		static void n_SignalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SignalItemRemoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_signalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager']/method[@name='signalItemRemoved' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.protocol.module.DOMStorage.StorageId'] and parameter[2][@type='java.lang.String']]"
		[Register ("signalItemRemoved", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;)V", "GetSignalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Handler")]
		public virtual unsafe void SignalItemRemoved (global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId p0, string p1)
		{
			if (id_signalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_ == IntPtr.Zero)
				id_signalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "signalItemRemoved", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signalItemRemoved_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signalItemRemoved", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_signalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSignalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_signalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_signalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SignalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_signalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SignalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Domstorage.DOMStoragePeerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SignalItemUpdated (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_signalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.domstorage']/class[@name='DOMStoragePeerManager']/method[@name='signalItemUpdated' and count(parameter)=4 and parameter[1][@type='com.facebook.stetho.inspector.protocol.module.DOMStorage.StorageId'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("signalItemUpdated", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSignalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SignalItemUpdated (global::Com.Facebook.Stetho.Inspector.Protocol.Module.DOMStorage.StorageId p0, string p1, string p2, string p3)
		{
			if (id_signalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_signalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "signalItemUpdated", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_signalItemUpdated_Lcom_facebook_stetho_inspector_protocol_module_DOMStorage_StorageId_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signalItemUpdated", "(Lcom/facebook/stetho/inspector/protocol/module/DOMStorage$StorageId;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
