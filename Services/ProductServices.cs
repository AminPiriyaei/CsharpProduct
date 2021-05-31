using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Products.Web_App.Context;
using Products.Web_App.Entities;
using Products.Web_App.Generator;

namespace Products.Web_App.Services
{
    public class ProductServices : IProductServices
    {

        private ProductContext _Context;
        public ProductServices(ProductContext Context)
        {
            _Context = Context;

        }

        public int AddProduct(Productt productt, IFormFile imgUp)
        {
            productt.createdate = DateTime.Now;
            productt.ImageName = "no-photo.jpg";
            //TODO Check Image
            if (imgUp != null)
            {
                productt.ImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgUp.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Product/Image", productt.ImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgUp.CopyTo(stream);
                }
            }

            _Context.Add(productt);
            _Context.SaveChanges();
            return productt.ProductId;
        }

     
        public void DeleteProduct( int productId)
        {
            var productt = GetProductsById(productId);

            if (productt.ImageName != "no-photo.jpg")
            {
                string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "/Product/Image", productt.ImageName);
                if (File.Exists(deleteimagePath))
                {
                    File.Delete(deleteimagePath);
                }
            }
            _Context.Remove(productt);
            _Context.SaveChanges();

        }

        public Productt GetProductsById(int productId)
        {
            return _Context.Productts.Find(productId);
        }

        public void UpdateProduct(Productt productt, IFormFile imgUp)
        {
            if (imgUp != null)
            {
                if (productt.ImageName != "no-photo.jpg")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Product/Image", productt.ImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }


                }
                productt.ImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgUp.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Product/Image", productt.ImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgUp.CopyTo(stream);
                }

            }

            _Context.Update(productt);
            _Context.SaveChanges();
        }
    }
}