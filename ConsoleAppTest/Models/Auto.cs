namespace ConsoleAppTest.Models
{
    public class Auto : IAuto
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"Manufacturer : {Manufacturer}  Model: {Model}";
        }
    }
    
}