using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the console PhoneBook App");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact By Number");
            Console.WriteLine("3 View All Contacts");
            Console.WriteLine("4 Search for contact for a given Name");
            Console.WriteLine("Press x to Exit");

            var phoneBook = new PhoneBook();

            while(true)
            {
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number:");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        Console.WriteLine("\n\nSelect Operation");
                        break;
                    case "2":
                        Console.WriteLine("Contact Number to search");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        Console.WriteLine("\n\nSelect Operation");

                         break;
                    case "3":
                        phoneBook.DisplayAllContact();
                        Console.WriteLine("\n\nSelect Operation");
                        break;
                    case "4":
                        Console.WriteLine("Search Name by Name Phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContact(searchPhrase);
                        Console.WriteLine("\n\nSelect Operation");
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Please Select Valid Operation");
                        break;
                }

            }



            
        }
    }
}
