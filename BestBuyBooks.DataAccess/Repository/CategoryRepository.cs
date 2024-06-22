using BestBuyBooks.DataAccess.Data;
using BestBuyBooks.DataAccess.Repository.IRepository;
using BestBuyBooks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICateogoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base (db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
