using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABTesting
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Application.Current.MainPage =  new NavigationPage(new Demo());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
