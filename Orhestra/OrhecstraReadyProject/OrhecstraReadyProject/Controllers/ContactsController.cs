using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using OrhecstraReadyProject.Data;
using OrhecstraReadyProject.Services;


namespace OrhecstraReadyProject.Controllers
{
    public class ContactsController : Controller
    {
        private readonly MyDbContext _context;

        private IDbService dbservice;
        public string atributes;

        public ContactsController(IDbService dbservice)
        {
            this.dbservice = dbservice;
        }


        // GET: Contacts
        public ActionResult Index()
        {
            var contacts = dbservice.getContacts();

            var array = contacts.ToArray(); 

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(contacts);
            Console.WriteLine(json);

            ViewBag.arr = new HtmlString(json);




            return View();
        }


        [HttpPost]
        public IActionResult SingleFile(IFormFile contactFile)
        {


            Console.WriteLine(contactFile.FileName);

            var result = new StringBuilder();
         

            ArrayList contacts = new ArrayList(); 
            using (var reader = new StreamReader(contactFile.OpenReadStream()))
            {
                atributes = reader.ReadLine();
                while (reader.Peek() >= 0) {

                    string contactLine = reader.ReadLine();

                    string[] contactParam = contactLine.Split(";");
                    Contact contact = new Contact()
                    {
                        Name = contactParam[0],
                        DateOfBirth = DateTime.Parse(contactParam[1]),
                        Married = bool.Parse(contactParam[2]), 
                        Phone = contactParam[3], 
                        Salary = double.Parse(contactParam[4])
                        
                    };

                    contacts.Add(contact);
                    dbservice.UploadContact(contact);

                }

            }


            Console.WriteLine(result.ToString());
            Console.WriteLine(contacts.Count);


           


            return RedirectToAction("Index");

        }

    }
}
