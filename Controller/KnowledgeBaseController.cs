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
                .Include(id => id.Article)
                .Include(id => id.Images)
                .FirstOrDefaultAsync(id => id.ArticleId == articleId);

            if (inventoryData == null)
            {
                return NotFound();
            }

            return Ok(new InventoryDataDTO
            {
                Id = inventoryData.Id,
                ArticleId = inventoryData.ArticleId,
                Title = inventoryData.Title,
                Content = inventoryData.Content,
                ArticleLink = new ArticleLinkDTO
                {
                    Url = inventoryData.ArticleLink.Url,
                    Text = inventoryData.ArticleLink.Text
                },
                Images = inventoryData.Images.Select(i => new ImageDTO
                {
                    Url = i.Url,
                    Caption = i.Caption
                }).ToList(),
                Author = new AuthorDTO
                {
                    Name = inventoryData.Author.Name,
                    Avatar = inventoryData.Author.Avatar,
                    LastUpdated = inventoryData.Author.LastUpdated
                },
                AppLinks = new AppLinksDTO
                {
                    PlayStore = new StoreLinkDTO
                    {
                        Url = inventoryData.AppLinks.PlayStore.Url,
                        Image = inventoryData.AppLinks.PlayStore.Image
                    },
                    AppStore = new StoreLinkDTO
                    {
                        Url = inventoryData.AppLinks.AppStore.Url,
                        Image = inventoryData.AppLinks.AppStore.Image
                    }
                }
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
                Content = request.Content,
                ArticleLink = new ArticleLink
                {
                    Url = request.ArticleLink?.Url,
                    Text = request.ArticleLink?.Text
                },
                Images = request.Images?.Select(i => new InventoryImage
                {
                    Url = i.Url,
                    Caption = i.Caption
                }).ToList(),
                Author = new Author
                {
                    Name = request.Author.Name,
                    Avatar = request.Author.Avatar,
                    LastUpdated = request.Author.LastUpdated
                },
                AppLinks = new AppLinks
                {
                    PlayStore = new StoreLink
                    {
                        Url = request.AppLinks.PlayStore.Url,
                        Image = request.AppLinks.PlayStore.Image
                    },
                    AppStore = new StoreLink
                    {
                        Url = request.AppLinks.AppStore.Url,
                        Image = request.AppLinks.AppStore.Image
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