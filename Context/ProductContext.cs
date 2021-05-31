using Microsoft.EntityFrameworkCore;
using Products.Web_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Web_App.Context
{
    public class ProductContext:DbContext
    {

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {


        }
        public DbSet<Productt> Productts { get; set; }
        public DbSet<SendMessage> sendMessages { get; set; }
    }
}
