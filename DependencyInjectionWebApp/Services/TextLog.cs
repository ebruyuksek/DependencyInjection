using DependencyInjectionWebApp.Services.Interfaces;

namespace DependencyInjectionWebApi.Services
{
    internal class TextLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Logged to Text.txt");
        }
    }
}
