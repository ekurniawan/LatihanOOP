using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BO;
using BL;

namespace WebAPISample.Controllers
{
    public class PelangganController : ApiController
    {
        private PelangganBL pelangganBL;

        public PelangganController()
        {
            pelangganBL = new PelangganBL();
        }

        // GET: api/Pelanggan
        public IEnumerable<Pelanggan> Get()
        {
            var results = pelangganBL.GetAll();
            return results;
        }

        // GET: api/Pelanggan/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pelanggan
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pelanggan/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pelanggan/5
        public void Delete(int id)
        {
        }
    }
}
