using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='DefaultDatabaseConnectionProvider']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/DefaultDatabaseConnectionProvider", DoNotGenerateAcw=true)]
	public partial class DefaultDatabaseConnectionProvider : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Database.IDatabaseConnectionProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/DefaultDatabaseConnectionProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultDatabaseConnectionProvider); }
		}

		protected DefaultDatabaseConnectionProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='DefaultDatabaseConnectionProvider']/constructor[@name='DefaultDatabaseConnectionProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultDatabaseConnectionProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultDatabaseConnectionProvider)) {
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

		static Delegate cb_determineOpenOptions_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetDetermineOpenOptions_Ljava_io_File_Handler ()
		{
			if (cb_determineOpenOptions_Ljava_io_File_ == null)
				cb_determineOpenOptions_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DetermineOpenOptions_Ljava_io_File_);
			return cb_determineOpenOptions_Ljava_io_File_;
		}

		static int n_DetermineOpenOptions_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Database.DefaultDatabaseConnectionProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.DefaultDatabaseConnectionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DetermineOpenOptions (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_determineOpenOptions_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='DefaultDatabaseConnectionProvider']/method[@name='determineOpenOptions' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("determineOpenOptions", "(Ljava/io/File;)I", "GetDetermineOpenOptions_Ljava_io_File_Handler")]
		protected virtual unsafe int DetermineOpenOptions (global::Java.IO.File p0)
		{
			if (id_determineOpenOptions_Ljava_io_File_ == IntPtr.Zero)
				id_determineOpenOptions_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "determineOpenOptions", "(Ljava/io/File;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_determineOpenOptions_Ljava_io_File_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "determineOpenOptions", "(Ljava/io/File;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_openDatabase_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetOpenDatabase_Ljava_io_File_Handler ()
		{
			if (cb_openDatabase_Ljava_io_File_ == null)
				cb_openDatabase_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenDatabase_Ljava_io_File_);
			return cb_openDatabase_Ljava_io_File_;
		}

		static IntPtr n_OpenDatabase_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Stetho.Inspector.Database.DefaultDatabaseConnectionProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.DefaultDatabaseConnectionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenDatabase (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openDatabase_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='DefaultDatabaseConnectionProvider']/method[@name='openDatabase' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("openDatabase", "(Ljava/io/File;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenDatabase_Ljava_io_File_Handler")]
		public virtual unsafe global::Android.Database.Sqlite.SQLiteDatabase OpenDatabase (global::Java.IO.File p0)
		{
			if (id_openDatabase_Ljava_io_File_ == IntPtr.Zero)
				id_openDatabase_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "openDatabase", "(Ljava/io/File;)Landroid/database/sqlite/SQLiteDatabase;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Database.Sqlite.SQLiteDatabase __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openDatabase_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openDatabase", "(Ljava/io/File;)Landroid/database/sqlite/SQLiteDatabase;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_performOpen_Ljava_io_File_I;
#pragma warning disable 0169
		static Delegate GetPerformOpen_Ljava_io_File_IHandler ()
		{
			if (cb_performOpen_Ljava_io_File_I == null)
				cb_performOpen_Ljava_io_File_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_PerformOpen_Ljava_io_File_I);
			return cb_performOpen_Ljava_io_File_I;
		}

		static IntPtr n_PerformOpen_Ljava_io_File_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Facebook.Stetho.Inspector.Database.DefaultDatabaseConnectionProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.DefaultDatabaseConnectionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformOpen (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_performOpen_Ljava_io_File_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='DefaultDatabaseConnectionProvider']/method[@name='performOpen' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register ("performOpen", "(Ljava/io/File;I)Landroid/database/sqlite/SQLiteDatabase;", "GetPerformOpen_Ljava_io_File_IHandler")]
		protected virtual unsafe global::Android.Database.Sqlite.SQLiteDatabase PerformOpen (global::Java.IO.File p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Com.Facebook.Stetho.Inspector.Database.SQLiteDatabaseCompat", Fields = new string [] {"EnableWriteAheadLogging", "EnableForeignKeyConstraints"})]int p1)
		{
			if (id_performOpen_Ljava_io_File_I == IntPtr.Zero)
				id_performOpen_Ljava_io_File_I = JNIEnv.GetMethodID (class_ref, "performOpen", "(Ljava/io/File;I)Landroid/database/sqlite/SQLiteDatabase;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Database.Sqlite.SQLiteDatabase __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_performOpen_Ljava_io_File_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performOpen", "(Ljava/io/File;I)Landroid/database/sqlite/SQLiteDatabase;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
