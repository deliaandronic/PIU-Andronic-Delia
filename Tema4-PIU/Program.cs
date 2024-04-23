using ProiectPIU;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti numarul de persoane:");
        int numarPersoane = int.Parse(Console.ReadLine());

        // Vectorul de obiecte Persoana
        ClasaPersoana[] persoane = new ClasaPersoana[numarPersoane];

        // Citirea datelor si crearea obiectelor
        for (int i = 0; i < numarPersoane; i++)
        {
            Console.WriteLine($"Introduceti datele pentru persoana {i + 1}:");
            Console.Write("Nume: ");
            string nume = Console.ReadLine();
            Console.Write("CNP: ");
            string cnp = (Console.ReadLine());

            // Crearea unui nou obiect Persoana si adaugarea acestuia in vector
            persoane[i] = new ClasaPersoana { nume = nume, cnp = cnp };
        }

        // Afisarea datelor introduse
        Console.WriteLine("\nDatele introduse sunt:");
        foreach (var persoana in persoane)
        {
            Console.WriteLine($"Nume: {persoana.nume}, CNP: {persoana.cnp}");
        }



        Console.ReadKey();
    }
}
