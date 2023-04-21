using DependencyInjectionWebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWebApi.Services
{
    internal class ConsoleLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Logged to Console.");
        }
    }
}
