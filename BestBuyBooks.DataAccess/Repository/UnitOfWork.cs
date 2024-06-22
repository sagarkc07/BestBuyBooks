using BestBuyBooks.DataAccess.Data;
using BestBuyBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICateogoryRepository Cateogory { get; private set; }
        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Cateogory = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }

        public void Save() 
        {
            _db.SaveChanges();
        }
    }
}
