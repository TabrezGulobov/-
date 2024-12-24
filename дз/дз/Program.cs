using System;
using System.Security.Cryptography;

namespace ConsoleApp7

{
    class Domestic
    {
        public string Name;
        private string Brand;
        protected string Destination;

        public string brand
        {
            get { return Brand;}
            set{ Brand=value;}
        }

        public string destination
        {
            get { return Destination;}
            set{ Destination=value;}
        }
    }

    class Fridge:Domestic
   {
        public Fridge()
        {
            Name = "Fridge";
            brand = "Samsung";
            destination = "Designed to freeze the food so that it lasts longer";
        }
    }

    class VacuumCleaner:Domestic
    {
        public VacuumCleaner()
        {
            Name = "Vacuum Cleaner";
            brand = "Dyson";
            destination = "designed to collect dust in the house";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Fridge f = new Fridge();
            VacuumCleaner v = new VacuumCleaner();
            Console.WriteLine(f.Name);
            Console.WriteLine(f.brand);
            Console.WriteLine(f.destination);
            Console.WriteLine(v. Name);
            Console.WriteLine(v.brand);
            Console.WriteLine(v.destination);
        }
    }
}