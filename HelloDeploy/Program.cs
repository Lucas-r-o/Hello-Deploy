using System;
using System.Configuration;
using System.Deployment.Application;

namespace HelloDeploy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];
            Console.WriteLine($"ApiKey: {apiKey}");

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                var currentDeployment = ApplicationDeployment.CurrentDeployment;
                Console.WriteLine($"Versão: {currentDeployment.CurrentVersion}");
            }

            Console.WriteLine("Pressione uma tecla para Finalizar >>>");
            Console.ReadKey();
        }
    }
}
