using Microsoft.AspNetCore.Mvc;
using ProductOperation.Models;
using ProductOperation.Repository;

namespace ProductOperation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository repository)
        {
            _productRepository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            try 
            {
                return Ok(await _productRepository.GetProducts());
            }
            catch (Exception) { return StatusCode(StatusCodes.Status500InternalServerError, "Error while retrieving the data"); }
        }
    }
}