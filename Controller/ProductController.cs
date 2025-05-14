// ProductController.cs
using KnowledgeBaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using optsupport.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace optsupport.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly KnowledgeBaseContext _context;

        public ProductController(KnowledgeBaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}