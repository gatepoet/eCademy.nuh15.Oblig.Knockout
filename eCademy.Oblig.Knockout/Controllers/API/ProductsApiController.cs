using eCademy.Oblig.Knockout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eCademy.Oblig.Knockout.Controllers.API
{
    public class ProductsApiController : ApiController
    {
        // GET: api/Products
        [Route("api/Products")]
        public IEnumerable<Product> Get()
        {
            return Database.Products;
        }

        // GET: api/Products/5
        [Route("api/Products/{id}")]
        public IHttpActionResult Get(int id)
        {
            var product = Database.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/ProductsApi/5
        [Route("api/Products/{id}")]
        public IHttpActionResult Put(int id, [FromBody]Product value)
        {
            var index = Database.Products.FindIndex(p => p.Id == id);
            Database.Products[index] = value;

            return Ok();
        }
    }
}
