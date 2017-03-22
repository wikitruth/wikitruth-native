using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Android.Views;

namespace WikitruthNative.Droid
{
	[Activity(Label = "Wikitruth", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;
		private WebView webView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			RequestWindowFeature(WindowFeatures.NoTitle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			/*Button button = FindViewById<Button>(Resource.Id.myButton);
			button.Click += delegate { button.Text = $"{count++} clicks!"; };*/

			//Window.DecorView.SystemUiVisibility = (StatusBarVisibility)(SystemUiFlags.Fullscreen | SystemUiFlags.LayoutHideNavigation);

			webView = FindViewById<WebView>(Resource.Id.webView1);
			webView.Settings.JavaScriptEnabled = true;
			webView.SetWebViewClient(new WebViewClient());
			webView.SetWebChromeClient(new WebChromeClient());
			webView.LoadUrl("https://wikitruth.co");
		}

		public override void OnBackPressed()
		{
			if (webView.CanGoBack())
			{
				webView.GoBack();
			}
			else
			{
				base.OnBackPressed();
			}
		}
	}
}

