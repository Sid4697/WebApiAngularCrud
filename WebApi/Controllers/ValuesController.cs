using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebApi.Models;
using Microsoft.AspNetCore.Cors;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors]


    public class ValuesController : ControllerBase
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer {id=1,firstName="Siddhant",lastName="Tiwari",address="C-78",
                gender="Male",email="abc@123.com",city="Modinagar",state="U.P",orderTotal=20000},
            new Customer {id=2,firstName="Abhishek",lastName="Tyagi",address="H-420",
                gender="Male",email="abc@123.com",city="Modinagar",state="U.P",orderTotal=20000},
            new Customer {id=3,firstName="Kajal",lastName="Kaushik",address="M-203",
                gender="Female",email="abc@123.com",city="New Delhi",state="Delhi",orderTotal=20000}
        };
    
    // GET: api/<ValuesController>
    [HttpGet]
    [Route("GetAll")]
        public ActionResult Get()
        {
            return Ok(customers);
        }

        // GET api/<ValuesController>/5
        [HttpGet]
        [Route("GetById")]
        public ActionResult Get(int uid)
        {
            var details = customers.SingleOrDefault(o => o.id == uid);
            return Ok(details);
        }

        // POST api/<ValuesController>
        [HttpPost]
        [Route("CreateCustomer")]
        public ActionResult Create(Customer value)
        {

            int count = customers.Count();
            count++;
            value.id = count;
            customers.Add(value);

            return Ok("Added");

        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        [Route("UpdateData")]
        public ActionResult Put(int id,[FromBody] Customer value)
        {
            int index = customers.FindIndex(o => o.id == id);
            customers[index].id = value.id;
            customers[index].firstName = value.firstName; 
            customers[index].lastName = value.lastName; 
            customers[index].address = value.address; 
            customers[index].gender = value.gender;
            customers[index].city = value.city;
            customers[index].state = value.state;
            customers[index].orderTotal = value.orderTotal;

            return Ok("updated");
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        [Route("DeleteData")]
        public ActionResult Delete(int uid)
        {
            customers.Remove(customers.SingleOrDefault(o => o.id == uid));
            return Ok("deleted");
        }
    }
}
