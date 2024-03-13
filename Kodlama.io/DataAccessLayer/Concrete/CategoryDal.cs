using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.EnitityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccessLayer.Concrete
{
    public class CategoryDal : IGenericDal<Category>
    {
        List<Category> list;
        public CategoryDal()
        {
            list = new List<Category>()
            {
                new Category { Id = 1, Name = "Web Development" },
                new Category { Id = 2, Name = "Mobil Development" },
                new Category { Id = 3, Name = "Desktop Application" },
            };
        }
        public void Add(Category item)
        {
            Console.WriteLine("New Cateogry Added");
        }

        public void Delete(Category item)
        {
            Console.WriteLine("Category Deleted");
        }

        public Category GetById(int id)
        {
            var category = list.FirstOrDefault(x=>x.Id == id);
            return category;
        }

        public List<Category> GetList()
        {
            return list;
        }

        public void Update(Category item)
        {
            Console.WriteLine("Category Updated");
        }
    }
}
