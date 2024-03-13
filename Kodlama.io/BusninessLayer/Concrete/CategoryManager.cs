using Kodlama.io.BusninessLayer.Abstract;
using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.DataAccessLayer.Concrete;
using Kodlama.io.EnitityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.BusninessLayer.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {
        private readonly IGenericDal<Category> _categoryDal;

        public CategoryManager(IGenericDal<Category> categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category item)
        {
            _categoryDal.Add(item);
        }

        public void Delete(Category item)
        {
            _categoryDal.Delete(item);
        }
        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Update(Category item)
        {
            _categoryDal.Update(item);
        }
    }
}
