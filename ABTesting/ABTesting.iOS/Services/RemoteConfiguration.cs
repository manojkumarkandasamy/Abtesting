using ABTesting.DependencyInterface;
using ABTesting.iOS.Services;
using Firebase.CloudMessaging;
using Firebase.RemoteConfig;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(RemoteConfiguration))]
namespace ABTesting.iOS.Services
{
    public class RemoteConfiguration : IRemoteConfiguration
    {

        public RemoteConfiguration()
        {
            //Set the default values
            RemoteConfig.SharedInstance.SetDefaults("RemoteConfigDefaults");
            FetchAndActivateAsync();
        }

        public async Task FetchAndActivateAsync()
        {
            //Fetch remote values
            var status = await RemoteConfig.SharedInstance.FetchAsync(0);
            if (status == RemoteConfigFetchStatus.Success)
            {
                //Activate new values
               var value =  RemoteConfig.SharedInstance.GetKeys("Testing");
            }
        }

        
    }
    
}