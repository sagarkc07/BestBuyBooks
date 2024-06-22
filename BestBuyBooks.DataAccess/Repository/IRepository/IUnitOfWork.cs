using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork 
    {
        ICateogoryRepository Cateogory { get; }
        IProductRepository Product { get; }

        void Save();
    }
}
