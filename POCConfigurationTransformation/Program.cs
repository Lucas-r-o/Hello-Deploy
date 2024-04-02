using System;
using System.Configuration;

namespace POCConfigurationTransformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value = ConfigurationManager.AppSettings["teste"];
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
