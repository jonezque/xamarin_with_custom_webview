using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace multi_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            hybridWebView.RegisterAction(data => DisplayAlert("Alert", data, "OK"));

        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            var data = "{ \"firstName\": \"John\", \"lastName\": \"Smith\", \"company\": \"Google\" }";
            hybridWebView.EvaluateJavaScriptAsync($"updatetextonwebview('{data}')");
            Console.WriteLine("C# button clicked");
        }
    }
}
public interface IBaseUrl { string Get(); }