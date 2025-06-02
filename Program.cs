using System.Collections.Generic;

class Program
{
    class Patient
    {
        public string Name { get; set; }
        public int Nyrer { get; set; } // liczba nerek pacjenta

        public Patient(string name, int nyrer)
        {
            Name = name;
            Nyrer = nyrer;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Pacjent: {Name}, Nerki: {Nyrer}");
        }
    }

    class Donor
    {
        public string Name { get; set; }
        public int Nyrer { get; set; }

        public Donor(string name, int nyrer)
        {
            Name = name;
            Nyrer = nyrer;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Dawca: {Name}, Nerki: {Nyrer}");
        }
    }

    static List<Donor> donors = new List<Donor>(); // Moved donors list to a static field

    static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient("Ola Nordmann", 1),
            new Patient("Per Hansen", 2),
            new Patient("Kari Nordmann", 3),
            new Patient("Lise Jensen", 4),
            new Patient("Knut Olsen", 5)
        };

        donors = new List<Donor> // Initialize donors list
        {
            new Donor("Anna Berg", 1),
            new Donor("Bjørn Eriksen", 2),
            new Donor("Cecilie Larsen", 3),
            new Donor("David Nilsen", 4),
            new Donor("Eva Solberg", 5)
        };

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

            if (choice == "0")
                break;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Viser pasienter...");
                    ShowPatients(patients);
                    break;
                case "2":
                    Console.WriteLine("Viser givere...");
                    ShowDonors(donors);
                    break;
                case "3":
                    Console.WriteLine("Legger til giver...");
                    AddDonor();
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

    static void ShowPatients(List<Patient> patients)
    {
        Console.WriteLine("\nPasientliste:");
        for (int i = 0; i < patients.Count; i++)
        {
            Console.Write($"{i}: ");
            patients[i].PrintInfo();
        }
    }

    static void ShowDonors(List<Donor> donors)
    {
        Console.WriteLine("\nDonorliste:");
        for (int i = 0; i < donors.Count; i++)
        {
            Console.Write($"{i}: ");
            donors[i].PrintInfo();
        }
    }

    static void AddDonor()
    {
        Console.Write("Podaj imię dawcy: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name)) // Handle null or empty input
        {
            Console.WriteLine("Imię dawcy nie może być puste.");
            return;
        }

        int nyrer;
        do
        {
            Console.Write("Podaj liczbę nerek dawcy (minimum 1): ");
        } while (!int.TryParse(Console.ReadLine(), out nyrer) || nyrer < 1);

        donors.Add(new Donor(name, nyrer));
        Console.WriteLine($"Dawca {name} dodany z {nyrer} nerkami.");
    }
}

