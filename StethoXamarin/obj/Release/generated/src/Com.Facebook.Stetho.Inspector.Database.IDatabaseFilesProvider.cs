using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Database {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/interface[@name='DatabaseFilesProvider']"
	[Register ("com/facebook/stetho/inspector/database/DatabaseFilesProvider", "", "Com.Facebook.Stetho.Inspector.Database.IDatabaseFilesProviderInvoker")]
	public partial interface IDatabaseFilesProvider : IJavaObject {

		global::System.Collections.Generic.IList<global::Java.IO.File> DatabaseFiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/interface[@name='DatabaseFilesProvider']/method[@name='getDatabaseFiles' and count(parameter)=0]"
			[Register ("getDatabaseFiles", "()Ljava/util/List;", "GetGetDatabaseFilesHandler:Com.Facebook.Stetho.Inspector.Database.IDatabaseFilesProviderInvoker, StethoXamarin")] get;
		}

	}

	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/DatabaseFilesProvider", DoNotGenerateAcw=true)]
	internal class IDatabaseFilesProviderInvoker : global::Java.Lang.Object, IDatabaseFilesProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/inspector/database/DatabaseFilesProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDatabaseFilesProviderInvoker); }
		}

		IntPtr class_ref;

		public static IDatabaseFilesProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDatabaseFilesProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.inspector.database.DatabaseFilesProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDatabaseFilesProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDatabaseFiles;
#pragma warning disable 0169
		static Delegate GetGetDatabaseFilesHandler ()
		{
			if (cb_getDatabaseFiles == null)
				cb_getDatabaseFiles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDatabaseFiles);
			return cb_getDatabaseFiles;
		}

		static IntPtr n_GetDatabaseFiles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Database.IDatabaseFilesProvider __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.IDatabaseFilesProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.IO.File>.ToLocalJniHandle (__this.DatabaseFiles);
		}
#pragma warning restore 0169

		IntPtr id_getDatabaseFiles;
		public unsafe global::System.Collections.Generic.IList<global::Java.IO.File> DatabaseFiles {
			get {
				if (id_getDatabaseFiles == IntPtr.Zero)
					id_getDatabaseFiles = JNIEnv.GetMethodID (class_ref, "getDatabaseFiles", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Java.IO.File>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDatabaseFiles), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
