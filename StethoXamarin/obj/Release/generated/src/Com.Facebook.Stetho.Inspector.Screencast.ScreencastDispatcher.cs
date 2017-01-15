using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Screencast {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/screencast/ScreencastDispatcher", DoNotGenerateAcw=true)]
	public sealed partial class ScreencastDispatcher : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher.BitmapFetchRunnable']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/screencast/ScreencastDispatcher$BitmapFetchRunnable", DoNotGenerateAcw=true)]
		public partial class BitmapFetchRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/screencast/ScreencastDispatcher$BitmapFetchRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BitmapFetchRunnable); }
			}

			protected BitmapFetchRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Screencast.ScreencastDispatcher.BitmapFetchRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Screencast.ScreencastDispatcher.BitmapFetchRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher.BitmapFetchRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher.CancellationRunnable']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/screencast/ScreencastDispatcher$CancellationRunnable", DoNotGenerateAcw=true)]
		public partial class CancellationRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/screencast/ScreencastDispatcher$CancellationRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CancellationRunnable); }
			}

			protected CancellationRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Screencast.ScreencastDispatcher.CancellationRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Screencast.ScreencastDispatcher.CancellationRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher.CancellationRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher.EventDispatchRunnable']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/screencast/ScreencastDispatcher$EventDispatchRunnable", DoNotGenerateAcw=true)]
		public partial class EventDispatchRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/screencast/ScreencastDispatcher$EventDispatchRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EventDispatchRunnable); }
			}

			protected EventDispatchRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Screencast.ScreencastDispatcher.EventDispatchRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Screencast.ScreencastDispatcher.EventDispatchRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher.EventDispatchRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/screencast/ScreencastDispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScreencastDispatcher); }
		}

		internal ScreencastDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher']/constructor[@name='ScreencastDispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScreencastDispatcher ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ScreencastDispatcher)) {
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

		static IntPtr id_startScreencast_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_protocol_module_Page_StartScreencastRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher']/method[@name='startScreencast' and count(parameter)=2 and parameter[1][@type='com.facebook.stetho.inspector.jsonrpc.JsonRpcPeer'] and parameter[2][@type='com.facebook.stetho.inspector.protocol.module.Page.StartScreencastRequest']]"
		[Register ("startScreencast", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lcom/facebook/stetho/inspector/protocol/module/Page$StartScreencastRequest;)V", "")]
		public unsafe void StartScreencast (global::Com.Facebook.Stetho.Inspector.Jsonrpc.JsonRpcPeer p0, global::Com.Facebook.Stetho.Inspector.Protocol.Module.Page.StartScreencastRequest p1)
		{
			if (id_startScreencast_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_protocol_module_Page_StartScreencastRequest_ == IntPtr.Zero)
				id_startScreencast_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_protocol_module_Page_StartScreencastRequest_ = JNIEnv.GetMethodID (class_ref, "startScreencast", "(Lcom/facebook/stetho/inspector/jsonrpc/JsonRpcPeer;Lcom/facebook/stetho/inspector/protocol/module/Page$StartScreencastRequest;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startScreencast_Lcom_facebook_stetho_inspector_jsonrpc_JsonRpcPeer_Lcom_facebook_stetho_inspector_protocol_module_Page_StartScreencastRequest_, __args);
			} finally {
			}
		}

		static IntPtr id_stopScreencast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.screencast']/class[@name='ScreencastDispatcher']/method[@name='stopScreencast' and count(parameter)=0]"
		[Register ("stopScreencast", "()V", "")]
		public unsafe void StopScreencast ()
		{
			if (id_stopScreencast == IntPtr.Zero)
				id_stopScreencast = JNIEnv.GetMethodID (class_ref, "stopScreencast", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopScreencast);
			} finally {
			}
		}

	}
}
