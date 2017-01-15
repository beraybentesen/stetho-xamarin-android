using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Json.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.json.annotation']/interface[@name='JsonProperty']"
	[Register ("com/facebook/stetho/json/annotation/JsonProperty", "", "Com.Facebook.Stetho.Json.Annotation.IJsonPropertyInvoker")]
	public partial interface IJsonProperty : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.json.annotation']/interface[@name='JsonProperty']/method[@name='required' and count(parameter)=0]"
		[Register ("required", "()Z", "GetRequiredHandler:Com.Facebook.Stetho.Json.Annotation.IJsonPropertyInvoker, StethoXamarin")]
		bool Required ();

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/json/annotation/JsonProperty", DoNotGenerateAcw=true)]
	internal class IJsonPropertyInvoker : global::Java.Lang.Object, IJsonProperty {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/json/annotation/JsonProperty");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJsonPropertyInvoker); }
		}

		IntPtr class_ref;

		public static IJsonProperty GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonProperty> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.json.annotation.JsonProperty"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonPropertyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_required;
#pragma warning disable 0169
		static Delegate GetRequiredHandler ()
		{
			if (cb_required == null)
				cb_required = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Required);
			return cb_required;
		}

		static bool n_Required (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Required ();
		}
#pragma warning restore 0169

		IntPtr id_required;
		public unsafe bool Required ()
		{
			if (id_required == IntPtr.Zero)
				id_required = JNIEnv.GetMethodID (class_ref, "required", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_required);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (obj);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Json.Annotation.IJsonProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
