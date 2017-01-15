using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat", DoNotGenerateAcw=true)]
	public abstract partial class SQLiteDatabaseCompat : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']/field[@name='ENABLE_FOREIGN_KEY_CONSTRAINTS']"
		[Register ("ENABLE_FOREIGN_KEY_CONSTRAINTS")]
		public const int EnableForeignKeyConstraints = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']/field[@name='ENABLE_WRITE_AHEAD_LOGGING']"
		[Register ("ENABLE_WRITE_AHEAD_LOGGING")]
		public const int EnableWriteAheadLogging = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.HoneycombImpl']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$HoneycombImpl", DoNotGenerateAcw=true)]
		public partial class HoneycombImpl : global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$HoneycombImpl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HoneycombImpl); }
			}

			protected HoneycombImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ == null)
					cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_EnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_);
				return cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
			}

			static void n_EnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.HoneycombImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.HoneycombImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p1 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.EnableFeatures (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.HoneycombImpl']/method[@name='enableFeatures' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.database.sqlite.SQLiteDatabase']]"
			[Register ("enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V", "GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler")]
			public override unsafe void EnableFeatures (int p0, global::Android.Database.Sqlite.SQLiteDatabase p1)
			{
				if (id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_provideOpenFlags_I;
#pragma warning disable 0169
			static Delegate GetProvideOpenFlags_IHandler ()
			{
				if (cb_provideOpenFlags_I == null)
					cb_provideOpenFlags_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ProvideOpenFlags_I);
				return cb_provideOpenFlags_I;
			}

			static int n_ProvideOpenFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.HoneycombImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.HoneycombImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ProvideOpenFlags (p0);
			}
#pragma warning restore 0169

			static IntPtr id_provideOpenFlags_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.HoneycombImpl']/method[@name='provideOpenFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("provideOpenFlags", "(I)I", "GetProvideOpenFlags_IHandler")]
			public override unsafe int ProvideOpenFlags (int p0)
			{
				if (id_provideOpenFlags_I == IntPtr.Zero)
					id_provideOpenFlags_I = JNIEnv.GetMethodID (class_ref, "provideOpenFlags", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_provideOpenFlags_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "provideOpenFlags", "(I)I"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.JellyBeanAndBeyondImpl']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$JellyBeanAndBeyondImpl", DoNotGenerateAcw=true)]
		public partial class JellyBeanAndBeyondImpl : global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$JellyBeanAndBeyondImpl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JellyBeanAndBeyondImpl); }
			}

			protected JellyBeanAndBeyondImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ == null)
					cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_EnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_);
				return cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
			}

			static void n_EnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.JellyBeanAndBeyondImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.JellyBeanAndBeyondImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p1 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.EnableFeatures (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.JellyBeanAndBeyondImpl']/method[@name='enableFeatures' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.database.sqlite.SQLiteDatabase']]"
			[Register ("enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V", "GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler")]
			public override unsafe void EnableFeatures (int p0, global::Android.Database.Sqlite.SQLiteDatabase p1)
			{
				if (id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_provideOpenFlags_I;
#pragma warning disable 0169
			static Delegate GetProvideOpenFlags_IHandler ()
			{
				if (cb_provideOpenFlags_I == null)
					cb_provideOpenFlags_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ProvideOpenFlags_I);
				return cb_provideOpenFlags_I;
			}

			static int n_ProvideOpenFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.JellyBeanAndBeyondImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.JellyBeanAndBeyondImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ProvideOpenFlags (p0);
			}
#pragma warning restore 0169

			static IntPtr id_provideOpenFlags_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.JellyBeanAndBeyondImpl']/method[@name='provideOpenFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("provideOpenFlags", "(I)I", "GetProvideOpenFlags_IHandler")]
			public override unsafe int ProvideOpenFlags (int p0)
			{
				if (id_provideOpenFlags_I == IntPtr.Zero)
					id_provideOpenFlags_I = JNIEnv.GetMethodID (class_ref, "provideOpenFlags", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_provideOpenFlags_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "provideOpenFlags", "(I)I"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.NoopImpl']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$NoopImpl", DoNotGenerateAcw=true)]
		public partial class NoopImpl : global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$NoopImpl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NoopImpl); }
			}

			protected NoopImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ == null)
					cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_EnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_);
				return cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
			}

			static void n_EnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.NoopImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.NoopImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p1 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.EnableFeatures (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.NoopImpl']/method[@name='enableFeatures' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.database.sqlite.SQLiteDatabase']]"
			[Register ("enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V", "GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler")]
			public override unsafe void EnableFeatures (int p0, global::Android.Database.Sqlite.SQLiteDatabase p1)
			{
				if (id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_provideOpenFlags_I;
#pragma warning disable 0169
			static Delegate GetProvideOpenFlags_IHandler ()
			{
				if (cb_provideOpenFlags_I == null)
					cb_provideOpenFlags_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ProvideOpenFlags_I);
				return cb_provideOpenFlags_I;
			}

			static int n_ProvideOpenFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.NoopImpl __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.NoopImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ProvideOpenFlags (p0);
			}
#pragma warning restore 0169

			static IntPtr id_provideOpenFlags_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat.NoopImpl']/method[@name='provideOpenFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("provideOpenFlags", "(I)I", "GetProvideOpenFlags_IHandler")]
			public override unsafe int ProvideOpenFlags (int p0)
			{
				if (id_provideOpenFlags_I == IntPtr.Zero)
					id_provideOpenFlags_I = JNIEnv.GetMethodID (class_ref, "provideOpenFlags", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_provideOpenFlags_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "provideOpenFlags", "(I)I"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/interface[@name='SQLiteDatabaseCompat.SQLiteOpenOptions']"
		[Register ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$SQLiteOpenOptions", "", "Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat/ISQLiteOpenOptionsInvoker")]
		public partial interface ISQLiteOpenOptions : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$SQLiteOpenOptions", DoNotGenerateAcw=true)]
		internal class ISQLiteOpenOptionsInvoker : global::Java.Lang.Object, ISQLiteOpenOptions {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat$SQLiteOpenOptions");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISQLiteOpenOptionsInvoker); }
			}

			IntPtr class_ref;

			public static ISQLiteOpenOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISQLiteOpenOptions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.database.SQLiteDatabaseCompat.SQLiteOpenOptions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISQLiteOpenOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.ISQLiteOpenOptions __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.ISQLiteOpenOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.ISQLiteOpenOptions __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.ISQLiteOpenOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.ISQLiteOpenOptions __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.ISQLiteOpenOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.ISQLiteOpenOptions __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat.ISQLiteOpenOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SQLiteDatabaseCompat); }
		}

		protected SQLiteDatabaseCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']/constructor[@name='SQLiteDatabaseCompat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SQLiteDatabaseCompat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SQLiteDatabaseCompat)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/facebook/stetho/inspector/database/SQLiteDatabaseCompat;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/facebook/stetho/inspector/database/SQLiteDatabaseCompat;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
		static Delegate GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler ()
		{
			if (cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ == null)
				cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_EnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_);
			return cb_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
		}

		static void n_EnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase p1 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EnableFeatures (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']/method[@name='enableFeatures' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V", "GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler")]
		public abstract void EnableFeatures ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat", Fields = new string [] {"EnableWriteAheadLogging", "EnableForeignKeyConstraints"})]int p0, global::Android.Database.Sqlite.SQLiteDatabase p1);

		static Delegate cb_provideOpenFlags_I;
#pragma warning disable 0169
		static Delegate GetProvideOpenFlags_IHandler ()
		{
			if (cb_provideOpenFlags_I == null)
				cb_provideOpenFlags_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ProvideOpenFlags_I);
			return cb_provideOpenFlags_I;
		}

		static int n_ProvideOpenFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProvideOpenFlags (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']/method[@name='provideOpenFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("provideOpenFlags", "(I)I", "GetProvideOpenFlags_IHandler")]
		public abstract int ProvideOpenFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat", Fields = new string [] {"EnableWriteAheadLogging", "EnableForeignKeyConstraints"})]int p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/SQLiteDatabaseCompat", DoNotGenerateAcw=true)]
	internal partial class SQLiteDatabaseCompatInvoker : SQLiteDatabaseCompat {

		public SQLiteDatabaseCompatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SQLiteDatabaseCompatInvoker); }
		}

		static IntPtr id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']/method[@name='enableFeatures' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V", "GetEnableFeatures_ILandroid_database_sqlite_SQLiteDatabase_Handler")]
		public override unsafe void EnableFeatures ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat", Fields = new string [] {"EnableWriteAheadLogging", "EnableForeignKeyConstraints"})]int p0, global::Android.Database.Sqlite.SQLiteDatabase p1)
		{
			if (id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "enableFeatures", "(ILandroid/database/sqlite/SQLiteDatabase;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableFeatures_ILandroid_database_sqlite_SQLiteDatabase_, __args);
			} finally {
			}
		}

		static IntPtr id_provideOpenFlags_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='SQLiteDatabaseCompat']/method[@name='provideOpenFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("provideOpenFlags", "(I)I", "GetProvideOpenFlags_IHandler")]
		public override unsafe int ProvideOpenFlags ([global::Android.Runtime.IntDef (Flag = true, Type = "Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat", Fields = new string [] {"EnableWriteAheadLogging", "EnableForeignKeyConstraints"})]int p0)
		{
			if (id_provideOpenFlags_I == IntPtr.Zero)
				id_provideOpenFlags_I = JNIEnv.GetMethodID (class_ref, "provideOpenFlags", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_provideOpenFlags_I, __args);
			} finally {
			}
		}

	}

}
