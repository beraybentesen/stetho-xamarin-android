using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='RequestBodyHelper']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/RequestBodyHelper", DoNotGenerateAcw=true)]
	public partial class RequestBodyHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/RequestBodyHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestBodyHelper); }
		}

		protected RequestBodyHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='RequestBodyHelper']/constructor[@name='RequestBodyHelper' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.network.NetworkEventReporter'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter;Ljava/lang/String;)V", "")]
		public unsafe RequestBodyHelper (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (RequestBodyHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_hasBody;
#pragma warning disable 0169
		static Delegate GetHasBodyHandler ()
		{
			if (cb_hasBody == null)
				cb_hasBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBody);
			return cb_hasBody;
		}

		static bool n_HasBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.RequestBodyHelper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.RequestBodyHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBody;
		}
#pragma warning restore 0169

		static IntPtr id_hasBody;
		public virtual unsafe bool HasBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='RequestBodyHelper']/method[@name='hasBody' and count(parameter)=0]"
			[Register ("hasBody", "()Z", "GetHasBodyHandler")]
			get {
				if (id_hasBody == IntPtr.Zero)
					id_hasBody = JNIEnv.GetMethodID (class_ref, "hasBody", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasBody);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasBody", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_createBodySink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateBodySink_Ljava_lang_String_Handler ()
		{
			if (cb_createBodySink_Ljava_lang_String_ == null)
				cb_createBodySink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateBodySink_Ljava_lang_String_);
			return cb_createBodySink_Ljava_lang_String_;
		}

		static IntPtr n_CreateBodySink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.RequestBodyHelper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.RequestBodyHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.CreateBodySink (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createBodySink_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='RequestBodyHelper']/method[@name='createBodySink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createBodySink", "(Ljava/lang/String;)Ljava/io/OutputStream;", "GetCreateBodySink_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.IO.Stream CreateBodySink (string p0)
		{
			if (id_createBodySink_Ljava_lang_String_ == IntPtr.Zero)
				id_createBodySink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createBodySink", "(Ljava/lang/String;)Ljava/io/OutputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createBodySink_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createBodySink", "(Ljava/lang/String;)Ljava/io/OutputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDisplayBody;
#pragma warning disable 0169
		static Delegate GetGetDisplayBodyHandler ()
		{
			if (cb_getDisplayBody == null)
				cb_getDisplayBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayBody);
			return cb_getDisplayBody;
		}

		static IntPtr n_GetDisplayBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.RequestBodyHelper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.RequestBodyHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDisplayBody ());
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='RequestBodyHelper']/method[@name='getDisplayBody' and count(parameter)=0]"
		[Register ("getDisplayBody", "()[B", "GetGetDisplayBodyHandler")]
		public virtual unsafe byte[] GetDisplayBody ()
		{
			if (id_getDisplayBody == IntPtr.Zero)
				id_getDisplayBody = JNIEnv.GetMethodID (class_ref, "getDisplayBody", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayBody), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayBody", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_reportDataSent;
#pragma warning disable 0169
		static Delegate GetReportDataSentHandler ()
		{
			if (cb_reportDataSent == null)
				cb_reportDataSent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReportDataSent);
			return cb_reportDataSent;
		}

		static void n_ReportDataSent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.RequestBodyHelper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.RequestBodyHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReportDataSent ();
		}
#pragma warning restore 0169

		static IntPtr id_reportDataSent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='RequestBodyHelper']/method[@name='reportDataSent' and count(parameter)=0]"
		[Register ("reportDataSent", "()V", "GetReportDataSentHandler")]
		public virtual unsafe void ReportDataSent ()
		{
			if (id_reportDataSent == IntPtr.Zero)
				id_reportDataSent = JNIEnv.GetMethodID (class_ref, "reportDataSent", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportDataSent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportDataSent", "()V"));
			} finally {
			}
		}

	}
}
