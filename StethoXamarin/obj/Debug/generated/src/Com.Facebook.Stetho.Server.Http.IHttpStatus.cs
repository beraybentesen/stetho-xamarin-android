using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	[Register ("com/facebook/stetho/server/http/HttpStatus", DoNotGenerateAcw=true)]
	public abstract class HttpStatus : Java.Lang.Object {

		internal HttpStatus ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpStatus']/field[@name='HTTP_INTERNAL_SERVER_ERROR']"
		[Register ("HTTP_INTERNAL_SERVER_ERROR")]
		public const int HttpInternalServerError = (int) 500;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpStatus']/field[@name='HTTP_NOT_FOUND']"
		[Register ("HTTP_NOT_FOUND")]
		public const int HttpNotFound = (int) 404;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpStatus']/field[@name='HTTP_NOT_IMPLEMENTED']"
		[Register ("HTTP_NOT_IMPLEMENTED")]
		public const int HttpNotImplemented = (int) 501;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpStatus']/field[@name='HTTP_OK']"
		[Register ("HTTP_OK")]
		public const int HttpOk = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpStatus']/field[@name='HTTP_SWITCHING_PROTOCOLS']"
		[Register ("HTTP_SWITCHING_PROTOCOLS")]
		public const int HttpSwitchingProtocols = (int) 101;
	}

	[Register ("com/facebook/stetho/server/http/HttpStatus", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HttpStatus' type. This type will be removed in a future release.")]
	public abstract class HttpStatusConsts : HttpStatus {

		private HttpStatusConsts ()
		{
		}
	}

}
