using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ABTesting.DependencyInterface
{
    public interface IRemoteConfiguration 
    {
        
        Task FetchAndActivateAsync();

         //Task<string> Display();

        //Task<string> GetTokenAsync();

    }
}