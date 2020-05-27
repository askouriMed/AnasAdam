namespace ConsoleAppTest.Models
{
    public class Client :IClient
    {
        public string Name { get; set; }
        public string Adresse { get; set; }
        public IAuto Auto { get; set; }

    }
}