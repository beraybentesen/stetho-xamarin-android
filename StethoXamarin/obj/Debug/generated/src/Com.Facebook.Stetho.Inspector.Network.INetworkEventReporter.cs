using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorHeaders']"
	[Register ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorHeaders", "", "Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeadersInvoker")]
	public partial interface INetworkEventReporterInspectorHeaders : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorHeaders']/method[@name='firstHeaderValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("firstHeaderValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetFirstHeaderValue_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeadersInvoker, StethoXamarin")]
		string FirstHeaderValue (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorHeaders']/method[@name='headerCount' and count(parameter)=0]"
		[Register ("headerCount", "()I", "GetHeaderCountHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeadersInvoker, StethoXamarin")]
		int HeaderCount ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorHeaders']/method[@name='headerName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("headerName", "(I)Ljava/lang/String;", "GetHeaderName_IHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeadersInvoker, StethoXamarin")]
		string HeaderName (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorHeaders']/method[@name='headerValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("headerValue", "(I)Ljava/lang/String;", "GetHeaderValue_IHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeadersInvoker, StethoXamarin")]
		string HeaderValue (int p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorHeaders", DoNotGenerateAcw=true)]
	internal class INetworkEventReporterInspectorHeadersInvoker : global::Java.Lang.Object, INetworkEventReporterInspectorHeaders {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorHeaders");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkEventReporterInspectorHeadersInvoker); }
		}

		IntPtr class_ref;

		public static INetworkEventReporterInspectorHeaders GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkEventReporterInspectorHeaders> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.network.NetworkEventReporter.InspectorHeaders"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkEventReporterInspectorHeadersInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_firstHeaderValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFirstHeaderValue_Ljava_lang_String_Handler ()
		{
			if (cb_firstHeaderValue_Ljava_lang_String_ == null)
				cb_firstHeaderValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FirstHeaderValue_Ljava_lang_String_);
			return cb_firstHeaderValue_Ljava_lang_String_;
		}

		static IntPtr n_FirstHeaderValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FirstHeaderValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_firstHeaderValue_Ljava_lang_String_;
		public unsafe string FirstHeaderValue (string p0)
		{
			if (id_firstHeaderValue_Ljava_lang_String_ == IntPtr.Zero)
				id_firstHeaderValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "firstHeaderValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_firstHeaderValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_headerCount;
#pragma warning disable 0169
		static Delegate GetHeaderCountHandler ()
		{
			if (cb_headerCount == null)
				cb_headerCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HeaderCount);
			return cb_headerCount;
		}

		static int n_HeaderCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderCount ();
		}
#pragma warning restore 0169

		IntPtr id_headerCount;
		public unsafe int HeaderCount ()
		{
			if (id_headerCount == IntPtr.Zero)
				id_headerCount = JNIEnv.GetMethodID (class_ref, "headerCount", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_headerCount);
		}

		static Delegate cb_headerName_I;
#pragma warning disable 0169
		static Delegate GetHeaderName_IHandler ()
		{
			if (cb_headerName_I == null)
				cb_headerName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderName_I);
			return cb_headerName_I;
		}

		static IntPtr n_HeaderName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderName (p0));
		}
#pragma warning restore 0169

		IntPtr id_headerName_I;
		public unsafe string HeaderName (int p0)
		{
			if (id_headerName_I == IntPtr.Zero)
				id_headerName_I = JNIEnv.GetMethodID (class_ref, "headerName", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerName_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_headerValue_I;
#pragma warning disable 0169
		static Delegate GetHeaderValue_IHandler ()
		{
			if (cb_headerValue_I == null)
				cb_headerValue_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderValue_I);
			return cb_headerValue_I;
		}

		static IntPtr n_HeaderValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderValue (p0));
		}
#pragma warning restore 0169

		IntPtr id_headerValue_I;
		public unsafe string HeaderValue (int p0)
		{
			if (id_headerValue_I == IntPtr.Zero)
				id_headerValue_I = JNIEnv.GetMethodID (class_ref, "headerValue", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerValue_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorRequest']"
	[Register ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorRequest", "", "Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequestInvoker")]
	public partial interface INetworkEventReporterInspectorRequest : global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorRequest']/method[@name='body' and count(parameter)=0]"
		[Register ("body", "()[B", "GetBodyHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequestInvoker, StethoXamarin")]
		byte[] Body ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorRequest']/method[@name='friendlyName' and count(parameter)=0]"
		[Register ("friendlyName", "()Ljava/lang/String;", "GetFriendlyNameHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequestInvoker, StethoXamarin")]
		string FriendlyName ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorRequest']/method[@name='friendlyNameExtra' and count(parameter)=0]"
		[Register ("friendlyNameExtra", "()Ljava/lang/Integer;", "GetFriendlyNameExtraHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequestInvoker, StethoXamarin")]
		global::Java.Lang.Integer FriendlyNameExtra ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorRequest']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "GetIdHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequestInvoker, StethoXamarin")]
		string Id ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorRequest']/method[@name='method' and count(parameter)=0]"
		[Register ("method", "()Ljava/lang/String;", "GetMethodHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequestInvoker, StethoXamarin")]
		string Method ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorRequest']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/lang/String;", "GetUrlHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequestInvoker, StethoXamarin")]
		string Url ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorRequest", DoNotGenerateAcw=true)]
	internal class INetworkEventReporterInspectorRequestInvoker : global::Java.Lang.Object, INetworkEventReporterInspectorRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorRequest");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkEventReporterInspectorRequestInvoker); }
		}

		IntPtr class_ref;

		public static INetworkEventReporterInspectorRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkEventReporterInspectorRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.network.NetworkEventReporter.InspectorRequest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkEventReporterInspectorRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_body;
#pragma warning disable 0169
		static Delegate GetBodyHandler ()
		{
			if (cb_body == null)
				cb_body = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Body);
			return cb_body;
		}

		static IntPtr n_Body (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Body ());
		}
#pragma warning restore 0169

		IntPtr id_body;
		public unsafe byte[] Body ()
		{
			if (id_body == IntPtr.Zero)
				id_body = JNIEnv.GetMethodID (class_ref, "body", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_body), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_friendlyName;
#pragma warning disable 0169
		static Delegate GetFriendlyNameHandler ()
		{
			if (cb_friendlyName == null)
				cb_friendlyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FriendlyName);
			return cb_friendlyName;
		}

		static IntPtr n_FriendlyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FriendlyName ());
		}
#pragma warning restore 0169

		IntPtr id_friendlyName;
		public unsafe string FriendlyName ()
		{
			if (id_friendlyName == IntPtr.Zero)
				id_friendlyName = JNIEnv.GetMethodID (class_ref, "friendlyName", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_friendlyName), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_friendlyNameExtra;
#pragma warning disable 0169
		static Delegate GetFriendlyNameExtraHandler ()
		{
			if (cb_friendlyNameExtra == null)
				cb_friendlyNameExtra = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FriendlyNameExtra);
			return cb_friendlyNameExtra;
		}

		static IntPtr n_FriendlyNameExtra (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FriendlyNameExtra ());
		}
#pragma warning restore 0169

		IntPtr id_friendlyNameExtra;
		public unsafe global::Java.Lang.Integer FriendlyNameExtra ()
		{
			if (id_friendlyNameExtra == IntPtr.Zero)
				id_friendlyNameExtra = JNIEnv.GetMethodID (class_ref, "friendlyNameExtra", "()Ljava/lang/Integer;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_friendlyNameExtra), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_id;
#pragma warning disable 0169
		static Delegate GetIdHandler ()
		{
			if (cb_id == null)
				cb_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Id);
			return cb_id;
		}

		static IntPtr n_Id (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		IntPtr id_id;
		public unsafe string Id ()
		{
			if (id_id == IntPtr.Zero)
				id_id = JNIEnv.GetMethodID (class_ref, "id", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_id), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_method;
#pragma warning disable 0169
		static Delegate GetMethodHandler ()
		{
			if (cb_method == null)
				cb_method = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Method);
			return cb_method;
		}

		static IntPtr n_Method (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method ());
		}
#pragma warning restore 0169

		IntPtr id_method;
		public unsafe string Method ()
		{
			if (id_method == IntPtr.Zero)
				id_method = JNIEnv.GetMethodID (class_ref, "method", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_method), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_url;
#pragma warning disable 0169
		static Delegate GetUrlHandler ()
		{
			if (cb_url == null)
				cb_url = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Url);
			return cb_url;
		}

		static IntPtr n_Url (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url ());
		}
#pragma warning restore 0169

		IntPtr id_url;
		public unsafe string Url ()
		{
			if (id_url == IntPtr.Zero)
				id_url = JNIEnv.GetMethodID (class_ref, "url", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_firstHeaderValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFirstHeaderValue_Ljava_lang_String_Handler ()
		{
			if (cb_firstHeaderValue_Ljava_lang_String_ == null)
				cb_firstHeaderValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FirstHeaderValue_Ljava_lang_String_);
			return cb_firstHeaderValue_Ljava_lang_String_;
		}

		static IntPtr n_FirstHeaderValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FirstHeaderValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_firstHeaderValue_Ljava_lang_String_;
		public unsafe string FirstHeaderValue (string p0)
		{
			if (id_firstHeaderValue_Ljava_lang_String_ == IntPtr.Zero)
				id_firstHeaderValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "firstHeaderValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_firstHeaderValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_headerCount;
#pragma warning disable 0169
		static Delegate GetHeaderCountHandler ()
		{
			if (cb_headerCount == null)
				cb_headerCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HeaderCount);
			return cb_headerCount;
		}

		static int n_HeaderCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderCount ();
		}
#pragma warning restore 0169

		IntPtr id_headerCount;
		public unsafe int HeaderCount ()
		{
			if (id_headerCount == IntPtr.Zero)
				id_headerCount = JNIEnv.GetMethodID (class_ref, "headerCount", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_headerCount);
		}

		static Delegate cb_headerName_I;
#pragma warning disable 0169
		static Delegate GetHeaderName_IHandler ()
		{
			if (cb_headerName_I == null)
				cb_headerName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderName_I);
			return cb_headerName_I;
		}

		static IntPtr n_HeaderName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderName (p0));
		}
#pragma warning restore 0169

		IntPtr id_headerName_I;
		public unsafe string HeaderName (int p0)
		{
			if (id_headerName_I == IntPtr.Zero)
				id_headerName_I = JNIEnv.GetMethodID (class_ref, "headerName", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerName_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_headerValue_I;
#pragma warning disable 0169
		static Delegate GetHeaderValue_IHandler ()
		{
			if (cb_headerValue_I == null)
				cb_headerValue_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderValue_I);
			return cb_headerValue_I;
		}

		static IntPtr n_HeaderValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderValue (p0));
		}
#pragma warning restore 0169

		IntPtr id_headerValue_I;
		public unsafe string HeaderValue (int p0)
		{
			if (id_headerValue_I == IntPtr.Zero)
				id_headerValue_I = JNIEnv.GetMethodID (class_ref, "headerValue", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerValue_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorResponse']"
	[Register ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorResponse", "", "Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponseInvoker")]
	public partial interface INetworkEventReporterInspectorResponse : global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorHeaders {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorResponse']/method[@name='connectionId' and count(parameter)=0]"
		[Register ("connectionId", "()I", "GetConnectionIdHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponseInvoker, StethoXamarin")]
		int ConnectionId ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorResponse']/method[@name='connectionReused' and count(parameter)=0]"
		[Register ("connectionReused", "()Z", "GetConnectionReusedHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponseInvoker, StethoXamarin")]
		bool ConnectionReused ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorResponse']/method[@name='fromDiskCache' and count(parameter)=0]"
		[Register ("fromDiskCache", "()Z", "GetFromDiskCacheHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponseInvoker, StethoXamarin")]
		bool FromDiskCache ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorResponse']/method[@name='reasonPhrase' and count(parameter)=0]"
		[Register ("reasonPhrase", "()Ljava/lang/String;", "GetReasonPhraseHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponseInvoker, StethoXamarin")]
		string ReasonPhrase ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorResponse']/method[@name='requestId' and count(parameter)=0]"
		[Register ("requestId", "()Ljava/lang/String;", "GetRequestIdHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponseInvoker, StethoXamarin")]
		string RequestId ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorResponse']/method[@name='statusCode' and count(parameter)=0]"
		[Register ("statusCode", "()I", "GetStatusCodeHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponseInvoker, StethoXamarin")]
		int StatusCode ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter.InspectorResponse']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/lang/String;", "GetUrlHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponseInvoker, StethoXamarin")]
		string Url ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorResponse", DoNotGenerateAcw=true)]
	internal class INetworkEventReporterInspectorResponseInvoker : global::Java.Lang.Object, INetworkEventReporterInspectorResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/network/NetworkEventReporter$InspectorResponse");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkEventReporterInspectorResponseInvoker); }
		}

		IntPtr class_ref;

		public static INetworkEventReporterInspectorResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkEventReporterInspectorResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.network.NetworkEventReporter.InspectorResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkEventReporterInspectorResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connectionId;
#pragma warning disable 0169
		static Delegate GetConnectionIdHandler ()
		{
			if (cb_connectionId == null)
				cb_connectionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ConnectionId);
			return cb_connectionId;
		}

		static int n_ConnectionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionId ();
		}
#pragma warning restore 0169

		IntPtr id_connectionId;
		public unsafe int ConnectionId ()
		{
			if (id_connectionId == IntPtr.Zero)
				id_connectionId = JNIEnv.GetMethodID (class_ref, "connectionId", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectionId);
		}

		static Delegate cb_connectionReused;
#pragma warning disable 0169
		static Delegate GetConnectionReusedHandler ()
		{
			if (cb_connectionReused == null)
				cb_connectionReused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ConnectionReused);
			return cb_connectionReused;
		}

		static bool n_ConnectionReused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionReused ();
		}
#pragma warning restore 0169

		IntPtr id_connectionReused;
		public unsafe bool ConnectionReused ()
		{
			if (id_connectionReused == IntPtr.Zero)
				id_connectionReused = JNIEnv.GetMethodID (class_ref, "connectionReused", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_connectionReused);
		}

		static Delegate cb_fromDiskCache;
#pragma warning disable 0169
		static Delegate GetFromDiskCacheHandler ()
		{
			if (cb_fromDiskCache == null)
				cb_fromDiskCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_FromDiskCache);
			return cb_fromDiskCache;
		}

		static bool n_FromDiskCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FromDiskCache ();
		}
#pragma warning restore 0169

		IntPtr id_fromDiskCache;
		public unsafe bool FromDiskCache ()
		{
			if (id_fromDiskCache == IntPtr.Zero)
				id_fromDiskCache = JNIEnv.GetMethodID (class_ref, "fromDiskCache", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_fromDiskCache);
		}

		static Delegate cb_reasonPhrase;
#pragma warning disable 0169
		static Delegate GetReasonPhraseHandler ()
		{
			if (cb_reasonPhrase == null)
				cb_reasonPhrase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReasonPhrase);
			return cb_reasonPhrase;
		}

		static IntPtr n_ReasonPhrase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReasonPhrase ());
		}
#pragma warning restore 0169

		IntPtr id_reasonPhrase;
		public unsafe string ReasonPhrase ()
		{
			if (id_reasonPhrase == IntPtr.Zero)
				id_reasonPhrase = JNIEnv.GetMethodID (class_ref, "reasonPhrase", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reasonPhrase), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_requestId;
#pragma warning disable 0169
		static Delegate GetRequestIdHandler ()
		{
			if (cb_requestId == null)
				cb_requestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RequestId);
			return cb_requestId;
		}

		static IntPtr n_RequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId ());
		}
#pragma warning restore 0169

		IntPtr id_requestId;
		public unsafe string RequestId ()
		{
			if (id_requestId == IntPtr.Zero)
				id_requestId = JNIEnv.GetMethodID (class_ref, "requestId", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestId), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_statusCode;
#pragma warning disable 0169
		static Delegate GetStatusCodeHandler ()
		{
			if (cb_statusCode == null)
				cb_statusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_StatusCode);
			return cb_statusCode;
		}

		static int n_StatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode ();
		}
#pragma warning restore 0169

		IntPtr id_statusCode;
		public unsafe int StatusCode ()
		{
			if (id_statusCode == IntPtr.Zero)
				id_statusCode = JNIEnv.GetMethodID (class_ref, "statusCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_statusCode);
		}

		static Delegate cb_url;
#pragma warning disable 0169
		static Delegate GetUrlHandler ()
		{
			if (cb_url == null)
				cb_url = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Url);
			return cb_url;
		}

		static IntPtr n_Url (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url ());
		}
#pragma warning restore 0169

		IntPtr id_url;
		public unsafe string Url ()
		{
			if (id_url == IntPtr.Zero)
				id_url = JNIEnv.GetMethodID (class_ref, "url", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_firstHeaderValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFirstHeaderValue_Ljava_lang_String_Handler ()
		{
			if (cb_firstHeaderValue_Ljava_lang_String_ == null)
				cb_firstHeaderValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FirstHeaderValue_Ljava_lang_String_);
			return cb_firstHeaderValue_Ljava_lang_String_;
		}

		static IntPtr n_FirstHeaderValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FirstHeaderValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_firstHeaderValue_Ljava_lang_String_;
		public unsafe string FirstHeaderValue (string p0)
		{
			if (id_firstHeaderValue_Ljava_lang_String_ == IntPtr.Zero)
				id_firstHeaderValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "firstHeaderValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_firstHeaderValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_headerCount;
#pragma warning disable 0169
		static Delegate GetHeaderCountHandler ()
		{
			if (cb_headerCount == null)
				cb_headerCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HeaderCount);
			return cb_headerCount;
		}

		static int n_HeaderCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderCount ();
		}
#pragma warning restore 0169

		IntPtr id_headerCount;
		public unsafe int HeaderCount ()
		{
			if (id_headerCount == IntPtr.Zero)
				id_headerCount = JNIEnv.GetMethodID (class_ref, "headerCount", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_headerCount);
		}

		static Delegate cb_headerName_I;
#pragma warning disable 0169
		static Delegate GetHeaderName_IHandler ()
		{
			if (cb_headerName_I == null)
				cb_headerName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderName_I);
			return cb_headerName_I;
		}

		static IntPtr n_HeaderName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderName (p0));
		}
#pragma warning restore 0169

		IntPtr id_headerName_I;
		public unsafe string HeaderName (int p0)
		{
			if (id_headerName_I == IntPtr.Zero)
				id_headerName_I = JNIEnv.GetMethodID (class_ref, "headerName", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerName_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_headerValue_I;
#pragma warning disable 0169
		static Delegate GetHeaderValue_IHandler ()
		{
			if (cb_headerValue_I == null)
				cb_headerValue_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderValue_I);
			return cb_headerValue_I;
		}

		static IntPtr n_HeaderValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HeaderValue (p0));
		}
#pragma warning restore 0169

		IntPtr id_headerValue_I;
		public unsafe string HeaderValue (int p0)
		{
			if (id_headerValue_I == IntPtr.Zero)
				id_headerValue_I = JNIEnv.GetMethodID (class_ref, "headerValue", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerValue_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']"
	[Register ("com/facebook/stetho/inspector/network/NetworkEventReporter", "", "Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker")]
	public partial interface INetworkEventReporter : IJavaObject {

		bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='dataReceived' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dataReceived", "(Ljava/lang/String;II)V", "GetDataReceived_Ljava_lang_String_IIHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")]
		void DataReceived (string p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='dataSent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dataSent", "(Ljava/lang/String;II)V", "GetDataSent_Ljava_lang_String_IIHandler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")]
		void DataSent (string p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='httpExchangeFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpExchangeFailed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetHttpExchangeFailed_Ljava_lang_String_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")]
		void HttpExchangeFailed (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='interpretResponseStream' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.io.InputStream'] and parameter[5][@type='com.facebook.stetho.inspector.network.ResponseHandler']]"
		[Register ("interpretResponseStream", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;Lcom/facebook/stetho/inspector/network/ResponseHandler;)Ljava/io/InputStream;", "GetInterpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_Handler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")]
		global::System.IO.Stream InterpretResponseStream (string p0, string p1, string p2, global::System.IO.Stream p3, global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='requestWillBeSent' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.network.NetworkEventReporter.InspectorRequest']]"
		[Register ("requestWillBeSent", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorRequest;)V", "GetRequestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_Handler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")]
		void RequestWillBeSent (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='responseHeadersReceived' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.network.NetworkEventReporter.InspectorResponse']]"
		[Register ("responseHeadersReceived", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorResponse;)V", "GetResponseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_Handler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")]
		void ResponseHeadersReceived (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='responseReadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("responseReadFailed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetResponseReadFailed_Ljava_lang_String_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")]
		void ResponseReadFailed (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/interface[@name='NetworkEventReporter']/method[@name='responseReadFinished' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("responseReadFinished", "(Ljava/lang/String;)V", "GetResponseReadFinished_Ljava_lang_String_Handler:Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInvoker, StethoXamarin")]
		void ResponseReadFinished (string p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/NetworkEventReporter", DoNotGenerateAcw=true)]
	internal class INetworkEventReporterInvoker : global::Java.Lang.Object, INetworkEventReporter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/network/NetworkEventReporter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkEventReporterInvoker); }
		}

		IntPtr class_ref;

		public static INetworkEventReporter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkEventReporter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.network.NetworkEventReporter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkEventReporterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isEnabled;
		public unsafe bool IsEnabled {
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
			}
		}

		static Delegate cb_dataReceived_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetDataReceived_Ljava_lang_String_IIHandler ()
		{
			if (cb_dataReceived_Ljava_lang_String_II == null)
				cb_dataReceived_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_DataReceived_Ljava_lang_String_II);
			return cb_dataReceived_Ljava_lang_String_II;
		}

		static void n_DataReceived_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataReceived (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_dataReceived_Ljava_lang_String_II;
		public unsafe void DataReceived (string p0, int p1, int p2)
		{
			if (id_dataReceived_Ljava_lang_String_II == IntPtr.Zero)
				id_dataReceived_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "dataReceived", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dataReceived_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_dataSent_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetDataSent_Ljava_lang_String_IIHandler ()
		{
			if (cb_dataSent_Ljava_lang_String_II == null)
				cb_dataSent_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_DataSent_Ljava_lang_String_II);
			return cb_dataSent_Ljava_lang_String_II;
		}

		static void n_DataSent_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_dataSent_Ljava_lang_String_II;
		public unsafe void DataSent (string p0, int p1, int p2)
		{
			if (id_dataSent_Ljava_lang_String_II == IntPtr.Zero)
				id_dataSent_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "dataSent", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dataSent_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHttpExchangeFailed_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HttpExchangeFailed_Ljava_lang_String_Ljava_lang_String_);
			return cb_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_HttpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HttpExchangeFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void HttpExchangeFailed (string p0, string p1)
		{
			if (id_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "httpExchangeFailed", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_httpExchangeFailed_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_;
#pragma warning disable 0169
		static Delegate GetInterpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_Handler ()
		{
			if (cb_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ == null)
				cb_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InterpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_);
			return cb_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_;
		}

		static IntPtr n_InterpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p3 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler p4 = (global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InterpretResponseStream (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_;
		public unsafe global::System.IO.Stream InterpretResponseStream (string p0, string p1, string p2, global::System.IO.Stream p3, global::Com.Facebook.Stetho.Inspector.Network.IResponseHandler p4)
		{
			if (id_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ == IntPtr.Zero)
				id_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_ = JNIEnv.GetMethodID (class_ref, "interpretResponseStream", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;Lcom/facebook/stetho/inspector/network/ResponseHandler;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_interpretResponseStream_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Lcom_facebook_stetho_inspector_network_ResponseHandler_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_;
#pragma warning disable 0169
		static Delegate GetRequestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_Handler ()
		{
			if (cb_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ == null)
				cb_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_);
			return cb_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_;
		}

		static void n_RequestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest p0 = (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestWillBeSent (p0);
		}
#pragma warning restore 0169

		IntPtr id_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_;
		public unsafe void RequestWillBeSent (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorRequest p0)
		{
			if (id_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ == IntPtr.Zero)
				id_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_ = JNIEnv.GetMethodID (class_ref, "requestWillBeSent", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorRequest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestWillBeSent_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorRequest_, __args);
		}

		static Delegate cb_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_;
#pragma warning disable 0169
		static Delegate GetResponseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_Handler ()
		{
			if (cb_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ == null)
				cb_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResponseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_);
			return cb_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_;
		}

		static void n_ResponseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse p0 = (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseHeadersReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_;
		public unsafe void ResponseHeadersReceived (global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporterInspectorResponse p0)
		{
			if (id_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ == IntPtr.Zero)
				id_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_ = JNIEnv.GetMethodID (class_ref, "responseHeadersReceived", "(Lcom/facebook/stetho/inspector/network/NetworkEventReporter$InspectorResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_responseHeadersReceived_Lcom_facebook_stetho_inspector_network_NetworkEventReporter_InspectorResponse_, __args);
		}

		static Delegate cb_responseReadFailed_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResponseReadFailed_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_responseReadFailed_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_responseReadFailed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResponseReadFailed_Ljava_lang_String_Ljava_lang_String_);
			return cb_responseReadFailed_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ResponseReadFailed_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ResponseReadFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_responseReadFailed_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void ResponseReadFailed (string p0, string p1)
		{
			if (id_responseReadFailed_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_responseReadFailed_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "responseReadFailed", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_responseReadFailed_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_responseReadFinished_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResponseReadFinished_Ljava_lang_String_Handler ()
		{
			if (cb_responseReadFinished_Ljava_lang_String_ == null)
				cb_responseReadFinished_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResponseReadFinished_Ljava_lang_String_);
			return cb_responseReadFinished_Ljava_lang_String_;
		}

		static void n_ResponseReadFinished_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.INetworkEventReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseReadFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_responseReadFinished_Ljava_lang_String_;
		public unsafe void ResponseReadFinished (string p0)
		{
			if (id_responseReadFinished_Ljava_lang_String_ == IntPtr.Zero)
				id_responseReadFinished_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "responseReadFinished", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_responseReadFinished_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
