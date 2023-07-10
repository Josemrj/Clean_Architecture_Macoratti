using System;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Infra.Data.Context;
using CleanArch.Domain.Entities;

namespace CleanArch.Infra.Data.Repositories {
    public class ProductRepository : IProductRepository {

        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) {

            _context = context;

        }

        public IEnumerable<Product> GetProducts() {

            return _context.Products;
        }
    }
}
