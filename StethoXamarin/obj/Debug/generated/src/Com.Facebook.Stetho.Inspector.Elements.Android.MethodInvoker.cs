using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/MethodInvoker", DoNotGenerateAcw=true)]
	public partial class MethodInvoker : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker.BooleanMethodInvoker']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/MethodInvoker$BooleanMethodInvoker", DoNotGenerateAcw=true)]
		public partial class BooleanMethodInvoker : global::Com.Facebook.Stetho.Inspector.Elements.Android.MethodInvoker.TypedMethodInvoker {

			protected BooleanMethodInvoker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker.CharSequenceMethodInvoker']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/MethodInvoker$CharSequenceMethodInvoker", DoNotGenerateAcw=true)]
		public partial class CharSequenceMethodInvoker : global::Com.Facebook.Stetho.Inspector.Elements.Android.MethodInvoker.TypedMethodInvoker {

			protected CharSequenceMethodInvoker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker.FloatMethodInvoker']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/MethodInvoker$FloatMethodInvoker", DoNotGenerateAcw=true)]
		public partial class FloatMethodInvoker : global::Com.Facebook.Stetho.Inspector.Elements.Android.MethodInvoker.TypedMethodInvoker {

			protected FloatMethodInvoker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker.IntegerMethodInvoker']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/MethodInvoker$IntegerMethodInvoker", DoNotGenerateAcw=true)]
		public partial class IntegerMethodInvoker : global::Com.Facebook.Stetho.Inspector.Elements.Android.MethodInvoker.TypedMethodInvoker {

			protected IntegerMethodInvoker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker.StringMethodInvoker']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/MethodInvoker$StringMethodInvoker", DoNotGenerateAcw=true)]
		public partial class StringMethodInvoker : global::Com.Facebook.Stetho.Inspector.Elements.Android.MethodInvoker.TypedMethodInvoker {

			protected StringMethodInvoker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker.TypedMethodInvoker']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/MethodInvoker$TypedMethodInvoker", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public abstract partial class TypedMethodInvoker : global::Java.Lang.Object {

			protected TypedMethodInvoker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/elements/android/MethodInvoker$TypedMethodInvoker", DoNotGenerateAcw=true)]
		internal partial class TypedMethodInvokerInvoker : TypedMethodInvoker {

			public TypedMethodInvokerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (TypedMethodInvokerInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/elements/android/MethodInvoker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MethodInvoker); }
		}

		protected MethodInvoker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker']/constructor[@name='MethodInvoker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MethodInvoker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MethodInvoker)) {
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

		static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_);
			return cb_invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Stetho.Inspector.Elements.Android.MethodInvoker __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Elements.Android.MethodInvoker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Invoke (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/class[@name='MethodInvoker']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", "GetInvoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Invoke (global::Java.Lang.Object p0, string p1, string p2)
		{
			if (id_invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
