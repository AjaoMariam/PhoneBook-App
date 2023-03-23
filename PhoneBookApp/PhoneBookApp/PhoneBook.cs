using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class PhoneBook
    {
        private List<Contact> _contact { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            _contact.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contact.FirstOrDefault();
            if (contact == null)
            {
                Console.WriteLine("Contact not found");

            }
            else
            {
                DisplayContactDetails(contact);
                //Console.WriteLine(contact);
            }
        }

        //public void DisplayContactDetails(Contact contact)
        //{
        //    Console.WriteLine($"Contact{contact.Name}," + $"{contact.Number}");
        //}

        public void DisplayAllContact()
        {
            foreach (var contact in _contact)
            {
                DisplayContactDetails(contact);
            }

        }
        public void DisplayContactsDetails(List<Contact> contacts) 
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}"+ $" Number: {contact.Number} \n");
        }
        public void DisplayMatchingContact(string searchPhrase)
        {
            var matchingContacts = _contact.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
