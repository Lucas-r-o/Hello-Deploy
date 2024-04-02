using System;
using System.Configuration;

namespace HelloDeploy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];
            Console.WriteLine($"ApiKey: {apiKey}");
            Console.WriteLine("Pressione uma tecla para Finalizar >>>");
            Console.ReadKey();
        }
    }
}
