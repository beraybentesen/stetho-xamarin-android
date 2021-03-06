using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common.Android {

	[Register ("com/facebook/stetho/common/android/FragmentAccessor", DoNotGenerateAcw=true)]
	public abstract class FragmentAccessor : Java.Lang.Object {

		internal FragmentAccessor ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentAccessor']/field[@name='NO_ID']"
		[Register ("NO_ID")]
		public const int NoId = (int) 0;
	}

	[Register ("com/facebook/stetho/common/android/FragmentAccessor", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'FragmentAccessor' type. This type will be removed in a future release.")]
	public abstract class FragmentAccessorConsts : FragmentAccessor {

		private FragmentAccessorConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentAccessor']"
	[Register ("com/facebook/stetho/common/android/FragmentAccessor", "", "Com.Facebook.Stetho.Common.Android.IFragmentAccessorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"FRAGMENT", "FRAGMENT_MANAGER"})]
	public partial interface IFragmentAccessor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentAccessor']/method[@name='getChildFragmentManager' and count(parameter)=1 and parameter[1][@type='FRAGMENT']]"
		[Register ("getChildFragmentManager", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetChildFragmentManager_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.Android.IFragmentAccessorInvoker, StethoXamarin")]
		global::Java.Lang.Object GetChildFragmentManager (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentAccessor']/method[@name='getFragmentManager' and count(parameter)=1 and parameter[1][@type='FRAGMENT']]"
		[Register ("getFragmentManager", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetFragmentManager_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.Android.IFragmentAccessorInvoker, StethoXamarin")]
		global::Java.Lang.Object GetFragmentManager (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentAccessor']/method[@name='getId' and count(parameter)=1 and parameter[1][@type='FRAGMENT']]"
		[Register ("getId", "(Ljava/lang/Object;)I", "GetGetId_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.Android.IFragmentAccessorInvoker, StethoXamarin")]
		int GetId (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentAccessor']/method[@name='getResources' and count(parameter)=1 and parameter[1][@type='FRAGMENT']]"
		[Register ("getResources", "(Ljava/lang/Object;)Landroid/content/res/Resources;", "GetGetResources_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.Android.IFragmentAccessorInvoker, StethoXamarin")]
		global::Android.Content.Res.Resources GetResources (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentAccessor']/method[@name='getTag' and count(parameter)=1 and parameter[1][@type='FRAGMENT']]"
		[Register ("getTag", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetTag_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.Android.IFragmentAccessorInvoker, StethoXamarin")]
		string GetTag (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common.android']/interface[@name='FragmentAccessor']/method[@name='getView' and count(parameter)=1 and parameter[1][@type='FRAGMENT']]"
		[Register ("getView", "(Ljava/lang/Object;)Landroid/view/View;", "GetGetView_Ljava_lang_Object_Handler:Com.Facebook.Stetho.Common.Android.IFragmentAccessorInvoker, StethoXamarin")]
		global::Android.Views.View GetView (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/common/android/FragmentAccessor", DoNotGenerateAcw=true)]
	internal class IFragmentAccessorInvoker : global::Java.Lang.Object, IFragmentAccessor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/android/FragmentAccessor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFragmentAccessorInvoker); }
		}

		IntPtr class_ref;

		public static IFragmentAccessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFragmentAccessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.android.FragmentAccessor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFragmentAccessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.Android.IFragmentAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
