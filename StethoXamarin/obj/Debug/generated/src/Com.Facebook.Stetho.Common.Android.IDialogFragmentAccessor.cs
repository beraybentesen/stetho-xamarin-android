using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='DialogFragmentAccessor']"
	[Register ("com/facebook/stetho/common/android/DialogFragmentAccessor", "", "Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"DIALOG_FRAGMENT", "FRAGMENT", "FRAGMENT_MANAGER"})]
	public partial interface IDialogFragmentAccessor : global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='DialogFragmentAccessor']/method[@name='getDialog' and count(parameter)=1 and parameter[1][@type='DIALOG_FRAGMENT']]"
		[Register ("getDialog", "(Ljava/lang/Object;)Landroid/app/Dialog;", "GetGetDialog_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessorInvoker, StethoXamarin")]
		global::Android.App.Dialog GetDialog (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/DialogFragmentAccessor", DoNotGenerateAcw=true)]
	internal class IDialogFragmentAccessorInvoker : global::Java.Lang.Object, IDialogFragmentAccessor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/android/DialogFragmentAccessor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDialogFragmentAccessorInvoker); }
		}

		IntPtr class_ref;

		public static IDialogFragmentAccessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDialogFragmentAccessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.android.DialogFragmentAccessor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDialogFragmentAccessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDialog_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetDialog_Ljava_lang_Object_Handler ()
		{
			if (cb_getDialog_Ljava_lang_Object_ == null)
				cb_getDialog_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDialog_Ljava_lang_Object_);
			return cb_getDialog_Ljava_lang_Object_;
		}

		static IntPtr n_GetDialog_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDialog (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDialog_Ljava_lang_Object_;
		public unsafe global::Android.App.Dialog GetDialog (global::Java.Lang.Object p0)
		{
			if (id_getDialog_Ljava_lang_Object_ == IntPtr.Zero)
				id_getDialog_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getDialog", "(Ljava/lang/Object;)Landroid/app/Dialog;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDialog_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getChildFragmentManager_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetChildFragmentManager_Ljava_lang_Object_Handler ()
		{
			if (cb_getChildFragmentManager_Ljava_lang_Object_ == null)
				cb_getChildFragmentManager_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChildFragmentManager_Ljava_lang_Object_);
			return cb_getChildFragmentManager_Ljava_lang_Object_;
		}

		static IntPtr n_GetChildFragmentManager_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChildFragmentManager (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getChildFragmentManager_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object GetChildFragmentManager (global::Java.Lang.Object p0)
		{
			if (id_getChildFragmentManager_Ljava_lang_Object_ == IntPtr.Zero)
				id_getChildFragmentManager_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getChildFragmentManager", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChildFragmentManager_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getFragmentManager_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetFragmentManager_Ljava_lang_Object_Handler ()
		{
			if (cb_getFragmentManager_Ljava_lang_Object_ == null)
				cb_getFragmentManager_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFragmentManager_Ljava_lang_Object_);
			return cb_getFragmentManager_Ljava_lang_Object_;
		}

		static IntPtr n_GetFragmentManager_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFragmentManager (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFragmentManager_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object GetFragmentManager (global::Java.Lang.Object p0)
		{
			if (id_getFragmentManager_Ljava_lang_Object_ == IntPtr.Zero)
				id_getFragmentManager_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getFragmentManager", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFragmentManager_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getId_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetId_Ljava_lang_Object_Handler ()
		{
			if (cb_getId_Ljava_lang_Object_ == null)
				cb_getId_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetId_Ljava_lang_Object_);
			return cb_getId_Ljava_lang_Object_;
		}

		static int n_GetId_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetId (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getId_Ljava_lang_Object_;
		public unsafe int GetId (global::Java.Lang.Object p0)
		{
			if (id_getId_Ljava_lang_Object_ == IntPtr.Zero)
				id_getId_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getId", "(Ljava/lang/Object;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getId_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getResources_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetResources_Ljava_lang_Object_Handler ()
		{
			if (cb_getResources_Ljava_lang_Object_ == null)
				cb_getResources_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetResources_Ljava_lang_Object_);
			return cb_getResources_Ljava_lang_Object_;
		}

		static IntPtr n_GetResources_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResources (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getResources_Ljava_lang_Object_;
		public unsafe global::Android.Content.Res.Resources GetResources (global::Java.Lang.Object p0)
		{
			if (id_getResources_Ljava_lang_Object_ == IntPtr.Zero)
				id_getResources_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getResources", "(Ljava/lang/Object;)Landroid/content/res/Resources;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.Content.Res.Resources __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResources_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetTag_Ljava_lang_Object_Handler ()
		{
			if (cb_getTag_Ljava_lang_Object_ == null)
				cb_getTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTag_Ljava_lang_Object_);
			return cb_getTag_Ljava_lang_Object_;
		}

		static IntPtr n_GetTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTag_Ljava_lang_Object_;
		public unsafe string GetTag (global::Java.Lang.Object p0)
		{
			if (id_getTag_Ljava_lang_Object_ == IntPtr.Zero)
				id_getTag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getTag", "(Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTag_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getView_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetView_Ljava_lang_Object_Handler ()
		{
			if (cb_getView_Ljava_lang_Object_ == null)
				cb_getView_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetView_Ljava_lang_Object_);
			return cb_getView_Ljava_lang_Object_;
		}

		static IntPtr n_GetView_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IDialogFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getView_Ljava_lang_Object_;
		public unsafe global::Android.Views.View GetView (global::Java.Lang.Object p0)
		{
			if (id_getView_Ljava_lang_Object_ == IntPtr.Zero)
				id_getView_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getView", "(Ljava/lang/Object;)Landroid/view/View;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
