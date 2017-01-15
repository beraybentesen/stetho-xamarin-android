using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResourceTypeHelper']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/ResourceTypeHelper", DoNotGenerateAcw=true)]
	public partial class ResourceTypeHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/ResourceTypeHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceTypeHelper); }
		}

		protected ResourceTypeHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResourceTypeHelper']/constructor[@name='ResourceTypeHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceTypeHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ResourceTypeHelper)) {
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

		static Delegate cb_determineResourceType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDetermineResourceType_Ljava_lang_String_Handler ()
		{
			if (cb_determineResourceType_Ljava_lang_String_ == null)
				cb_determineResourceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DetermineResourceType_Ljava_lang_String_);
			return cb_determineResourceType_Ljava_lang_String_;
		}

		static IntPtr n_DetermineResourceType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.ResourceTypeHelper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResourceTypeHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DetermineResourceType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_determineResourceType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResourceTypeHelper']/method[@name='determineResourceType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("determineResourceType", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;", "GetDetermineResourceType_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType DetermineResourceType (string p0)
		{
			if (id_determineResourceType_Ljava_lang_String_ == IntPtr.Zero)
				id_determineResourceType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "determineResourceType", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_determineResourceType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.ResourceType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "determineResourceType", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/protocol/module/Page$ResourceType;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_stripContentExtras_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStripContentExtras_Ljava_lang_String_Handler ()
		{
			if (cb_stripContentExtras_Ljava_lang_String_ == null)
				cb_stripContentExtras_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StripContentExtras_Ljava_lang_String_);
			return cb_stripContentExtras_Ljava_lang_String_;
		}

		static IntPtr n_StripContentExtras_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.ResourceTypeHelper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.ResourceTypeHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.StripContentExtras (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_stripContentExtras_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='ResourceTypeHelper']/method[@name='stripContentExtras' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stripContentExtras", "(Ljava/lang/String;)Ljava/lang/String;", "GetStripContentExtras_Ljava_lang_String_Handler")]
		public virtual unsafe string StripContentExtras (string p0)
		{
			if (id_stripContentExtras_Ljava_lang_String_ == IntPtr.Zero)
				id_stripContentExtras_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stripContentExtras", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_stripContentExtras_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stripContentExtras", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
