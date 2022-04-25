using ABTesting.DependencyInterface;
using Firebase.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(IFirebaseAnalytics))]
namespace ABTesting.Droid.Services
{
    public class FirebaseAnalyrtics : IFirebaseAnalytics
    {
        public void LogEvent(string EventID)
        {
            try
            {
                var fireBaseAnalytics = FirebaseAnalytics.GetInstance(Platform.CurrentActivity);
                fireBaseAnalytics.LogEvent(EventID, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }
            }
    }
}