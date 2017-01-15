using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='DefaultDatabaseFilesProvider']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/DefaultDatabaseFilesProvider", DoNotGenerateAcw=true)]
	public sealed partial class DefaultDatabaseFilesProvider : global::Java.Lang.Object, global::Com.Facebook.Stetho.Inspector.Database.IDatabaseFilesProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/DefaultDatabaseFilesProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultDatabaseFilesProvider); }
		}

		internal DefaultDatabaseFilesProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='DefaultDatabaseFilesProvider']/constructor[@name='DefaultDatabaseFilesProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DefaultDatabaseFilesProvider (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DefaultDatabaseFilesProvider)) {
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

		static IntPtr id_getDatabaseFiles;
		public unsafe global::System.Collections.Generic.IList<global::Java.IO.File> DatabaseFiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='DefaultDatabaseFilesProvider']/method[@name='getDatabaseFiles' and count(parameter)=0]"
			[Register ("getDatabaseFiles", "()Ljava/util/List;", "GetGetDatabaseFilesHandler")]
			get {
				if (id_getDatabaseFiles == IntPtr.Zero)
					id_getDatabaseFiles = JNIEnv.GetMethodID (class_ref, "getDatabaseFiles", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Java.IO.File>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDatabaseFiles), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
