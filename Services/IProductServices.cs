using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
using Products.Web_App.Entities;

namespace Products.Web_App.Services
{
    public interface IProductServices
    {


        int AddProduct(Products.Web_App.Entities.Productt productt, IFormFile imgUp);

        // void DeleteProduct(Products.Web_App.Entities.Productt productt, int productId);
        void DeleteProduct( int productId);

        void UpdateProduct(Products.Web_App.Entities.Productt productt, IFormFile imgUp);

        Productt GetProductsById(int productId);
    }
}
