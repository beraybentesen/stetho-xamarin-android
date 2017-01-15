using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil']"
	[global::Android.Runtime.Register ("com/facebook/stetho/common/ListUtil", DoNotGenerateAcw=true)]
	public sealed partial class ListUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.FiveItemImmutableList']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/ListUtil$FiveItemImmutableList", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public sealed partial class FiveItemImmutableList : global::Java.Util.AbstractList, global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/ListUtil$FiveItemImmutableList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FiveItemImmutableList); }
			}

			internal FiveItemImmutableList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.FiveItemImmutableList']/constructor[@name='ListUtil.FiveItemImmutableList' and count(parameter)=5 and parameter[1][@type='E'] and parameter[2][@type='E'] and parameter[3][@type='E'] and parameter[4][@type='E'] and parameter[5][@type='E']]"
			[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
			public unsafe FiveItemImmutableList (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Java.Lang.Object p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
				IntPtr native_p3 = JNIEnv.ToLocalJniHandle (p3);
				IntPtr native_p4 = JNIEnv.ToLocalJniHandle (p4);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					__args [4] = new JValue (native_p4);
					if (GetType () != typeof (FiveItemImmutableList)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}

			static IntPtr id_get_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.FiveItemImmutableList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("get", "(I)Ljava/lang/Object;", "")]
			public override unsafe global::Java.Lang.Object Get (int p0)
			{
				if (id_get_I == IntPtr.Zero)
					id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.FiveItemImmutableList']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "")]
			public override unsafe int Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.FourItemImmutableList']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/ListUtil$FourItemImmutableList", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public sealed partial class FourItemImmutableList : global::Java.Util.AbstractList, global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/ListUtil$FourItemImmutableList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FourItemImmutableList); }
			}

			internal FourItemImmutableList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.FourItemImmutableList']/constructor[@name='ListUtil.FourItemImmutableList' and count(parameter)=4 and parameter[1][@type='E'] and parameter[2][@type='E'] and parameter[3][@type='E'] and parameter[4][@type='E']]"
			[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
			public unsafe FourItemImmutableList (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
				IntPtr native_p3 = JNIEnv.ToLocalJniHandle (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					if (GetType () != typeof (FourItemImmutableList)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			static IntPtr id_get_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.FourItemImmutableList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("get", "(I)Ljava/lang/Object;", "")]
			public override unsafe global::Java.Lang.Object Get (int p0)
			{
				if (id_get_I == IntPtr.Zero)
					id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.FourItemImmutableList']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "")]
			public override unsafe int Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.ImmutableArrayList']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/ListUtil$ImmutableArrayList", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public sealed partial class ImmutableArrayList : global::Java.Util.AbstractList, global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/ListUtil$ImmutableArrayList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImmutableArrayList); }
			}

			internal ImmutableArrayList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_arrayLjava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.ImmutableArrayList']/constructor[@name='ListUtil.ImmutableArrayList' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
			[Register (".ctor", "([Ljava/lang/Object;)V", "")]
			public unsafe ImmutableArrayList (global::Java.Lang.Object[] p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (ImmutableArrayList)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_arrayLjava_lang_Object_ == IntPtr.Zero)
						id_ctor_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_Object_, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_get_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.ImmutableArrayList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("get", "(I)Ljava/lang/Object;", "")]
			public override unsafe global::Java.Lang.Object Get (int p0)
			{
				if (id_get_I == IntPtr.Zero)
					id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.ImmutableArrayList']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "")]
			public override unsafe int Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.stetho.common']/interface[@name='ListUtil.ImmutableList']"
		[Register ("com/facebook/stetho/common/ListUtil$ImmutableList", "", "Com.Facebook.Stetho.Common.ListUtil/IImmutableListInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public partial interface IImmutableList : global::Java.Util.IList, global::Java.Util.IRandomAccess {

		}

		[global::Android.Runtime.Register ("com/facebook/stetho/common/ListUtil$ImmutableList", DoNotGenerateAcw=true)]
		internal class IImmutableListInvoker : global::Java.Lang.Object, IImmutableList {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/stetho/common/ListUtil$ImmutableList");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IImmutableListInvoker); }
			}

			IntPtr class_ref;

			public static IImmutableList GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IImmutableList> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.stetho.common.ListUtil.ImmutableList"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IImmutableListInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_isEmpty;
#pragma warning disable 0169
			static Delegate GetIsEmptyHandler ()
			{
				if (cb_isEmpty == null)
					cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
				return cb_isEmpty;
			}

			static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsEmpty;
			}
#pragma warning restore 0169

			IntPtr id_isEmpty;
			public unsafe global::System.Boolean IsEmpty {
				get {
					if (id_isEmpty == IntPtr.Zero)
						id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
				}
			}

			static Delegate cb_add_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetAdd_Ljava_lang_Object_Handler ()
			{
				if (cb_add_Ljava_lang_Object_ == null)
					cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_Ljava_lang_Object_);
				return cb_add_Ljava_lang_Object_;
			}

			static bool n_Add_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Add (e);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_add_Ljava_lang_Object_;
			public unsafe global::System.Boolean Add (global::Java.Lang.Object e)
			{
				if (id_add_Ljava_lang_Object_ == IntPtr.Zero)
					id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_add_ILjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetAdd_ILjava_lang_Object_Handler ()
			{
				if (cb_add_ILjava_lang_Object_ == null)
					cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Add_ILjava_lang_Object_);
				return cb_add_ILjava_lang_Object_;
			}

			static void n_Add_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object element = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_element, JniHandleOwnership.DoNotTransfer);
				__this.Add (index, element);
			}
#pragma warning restore 0169

			IntPtr id_add_ILjava_lang_Object_;
			public unsafe void Add (int index, global::Java.Lang.Object element)
			{
				if (id_add_ILjava_lang_Object_ == IntPtr.Zero)
					id_add_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/lang/Object;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (element);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_ILjava_lang_Object_, __args);
			}

			static Delegate cb_addAll_ILSystem_Collections_ICollection_;
#pragma warning disable 0169
			static Delegate GetAddAll_ILSystem_Collections_ICollection_Handler ()
			{
				if (cb_addAll_ILSystem_Collections_ICollection_ == null)
					cb_addAll_ILSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_AddAll_ILSystem_Collections_ICollection_);
				return cb_addAll_ILSystem_Collections_ICollection_;
			}

			static bool n_AddAll_ILSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_c)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var c = global::Android.Runtime.JavaCollection.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.AddAll (index, c);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_addAll_ILSystem_Collections_ICollection_;
			public unsafe global::System.Boolean AddAll (int index, global::System.Collections.ICollection c)
			{
				if (id_addAll_ILSystem_Collections_ICollection_ == IntPtr.Zero)
					id_addAll_ILSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(ILSystem/Collections/ICollection;)Z");
				IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_c);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addAll_ILSystem_Collections_ICollection_, __args);
				JNIEnv.DeleteLocalRef (native_c);
				return __ret;
			}

			static Delegate cb_addAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
			static Delegate GetAddAll_LSystem_Collections_ICollection_Handler ()
			{
				if (cb_addAll_LSystem_Collections_ICollection_ == null)
					cb_addAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAll_LSystem_Collections_ICollection_);
				return cb_addAll_LSystem_Collections_ICollection_;
			}

			static bool n_AddAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var c = global::Android.Runtime.JavaCollection.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.AddAll (c);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_addAll_LSystem_Collections_ICollection_;
			public unsafe global::System.Boolean AddAll (global::System.Collections.ICollection c)
			{
				if (id_addAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
					id_addAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(LSystem/Collections/ICollection;)Z");
				IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addAll_LSystem_Collections_ICollection_, __args);
				JNIEnv.DeleteLocalRef (native_c);
				return __ret;
			}

			static Delegate cb_clear;
#pragma warning disable 0169
			static Delegate GetClearHandler ()
			{
				if (cb_clear == null)
					cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
				return cb_clear;
			}

			static void n_Clear (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			IntPtr id_clear;
			public unsafe void Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			}

			static Delegate cb_contains_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetContains_Ljava_lang_Object_Handler ()
			{
				if (cb_contains_Ljava_lang_Object_ == null)
					cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_Object_);
				return cb_contains_Ljava_lang_Object_;
			}

			static bool n_Contains_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Contains (o);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_contains_Ljava_lang_Object_;
			public unsafe global::System.Boolean Contains (global::Java.Lang.Object o)
			{
				if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
					id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_containsAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
			static Delegate GetContainsAll_LSystem_Collections_ICollection_Handler ()
			{
				if (cb_containsAll_LSystem_Collections_ICollection_ == null)
					cb_containsAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsAll_LSystem_Collections_ICollection_);
				return cb_containsAll_LSystem_Collections_ICollection_;
			}

			static bool n_ContainsAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var c = global::Android.Runtime.JavaCollection.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.ContainsAll (c);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_containsAll_LSystem_Collections_ICollection_;
			public unsafe global::System.Boolean ContainsAll (global::System.Collections.ICollection c)
			{
				if (id_containsAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
					id_containsAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "containsAll", "(LSystem/Collections/ICollection;)Z");
				IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsAll_LSystem_Collections_ICollection_, __args);
				JNIEnv.DeleteLocalRef (native_c);
				return __ret;
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (o);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object o)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_get_I;
#pragma warning disable 0169
			static Delegate GetGet_IHandler ()
			{
				if (cb_get_I == null)
					cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
				return cb_get_I;
			}

			static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Get (index));
			}
#pragma warning restore 0169

			IntPtr id_get_I;
			public unsafe global::Java.Lang.Object Get (int index)
			{
				if (id_get_I == IntPtr.Zero)
					id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_indexOf_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetIndexOf_Ljava_lang_Object_Handler ()
			{
				if (cb_indexOf_Ljava_lang_Object_ == null)
					cb_indexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_IndexOf_Ljava_lang_Object_);
				return cb_indexOf_Ljava_lang_Object_;
			}

			static int n_IndexOf_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.IndexOf (o);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_indexOf_Ljava_lang_Object_;
			public unsafe global::System.Int32 IndexOf (global::Java.Lang.Object o)
			{
				if (id_indexOf_Ljava_lang_Object_ == IntPtr.Zero)
					id_indexOf_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Ljava/lang/Object;)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_iterator;
#pragma warning disable 0169
			static Delegate GetIteratorHandler ()
			{
				if (cb_iterator == null)
					cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
				return cb_iterator;
			}

			static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Iterator ());
			}
#pragma warning restore 0169

			IntPtr id_iterator;
			public unsafe global::Java.Util.IIterator Iterator ()
			{
				if (id_iterator == IntPtr.Zero)
					id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_lastIndexOf_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetLastIndexOf_Ljava_lang_Object_Handler ()
			{
				if (cb_lastIndexOf_Ljava_lang_Object_ == null)
					cb_lastIndexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LastIndexOf_Ljava_lang_Object_);
				return cb_lastIndexOf_Ljava_lang_Object_;
			}

			static int n_LastIndexOf_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.LastIndexOf (o);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_lastIndexOf_Ljava_lang_Object_;
			public unsafe global::System.Int32 LastIndexOf (global::Java.Lang.Object o)
			{
				if (id_lastIndexOf_Ljava_lang_Object_ == IntPtr.Zero)
					id_lastIndexOf_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(Ljava/lang/Object;)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lastIndexOf_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_listIterator;
#pragma warning disable 0169
			static Delegate GetListIteratorHandler ()
			{
				if (cb_listIterator == null)
					cb_listIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ListIterator);
				return cb_listIterator;
			}

			static IntPtr n_ListIterator (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ListIterator ());
			}
#pragma warning restore 0169

			IntPtr id_listIterator;
			public unsafe global::Java.Util.IListIterator ListIterator ()
			{
				if (id_listIterator == IntPtr.Zero)
					id_listIterator = JNIEnv.GetMethodID (class_ref, "listIterator", "()Ljava/util/ListIterator;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listIterator), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_listIterator_I;
#pragma warning disable 0169
			static Delegate GetListIterator_IHandler ()
			{
				if (cb_listIterator_I == null)
					cb_listIterator_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ListIterator_I);
				return cb_listIterator_I;
			}

			static IntPtr n_ListIterator_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ListIterator (index));
			}
#pragma warning restore 0169

			IntPtr id_listIterator_I;
			public unsafe global::Java.Util.IListIterator ListIterator (int index)
			{
				if (id_listIterator_I == IntPtr.Zero)
					id_listIterator_I = JNIEnv.GetMethodID (class_ref, "listIterator", "(I)Ljava/util/ListIterator;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listIterator_I, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_remove_I;
#pragma warning disable 0169
			static Delegate GetRemove_IHandler ()
			{
				if (cb_remove_I == null)
					cb_remove_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Remove_I);
				return cb_remove_I;
			}

			static IntPtr n_Remove_I (IntPtr jnienv, IntPtr native__this, int index)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Remove (index));
			}
#pragma warning restore 0169

			IntPtr id_remove_I;
			public unsafe global::Java.Lang.Object Remove (int index)
			{
				if (id_remove_I == IntPtr.Zero)
					id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)Ljava/lang/Object;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetRemove_Ljava_lang_Object_Handler ()
			{
				if (cb_remove_Ljava_lang_Object_ == null)
					cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Ljava_lang_Object_);
				return cb_remove_Ljava_lang_Object_;
			}

			static bool n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Remove (o);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_remove_Ljava_lang_Object_;
			public unsafe global::System.Boolean Remove (global::Java.Lang.Object o)
			{
				if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
					id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_removeAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
			static Delegate GetRemoveAll_LSystem_Collections_ICollection_Handler ()
			{
				if (cb_removeAll_LSystem_Collections_ICollection_ == null)
					cb_removeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveAll_LSystem_Collections_ICollection_);
				return cb_removeAll_LSystem_Collections_ICollection_;
			}

			static bool n_RemoveAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var c = global::Android.Runtime.JavaCollection.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RemoveAll (c);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_removeAll_LSystem_Collections_ICollection_;
			public unsafe global::System.Boolean RemoveAll (global::System.Collections.ICollection c)
			{
				if (id_removeAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
					id_removeAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(LSystem/Collections/ICollection;)Z");
				IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_LSystem_Collections_ICollection_, __args);
				JNIEnv.DeleteLocalRef (native_c);
				return __ret;
			}

			static Delegate cb_retainAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
			static Delegate GetRetainAll_LSystem_Collections_ICollection_Handler ()
			{
				if (cb_retainAll_LSystem_Collections_ICollection_ == null)
					cb_retainAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RetainAll_LSystem_Collections_ICollection_);
				return cb_retainAll_LSystem_Collections_ICollection_;
			}

			static bool n_RetainAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var c = global::Android.Runtime.JavaCollection.FromJniHandle (native_c, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RetainAll (c);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_retainAll_LSystem_Collections_ICollection_;
			public unsafe global::System.Boolean RetainAll (global::System.Collections.ICollection c)
			{
				if (id_retainAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
					id_retainAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "retainAll", "(LSystem/Collections/ICollection;)Z");
				IntPtr native_c = global::Android.Runtime.JavaCollection.ToLocalJniHandle (c);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_c);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_retainAll_LSystem_Collections_ICollection_, __args);
				JNIEnv.DeleteLocalRef (native_c);
				return __ret;
			}

			static Delegate cb_set_ILjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSet_ILjava_lang_Object_Handler ()
			{
				if (cb_set_ILjava_lang_Object_ == null)
					cb_set_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Set_ILjava_lang_Object_);
				return cb_set_ILjava_lang_Object_;
			}

			static IntPtr n_Set_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_element)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object element = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_element, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (index, element));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_set_ILjava_lang_Object_;
			public unsafe global::Java.Lang.Object Set (int index, global::Java.Lang.Object element)
			{
				if (id_set_ILjava_lang_Object_ == IntPtr.Zero)
					id_set_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (element);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_size;
#pragma warning disable 0169
			static Delegate GetSizeHandler ()
			{
				if (cb_size == null)
					cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
				return cb_size;
			}

			static int n_Size (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size ();
			}
#pragma warning restore 0169

			IntPtr id_size;
			public unsafe global::System.Int32 Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
			}

			static Delegate cb_subList_II;
#pragma warning disable 0169
			static Delegate GetSubList_IIHandler ()
			{
				if (cb_subList_II == null)
					cb_subList_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SubList_II);
				return cb_subList_II;
			}

			static IntPtr n_SubList_II (IntPtr jnienv, IntPtr native__this, int fromIndex, int toIndex)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.SubList (fromIndex, toIndex));
			}
#pragma warning restore 0169

			IntPtr id_subList_II;
			public unsafe global::System.Collections.IList SubList (int fromIndex, int toIndex)
			{
				if (id_subList_II == IntPtr.Zero)
					id_subList_II = JNIEnv.GetMethodID (class_ref, "subList", "(II)Ljava/util/List;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (fromIndex);
				__args [1] = new JValue (toIndex);
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subList_II, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_toArray;
#pragma warning disable 0169
			static Delegate GetToArrayHandler ()
			{
				if (cb_toArray == null)
					cb_toArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToArray);
				return cb_toArray;
			}

			static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.ToArray ());
			}
#pragma warning restore 0169

			IntPtr id_toArray;
			public unsafe global::Java.Lang.Object[] ToArray ()
			{
				if (id_toArray == IntPtr.Zero)
					id_toArray = JNIEnv.GetMethodID (class_ref, "toArray", "()[Ljava/lang/Object;");
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toArray), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			}

			static Delegate cb_toArray_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetToArray_arrayLjava_lang_Object_Handler ()
			{
				if (cb_toArray_arrayLjava_lang_Object_ == null)
					cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToArray_arrayLjava_lang_Object_);
				return cb_toArray_arrayLjava_lang_Object_;
			}

			static IntPtr n_ToArray_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a)
			{
				global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] a = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_a, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.NewArray (__this.ToArray (a));
				if (a != null)
					JNIEnv.CopyArray (a, native_a);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_toArray_arrayLjava_lang_Object_;
			public unsafe global::Java.Lang.Object[] ToArray (global::Java.Lang.Object[] a)
			{
				if (id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
				IntPtr native_a = JNIEnv.NewArray (a);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_a);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toArray_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.OneItemImmutableList']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/ListUtil$OneItemImmutableList", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public sealed partial class OneItemImmutableList : global::Java.Util.AbstractList, global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/ListUtil$OneItemImmutableList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OneItemImmutableList); }
			}

			internal OneItemImmutableList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.OneItemImmutableList']/constructor[@name='ListUtil.OneItemImmutableList' and count(parameter)=1 and parameter[1][@type='E']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe OneItemImmutableList (global::Java.Lang.Object p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (OneItemImmutableList)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_get_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.OneItemImmutableList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("get", "(I)Ljava/lang/Object;", "")]
			public override unsafe global::Java.Lang.Object Get (int p0)
			{
				if (id_get_I == IntPtr.Zero)
					id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.OneItemImmutableList']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "")]
			public override unsafe int Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.ThreeItemImmutableList']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/ListUtil$ThreeItemImmutableList", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public sealed partial class ThreeItemImmutableList : global::Java.Util.AbstractList, global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/ListUtil$ThreeItemImmutableList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ThreeItemImmutableList); }
			}

			internal ThreeItemImmutableList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.ThreeItemImmutableList']/constructor[@name='ListUtil.ThreeItemImmutableList' and count(parameter)=3 and parameter[1][@type='E'] and parameter[2][@type='E'] and parameter[3][@type='E']]"
			[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
			public unsafe ThreeItemImmutableList (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (GetType () != typeof (ThreeItemImmutableList)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static IntPtr id_get_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.ThreeItemImmutableList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("get", "(I)Ljava/lang/Object;", "")]
			public override unsafe global::Java.Lang.Object Get (int p0)
			{
				if (id_get_I == IntPtr.Zero)
					id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.ThreeItemImmutableList']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "")]
			public override unsafe int Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.TwoItemImmutableList']"
		[global::Android.Runtime.Register ("com/facebook/stetho/common/ListUtil$TwoItemImmutableList", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public sealed partial class TwoItemImmutableList : global::Java.Util.AbstractList, global::Com.Facebook.Stetho.Common.ListUtil.IImmutableList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/stetho/common/ListUtil$TwoItemImmutableList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TwoItemImmutableList); }
			}

			internal TwoItemImmutableList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.TwoItemImmutableList']/constructor[@name='ListUtil.TwoItemImmutableList' and count(parameter)=2 and parameter[1][@type='E'] and parameter[2][@type='E']]"
			[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
			public unsafe TwoItemImmutableList (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (TwoItemImmutableList)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_get_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.TwoItemImmutableList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("get", "(I)Ljava/lang/Object;", "")]
			public override unsafe global::Java.Lang.Object Get (int p0)
			{
				if (id_get_I == IntPtr.Zero)
					id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil.TwoItemImmutableList']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "")]
			public override unsafe int Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/stetho/common/ListUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListUtil); }
		}

		internal ListUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_copyToImmutableList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil']/method[@name='copyToImmutableList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("copyToImmutableList", "(Ljava/util/List;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList CopyToImmutableList (global::System.Collections.IList p0)
		{
			if (id_copyToImmutableList_Ljava_util_List_ == IntPtr.Zero)
				id_copyToImmutableList_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "copyToImmutableList", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyToImmutableList_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_identityEquals_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil']/method[@name='identityEquals' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;? extends T&gt;'] and parameter[2][@type='java.util.List&lt;? extends T&gt;']]"
		[Register ("identityEquals", "(Ljava/util/List;Ljava/util/List;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool IdentityEquals (global::System.Collections.IList p0, global::System.Collections.IList p1)
		{
			if (id_identityEquals_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_identityEquals_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "identityEquals", "(Ljava/util/List;Ljava/util/List;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_identityEquals_Ljava_util_List_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_newImmutableList_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil']/method[@name='newImmutableList' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("newImmutableList", "(Ljava/lang/Object;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList NewImmutableList (global::Java.Lang.Object p0)
		{
			if (id_newImmutableList_Ljava_lang_Object_ == IntPtr.Zero)
				id_newImmutableList_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "newImmutableList", "(Ljava/lang/Object;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_newImmutableList_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_newImmutableList_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.stetho.common']/class[@name='ListUtil']/method[@name='newImmutableList' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("newImmutableList", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList NewImmutableList (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_newImmutableList_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_newImmutableList_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "newImmutableList", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_newImmutableList_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
