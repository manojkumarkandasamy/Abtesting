using ABTesting.DependencyInterface;
using ABTesting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABTesting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Demo : ContentPage
    {
        public string Instance;
        public Demo()
        {
            InitializeComponent();
            //DependencyService.Get<IFirebaseAnalytics>().LogEvent("First_opened");
            BindingContext = new DemoVM();

            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          //  DependencyService.Get<IFirebaseAnalytics>().LogEvent("firs_result_opened");
            
           Navigation.PushAsync(new MainPage());
        }


    }
}