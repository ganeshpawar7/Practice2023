using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) :base(db) 
        {
            _db = db;
        }

        // Refer to UnitOfWork
        //public void Save()
        //{
        //    _db.SaveChanges();
        //}

        public void Update(Product obj)
        {
            //_db.Products.Update(obj);
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.ISBN= obj.ISBN;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryID = obj.CategoryID;
                objFromDb.CoverTypeID= obj.CoverTypeID;
                objFromDb.Author= obj.Author;
                objFromDb.ListPrice= obj.ListPrice;
                objFromDb.Price= obj.Price;
                objFromDb.Price50= obj.Price50;
                objFromDb.Price100= obj.Price100;
                if(obj.ImageUrl!=null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
