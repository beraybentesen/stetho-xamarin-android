using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Inspector.Protocol.Module {

	[Register ("com/facebook/stetho/inspector/protocol/module/DatabaseConstants", DoNotGenerateAcw=true)]
	public abstract class DatabaseConstants : Java.Lang.Object {

		internal DatabaseConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.inspector.protocol.module']/interface[@name='DatabaseConstants']/field[@name='MIN_API_LEVEL']"
		[Register ("MIN_API_LEVEL")]
		public const int MinApiLevel = (int) 11;
	}

	[Register ("com/facebook/stetho/inspector/protocol/module/DatabaseConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'DatabaseConstants' type. This type will be removed in a future release.")]
	public abstract class DatabaseConstantsConsts : DatabaseConstants {

		private DatabaseConstantsConsts ()
		{
		}
	}

}
