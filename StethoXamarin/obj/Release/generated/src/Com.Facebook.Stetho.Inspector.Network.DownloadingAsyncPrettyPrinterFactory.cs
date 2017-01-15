using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory", DoNotGenerateAcw=true)]
	public abstract partial class DownloadingAsyncPrettyPrinterFactory : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinterFactory {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory.MatchResult']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory$MatchResult", DoNotGenerateAcw=true)]
		protected internal partial class MatchResult : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory$MatchResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MatchResult); }
			}

			protected MatchResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_stetho_inspector_network_DownloadingAsyncPrettyPrinterFactory_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_PrettyPrinterDisplayType_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory.MatchResult']/constructor[@name='DownloadingAsyncPrettyPrinterFactory.MatchResult' and count(parameter)=3 and parameter[1][@type='com.facebook.stetho.inspector.network.DownloadingAsyncPrettyPrinterFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.stetho.inspector.network.PrettyPrinterDisplayType']]"
			[Register (".ctor", "(Lcom/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory;Ljava/lang/String;Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;)V", "")]
			public unsafe MatchResult (global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory __self, string p1, global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (MatchResult)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;)V", __args);
						return;
					}

					if (id_ctor_Lcom_facebook_stetho_inspector_network_DownloadingAsyncPrettyPrinterFactory_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_PrettyPrinterDisplayType_ == IntPtr.Zero)
						id_ctor_Lcom_facebook_stetho_inspector_network_DownloadingAsyncPrettyPrinterFactory_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_PrettyPrinterDisplayType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory;Ljava/lang/String;Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_stetho_inspector_network_DownloadingAsyncPrettyPrinterFactory_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_PrettyPrinterDisplayType_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_stetho_inspector_network_DownloadingAsyncPrettyPrinterFactory_Ljava_lang_String_Lcom_facebook_stetho_inspector_network_PrettyPrinterDisplayType_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_getDisplayType;
#pragma warning disable 0169
			static Delegate GetGetDisplayTypeHandler ()
			{
				if (cb_getDisplayType == null)
					cb_getDisplayType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayType);
				return cb_getDisplayType;
			}

			static IntPtr n_GetDisplayType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory.MatchResult __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory.MatchResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DisplayType);
			}
#pragma warning restore 0169

			static IntPtr id_getDisplayType;
			public virtual unsafe global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType DisplayType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory.MatchResult']/method[@name='getDisplayType' and count(parameter)=0]"
				[Register ("getDisplayType", "()Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;", "GetGetDisplayTypeHandler")]
				get {
					if (id_getDisplayType == IntPtr.Zero)
						id_getDisplayType = JNIEnv.GetMethodID (class_ref, "getDisplayType", "()Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayType), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.PrettyPrinterDisplayType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayType", "()Lcom/facebook/stetho/inspector/network/PrettyPrinterDisplayType;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getSchemaUri;
#pragma warning disable 0169
			static Delegate GetGetSchemaUriHandler ()
			{
				if (cb_getSchemaUri == null)
					cb_getSchemaUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSchemaUri);
				return cb_getSchemaUri;
			}

			static IntPtr n_GetSchemaUri (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory.MatchResult __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory.MatchResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.SchemaUri);
			}
#pragma warning restore 0169

			static IntPtr id_getSchemaUri;
			public virtual unsafe string SchemaUri {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory.MatchResult']/method[@name='getSchemaUri' and count(parameter)=0]"
				[Register ("getSchemaUri", "()Ljava/lang/String;", "GetGetSchemaUriHandler")]
				get {
					if (id_getSchemaUri == IntPtr.Zero)
						id_getSchemaUri = JNIEnv.GetMethodID (class_ref, "getSchemaUri", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSchemaUri), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSchemaUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadingAsyncPrettyPrinterFactory); }
		}

		protected DownloadingAsyncPrettyPrinterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory']/constructor[@name='DownloadingAsyncPrettyPrinterFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DownloadingAsyncPrettyPrinterFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DownloadingAsyncPrettyPrinterFactory)) {
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

		static Delegate cb_doPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_Handler ()
		{
			if (cb_doPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_ == null)
				cb_doPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_);
			return cb_doPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_;
		}

		static void n_DoPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PrintWriter p0 = global::Java.Lang.Object.GetObject<global::Java.IO.PrintWriter> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DoPrint (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory']/method[@name='doPrint' and count(parameter)=3 and parameter[1][@type='java.io.PrintWriter'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='java.lang.String']]"
		[Register ("doPrint", "(Ljava/io/PrintWriter;Ljava/io/InputStream;Ljava/lang/String;)V", "GetDoPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_Handler")]
		protected abstract void DoPrint (global::Java.IO.PrintWriter p0, global::System.IO.Stream p1, string p2);

		static Delegate cb_getInstance_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInstance_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getInstance_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getInstance_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInstance_Ljava_lang_String_Ljava_lang_String_);
			return cb_getInstance_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetInstance_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInstance (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInstance_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinter;", "GetGetInstance_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter GetInstance (string p0, string p1)
		{
			if (id_getInstance_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInstance_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IAsyncPrettyPrinter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/AsyncPrettyPrinter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_matchAndParseHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMatchAndParseHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_matchAndParseHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_matchAndParseHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MatchAndParseHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_matchAndParseHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_MatchAndParseHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MatchAndParseHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory']/method[@name='matchAndParseHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("matchAndParseHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory$MatchResult;", "GetMatchAndParseHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected abstract global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory.MatchResult MatchAndParseHeader (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory", DoNotGenerateAcw=true)]
	internal partial class DownloadingAsyncPrettyPrinterFactoryInvoker : DownloadingAsyncPrettyPrinterFactory {

		public DownloadingAsyncPrettyPrinterFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadingAsyncPrettyPrinterFactoryInvoker); }
		}

		static IntPtr id_doPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory']/method[@name='doPrint' and count(parameter)=3 and parameter[1][@type='java.io.PrintWriter'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='java.lang.String']]"
		[Register ("doPrint", "(Ljava/io/PrintWriter;Ljava/io/InputStream;Ljava/lang/String;)V", "GetDoPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_Handler")]
		protected override unsafe void DoPrint (global::Java.IO.PrintWriter p0, global::System.IO.Stream p1, string p2)
		{
			if (id_doPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_doPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doPrint", "(Ljava/io/PrintWriter;Ljava/io/InputStream;Ljava/lang/String;)V");
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doPrint_Ljava_io_PrintWriter_Ljava_io_InputStream_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_matchAndParseHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='DownloadingAsyncPrettyPrinterFactory']/method[@name='matchAndParseHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("matchAndParseHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory$MatchResult;", "GetMatchAndParseHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected override unsafe global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory.MatchResult MatchAndParseHeader (string p0, string p1)
		{
			if (id_matchAndParseHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_matchAndParseHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "matchAndParseHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/stetho/inspector/network/DownloadingAsyncPrettyPrinterFactory$MatchResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory.MatchResult __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.DownloadingAsyncPrettyPrinterFactory.MatchResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_matchAndParseHeader_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
