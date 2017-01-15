using System;

namespace Com.Facebook.Stetho.Json.Annotation {

	[global::Android.Runtime.Annotation ("com.facebook.stetho.json.annotation.JsonProperty")]
	public partial class JsonPropertyAttribute : Attribute
	{
		[global::Android.Runtime.Register ("required")]
		public bool Required { get; set; }

	}
}
