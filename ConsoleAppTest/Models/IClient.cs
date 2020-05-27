namespace ConsoleAppTest.Models
{
    public interface IClient
    {
        string Name { get; set; }
        string Adresse { get; set; }
        IAuto Auto { get; set; }
    }
}