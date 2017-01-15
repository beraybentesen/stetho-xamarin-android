using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='RegexpPathMatcher']"
	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/RegexpPathMatcher", DoNotGenerateAcw=true)]
	public partial class RegexpPathMatcher : global::Java.Lang.Object, global::Com.Facebook.Stetho.Server.Http.IPathMatcher {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/server/http/RegexpPathMatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegexpPathMatcher); }
		}

		protected RegexpPathMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_regex_Pattern_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='RegexpPathMatcher']/constructor[@name='RegexpPathMatcher' and count(parameter)=1 and parameter[1][@type='java.util.regex.Pattern']]"
		[Register (".ctor", "(Ljava/util/regex/Pattern;)V", "")]
		public unsafe RegexpPathMatcher (global::Java.Util.Regex.Pattern p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RegexpPathMatcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/regex/Pattern;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/regex/Pattern;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_regex_Pattern_ == IntPtr.Zero)
					id_ctor_Ljava_util_regex_Pattern_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/regex/Pattern;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_regex_Pattern_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_regex_Pattern_, __args);
			} finally {
			}
		}

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
			global::Com.Facebook.Stetho.Server.Http.RegexpPathMatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.RegexpPathMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Match (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_match_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/class[@name='RegexpPathMatcher']/method[@name='match' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
}
