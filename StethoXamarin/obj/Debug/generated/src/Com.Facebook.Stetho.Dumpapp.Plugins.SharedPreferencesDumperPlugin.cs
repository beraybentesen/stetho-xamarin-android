using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Dumpapp.Plugins {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin']"
	[global::Android.Runtime.Register ("com/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin", DoNotGenerateAcw=true)]
	public partial class SharedPreferencesDumperPlugin : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin.Type']"
		[global::Android.Runtime.Register ("com/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr BOOLEAN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin.Type']/field[@name='BOOLEAN']"
			[Register ("BOOLEAN")]
			public static global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type Boolean {
				get {
					if (BOOLEAN_jfieldId == IntPtr.Zero)
						BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN", "Lcom/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOLEAN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FLOAT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin.Type']/field[@name='FLOAT']"
			[Register ("FLOAT")]
			public static global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type Float {
				get {
					if (FLOAT_jfieldId == IntPtr.Zero)
						FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin.Type']/field[@name='INT']"
			[Register ("INT")]
			public static global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type Int {
				get {
					if (INT_jfieldId == IntPtr.Zero)
						INT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INT", "Lcom/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LONG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin.Type']/field[@name='LONG']"
			[Register ("LONG")]
			public static global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type Long {
				get {
					if (LONG_jfieldId == IntPtr.Zero)
						LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG", "Lcom/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin.Type']/field[@name='SET']"
			[Register ("SET")]
			public static global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type Set {
				get {
					if (SET_jfieldId == IntPtr.Zero)
						SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SET", "Lcom/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin.Type']/field[@name='STRING']"
			[Register ("STRING")]
			public static global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type String {
				get {
					if (STRING_jfieldId == IntPtr.Zero)
						STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_appendNamesList_Ljava_lang_StringBuilder_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin.Type']/method[@name='appendNamesList' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='java.lang.String']]"
			[Register ("appendNamesList", "(Ljava/lang/StringBuilder;Ljava/lang/String;)Ljava/lang/StringBuilder;", "")]
			public static unsafe global::Java.Lang.StringBuilder AppendNamesList (global::Java.Lang.StringBuilder p0, string p1)
			{
				if (id_appendNamesList_Ljava_lang_StringBuilder_Ljava_lang_String_ == IntPtr.Zero)
					id_appendNamesList_Ljava_lang_StringBuilder_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "appendNamesList", "(Ljava/lang/StringBuilder;Ljava/lang/String;)Ljava/lang/StringBuilder;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					global::Java.Lang.StringBuilder __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_appendNamesList_Ljava_lang_StringBuilder_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/dumpapp/plugins/SharedPreferencesDumperPlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SharedPreferencesDumperPlugin); }
		}

		protected SharedPreferencesDumperPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin']/constructor[@name='SharedPreferencesDumperPlugin' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SharedPreferencesDumperPlugin (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SharedPreferencesDumperPlugin)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Dumpapp.Plugins.SharedPreferencesDumperPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.dumpapp.plugins']/class[@name='SharedPreferencesDumperPlugin']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
