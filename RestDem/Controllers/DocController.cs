using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dataconnect;
namespace RestDem.Controllers
{
    public class DocController : ApiController
    {
        // GET: api/Doc
        public IEnumerable<persone1> Get()
        {
            using (tesEntities entity = new tesEntities())
            {
                return entity.persone1.ToList();
            }
               
        }

        // GET: api/Doc/5
        public persone1 Get(int id)
        {
            using (tesEntities entity = new tesEntities())
            {
                return entity.persone1.Where(x=>x.id==id).FirstOrDefault();
            }
        }

        // POST: api/Doc
        public void Post([FromBody]persone1 value)
        {

            using (tesEntities entity = new tesEntities())
            {
                entity.persone1.Add(value);
                entity.SaveChanges();
            }
        }
        // change a personel name
        // PUT: api/Doc/5
        public void Put(int id, [FromBody]string value)
        {
            using (tesEntities entity = new tesEntities())
            {

                var val=entity.persone1.Single(x => x.id == id);
                val.name = value;
                entity.SaveChanges();

            }
            



        }

        // DELETE: api/Doc/5
        public void Delete(int id)
        {
            using (tesEntities entity = new tesEntities())
            {
                entity.persone1.Remove(this.Get(id));
                entity.SaveChanges();
            }

        }
    }
}
