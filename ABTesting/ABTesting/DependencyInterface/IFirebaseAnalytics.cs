using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ABTesting.DependencyInterface
{
    public interface IFirebaseAnalytics
    {
        void LogEvent(string EventID);
    }
}