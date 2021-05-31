using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Products.Web_App.Context;
using Products.Web_App.Convertors;
using Products.Web_App.Entities;
using Products.Web_App.Generator;
using Products.Web_App.Senders;
using Products.Web_App.Services;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Products.Web_App.Controllers
{
    public class ProducttsController : Controller
    {
        private readonly ProductContext _context;

        private IViewRenderService _viewRender;
        private IProductServices _productservives;

        public ProducttsController(ProductContext context, IViewRenderService viewRender ,IProductServices productServices)
        {
            _context = context;
            _viewRender = viewRender;
            _productservives = productServices;

        }

        // GET: Productts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Productts.ToListAsync());
        }

        // GET: Productts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productt = await _context.Productts
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productt == null)
            {
                return NotFound();
            }

            return View(productt);
        }

        // GET: Productts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("ProductId,ProductName,ImageName,Price,Description,createdate")] Productt productt, IFormFile imgUp)
        {
            if (!ModelState.IsValid)
                return View(productt);
            _productservives.AddProduct(productt, imgUp);
            return RedirectToAction("Index");                     
        }

        // GET: Productts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productt = await _context.Productts.FindAsync(id);
            if (productt == null)
            {
                return NotFound();
            }
            return View(productt);
        }

        // POST: Productts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ImageName,Price,Description,createdate")] Productt productt, IFormFile imgUp)
        //{
        public IActionResult Edit(int id, [Bind("ProductId,ProductName,ImageName,Price,Description,createdate")] Productt productt, IFormFile imgUp)
        {
            if (id != productt.ProductId)
            {
                return NotFound();
            }      
            if (!ModelState.IsValid)
                return View(productt);
            _productservives.UpdateProduct(productt, imgUp);
            return RedirectToAction("Index");
          
        }

        // GET: Productts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productt = await _context.Productts
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productt == null)
            {
                return NotFound();
            }

            return View(productt);
        }

        // POST: Productts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var productt = _productservives.GetProductsById(id);          
            _productservives.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProducttExists(int id)
        {
            return _context.Productts.Any(e => e.ProductId == id);
        }


        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(string fullname, string email, string text)
        {
            if (ModelState.IsValid)
            {
                var product = new Productt();           
                    SendMessage send = new SendMessage();
                    send.FullName = fullname;
                    send.Email = email;
                    send.Text = text;
                    _context.Add(send);
                    _context.SaveChanges();
                    //send
                    string body = _viewRender.RenderToStringAsync("SendEmail", send);
                    SendEmail.Send(send.Email, "فعالسازی", body);
                    ViewBag.IsSuccess = true;
                    return View("_SuccessEmail",send);
            }
            return View();
        }



      
    }
}
