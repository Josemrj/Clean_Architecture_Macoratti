using System;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Infra.Data.Context;
using CleanArch.Domain.Entities;

namespace CleanArch.Infra.Data.Repositories {

    //Incluindo a referência, herdando a 'Interface' criada para 'Product'
    public class ProductRepository : IProductRepository {
        
        //Incluindo uma instância no arquivo de contexto;
        private ApplicationDbContext _context;

        //Injetando a instância no construtor;
        public ProductRepository(ApplicationDbContext context) {

            _context = context;

        }
        
        //Usando a instância do contexto para obter os dados do produto
        public IEnumerable<Product> GetProducts() {

            return _context.Products;
        }
    }
}
