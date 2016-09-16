using Chooza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Chooza.Api_Controller
{
    public class ValuesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        public string AccountModel()
        {
            UserViewModel obj = new UserViewModel()
            {
                FirstName = "Safi",
                LastName = "Mustafa",
                Address = "Dha Islamabad"
            };
            return new JavaScriptSerializer().Serialize(obj);
        }

        [HttpGet]
        public string Customer_()
        {
            UserViewModel obj1 = new UserViewModel(); 
            UserViewModel obj2 = new UserViewModel(); 
            UserViewModel obj3 = new UserViewModel();
            UserViewModel obj4 = new UserViewModel();
            UserViewModel obj5 = new UserViewModel();
            obj1.FirstName = "Waqar";
            obj2.FirstName = "Hasan";
            obj3.FirstName = "Ali";
            obj4.FirstName = "Umer";
            obj5.FirstName = "Zia";
            List<UserViewModel> user = new List<UserViewModel>();
            user.Add(obj1);
            user.Add(obj2);
            user.Add(obj3);
            user.Add(obj4);
            user.Add(obj5);
            return new JavaScriptSerializer().Serialize(user);




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