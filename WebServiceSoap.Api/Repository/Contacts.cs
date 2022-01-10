using System.Collections.Generic;
using WebServiceSoap.Api.Models;

namespace WebServiceSoap.Api.Repository
{
    public class Contacts
    {
        private static List<Contact> contacts;

        public Contacts()
        {
            if (contacts == null)
            {
                contacts = new List<Contact>();
                InicilizaContato();
            } 
        }
        private void InicilizaContato()
        {
            Contact contact1 = new Contact();
            contact1.Email = "teste01@gmail.com";
            contact1.Nome = "Teste1";
            contact1.Address = new Address();
            contact1.Address.Street = "Street 01";
            contact1.Address.Number = 1;

            Contact contact2 = new Contact();
            contact2.Email = "teste02@gmail.com";
            contact2.Nome = "Teste2";
            contact2.Address = new Address();
            contact2.Address.Street = "Street 02";
            contact2.Address.Number = 2;

            contacts.Add(contact1);
            contacts.Add(contact2);
        }
        public List<Contact> getList()
        {
           
            return contacts;
        }

        public List<Contact> AddContact(Contact contact)
        {
            contacts.Add(contact);
            return contacts;
        }
    }
}