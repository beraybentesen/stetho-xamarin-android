using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema']"
	[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/ContentProviderSchema", DoNotGenerateAcw=true)]
	public partial class ContentProviderSchema : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Builder']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/ContentProviderSchema$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/ContentProviderSchema$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Builder']/constructor[@name='ContentProviderSchema.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/stetho/inspector/database/ContentProviderSchema;", "GetBuildHandler")]
			public virtual unsafe global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/stetho/inspector/database/ContentProviderSchema;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/facebook/stetho/inspector/database/ContentProviderSchema;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_;
#pragma warning disable 0169
			static Delegate GetTable_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_Handler ()
			{
				if (cb_table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_ == null)
					cb_table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_);
				return cb_table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_;
			}

			static IntPtr n_Table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Table (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Builder']/method[@name='table' and count(parameter)=1 and parameter[1][@type='com.facebook.stetho.inspector.database.ContentProviderSchema.Table']]"
			[Register ("table", "(Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Builder;", "GetTable_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_Handler")]
			public virtual unsafe global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Builder Table (global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table p0)
			{
				if (id_table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_ == IntPtr.Zero)
					id_table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_ = JNIEnv.GetMethodID (class_ref, "table", "(Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_table_Lcom_facebook_stetho_inspector_database_ContentProviderSchema_Table_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "table", "(Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Table']"
		[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/ContentProviderSchema$Table", DoNotGenerateAcw=true)]
		public partial class Table : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Table.Builder']"
			[global::Android.Runtime.Register ("com/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder", DoNotGenerateAcw=true)]
			public partial class Builder : global::Java.Lang.Object {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Table.Builder']/constructor[@name='ContentProviderSchema.Table.Builder' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public unsafe Builder ()
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						if (GetType () != typeof (Builder)) {
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

				static Delegate cb_build;
#pragma warning disable 0169
				static Delegate GetBuildHandler ()
				{
					if (cb_build == null)
						cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
					return cb_build;
				}

				static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.Build ());
				}
#pragma warning restore 0169

				static IntPtr id_build;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Table.Builder']/method[@name='build' and count(parameter)=0]"
				[Register ("build", "()Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table;", "GetBuildHandler")]
				public virtual unsafe global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table Build ()
				{
					if (id_build == IntPtr.Zero)
						id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_name_Ljava_lang_String_;
#pragma warning disable 0169
				static Delegate GetName_Ljava_lang_String_Handler ()
				{
					if (cb_name_Ljava_lang_String_ == null)
						cb_name_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Name_Ljava_lang_String_);
					return cb_name_Ljava_lang_String_;
				}

				static IntPtr n_Name_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Name (p0));
					return __ret;
				}
#pragma warning restore 0169

				static IntPtr id_name_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Table.Builder']/method[@name='name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("name", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;", "GetName_Ljava_lang_String_Handler")]
				public virtual unsafe global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder Name (string p0)
				{
					if (id_name_Ljava_lang_String_ == IntPtr.Zero)
						id_name_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "name", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);

						global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder __ret;
						if (GetType () == ThresholdType)
							__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_name_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						else
							__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "name", "(Ljava/lang/String;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

				static Delegate cb_projection_arrayLjava_lang_String_;
#pragma warning disable 0169
				static Delegate GetProjection_arrayLjava_lang_String_Handler ()
				{
					if (cb_projection_arrayLjava_lang_String_ == null)
						cb_projection_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Projection_arrayLjava_lang_String_);
					return cb_projection_arrayLjava_lang_String_;
				}

				static IntPtr n_Projection_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Projection (p0));
					if (p0 != null)
						JNIEnv.CopyArray (p0, native_p0);
					return __ret;
				}
#pragma warning restore 0169

				static IntPtr id_projection_arrayLjava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Table.Builder']/method[@name='projection' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
				[Register ("projection", "([Ljava/lang/String;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;", "GetProjection_arrayLjava_lang_String_Handler")]
				public virtual unsafe global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder Projection (string[] p0)
				{
					if (id_projection_arrayLjava_lang_String_ == IntPtr.Zero)
						id_projection_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "projection", "([Ljava/lang/String;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;");
					IntPtr native_p0 = JNIEnv.NewArray (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);

						global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder __ret;
						if (GetType () == ThresholdType)
							__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_projection_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						else
							__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "projection", "([Ljava/lang/String;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						if (p0 != null) {
							JNIEnv.CopyArray (native_p0, p0);
							JNIEnv.DeleteLocalRef (native_p0);
						}
					}
				}

				static Delegate cb_uri_Landroid_net_Uri_;
#pragma warning disable 0169
				static Delegate GetUri_Landroid_net_Uri_Handler ()
				{
					if (cb_uri_Landroid_net_Uri_ == null)
						cb_uri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Uri_Landroid_net_Uri_);
					return cb_uri_Landroid_net_Uri_;
				}

				static IntPtr n_Uri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Uri (p0));
					return __ret;
				}
#pragma warning restore 0169

				static IntPtr id_uri_Landroid_net_Uri_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema.Table.Builder']/method[@name='uri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
				[Register ("uri", "(Landroid/net/Uri;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;", "GetUri_Landroid_net_Uri_Handler")]
				public virtual unsafe global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder Uri (global::Android.Net.Uri p0)
				{
					if (id_uri_Landroid_net_Uri_ == IntPtr.Zero)
						id_uri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "uri", "(Landroid/net/Uri;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (p0);

						global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder __ret;
						if (GetType () == ThresholdType)
							__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uri_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
						else
							__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema.Table.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uri", "(Landroid/net/Uri;)Lcom/facebook/stetho/inspector/database/ContentProviderSchema$Table$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
					}
				}

			}

			protected Table (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/inspector/database/ContentProviderSchema", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentProviderSchema); }
		}

		protected ContentProviderSchema (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTableName;
#pragma warning disable 0169
		static Delegate GetGetTableNameHandler ()
		{
			if (cb_getTableName == null)
				cb_getTableName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTableName);
			return cb_getTableName;
		}

		static IntPtr n_GetTableName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TableName);
		}
#pragma warning restore 0169

		static IntPtr id_getTableName;
		public virtual unsafe string TableName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema']/method[@name='getTableName' and count(parameter)=0]"
			[Register ("getTableName", "()Ljava/lang/String;", "GetGetTableNameHandler")]
			get {
				if (id_getTableName == IntPtr.Zero)
					id_getTableName = JNIEnv.GetMethodID (class_ref, "getTableName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTableName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTableName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUri;
#pragma warning disable 0169
		static Delegate GetGetUriHandler ()
		{
			if (cb_getUri == null)
				cb_getUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUri);
			return cb_getUri;
		}

		static IntPtr n_GetUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uri);
		}
#pragma warning restore 0169

		static IntPtr id_getUri;
		public virtual unsafe global::Android.Net.Uri Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
			get {
				if (id_getUri == IntPtr.Zero)
					id_getUri = JNIEnv.GetMethodID (class_ref, "getUri", "()Landroid/net/Uri;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProjection;
#pragma warning disable 0169
		static Delegate GetGetProjectionHandler ()
		{
			if (cb_getProjection == null)
				cb_getProjection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjection);
			return cb_getProjection;
		}

		static IntPtr n_GetProjection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Inspector.Database.ContentProviderSchema> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetProjection ());
		}
#pragma warning restore 0169

		static IntPtr id_getProjection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.inspector.database']/class[@name='ContentProviderSchema']/method[@name='getProjection' and count(parameter)=0]"
		[Register ("getProjection", "()[Ljava/lang/String;", "GetGetProjectionHandler")]
		public virtual unsafe string[] GetProjection ()
		{
			if (id_getProjection == IntPtr.Zero)
				id_getProjection = JNIEnv.GetMethodID (class_ref, "getProjection", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProjection), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProjection", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
