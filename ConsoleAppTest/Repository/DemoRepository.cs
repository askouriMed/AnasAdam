using ConsoleAppTest.Models;
using System.Collections.Generic;

namespace ConsoleAppTest.Repository
{
    public class DemoRepository
    {
        private static DemoRepository _instanceDemoRepository;
        public static DemoRepository Instance()
        {
            return _instanceDemoRepository ??= new DemoRepository();
        }

        public List<IAuto> Autos()
        {
           return new List<IAuto>()
           {
               new Auto(){Model = "A5",Manufacturer = "Audi"},
               new Auto(){Model = "Cls",Manufacturer = "Mercedes"}
           };
        }

        public List<IClient> Clients()
        {
            return new List<IClient>()
            {
                new Client(){Adresse = "client adresse 1",Name = "l3arbi",Auto = Autos()[0]},
                new Client(){Adresse = "client adresse 2",Name = "3abas",Auto = Autos()[1]},
            };
        }

        public List<LocationCompany> LocationCompanies()
        {
            return new List<LocationCompany>()
            {
                new LocationCompany(){Adresse = "Location adresse 1",Name = "Anas Company",Clients = {Clients()[1]}},
                new LocationCompany(){Adresse = "Location adresse 2",Name = "Adam Company",Clients = {Clients()[0]}},
            };
        }


    }
}
