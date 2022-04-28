using System;
using System.Collections.Generic;
using System.Linq;
using Firebase.CloudMessaging;
using Firebase.Installations;
using Firebase.InstanceID;
using Firebase.RemoteConfig;
using FirebaseAdmin;
using Foundation;
using UIKit;

namespace ABTesting.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public static FirebaseApp fapp;
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            takeToken();
            return base.FinishedLaunching(app, options);
        }
        public async void takeToken()
        {
            var result = await Installations.DefaultInstance.GetAuthTokenAsync();
            var token = result?.AuthToken;
        }


        /*        private void GetFCMToken(NSData apnsToken)
                {
         
                    var projectId = "xxxxx"; //from console
                    var scope = Firebase.InstanceID.InstanceId.ScopeFirebaseMessaging;
                    var options = new NSDictionary(
                             new NSString("apns_token"), apnsToken,
                             new NSString("apns_sandbox"), new NSString("0")
                    );

                    Firebase.InstanceID.InstanceId.SharedInstance.GetToken(projectId, scope, options, (string token, NSError err) =>
                    {
                        System.Diagnostics.Debug.WriteLine("fcmToken" + token);
                        Console.WriteLine($"Firebase registration token: {token}");
                    });
                }*/

    }
}
