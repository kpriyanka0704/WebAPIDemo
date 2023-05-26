using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;
using WebAPIDemo.Services;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;
        public ProductController(IProductService ser)
        {
            service = ser;
        }
        // GET: api/Product/GetAllProducts
        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            try
            {
                return new ObjectResult(service.GetAllProducts());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // GET  api/Product/GetProductById/1
        [HttpGet]
        [Route("GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                return new ObjectResult(service.GetProductById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct([FromBody] Product prod)
        {
            try
            {
                int res = service.AddProduct(prod);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPost]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] Product prod)
        {
            try
            {
                int res = service.UpdateProduct(prod);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // DELETE api/<ProductController>/5
        [HttpGet]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                int res = service.DeleteProduct(id);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
