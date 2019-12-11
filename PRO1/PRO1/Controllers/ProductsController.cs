using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO1.Models;

namespace PRO1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private s17293Context _context;

        public ProductsController(s17293Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {

            return Ok(_context.ProduktMenu.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetProduct(int id)
        {

            var product = _context.ProduktMenu.FirstOrDefault(e => e.IdProdukt == id);
            if (product == null)
            {

                return NotFound();
            }
           
            return Ok(product);

        }

        [HttpPost]
        public IActionResult CreateProduct(ProduktMenu newProduct)
        {
            _context.ProduktMenu.Add(newProduct);
            _context.SaveChanges();

            return StatusCode(201, newProduct);



        }

        [HttpPut("{idprodukt:int}")]
        public IActionResult UpdateProduct(ProduktMenu updatedProduct)
        {

            var prod = _context.ProduktMenu.FirstOrDefault(e => e.IdProdukt == updatedProduct.IdProdukt);

            if(prod == null)
            {

                return NotFound();
            }

            _context.ProduktMenu.Attach(updatedProduct);
            _context.Entry(updatedProduct).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(updatedProduct);

        }

        [HttpDelete("{idprodukt:int}")]
        public IActionResult DeleteProduct(int product)
        {

            var prod = _context.ProduktMenu.FirstOrDefault(e => e.IdProdukt == product);
            if(prod == null)
            {
                return NotFound();

            }
            _context.ProduktMenu.Remove(prod);
            _context.SaveChanges();

            return Ok(prod);


        }


    }
}