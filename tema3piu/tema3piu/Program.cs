using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Definește un tablou în scara de la 'a' la 'z'
        string[][] cuvinte = new string[26][];

        // Citirea cuvintelor din fișier
        string[] linii = File.ReadAllLines("input.txt");
        foreach (string linie in linii)
        {
            string[] cuvinteLinie = linie.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string cuvant in cuvinteLinie)
            {
                // Determinarea literei cu care începe cuvântul și adăugarea sa în tablou
                char primaLitera = char.ToLower(cuvant[0]);
                int index = primaLitera - 'a';
                if (index >= 0 && index < 26)
                {
                    if (cuvinte[index] == null)
                    {
                        cuvinte[index] = new string[] { cuvant };
                    }
                    else
                    {
                        Array.Resize(ref cuvinte[index], cuvinte[index].Length + 1);
                        cuvinte[index][cuvinte[index].Length - 1] = cuvant;
                    }
                }
            }
        }

        // Afișarea tabloului rezultat
        for (int i = 0; i < 26; i++)
        {
            char litera = (char)('a' + i);
            Console.WriteLine($"Cuvinte care încep cu '{litera}':");
            if (cuvinte[i] != null)
            {
                foreach (string cuvant in cuvinte[i])
                {
                    Console.WriteLine(cuvant);
                }
            }
            else
            {
                Console.WriteLine("Niciun cuvânt");
            }
            Console.WriteLine();
        }
    }
}
