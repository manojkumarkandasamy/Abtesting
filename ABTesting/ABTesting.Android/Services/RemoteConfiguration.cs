using ABTesting.DependencyInterface;
using ABTesting.Droid.Services;
using Android.Gms.Extensions;
using Firebase;
using Firebase.Analytics;
using Firebase.Iid;
using Firebase.Installations;
using Firebase.Messaging;
using Firebase.RemoteConfig;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(RemoteConfiguration))]
namespace ABTesting.Droid.Services
{
    public class RemoteConfiguration : IRemoteConfiguration
    {

        public RemoteConfiguration()
        {
            long cacheExpiration = 3600;
            FirebaseRemoteConfig.GetInstance(MainActivity.fapp).SetConfigSettingsAsync(new FirebaseRemoteConfigSettings.Builder().SetMinimumFetchIntervalInSeconds(cacheExpiration).Build());
            FirebaseRemoteConfig.GetInstance(MainActivity.fapp).SetDefaultsAsync(Resource.Xml.RemoteConfigDefaults);
            FetchAndActivateAsync();

        }
        public async Task FetchAndActivateAsync()
        {
            //Fetch remote values
            //await FirebaseRemoteConfig.GetInstance(MainActivity.fapp).FetchAsync();
            //Activate new values
            await FirebaseRemoteConfig.GetInstance(MainActivity.fapp).FetchAndActivate();
            var value =FirebaseRemoteConfig.GetInstance(MainActivity.fapp).GetString("Testing");

            Console.WriteLine(value);
        }

        public async Task<TInput> GetAsync<TInput>(string key)
        {
            var settings = FirebaseRemoteConfig.Instance.GetString(key);
            return await Task.FromResult(Newtonsoft.Json.JsonConvert.DeserializeObject<TInput>(settings));
        }




    }
}