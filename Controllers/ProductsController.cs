using _2130_KhumaloCraft.Data;
using _2130_KhumaloCraft.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _2130_KhumaloCraft.Controllers
{
    
    public class ProductsController : Controller
    {
        private readonly CraftContext craftContext;

        public ProductsController(CraftContext craftContext)
        {
            this.craftContext = craftContext;
        }
        [Authorize(Roles = "Admin,Customer")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var product = await craftContext.Products.ToListAsync();
            return View(product);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Add(ProductVM product)
        {
            var productobj = new Product()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                //Categories = product.
                //ImageUrl= product.ImageUrl

            };
            await craftContext.Products.AddAsync(productobj);
            await craftContext.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        [Authorize(Roles = "Admin,Customer")]
        [HttpGet]
        public async Task<IActionResult> View(int id)
        {
            var product = await craftContext.Products.FirstOrDefaultAsync(x => x.Id == id);


            if (product != null)
            {

                var viewModel = new UpdateProductModel()
                {

                    Id =product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    //Category = product.Category,
                    //ImageUrl= product.ImageUrl

                };
                return await Task.Run(() => View("View", viewModel));

            }
            return RedirectToAction("Index");

        }
        [Authorize(Roles = "Admin,Customer")]
        [HttpPost]
        public async Task<IActionResult> View(UpdateProductModel model)
        {
            var product = await craftContext.Products.FindAsync(model.Id);
            if (product != null)
            {
                product.Name = model.Name;
                product.Description = model.Description;
                product.Price = model.Price;
                //product.Category = model.Category;

                await craftContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateProductModel model)
        {
            var product = await craftContext.Products.FindAsync(model.Id);
            if (product != null)
            {
                craftContext.Products.Remove(product);
                await craftContext.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");

        }
    }
}

