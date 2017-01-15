using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/helper/ObjectIdMapper", DoNotGenerateAcw=true)]
	public partial class ObjectIdMapper : global::Java.Lang.Object {


		static IntPtr mSync_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/field[@name='mSync']"
		[Register ("mSync")]
		protected global::Java.Lang.Object MSync {
			get {
				if (mSync_jfieldId == IntPtr.Zero)
					mSync_jfieldId = JNIEnv.GetFieldID (class_ref, "mSync", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSync_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSync_jfieldId == IntPtr.Zero)
					mSync_jfieldId = JNIEnv.GetFieldID (class_ref, "mSync", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSync_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/helper/ObjectIdMapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectIdMapper); }
		}

		protected ObjectIdMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/constructor[@name='ObjectIdMapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectIdMapper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ObjectIdMapper)) {
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

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_containsId_I;
#pragma warning disable 0169
		static Delegate GetContainsId_IHandler ()
		{
			if (cb_containsId_I == null)
				cb_containsId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_ContainsId_I);
			return cb_containsId_I;
		}

		static bool n_ContainsId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainsId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_containsId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='containsId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("containsId", "(I)Z", "GetContainsId_IHandler")]
		public virtual unsafe bool ContainsId (int p0)
		{
			if (id_containsId_I == IntPtr.Zero)
				id_containsId_I = JNIEnv.GetMethodID (class_ref, "containsId", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsId_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsId", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_containsObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContainsObject_Ljava_lang_Object_Handler ()
		{
			if (cb_containsObject_Ljava_lang_Object_ == null)
				cb_containsObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsObject_Ljava_lang_Object_);
			return cb_containsObject_Ljava_lang_Object_;
		}

		static bool n_ContainsObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsObject (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsObject_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='containsObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("containsObject", "(Ljava/lang/Object;)Z", "GetContainsObject_Ljava_lang_Object_Handler")]
		public virtual unsafe bool ContainsObject (global::Java.Lang.Object p0)
		{
			if (id_containsObject_Ljava_lang_Object_ == IntPtr.Zero)
				id_containsObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "containsObject", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsObject_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsObject", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getIdForObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetIdForObject_Ljava_lang_Object_Handler ()
		{
			if (cb_getIdForObject_Ljava_lang_Object_ == null)
				cb_getIdForObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetIdForObject_Ljava_lang_Object_);
			return cb_getIdForObject_Ljava_lang_Object_;
		}

		static IntPtr n_GetIdForObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIdForObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIdForObject_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='getIdForObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getIdForObject", "(Ljava/lang/Object;)Ljava/lang/Integer;", "GetGetIdForObject_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Integer GetIdForObject (global::Java.Lang.Object p0)
		{
			if (id_getIdForObject_Ljava_lang_Object_ == IntPtr.Zero)
				id_getIdForObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getIdForObject", "(Ljava/lang/Object;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Integer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdForObject_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdForObject", "(Ljava/lang/Object;)Ljava/lang/Integer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getObjectForId_I;
#pragma warning disable 0169
		static Delegate GetGetObjectForId_IHandler ()
		{
			if (cb_getObjectForId_I == null)
				cb_getObjectForId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetObjectForId_I);
			return cb_getObjectForId_I;
		}

		static IntPtr n_GetObjectForId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObjectForId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getObjectForId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='getObjectForId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObjectForId", "(I)Ljava/lang/Object;", "GetGetObjectForId_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetObjectForId (int p0)
		{
			if (id_getObjectForId_I == IntPtr.Zero)
				id_getObjectForId_I = JNIEnv.GetMethodID (class_ref, "getObjectForId", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObjectForId_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectForId", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onMapped_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetOnMapped_Ljava_lang_Object_IHandler ()
		{
			if (cb_onMapped_Ljava_lang_Object_I == null)
				cb_onMapped_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnMapped_Ljava_lang_Object_I);
			return cb_onMapped_Ljava_lang_Object_I;
		}

		static void n_OnMapped_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMapped (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMapped_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='onMapped' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("onMapped", "(Ljava/lang/Object;I)V", "GetOnMapped_Ljava_lang_Object_IHandler")]
		protected virtual unsafe void OnMapped (global::Java.Lang.Object p0, int p1)
		{
			if (id_onMapped_Ljava_lang_Object_I == IntPtr.Zero)
				id_onMapped_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "onMapped", "(Ljava/lang/Object;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapped_Ljava_lang_Object_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMapped", "(Ljava/lang/Object;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUnmapped_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetOnUnmapped_Ljava_lang_Object_IHandler ()
		{
			if (cb_onUnmapped_Ljava_lang_Object_I == null)
				cb_onUnmapped_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnUnmapped_Ljava_lang_Object_I);
			return cb_onUnmapped_Ljava_lang_Object_I;
		}

		static void n_OnUnmapped_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnmapped (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onUnmapped_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='onUnmapped' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("onUnmapped", "(Ljava/lang/Object;I)V", "GetOnUnmapped_Ljava_lang_Object_IHandler")]
		protected virtual unsafe void OnUnmapped (global::Java.Lang.Object p0, int p1)
		{
			if (id_onUnmapped_Ljava_lang_Object_I == IntPtr.Zero)
				id_onUnmapped_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "onUnmapped", "(Ljava/lang/Object;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnmapped_Ljava_lang_Object_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnmapped", "(Ljava/lang/Object;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPutObject_Ljava_lang_Object_Handler ()
		{
			if (cb_putObject_Ljava_lang_Object_ == null)
				cb_putObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_PutObject_Ljava_lang_Object_);
			return cb_putObject_Ljava_lang_Object_;
		}

		static int n_PutObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutObject (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_putObject_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='putObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("putObject", "(Ljava/lang/Object;)I", "GetPutObject_Ljava_lang_Object_Handler")]
		public virtual unsafe int PutObject (global::Java.Lang.Object p0)
		{
			if (id_putObject_Ljava_lang_Object_ == IntPtr.Zero)
				id_putObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putObject", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_putObject_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putObject", "(Ljava/lang/Object;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveObject_Ljava_lang_Object_Handler ()
		{
			if (cb_removeObject_Ljava_lang_Object_ == null)
				cb_removeObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveObject_Ljava_lang_Object_);
			return cb_removeObject_Ljava_lang_Object_;
		}

		static IntPtr n_RemoveObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeObject_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='removeObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeObject", "(Ljava/lang/Object;)Ljava/lang/Integer;", "GetRemoveObject_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Integer RemoveObject (global::Java.Lang.Object p0)
		{
			if (id_removeObject_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeObject", "(Ljava/lang/Object;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Integer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeObject_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeObject", "(Ljava/lang/Object;)Ljava/lang/Integer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeObjectById_I;
#pragma warning disable 0169
		static Delegate GetRemoveObjectById_IHandler ()
		{
			if (cb_removeObjectById_I == null)
				cb_removeObjectById_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RemoveObjectById_I);
			return cb_removeObjectById_I;
		}

		static IntPtr n_RemoveObjectById_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveObjectById (p0));
		}
#pragma warning restore 0169

		static IntPtr id_removeObjectById_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='removeObjectById' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeObjectById", "(I)Ljava/lang/Object;", "GetRemoveObjectById_IHandler")]
		public virtual unsafe global::Java.Lang.Object RemoveObjectById (int p0)
		{
			if (id_removeObjectById_I == IntPtr.Zero)
				id_removeObjectById_I = JNIEnv.GetMethodID (class_ref, "removeObjectById", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeObjectById_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeObjectById", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Helper.ObjectIdMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.helper']/class[@name='ObjectIdMapper']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
