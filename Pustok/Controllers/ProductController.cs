using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Data;


namespace Pustok.Controllers
{
    public class ProductController:Controller
    {

        private readonly AppDbContext _context;

		public ProductController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Product()

        {
			var model = await _context.Products.Include(x=>x.Category).ToListAsync();
			return View(model);
        }

       


        public async Task<IActionResult> Detail()
		{

			return View();	
		}



  //      public async Task<IActionResult> Detail(int? id)
		//{
		//	if (id == null) return NotFound();
		//	var product = await _context.Products
		//		.Include(x => x.Category)
		//		.Include(x => x.productImages)
		//		.OrderByDescending(x => x.Id).FirstOrDefaultAsync(x=>x.Id==id);
		//	if (product == null) return NotFound();	
		//	return View(product);



		//}

      
	}
}
