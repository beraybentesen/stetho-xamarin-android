using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='PathMatcher']"
	[Register ("com/facebook/stetho/server/http/PathMatcher", "", "Com.Facebook.Stetho.Server.Http.IPathMatcherInvoker")]
	public partial interface IPathMatcher : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='PathMatcher']/method[@name='match' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("match", "(Ljava/lang/String;)Z", "GetMatch_Ljava_lang_String_Handler:Com.Facebook.Stetho.Server.Http.IPathMatcherInvoker, StethoXamarin")]
		bool Match (string p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/server/http/PathMatcher", DoNotGenerateAcw=true)]
	internal class IPathMatcherInvoker : global::Java.Lang.Object, IPathMatcher {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/server/http/PathMatcher");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPathMatcherInvoker); }
		}

		IntPtr class_ref;

		public static IPathMatcher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPathMatcher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.server.http.PathMatcher"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPathMatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Stetho.Server.Http.IPathMatcher __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Server.Http.IPathMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Match (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_match_Ljava_lang_String_;
		public unsafe bool Match (string p0)
		{
			if (id_match_Ljava_lang_String_ == IntPtr.Zero)
				id_match_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "match", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_match_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
