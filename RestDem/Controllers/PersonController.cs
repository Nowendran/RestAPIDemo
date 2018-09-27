using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestDem.Models;
namespace RestDem.Controllers
{
    public class PersonController : ApiController
    {
        public List<Person> lp = new List<Person>();

        public PersonController()
        {
            lp.Add(new Person { id = 1, name = "Toto", address = "Umlazi" });
            lp.Add(new Person { id = 2, name = "Toto1", address = "Umlazi" });
            lp.Add(new Person { id = 3, name = "Toto2", address = "Umlazi" });
        }

     

        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            return lp;
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            return lp.Where(x=>x.id==id).FirstOrDefault();
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
