using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='MimeMatcher']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/MimeMatcher", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class MimeMatcher : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='MimeMatcher.MimeMatcherRule']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/network/MimeMatcher$MimeMatcherRule", DoNotGenerateAcw=true)]
		public partial class MimeMatcherRule : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/MimeMatcher$MimeMatcherRule", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MimeMatcherRule); }
			}

			protected MimeMatcherRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_match_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetMatch_Ljava_lang_String_Handler ()
			{
				if (cb_match_Ljava_lang_String_ == null)
					cb_match_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Match_Ljava_lang_String_);
				return cb_match_Ljava_lang_String_;
			}

			static bool n_Match_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Network.MimeMatcher.MimeMatcherRule __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.MimeMatcher.MimeMatcherRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Match (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_match_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='MimeMatcher.MimeMatcherRule']/method[@name='match' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("match", "(Ljava/lang/String;)Z", "GetMatch_Ljava_lang_String_Handler")]
			public virtual unsafe bool Match (string p0)
			{
				if (id_match_Ljava_lang_String_ == IntPtr.Zero)
					id_match_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "match", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_match_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "match", "(Ljava/lang/String;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/network/MimeMatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MimeMatcher); }
		}

		protected MimeMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='MimeMatcher']/constructor[@name='MimeMatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MimeMatcher ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MimeMatcher)) {
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

		static Delegate cb_addRule_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddRule_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_addRule_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_addRule_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddRule_Ljava_lang_String_Ljava_lang_Object_);
			return cb_addRule_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_AddRule_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Network.MimeMatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.MimeMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddRule (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addRule_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='MimeMatcher']/method[@name='addRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("addRule", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetAddRule_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void AddRule (string p0, global::Java.Lang.Object p1)
		{
			if (id_addRule_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_addRule_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addRule", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRule_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRule", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Facebook.Stetho.Inspector.Network.MimeMatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.MimeMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='MimeMatcher']/method[@name='clear' and count(parameter)=0]"
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

		static Delegate cb_match_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMatch_Ljava_lang_String_Handler ()
		{
			if (cb_match_Ljava_lang_String_ == null)
				cb_match_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Match_Ljava_lang_String_);
			return cb_match_Ljava_lang_String_;
		}

		static IntPtr n_Match_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Network.MimeMatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Network.MimeMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Match (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_match_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.network']/class[@name='MimeMatcher']/method[@name='match' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("match", "(Ljava/lang/String;)Ljava/lang/Object;", "GetMatch_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object Match (string p0)
		{
			if (id_match_Ljava_lang_String_ == IntPtr.Zero)
				id_match_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "match", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_match_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "match", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
