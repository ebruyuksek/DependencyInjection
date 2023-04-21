using DependencyInjectionWebApi.Services;

namespace DependencyInjectionWebApp
{
    public class Example
    {
        public Example()
        {
            IServiceCollection services = new ServiceCollection(); //built in IoC mekanizması 
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));   //customize edilmiş servis eklemek için Add kullanılabilir
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));

            ServiceProvider serviceProvider = services.BuildServiceProvider(); //IoC container vericek. Somut bir container

            serviceProvider.GetService<ConsoleLog>();
            serviceProvider.GetService<TextLog>();

        }

    }
}
