using ABTesting.DependencyInterface;
using ABTesting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ABTesting.ViewModel
{
    public class DemoVM : DemoModel
    {
        public string defaultvalue;
        public DemoVM()
        {
            Text = "project";
            gettoken();
        }
        public void gettoken()
        {
            try
            {

                Instance = DependencyService.Get<IRemoteConfiguration>().GetTokenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}