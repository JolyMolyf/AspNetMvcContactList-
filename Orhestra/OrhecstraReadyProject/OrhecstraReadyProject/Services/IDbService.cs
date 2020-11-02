using OrhecstraReadyProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrhecstraReadyProject.Services
{
    public  interface IDbService
    {

        public void UploadContact(Contact contact);

        public IEnumerable<Contact> getContacts();
    }
}
