using AstanovWebApp.Database;
using AstanovWebApp.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AstanovWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebController : ControllerBase
    {

        private IDatabaseContext _dbContext;
        public WebController(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        [HttpGet]
        public IEnumerable<Web> Get()
        {
            return db.Users.ToList();
        }

        // GET api/<WebController>/5
        [HttpGet("{id}")]
        public Web Get(int id)
        {
            return db.Users.Find(id);
        }

        // POST api/<WebController>
        [HttpPost]
        public IActionResult Post([FromBody] Web model)
        {
            try
            {
                db.Users.Add(model);
                db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
