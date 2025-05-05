using KnowledgeBaseAPI.Data;
using KnowledgeBaseAPI.DTOs;
using KnowledgeBaseAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using optsupport.Dto;
using optsupport.Model;

namespace KnowledgeBaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnowledgeBaseController : ControllerBase
    {
        private readonly KnowledgeBaseContext _context;

        public KnowledgeBaseController(KnowledgeBaseContext context)
        {
            _context = context;
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategories()
        {
            var categories = await _context.Categories
                .Include(c => c.Articles)
                .Select(c => new CategoryDTO
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    Image = c.Image,
                    Articles = c.Articles.Select(a => new ArticleDTO
                    {
                        Id = a.Id,
                        Title = a.Title,
                        Url = a.Url
                    }).ToList()
                }).ToListAsync();

            return Ok(categories);
        }

        [HttpGet("inventory/{articleId}")]
        public async Task<ActionResult<InventoryDataDTO>> GetInventoryData(string articleId)
        {
            var inventoryData = await _context.InventoryData
                .Include(id => id.ProcessSteps)
                .Include(id => id.Prerequisites)
                .Include(id => id.Images)
                .Include(id => id.Article)
                .FirstOrDefaultAsync(id => id.ArticleId == articleId);

            if (inventoryData == null)
            {
                return NotFound();
            }

            return Ok(new InventoryDataDTO
            {
                Id = inventoryData.ArticleId,
                Title = inventoryData.Title,
                Overview = inventoryData.Overview,
                ProcessSteps = inventoryData.ProcessSteps.Select(ps => ps.Step).ToList(),
                FormName = inventoryData.FormName,
                Prerequisites = inventoryData.Prerequisites.Select(p => p.Requirement).ToList(),
                ArticleLink = inventoryData.ArticleLink,
                Images = inventoryData.Images.Select(i => new ImageDTO
                {
                    Url = i.Url,
                    Caption = i.Caption
                }).ToList(),
                Author = inventoryData.Author,
                AppLinks = inventoryData.AppLinks
            });
        }
        [HttpPost]
        public async Task<ActionResult<Article>> CreateInventoryArticle([FromBody] InventoryArticleDTO request)
        {
            var category = await _context.Categories.FindAsync(request.CategoryId);
            if (category == null)
            {
                return BadRequest("Invalid category ID");
            }

            var article = new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = request.ArticleTitle,
                Url = request.ArticleUrl,
                CategoryId = request.CategoryId
            };

            var inventoryData = new InventoryData
            {
                ArticleId = article.Id,
                Title = request.InventoryTitle,
                Overview = request.Overview,
                ProcessSteps = request.ProcessSteps?.Select(ps => new ProcessStep { Step = ps })?.ToList(),
                FormName = request.FormName,
                Prerequisites = request.Prerequisites?.Select(p => new Prerequisite { Requirement = p })?.ToList(),
                ArticleLink = new ArticleLink
                {
                    Url = request.ArticleLink?.Url,
                    Text = request.ArticleLink?.Text
                },
                Images = request.Images?.Select(i => new InventoryImage
                {
                    Url = i?.Url,
                    Caption = i?.Caption
                })?.ToList(),
                Author = new Author
                {
                    Name = request.Author?.Name,
                    Avatar = request.Author?.Avatar,
                    LastUpdated = request.Author?.LastUpdated
                },
                AppLinks = new AppLinks
                {
                    PlayStore = new StoreLink
                    {
                        Url = request.AppLinks?.PlayStore?.Url,
                        Image = request.AppLinks?.PlayStore?.Image
                    },
                    AppStore = new StoreLink
                    {
                        Url = request.AppLinks?.AppStore?.Url,
                        Image = request.AppLinks?.AppStore?.Image
                    }
                }
            };

            article.InventoryData = inventoryData;

            _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInventoryData), new { articleId = article.Id }, new { success = true });
        }
    }
}