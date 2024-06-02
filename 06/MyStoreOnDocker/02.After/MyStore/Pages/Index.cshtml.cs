using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyStore.Data;
using MyStore.Entities;

namespace MyStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMyStoreDbContext ctx;

        public List<Product> Products { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IMyStoreDbContext ctx)
        {
            _logger = logger;
            this.ctx = ctx;
        }

        public async Task OnGetAsync()
        {
            var products = await ctx.Products.Include(x => x.Category).ToListAsync();
            this.Products = products;
        }
    }
}
