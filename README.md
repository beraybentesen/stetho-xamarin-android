Stetho
=====

Stetho Xamarin Binding

Stetho is a sophisticated debug bridge for Android applications. When enabled, developers have access to the Chrome Developer Tools feature natively part of the Chrome desktop browser. Developers can also choose to enable the optional dumpapp tool which offers a powerful command-line interface to application internals.

Android resource: http://facebook.github.io/stetho/

Version : 1.4.2

Download : Available on Nuget Gallery ( https://www.nuget.org/packages/Stetho.Xamarin/ )

How do I use Stetho ?
-------------------

Simple use cases :

```cs
using Com.Facebook.Stetho;

public class MainActivity : Activity
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			Stetho.InitializeWithDefaults(this);
		}
	}

```


Author
------
Beray Bentesen -  @BerayBentesen on Twitter




