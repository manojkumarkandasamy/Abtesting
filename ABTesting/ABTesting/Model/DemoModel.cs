using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ABTesting.Model
{
    public class DemoModel : BaseModel
    {
        string _test;
        public string Text
        {
            get { return _test; }
            set { SetProperty(ref _test, value); }
        }

        string _instance;
        public string Instance
        {
            get { return _instance; }
            set { SetProperty(ref _instance, value); }
        }
    }
}