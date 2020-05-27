using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var demoRepository = DemoRepository.Instance();
            //var locationCompanies = demoRepository.LocationCompanies();

            //foreach (var locationCompany in locationCompanies)
            //{
            //    Console.WriteLine(locationCompany);
            //}

            //foreach (var auto in demoRepository.Autos())
            //{
            //    Console.WriteLine(auto);
            //}

            Action action = () =>
            {
                Console.WriteLine("2");
            };

            action();
        }
    }
}
