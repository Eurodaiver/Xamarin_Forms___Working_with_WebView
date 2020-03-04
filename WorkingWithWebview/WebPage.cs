using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebPage : ContentPage
    {
        public WebPage()
        {
            var browser = new WebView();
           
            //browser.Source = "http://109.124.95.90/mobileapp";
            browser.Source = "https://tkapp.ru/mobileapp";
            Content = browser;
        }
    }
}

