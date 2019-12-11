using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRO1.Models;

namespace PRO1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private s17293Context _context;

        public ClientsController(s17293Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetClients()
        {

            return Ok(_context.Klient.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetClient(int id)
        {

            var client = _context.Klient.FirstOrDefault(e => e.NrKlient == id);
            if(client == null)
            {

                return NotFound();
            }


            return Ok(client);

        }

      
    }
}