// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");

MyHttpRequest myHttpRequest = MyHttpRequest.GetBuilder().SetHeaders("").SetURL("").SetContentType("application/json").Build();

Console.WriteLine(myHttpRequest.ContentType);
