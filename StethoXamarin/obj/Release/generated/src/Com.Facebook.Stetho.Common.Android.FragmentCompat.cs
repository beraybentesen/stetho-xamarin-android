using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/FragmentCompat", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"FRAGMENT", "DIALOG_FRAGMENT", "FRAGMENT_MANAGER", "FRAGMENT_ACTIVITY extends android.app.Activity"})]
	public abstract partial class FragmentCompat : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat.FragmentManagerAccessorViaReflection']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/android/FragmentCompat$FragmentManagerAccessorViaReflection", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"FRAGMENT_MANAGER", "FRAGMENT"})]
		public partial class FragmentManagerAccessorViaReflection : global::Java.Lang.Object, global::Com.Facebook.Stetho.Common.Android.IFragmentManagerAccessor {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/android/FragmentCompat$FragmentManagerAccessorViaReflection", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FragmentManagerAccessorViaReflection); }
			}

			protected FragmentManagerAccessorViaReflection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getAddedFragments_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetGetAddedFragments_Ljava_lang_Object_Handler ()
			{
				if (cb_getAddedFragments_Ljava_lang_Object_ == null)
					cb_getAddedFragments_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAddedFragments_Ljava_lang_Object_);
				return cb_getAddedFragments_Ljava_lang_Object_;
			}

			static IntPtr n_GetAddedFragments_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Common.Android.FragmentCompat.FragmentManagerAccessorViaReflection __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat.FragmentManagerAccessorViaReflection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetAddedFragments (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getAddedFragments_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat.FragmentManagerAccessorViaReflection']/method[@name='getAddedFragments' and count(parameter)=1 and parameter[1][@type='FRAGMENT_MANAGER']]"
			[Register ("getAddedFragments", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetAddedFragments_Ljava_lang_Object_Handler")]
			public virtual unsafe global::System.Collections.IList GetAddedFragments (global::Java.Lang.Object p0)
			{
				if (id_getAddedFragments_Ljava_lang_Object_ == IntPtr.Zero)
					id_getAddedFragments_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getAddedFragments", "(Ljava/lang/Object;)Ljava/util/List;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::System.Collections.IList __ret;
					if (GetType () == ThresholdType)
						__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddedFragments_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddedFragments", "(Ljava/lang/Object;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/android/FragmentCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FragmentCompat); }
		}

		protected FragmentCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDialogFragmentClass;
#pragma warning disable 0169
		static Delegate GetGetDialogFragmentClassHandler ()
		{
			if (cb_getDialogFragmentClass == null)
				cb_getDialogFragmentClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDialogFragmentClass);
			return cb_getDialogFragmentClass;
		}

		static IntPtr n_GetDialogFragmentClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.Android.FragmentCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DialogFragmentClass);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Class DialogFragmentClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='getDialogFragmentClass' and count(parameter)=0]"
			[Register ("getDialogFragmentClass", "()Ljava/lang/Class;", "GetGetDialogFragmentClassHandler")] get;
		}

		static Delegate cb_getFragmentActivityClass;
#pragma warning disable 0169
		static Delegate GetGetFragmentActivityClassHandler ()
		{
			if (cb_getFragmentActivityClass == null)
				cb_getFragmentActivityClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFragmentActivityClass);
			return cb_getFragmentActivityClass;
		}

		static IntPtr n_GetFragmentActivityClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.Android.FragmentCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FragmentActivityClass);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Class FragmentActivityClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='getFragmentActivityClass' and count(parameter)=0]"
			[Register ("getFragmentActivityClass", "()Ljava/lang/Class;", "GetGetFragmentActivityClassHandler")] get;
		}

		static Delegate cb_getFragmentClass;
#pragma warning disable 0169
		static Delegate GetGetFragmentClassHandler ()
		{
			if (cb_getFragmentClass == null)
				cb_getFragmentClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFragmentClass);
			return cb_getFragmentClass;
		}

		static IntPtr n_GetFragmentClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.Android.FragmentCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FragmentClass);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Class FragmentClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='getFragmentClass' and count(parameter)=0]"
			[Register ("getFragmentClass", "()Ljava/lang/Class;", "GetGetFragmentClassHandler")] get;
		}

		static IntPtr id_getFrameworkInstance;
		public static unsafe global::Com.Facebook.Stetho.Common.Android.FragmentCompat FrameworkInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='getFrameworkInstance' and count(parameter)=0]"
			[Register ("getFrameworkInstance", "()Lcom/facebook/stetho/common/android/FragmentCompat;", "GetGetFrameworkInstanceHandler")]
			get {
				if (id_getFrameworkInstance == IntPtr.Zero)
					id_getFrameworkInstance = JNIEnv.GetStaticMethodID (class_ref, "getFrameworkInstance", "()Lcom/facebook/stetho/common/android/FragmentCompat;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFrameworkInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSupportLibInstance;
		public static unsafe global::Com.Facebook.Stetho.Common.Android.FragmentCompat SupportLibInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='getSupportLibInstance' and count(parameter)=0]"
			[Register ("getSupportLibInstance", "()Lcom/facebook/stetho/common/android/FragmentCompat;", "GetGetSupportLibInstanceHandler")]
			get {
				if (id_getSupportLibInstance == IntPtr.Zero)
					id_getSupportLibInstance = JNIEnv.GetStaticMethodID (class_ref, "getSupportLibInstance", "()Lcom/facebook/stetho/common/android/FragmentCompat;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSupportLibInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_forDialogFragment;
#pragma warning disable 0169
		static Delegate GetForDialogFragmentHandler ()
		{
			if (cb_forDialogFragment == null)
				cb_forDialogFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForDialogFragment);
			return cb_forDialogFragment;
		}

		static IntPtr n_ForDialogFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.Android.FragmentCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForDialogFragment ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='forDialogFragment' and count(parameter)=0]"
		[Register ("forDialogFragment", "()Lcom/facebook/stetho/common/android/DialogFragmentAccessor;", "GetForDialogFragmentHandler")]
		public abstract global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor ForDialogFragment ();

		static Delegate cb_forFragment;
#pragma warning disable 0169
		static Delegate GetForFragmentHandler ()
		{
			if (cb_forFragment == null)
				cb_forFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForFragment);
			return cb_forFragment;
		}

		static IntPtr n_ForFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.Android.FragmentCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForFragment ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='forFragment' and count(parameter)=0]"
		[Register ("forFragment", "()Lcom/facebook/stetho/common/android/FragmentAccessor;", "GetForFragmentHandler")]
		public abstract global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor ForFragment ();

		static Delegate cb_forFragmentActivity;
#pragma warning disable 0169
		static Delegate GetForFragmentActivityHandler ()
		{
			if (cb_forFragmentActivity == null)
				cb_forFragmentActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForFragmentActivity);
			return cb_forFragmentActivity;
		}

		static IntPtr n_ForFragmentActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.Android.FragmentCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForFragmentActivity ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='forFragmentActivity' and count(parameter)=0]"
		[Register ("forFragmentActivity", "()Lcom/facebook/stetho/common/android/FragmentActivityAccessor;", "GetForFragmentActivityHandler")]
		public abstract global::Com.Facebook.Stetho.Common.Android.IFragmentActivityAccessor ForFragmentActivity ();

		static Delegate cb_forFragmentManager;
#pragma warning disable 0169
		static Delegate GetForFragmentManagerHandler ()
		{
			if (cb_forFragmentManager == null)
				cb_forFragmentManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForFragmentManager);
			return cb_forFragmentManager;
		}

		static IntPtr n_ForFragmentManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Common.Android.FragmentCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.FragmentCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForFragmentManager ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='forFragmentManager' and count(parameter)=0]"
		[Register ("forFragmentManager", "()Lcom/facebook/stetho/common/android/FragmentManagerAccessor;", "GetForFragmentManagerHandler")]
		public abstract global::Com.Facebook.Stetho.Common.Android.IFragmentManagerAccessor ForFragmentManager ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/FragmentCompat", DoNotGenerateAcw=true)]
	internal partial class FragmentCompatInvoker : FragmentCompat {

		public FragmentCompatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FragmentCompatInvoker); }
		}

		static IntPtr id_getDialogFragmentClass;
		public override unsafe global::Java.Lang.Class DialogFragmentClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='getDialogFragmentClass' and count(parameter)=0]"
			[Register ("getDialogFragmentClass", "()Ljava/lang/Class;", "GetGetDialogFragmentClassHandler")]
			get {
				if (id_getDialogFragmentClass == IntPtr.Zero)
					id_getDialogFragmentClass = JNIEnv.GetMethodID (class_ref, "getDialogFragmentClass", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDialogFragmentClass), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFragmentActivityClass;
		public override unsafe global::Java.Lang.Class FragmentActivityClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='getFragmentActivityClass' and count(parameter)=0]"
			[Register ("getFragmentActivityClass", "()Ljava/lang/Class;", "GetGetFragmentActivityClassHandler")]
			get {
				if (id_getFragmentActivityClass == IntPtr.Zero)
					id_getFragmentActivityClass = JNIEnv.GetMethodID (class_ref, "getFragmentActivityClass", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFragmentActivityClass), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFragmentClass;
		public override unsafe global::Java.Lang.Class FragmentClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='getFragmentClass' and count(parameter)=0]"
			[Register ("getFragmentClass", "()Ljava/lang/Class;", "GetGetFragmentClassHandler")]
			get {
				if (id_getFragmentClass == IntPtr.Zero)
					id_getFragmentClass = JNIEnv.GetMethodID (class_ref, "getFragmentClass", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFragmentClass), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_forDialogFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='forDialogFragment' and count(parameter)=0]"
		[Register ("forDialogFragment", "()Lcom/facebook/stetho/common/android/DialogFragmentAccessor;", "GetForDialogFragmentHandler")]
		public override unsafe global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor ForDialogFragment ()
		{
			if (id_forDialogFragment == IntPtr.Zero)
				id_forDialogFragment = JNIEnv.GetMethodID (class_ref, "forDialogFragment", "()Lcom/facebook/stetho/common/android/DialogFragmentAccessor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forDialogFragment), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_forFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='forFragment' and count(parameter)=0]"
		[Register ("forFragment", "()Lcom/facebook/stetho/common/android/FragmentAccessor;", "GetForFragmentHandler")]
		public override unsafe global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor ForFragment ()
		{
			if (id_forFragment == IntPtr.Zero)
				id_forFragment = JNIEnv.GetMethodID (class_ref, "forFragment", "()Lcom/facebook/stetho/common/android/FragmentAccessor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forFragment), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_forFragmentActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='forFragmentActivity' and count(parameter)=0]"
		[Register ("forFragmentActivity", "()Lcom/facebook/stetho/common/android/FragmentActivityAccessor;", "GetForFragmentActivityHandler")]
		public override unsafe global::Com.Facebook.Stetho.Common.Android.IFragmentActivityAccessor ForFragmentActivity ()
		{
			if (id_forFragmentActivity == IntPtr.Zero)
				id_forFragmentActivity = JNIEnv.GetMethodID (class_ref, "forFragmentActivity", "()Lcom/facebook/stetho/common/android/FragmentActivityAccessor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentActivityAccessor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forFragmentActivity), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_forFragmentManager;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/class[@name='FragmentCompat']/method[@name='forFragmentManager' and count(parameter)=0]"
		[Register ("forFragmentManager", "()Lcom/facebook/stetho/common/android/FragmentManagerAccessor;", "GetForFragmentManagerHandler")]
		public override unsafe global::Com.Facebook.Stetho.Common.Android.IFragmentManagerAccessor ForFragmentManager ()
		{
			if (id_forFragmentManager == IntPtr.Zero)
				id_forFragmentManager = JNIEnv.GetMethodID (class_ref, "forFragmentManager", "()Lcom/facebook/stetho/common/android/FragmentManagerAccessor;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentManagerAccessor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forFragmentManager), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
