using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/ActivityTracker", DoNotGenerateAcw=true)]
	public sealed partial class ActivityTracker : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/ActivityTracker$AutomaticTracker", DoNotGenerateAcw=true)]
		public abstract partial class AutomaticTracker : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond']"
			[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/ActivityTracker$AutomaticTracker$AutomaticTrackerICSAndBeyond", DoNotGenerateAcw=true)]
			public partial class AutomaticTrackerICSAndBeyond : global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker {

				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/android/ActivityTracker$AutomaticTracker$AutomaticTrackerICSAndBeyond", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (AutomaticTrackerICSAndBeyond); }
				}

				protected AutomaticTrackerICSAndBeyond (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Landroid_app_Application_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond']/constructor[@name='ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.facebook.stetho.inspector.elements.android.ActivityTracker']]"
				[Register (".ctor", "(Landroid/app/Application;Lcom/facebook/stetho/inspector/elements/android/ActivityTracker;)V", "")]
				public unsafe AutomaticTrackerICSAndBeyond (global::Android.App.Application p0, global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker p1)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JValue* __args = stackalloc JValue [2];
						__args [0] = new JValue (p0);
						__args [1] = new JValue (p1);
						if (GetType () != typeof (AutomaticTrackerICSAndBeyond)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Application;Lcom/facebook/stetho/inspector/elements/android/ActivityTracker;)V", __args),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Application;Lcom/facebook/stetho/inspector/elements/android/ActivityTracker;)V", __args);
							return;
						}

						if (id_ctor_Landroid_app_Application_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_ == IntPtr.Zero)
							id_ctor_Landroid_app_Application_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Application;Lcom/facebook/stetho/inspector/elements/android/ActivityTracker;)V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Application_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_, __args),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Application_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_, __args);
					} finally {
					}
				}

				static Delegate cb_register;
#pragma warning disable 0169
				static Delegate GetRegisterHandler ()
				{
					if (cb_register == null)
						cb_register = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Register);
					return cb_register;
				}

				static void n_Register (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.Register ();
				}
#pragma warning restore 0169

				static IntPtr id_register;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond']/method[@name='register' and count(parameter)=0]"
				[Register ("register", "()V", "GetRegisterHandler")]
				public override unsafe void Register ()
				{
					if (id_register == IntPtr.Zero)
						id_register = JNIEnv.GetMethodID (class_ref, "register", "()V");
					try {

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "()V"));
					} finally {
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
					global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.Unregister ();
				}
#pragma warning restore 0169

				static IntPtr id_unregister;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker.AutomaticTrackerICSAndBeyond']/method[@name='unregister' and count(parameter)=0]"
				[Register ("unregister", "()V", "GetUnregisterHandler")]
				public override unsafe void Unregister ()
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

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/android/ActivityTracker$AutomaticTracker", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AutomaticTracker); }
			}

			protected AutomaticTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_register;
#pragma warning disable 0169
			static Delegate GetRegisterHandler ()
			{
				if (cb_register == null)
					cb_register = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Register);
				return cb_register;
			}

			static void n_Register (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Register ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker']/method[@name='register' and count(parameter)=0]"
			[Register ("register", "()V", "GetRegisterHandler")]
			public abstract void Register ();

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
				global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.AutomaticTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Unregister ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker']/method[@name='unregister' and count(parameter)=0]"
			[Register ("unregister", "()V", "GetUnregisterHandler")]
			public abstract void Unregister ();

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/ActivityTracker$AutomaticTracker", DoNotGenerateAcw=true)]
		internal partial class AutomaticTrackerInvoker : AutomaticTracker {

			public AutomaticTrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (AutomaticTrackerInvoker); }
			}

			static IntPtr id_register;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker']/method[@name='register' and count(parameter)=0]"
			[Register ("register", "()V", "GetRegisterHandler")]
			public override unsafe void Register ()
			{
				if (id_register == IntPtr.Zero)
					id_register = JNIEnv.GetMethodID (class_ref, "register", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register);
				} finally {
				}
			}

			static IntPtr id_unregister;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker.AutomaticTracker']/method[@name='unregister' and count(parameter)=0]"
			[Register ("unregister", "()V", "GetUnregisterHandler")]
			public override unsafe void Unregister ()
			{
				if (id_unregister == IntPtr.Zero)
					id_unregister = JNIEnv.GetMethodID (class_ref, "unregister", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister);
				} finally {
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/interface[@name='ActivityTracker.Listener']"
		[Register ("com/facebook/stetho/inspector/elements/android/ActivityTracker$Listener", "", "Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/interface[@name='ActivityTracker.Listener']/method[@name='onActivityAdded' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onActivityAdded", "(Landroid/app/Activity;)V", "GetOnActivityAdded_Landroid_app_Activity_Handler:Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker/IListenerInvoker, StethoXamarin")]
			void OnActivityAdded (global::Android.App.Activity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/interface[@name='ActivityTracker.Listener']/method[@name='onActivityRemoved' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onActivityRemoved", "(Landroid/app/Activity;)V", "GetOnActivityRemoved_Landroid_app_Activity_Handler:Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker/IListenerInvoker, StethoXamarin")]
			void OnActivityRemoved (global::Android.App.Activity p0);

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/ActivityTracker$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/android/ActivityTracker$Listener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.elements.android.ActivityTracker.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onActivityAdded_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnActivityAdded_Landroid_app_Activity_Handler ()
			{
				if (cb_onActivityAdded_Landroid_app_Activity_ == null)
					cb_onActivityAdded_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityAdded_Landroid_app_Activity_);
				return cb_onActivityAdded_Landroid_app_Activity_;
			}

			static void n_OnActivityAdded_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActivityAdded_Landroid_app_Activity_;
			public unsafe void OnActivityAdded (global::Android.App.Activity p0)
			{
				if (id_onActivityAdded_Landroid_app_Activity_ == IntPtr.Zero)
					id_onActivityAdded_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityAdded", "(Landroid/app/Activity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityAdded_Landroid_app_Activity_, __args);
			}

			static Delegate cb_onActivityRemoved_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnActivityRemoved_Landroid_app_Activity_Handler ()
			{
				if (cb_onActivityRemoved_Landroid_app_Activity_ == null)
					cb_onActivityRemoved_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityRemoved_Landroid_app_Activity_);
				return cb_onActivityRemoved_Landroid_app_Activity_;
			}

			static void n_OnActivityRemoved_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_onActivityRemoved_Landroid_app_Activity_;
			public unsafe void OnActivityRemoved (global::Android.App.Activity p0)
			{
				if (id_onActivityRemoved_Landroid_app_Activity_ == IntPtr.Zero)
					id_onActivityRemoved_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityRemoved", "(Landroid/app/Activity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityRemoved_Landroid_app_Activity_, __args);
			}

		}

		public partial class ActivityAddedEventArgs : global::System.EventArgs {

			public ActivityAddedEventArgs (global::Android.App.Activity p0)
			{
				this.p0 = p0;
			}

			global::Android.App.Activity p0;
			public global::Android.App.Activity P0 {
				get { return p0; }
			}
		}

		public partial class ActivityRemovedEventArgs : global::System.EventArgs {

			public ActivityRemovedEventArgs (global::Android.App.Activity p0)
			{
				this.p0 = p0;
			}

			global::Android.App.Activity p0;
			public global::Android.App.Activity P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/stetho/inspector/elements/android/ActivityTracker_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/stetho/inspector/elements/android/ActivityTracker_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ActivityAddedEventArgs> OnActivityAddedHandler;
#pragma warning restore 0649

			public void OnActivityAdded (global::Android.App.Activity p0)
			{
				var __h = OnActivityAddedHandler;
				if (__h != null)
					__h (sender, new ActivityAddedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ActivityRemovedEventArgs> OnActivityRemovedHandler;
#pragma warning restore 0649

			public void OnActivityRemoved (global::Android.App.Activity p0)
			{
				var __h = OnActivityRemovedHandler;
				if (__h != null)
					__h (sender, new ActivityRemovedEventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnActivityAddedHandler == null && value.OnActivityRemovedHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/android/ActivityTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActivityTracker); }
		}

		internal ActivityTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/constructor[@name='ActivityTracker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActivityTracker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ActivityTracker)) {
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

		static IntPtr id_getActivitiesView;
		public unsafe global::System.Collections.Generic.IList<global::Android.App.Activity> ActivitiesView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='getActivitiesView' and count(parameter)=0]"
			[Register ("getActivitiesView", "()Ljava/util/List;", "GetGetActivitiesViewHandler")]
			get {
				if (id_getActivitiesView == IntPtr.Zero)
					id_getActivitiesView = JNIEnv.GetMethodID (class_ref, "getActivitiesView", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Android.App.Activity>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivitiesView), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_add_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='add' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("add", "(Landroid/app/Activity;)V", "")]
		public unsafe void Add (global::Android.App.Activity p0)
		{
			if (id_add_Landroid_app_Activity_ == IntPtr.Zero)
				id_add_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "add", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_beginTrackingIfPossible_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='beginTrackingIfPossible' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("beginTrackingIfPossible", "(Landroid/app/Application;)Z", "")]
		public unsafe bool BeginTrackingIfPossible (global::Android.App.Application p0)
		{
			if (id_beginTrackingIfPossible_Landroid_app_Application_ == IntPtr.Zero)
				id_beginTrackingIfPossible_Landroid_app_Application_ = JNIEnv.GetMethodID (class_ref, "beginTrackingIfPossible", "(Landroid/app/Application;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_beginTrackingIfPossible_Landroid_app_Application_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_endTracking;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='endTracking' and count(parameter)=0]"
		[Register ("endTracking", "()Z", "")]
		public unsafe bool EndTracking ()
		{
			if (id_endTracking == IntPtr.Zero)
				id_endTracking = JNIEnv.GetMethodID (class_ref, "endTracking", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_endTracking);
			} finally {
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/facebook/stetho/inspector/elements/android/ActivityTracker;", "")]
		public static unsafe global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/facebook/stetho/inspector/elements/android/ActivityTracker;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_registerListener_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='registerListener' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.android.ActivityTracker.Listener']]"
		[Register ("registerListener", "(Lcom/facebook/stetho/inspector/elements/android/ActivityTracker$Listener;)V", "")]
		public unsafe void RegisterListener (global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.IListener p0)
		{
			if (id_registerListener_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_Listener_ == IntPtr.Zero)
				id_registerListener_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_Listener_ = JNIEnv.GetMethodID (class_ref, "registerListener", "(Lcom/facebook/stetho/inspector/elements/android/ActivityTracker$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerListener_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_Listener_, __args);
			} finally {
			}
		}

		static IntPtr id_remove_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("remove", "(Landroid/app/Activity;)V", "")]
		public unsafe void Remove (global::Android.App.Activity p0)
		{
			if (id_remove_Landroid_app_Activity_ == IntPtr.Zero)
				id_remove_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "remove", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_tryGetTopActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='tryGetTopActivity' and count(parameter)=0]"
		[Register ("tryGetTopActivity", "()Landroid/app/Activity;", "")]
		public unsafe global::Android.App.Activity TryGetTopActivity ()
		{
			if (id_tryGetTopActivity == IntPtr.Zero)
				id_tryGetTopActivity = JNIEnv.GetMethodID (class_ref, "tryGetTopActivity", "()Landroid/app/Activity;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tryGetTopActivity), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_unregisterListener_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='ActivityTracker']/method[@name='unregisterListener' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.elements.android.ActivityTracker.Listener']]"
		[Register ("unregisterListener", "(Lcom/facebook/stetho/inspector/elements/android/ActivityTracker$Listener;)V", "")]
		public unsafe void UnregisterListener (global::Com.Facebook.Stetho.Inspector.Elements.Android.ActivityTracker.IListener p0)
		{
			if (id_unregisterListener_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_Listener_ == IntPtr.Zero)
				id_unregisterListener_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_Listener_ = JNIEnv.GetMethodID (class_ref, "unregisterListener", "(Lcom/facebook/stetho/inspector/elements/android/ActivityTracker$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterListener_Lcom_facebook_stetho_inspector_elements_android_ActivityTracker_Listener_, __args);
			} finally {
			}
		}

	}
}
