using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Elements.Android {

	[Register ("com/facebook/stetho/inspector/elements/android/AndroidDocumentConstants", DoNotGenerateAcw=true)]
	public abstract class AndroidDocumentConstants : Java.Lang.Object {

		internal AndroidDocumentConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.elements.android']/interface[@name='AndroidDocumentConstants']/field[@name='MIN_API_LEVEL']"
		[Register ("MIN_API_LEVEL")]
		public const int MinApiLevel = (int) 14;
	}

	[Register ("com/facebook/stetho/inspector/elements/android/AndroidDocumentConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AndroidDocumentConstants' type. This type will be removed in a future release.")]
	public abstract class AndroidDocumentConstantsConsts : AndroidDocumentConstants {

		private AndroidDocumentConstantsConsts ()
		{
		}
	}

}
