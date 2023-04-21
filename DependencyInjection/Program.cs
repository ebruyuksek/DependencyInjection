// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
IOC Inversion of Control 
IOC Container'a neden ihtiyaç duyarız ? 
Dependency injection kullanılarak enjekte edilecek tüm değerler / nesneler IoC Container dediğimiz bir sınıfta tutulurlar. 
Ve ihtiyaç doğrultusunda bu değerler / nesneler çağrılarak elde edilirler. 
IOC Çalışma mantığı, kaydediliyor (register) ve talep edildiği zaman instance dönüyor. 
.Net Core dahili olarak IOC Container barındırmaktadır. (Built in IOC Container)
IoC Container, içerisinde koyulacak değerleri / nesneleri üç farklı davranışla alabilmektedir.
IOC Container Davranışları : 
Singleton
Scoped
Transient
*/
