using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Websocket {

	[Register ("com/facebook/stetho/websocket/CloseCodes", DoNotGenerateAcw=true)]
	public abstract class CloseCodes : Java.Lang.Object {

		internal CloseCodes ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='CloseCodes']/field[@name='CLOSED_ABNORMALLY']"
		[Register ("CLOSED_ABNORMALLY")]
		public const int ClosedAbnormally = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='CloseCodes']/field[@name='NORMAL_CLOSURE']"
		[Register ("NORMAL_CLOSURE")]
		public const int NormalClosure = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='CloseCodes']/field[@name='PROTOCOL_ERROR']"
		[Register ("PROTOCOL_ERROR")]
		public const int ProtocolError = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.websocket']/interface[@name='CloseCodes']/field[@name='UNEXPECTED_CONDITION']"
		[Register ("UNEXPECTED_CONDITION")]
		public const int UnexpectedCondition = (int) 1011;
	}

	[Register ("com/facebook/stetho/websocket/CloseCodes", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CloseCodes' type. This type will be removed in a future release.")]
	public abstract class CloseCodesConsts : CloseCodes {

		private CloseCodesConsts ()
		{
		}
	}

}
