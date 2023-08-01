using System;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("select * from products");
        }
    }
}
