using System;
using System.IO;
using API;
using Microsoft.Extensions.Configuration;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string phrase = configuration["phrase"];

            var helloWorldConsole = new API.HelloWorldConsole(phrase);
            helloWorldConsole.Execute();
        }
    }
}
