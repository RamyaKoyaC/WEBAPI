using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class CustomerController : ApiController
    {
        private rammiEntities test = new rammiEntities();

        // GET api/<controller>
        public IEnumerable<CUSTOMER> Get()
        {
            return test.CUSTOMERs;
        }

        // GET api/<controller>/5
        public CUSTOMER Get(int id)
           
        {
            
            return test.CUSTOMERs.FirstOrDefault(X => X.CUST_NAME=="GOPI");
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
          
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }
    }
}