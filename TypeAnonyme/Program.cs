using System;
using System.Linq;
using System.Collections.Generic;

namespace TypeAnonyme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            etudiants.Add(new Etudiant() { Id = 1, Nom = "Baens", Prenom = "Ludovic" });
            etudiants.Add(new Etudiant() { Id = 2, Nom = "Baens", Prenom = "Emeline" });
            etudiants.Add(new Etudiant() { Id = 3, Nom = "Shroder", Prenom = "Kevin" });
            etudiants.Add(new Etudiant() { Id = 4, Nom = "Aerts", Prenom = "Christian" });
            etudiants.Add(new Etudiant() { Id = 5, Nom = "Bielen", Prenom = "Nathalie" });


            var lstAerts = from e in etudiants
                           select new { NomEtudiant = e.Nom};

            foreach (var item in lstAerts)
            {
                Console.WriteLine($"NomEtudiant : { item.NomEtudiant}");
            }


            var lstBaens = etudiants.Where(e => e.Nom == "Baens").Select(e => new {Identifiant = e.Id, Firstname = e.Prenom });

            foreach (var item in lstBaens)
            {
                Console.WriteLine($"Identifiant : { item.Identifiant} - Firstname : {item.Firstname }");
            }

            Console.ReadKey();
        }
    }

    public class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string  Prenom { get; set; }
    }
}
