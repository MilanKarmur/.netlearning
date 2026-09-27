using Microsoft.AspNetCore.Mvc;
using pr6.Models;

//namespace pr6.Controllers
//{
//    public class ProductController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using ProductCatalog.Models;

namespace pr6.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = "High performance laptop",
                Price = 55000,
                Category = "Electronics",
                Stock = 10
            },

            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Description = "Latest Android smartphone",
                Price = 25000,
                Category = "Electronics",
                Stock = 20
            },

            new Product
            {
                Id = 3,
                Name = "Headphones",
                Description = "Wireless Bluetooth headphones",
                Price = 2500,
                Category = "Accessories",
                Stock = 15
            }
        };

        // GET: Product
        public IActionResult Index()
        {
            return View(products);
        }

        // GET: Product/Details/1
        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = products.Count > 0
                    ? products.Max(p => p.Id) + 1
                    : 1;

                products.Add(product);

                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Product/Edit/1
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Edit
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var existingProduct =
                    products.FirstOrDefault(p => p.Id == product.Id);

                if (existingProduct == null)
                {
                    return NotFound();
                }

                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.Category = product.Category;
                existingProduct.Stock = product.Stock;

                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Product/Delete/1
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);

            return RedirectToAction("Index");
        }
    }
}
