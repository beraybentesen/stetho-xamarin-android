using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/ProtocolDetectingSocketHandler", DoNotGenerateAcw=true)]
	public partial class ProtocolDetectingSocketHandler : global::Com.Facebook.Stetho.Server.SecureSocketHandler {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.AlwaysMatchMatcher']"
		[global::Android.Runtime.Register ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$AlwaysMatchMatcher", DoNotGenerateAcw=true)]
		public partial class AlwaysMatchMatcher : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$AlwaysMatchMatcher", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AlwaysMatchMatcher); }
			}

			protected AlwaysMatchMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.AlwaysMatchMatcher']/constructor[@name='ProtocolDetectingSocketHandler.AlwaysMatchMatcher' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AlwaysMatchMatcher ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (AlwaysMatchMatcher)) {
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

			static Delegate cb_matches_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetMatches_Ljava_io_InputStream_Handler ()
			{
				if (cb_matches_Ljava_io_InputStream_ == null)
					cb_matches_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Matches_Ljava_io_InputStream_);
				return cb_matches_Ljava_io_InputStream_;
			}

			static bool n_Matches_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.AlwaysMatchMatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.AlwaysMatchMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Matches (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_matches_Ljava_io_InputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.AlwaysMatchMatcher']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("matches", "(Ljava/io/InputStream;)Z", "GetMatches_Ljava_io_InputStream_Handler")]
			public virtual unsafe bool Matches (global::System.IO.Stream p0)
			{
				if (id_matches_Ljava_io_InputStream_ == IntPtr.Zero)
					id_matches_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "matches", "(Ljava/io/InputStream;)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Ljava_io_InputStream_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "matches", "(Ljava/io/InputStream;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.ExactMagicMatcher']"
		[global::Android.Runtime.Register ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$ExactMagicMatcher", DoNotGenerateAcw=true)]
		public partial class ExactMagicMatcher : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$ExactMagicMatcher", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExactMagicMatcher); }
			}

			protected ExactMagicMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_arrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.ExactMagicMatcher']/constructor[@name='ProtocolDetectingSocketHandler.ExactMagicMatcher' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register (".ctor", "([B)V", "")]
			public unsafe ExactMagicMatcher (byte[] p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (ExactMagicMatcher)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
						return;
					}

					if (id_ctor_arrayB == IntPtr.Zero)
						id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_matches_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetMatches_Ljava_io_InputStream_Handler ()
			{
				if (cb_matches_Ljava_io_InputStream_ == null)
					cb_matches_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Matches_Ljava_io_InputStream_);
				return cb_matches_Ljava_io_InputStream_;
			}

			static bool n_Matches_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.ExactMagicMatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.ExactMagicMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Matches (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_matches_Ljava_io_InputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.ExactMagicMatcher']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("matches", "(Ljava/io/InputStream;)Z", "GetMatches_Ljava_io_InputStream_Handler")]
			public virtual unsafe bool Matches (global::System.IO.Stream p0)
			{
				if (id_matches_Ljava_io_InputStream_ == IntPtr.Zero)
					id_matches_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "matches", "(Ljava/io/InputStream;)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Ljava_io_InputStream_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "matches", "(Ljava/io/InputStream;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.HandlerInfo']"
		[global::Android.Runtime.Register ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$HandlerInfo", DoNotGenerateAcw=true)]
		public partial class HandlerInfo : global::Java.Lang.Object {


			static IntPtr handler_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.HandlerInfo']/field[@name='handler']"
			[Register ("handler")]
			public global::Com.Facebook.Stetho.Server.ISocketLikeHandler Handler {
				get {
					if (handler_jfieldId == IntPtr.Zero)
						handler_jfieldId = JNIEnv.GetFieldID (class_ref, "handler", "Lcom/facebook/stetho/server/SocketLikeHandler;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, handler_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ISocketLikeHandler> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (handler_jfieldId == IntPtr.Zero)
						handler_jfieldId = JNIEnv.GetFieldID (class_ref, "handler", "Lcom/facebook/stetho/server/SocketLikeHandler;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, handler_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr magicMatcher_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler.HandlerInfo']/field[@name='magicMatcher']"
			[Register ("magicMatcher")]
			public global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher MagicMatcher {
				get {
					if (magicMatcher_jfieldId == IntPtr.Zero)
						magicMatcher_jfieldId = JNIEnv.GetFieldID (class_ref, "magicMatcher", "Lcom/facebook/stetho/server/ProtocolDetectingSocketHandler$MagicMatcher;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, magicMatcher_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (magicMatcher_jfieldId == IntPtr.Zero)
						magicMatcher_jfieldId = JNIEnv.GetFieldID (class_ref, "magicMatcher", "Lcom/facebook/stetho/server/ProtocolDetectingSocketHandler$MagicMatcher;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, magicMatcher_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$HandlerInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HandlerInfo); }
			}

			protected HandlerInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.server']/interface[@name='ProtocolDetectingSocketHandler.MagicMatcher']"
		[Register ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$MagicMatcher", "", "Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler/IMagicMatcherInvoker")]
		public partial interface IMagicMatcher : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/interface[@name='ProtocolDetectingSocketHandler.MagicMatcher']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("matches", "(Ljava/io/InputStream;)Z", "GetMatches_Ljava_io_InputStream_Handler:Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler/IMagicMatcherInvoker, StethoXamarin")]
			bool Matches (global::System.IO.Stream p0);

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$MagicMatcher", DoNotGenerateAcw=true)]
		internal class IMagicMatcherInvoker : global::Java.Lang.Object, IMagicMatcher {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/server/ProtocolDetectingSocketHandler$MagicMatcher");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMagicMatcherInvoker); }
			}

			IntPtr class_ref;

			public static IMagicMatcher GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMagicMatcher> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.server.ProtocolDetectingSocketHandler.MagicMatcher"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMagicMatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_matches_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetMatches_Ljava_io_InputStream_Handler ()
			{
				if (cb_matches_Ljava_io_InputStream_ == null)
					cb_matches_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Matches_Ljava_io_InputStream_);
				return cb_matches_Ljava_io_InputStream_;
			}

			static bool n_Matches_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Matches (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_matches_Ljava_io_InputStream_;
			public unsafe bool Matches (global::System.IO.Stream p0)
			{
				if (id_matches_Ljava_io_InputStream_ == IntPtr.Zero)
					id_matches_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "matches", "(Ljava/io/InputStream;)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Ljava_io_InputStream_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/ProtocolDetectingSocketHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProtocolDetectingSocketHandler); }
		}

		protected ProtocolDetectingSocketHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler']/constructor[@name='ProtocolDetectingSocketHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ProtocolDetectingSocketHandler (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ProtocolDetectingSocketHandler)) {
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

		static Delegate cb_addHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_;
#pragma warning disable 0169
		static Delegate GetAddHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_Handler ()
		{
			if (cb_addHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_ == null)
				cb_addHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_);
			return cb_addHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_;
		}

		static void n_AddHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher p0 = (global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Stetho.Server.ISocketLikeHandler p1 = (global::Com.Facebook.Stetho.Server.ISocketLikeHandler)global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ISocketLikeHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddHandler (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler']/method[@name='addHandler' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.server.ProtocolDetectingSocketHandler.MagicMatcher'] and parameter[2][@type='com.facebook.stetho.server.SocketLikeHandler']]"
		[Register ("addHandler", "(Lcom/facebook/stetho/server/ProtocolDetectingSocketHandler$MagicMatcher;Lcom/facebook/stetho/server/SocketLikeHandler;)V", "GetAddHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_Handler")]
		public virtual unsafe void AddHandler (global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler.IMagicMatcher p0, global::Com.Facebook.Stetho.Server.ISocketLikeHandler p1)
		{
			if (id_addHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_ == IntPtr.Zero)
				id_addHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_ = JNIEnv.GetMethodID (class_ref, "addHandler", "(Lcom/facebook/stetho/server/ProtocolDetectingSocketHandler$MagicMatcher;Lcom/facebook/stetho/server/SocketLikeHandler;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHandler_Lcom_facebook_stetho_server_ProtocolDetectingSocketHandler_MagicMatcher_Lcom_facebook_stetho_server_SocketLikeHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHandler", "(Lcom/facebook/stetho/server/ProtocolDetectingSocketHandler$MagicMatcher;Lcom/facebook/stetho/server/SocketLikeHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSecured_Landroid_net_LocalSocket_;
#pragma warning disable 0169
		static Delegate GetOnSecured_Landroid_net_LocalSocket_Handler ()
		{
			if (cb_onSecured_Landroid_net_LocalSocket_ == null)
				cb_onSecured_Landroid_net_LocalSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSecured_Landroid_net_LocalSocket_);
			return cb_onSecured_Landroid_net_LocalSocket_;
		}

		static void n_OnSecured_Landroid_net_LocalSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.ProtocolDetectingSocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.LocalSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Net.LocalSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSecured (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSecured_Landroid_net_LocalSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server']/class[@name='ProtocolDetectingSocketHandler']/method[@name='onSecured' and count(parameter)=1 and parameter[1][@type='android.net.LocalSocket']]"
		[Register ("onSecured", "(Landroid/net/LocalSocket;)V", "GetOnSecured_Landroid_net_LocalSocket_Handler")]
		protected override unsafe void OnSecured (global::Android.Net.LocalSocket p0)
		{
			if (id_onSecured_Landroid_net_LocalSocket_ == IntPtr.Zero)
				id_onSecured_Landroid_net_LocalSocket_ = JNIEnv.GetMethodID (class_ref, "onSecured", "(Landroid/net/LocalSocket;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSecured_Landroid_net_LocalSocket_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSecured", "(Landroid/net/LocalSocket;)V"), __args);
			} finally {
			}
		}

	}
}
