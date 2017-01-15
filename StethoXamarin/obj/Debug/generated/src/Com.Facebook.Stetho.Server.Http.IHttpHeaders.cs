using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Stetho.Server.Http {

	[Register ("com/facebook/stetho/server/http/HttpHeaders", DoNotGenerateAcw=true)]
	public abstract class HttpHeaders : Java.Lang.Object {

		internal HttpHeaders ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpHeaders']/field[@name='CONTENT_LENGTH']"
		[Register ("CONTENT_LENGTH")]
		public const string ContentLength = (string) "Content-Length";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.stetho.server.http']/interface[@name='HttpHeaders']/field[@name='CONTENT_TYPE']"
		[Register ("CONTENT_TYPE")]
		public const string ContentType = (string) "Content-Type";
	}

	[Register ("com/facebook/stetho/server/http/HttpHeaders", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HttpHeaders' type. This type will be removed in a future release.")]
	public abstract class HttpHeadersConsts : HttpHeaders {

		private HttpHeadersConsts ()
		{
		}
	}

}
