using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Database {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/interface[@name='DatabaseConnectionProvider']"
	[Register ("com/facebook/stetho/inspector/database/DatabaseConnectionProvider", "", "Com.Facebook.Stetho.Inspector.Database.IDatabaseConnectionProviderInvoker")]
	public partial interface IDatabaseConnectionProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/interface[@name='DatabaseConnectionProvider']/method[@name='openDatabase' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("openDatabase", "(Ljava/io/File;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenDatabase_Ljava_io_File_Handler:Com.Facebook.Stetho.Inspector.Database.IDatabaseConnectionProviderInvoker, StethoXamarin")]
		global::Android.Database.Sqlite.SQLiteDatabase OpenDatabase (global::Java.IO.File p0);

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/DatabaseConnectionProvider", DoNotGenerateAcw=true)]
	internal class IDatabaseConnectionProviderInvoker : global::Java.Lang.Object, IDatabaseConnectionProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/database/DatabaseConnectionProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDatabaseConnectionProviderInvoker); }
		}

		IntPtr class_ref;

		public static IDatabaseConnectionProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDatabaseConnectionProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.database.DatabaseConnectionProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDatabaseConnectionProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Stetho.Inspector.Database.IDatabaseConnectionProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.IDatabaseConnectionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenDatabase (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_openDatabase_Ljava_io_File_;
		public unsafe global::Android.Database.Sqlite.SQLiteDatabase OpenDatabase (global::Java.IO.File p0)
		{
			if (id_openDatabase_Ljava_io_File_ == IntPtr.Zero)
				id_openDatabase_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "openDatabase", "(Ljava/io/File;)Landroid/database/sqlite/SQLiteDatabase;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.Database.Sqlite.SQLiteDatabase __ret = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openDatabase_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
