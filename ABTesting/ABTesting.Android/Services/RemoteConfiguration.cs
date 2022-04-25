using ABTesting.DependencyInterface;
using ABTesting.Droid.Services;
using Firebase;
using Firebase.Analytics;
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
            FirebaseRemoteConfig.Instance.SetConfigSettingsAsync(new FirebaseRemoteConfigSettings.Builder().SetMinimumFetchIntervalInSeconds(cacheExpiration).Build());
            FirebaseRemoteConfig.Instance.SetDefaultsAsync(Resource.Xml.XMLFile1);
           
        }
        public async Task FetchAndActivateAsync()
        {
            //Fetch remote values
            await FirebaseRemoteConfig.Instance.FetchAsync();

                //Activate new values
            FirebaseRemoteConfig.Instance.FetchAndActivate();

          
        }

         public async Task<TInput> GetAsync<TInput>(string key)
         {
             var settings = FirebaseRemoteConfig.Instance.GetString(key);
             return await Task.FromResult(Newtonsoft.Json.JsonConvert.DeserializeObject<TInput>(settings));
         }
         
        public string Display()
        {
            try
            {
               var firebaseInstanceId = FirebaseInstallations.Instance.GetId();
                var firebaseInstanceToken = FirebaseMessaging.Instance.GetToken();
                var token = firebaseInstanceToken.Result.ToString();
                return token;
            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }
            
        }
           


    }
}