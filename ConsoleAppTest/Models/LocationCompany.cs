using System.Collections.Generic;

namespace ConsoleAppTest.Models
{
    public class LocationCompany
    {
        public string Name { get; set; }
        public string Adresse { get; set; }

        private List<IClient> _clients;
        public List<IClient> Clients => _clients ??= new List<IClient>();

        public override string ToString()
        {
            return $"{Name}  {Adresse}";
        }
    }
}