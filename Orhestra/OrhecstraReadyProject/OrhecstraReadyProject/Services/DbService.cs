using OrhecstraReadyProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrhecstraReadyProject.Services
{
    public class DbService : IDbService
    {


        private readonly MyDbContext dbContext;
        public DbService(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void UploadContact(Contact contact)
        {

            dbContext.Attach(contact);
            dbContext.SaveChanges();



        }


        public void deleteStd(string id)
        {
            var contact = dbContext.contacts.Single(s => s.Id.Equals(id));
            dbContext.contacts.Remove(contact);
            dbContext.SaveChanges();
        }


        public void changeStd(Contact updContact)
        {
            var contact = dbContext.contacts.Single(s => s.Id.Equals(updContact.Id));

            if (updContact.Name != null && updContact.Phone != null && updContact.Salary != 0 &&
                updContact.DateOfBirth != null)
            {

                contact.Name = updContact.Name;


                contact.Phone = updContact.Phone;

                contact.Salary = updContact.Salary;

                contact.DateOfBirth = updContact.DateOfBirth;
                contact.Married = updContact.Married; 

            }

            dbContext.SaveChanges();
        }



        public IEnumerable<Contact> getContacts() {

            var contacts = dbContext.contacts.ToList();

            return contacts;

        }
    }
}
