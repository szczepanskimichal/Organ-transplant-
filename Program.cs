using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMeny:");
            Console.WriteLine("1 - Vis pasienter");
            Console.WriteLine("2 - Vis givere");
            Console.WriteLine("3 - Legg til giver");
            Console.WriteLine("4 - Utfør transplantasjon");
            Console.WriteLine("0 - Avslutt");
            Console.Write("Velg et alternativ: ");

            string choice = Console.ReadLine(); // Read user input

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Viser pasienter...");
                    //VisPasienter();
                    break;
                case "2":
                    Console.WriteLine("Viser givere...");
                    //VisDonorer();
                    break;
                case "3":
                    Console.WriteLine("Legger til giver...");
                    //AddDonor();
                    break;
                case "4":
                    Console.WriteLine("Utfører transplantasjon...");
                    //Transplant();
                    break;
                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen.");
                    break;

            }
        }
    }
}
