using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    public class UserInterface
    {
        // Kolekce pro ukládání pojištěnců
        private InsurerManager insurerManager;

        public UserInterface(InsurerManager manager)
        {
            insurerManager = manager;
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("---------------------------");
            int vote = 0;
            bool loop = true;
            while (vote != 4)
            {

                Console.WriteLine("\nVyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");

                vote = int.Parse(Console.ReadLine().Trim());
                switch (vote)
                {
                    case 1:
                        AddNewInsured();
                        break;
                    case 2:
                        ListingInsured();
                        break;
                    case 3:
                        SearchInsurers();
                        break;
                    case 4:
                        Console.WriteLine("Konec programu");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Neplatná volba");
                        break;
                }
            }
        }

        // Metoda pro přidání nového pojištěnce
        private void AddNewInsured()
        {
            string firstName;
            string lastName;
            string phone;
            int age;

            // Zadání a validace jména
            do
            {
                Console.WriteLine("Zadejte jméno pojištěného: ");
                firstName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(firstName));

            // Zadání a validace příjmení
            do
            {
                Console.WriteLine("Zadejte příjmení pojištěného: ");
                lastName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(lastName));

            // Zadání a validace věku
            do
            {
                Console.WriteLine("Zadejte věk pojištěného: ");
                age = int.Parse(Console.ReadLine());
            } while (string.IsNullOrWhiteSpace(age.ToString()) || age <= 0);

            // Zadání telefonního čísla
            Console.WriteLine("Zadejte telefonní číslo pojištěného: ");
            phone = Console.ReadLine();


            Insurer newInsurer = new Insurer(firstName, lastName, age, phone);
            insurerManager.AddInsurer(newInsurer);
            Console.WriteLine($"Pojištěný {newInsurer} byl přidán.");

        }

        // Metoda pro vypsání všech pojištěnců
        private void ListingInsured()
        {
            var insurers = insurerManager.GetAllInsurers();
            if (insurers.Count == 0)
            {
                Console.WriteLine("Žádní pojištěnci nejsou v evidenci.");
            }
            else
            {
                Console.WriteLine("\nSeznam pojištěnců:");
                foreach (var insurer in insurerManager.GetAllInsurers())
                {
                    Console.WriteLine(insurer);
                }
            }
        }

        // Metoda pro vyhledání pojištěného
        private void SearchInsurers()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string lastName = Console.ReadLine();

            var foundedInsurers = insurerManager.SearchInsurers(firstName, lastName);

            if (foundedInsurers.Count > 0)
            {
                Console.WriteLine("\nNalezení pojištěnci:");
                foreach (var insurer in foundedInsurers)
                {
                    Console.WriteLine(insurer);
                }
            }
            else
            {
                Console.WriteLine("Pojištěný nebyl nalezen.");
            }

        }

    }
}
