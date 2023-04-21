using DependencyInjectionWebApi.Services;
using DependencyInjectionWebApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
//builder.Services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));
//Eklenen servisler default olarak singleton'dır. Lifetime'ını manüel değiştirebiliriz.

//builder.Services.AddSingleton<ConsoleLog>();

//Ekleyeceğimiz servisin constructorı parametreli ise servise aşağıdaki gibi eklemeliyiz : 
//builder.Services.AddSingleton<ConsoleLog>(p=> new ConsoleLog(param));

//builder.Services.AddScoped<ConsoleLog>(p => new ConsoleLog(param));
//Transient lifetime'da her requeste özel nesne üretip gönderecektir.

builder.Services.AddScoped<ILog>(p => new ConsoleLog());

//bu şekilde de yazılabilir: 
//builder.Services.AddScoped<ILog, TextLog>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

IConfiguration configuration = app.Configuration;
IWebHostEnvironment environment = app.Environment;

app.Run();
