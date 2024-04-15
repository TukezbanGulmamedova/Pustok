using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Data;
using Pustok.Models;

namespace Pustok.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CategoryController :Controller
	{

		private readonly AppDbContext _context;

		public CategoryController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var categories = await _context.Categories.Include(x=>x.Products).ToListAsync();
			return View(categories);
		}


		public IActionResult Create()
		{
			return View();	
		}


		
	}

	//public async Task<IActionResult> Edit(int? id)
	//{
	//	if (id == null || id == 0)
	//	{
	//		return NotFound()
	//	}
	//	Category? category = await _context.Categories.AsNotracking().FirstOrDefaultAsync(x => x.Id == id);
	//	if (category == null)
	//	{
	//		return NotFound()
	//	}

	//	return View(category)


	//}

	//public async Task<IActionResult> Delete(int id)
	//{
	//	Category? category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
	//	if (category is null) 
	//	{
	//		return NotFound();
	//    }
	//	category.SoftDelete = true;
	//	await _context.SaveChangesAsync();
	//	return RedirectToAction(nameof(Index);
	//}

}
