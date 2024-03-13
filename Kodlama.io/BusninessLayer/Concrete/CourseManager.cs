using Kodlama.io.BusninessLayer.Abstract;
using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.EnitityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.BusninessLayer.Concrete
{
    public class CourseManager : IGenericService<Course>
    {
        private readonly IGenericDal<Course> _CourseDal;

        public CourseManager(IGenericDal<Course> CourseDal)
        {
            _CourseDal = CourseDal;
        }

        public void Add(Course item)
        {
            _CourseDal.Add(item);
        }

        public void Delete(Course item)
        {
            _CourseDal.Delete(item);
        }

        public List<Course> GetAll()
        {
            return _CourseDal.GetList();
        }

        public Course GetById(int id)
        {
            return _CourseDal.GetById(id);
        }

        public void Update(Course item)
        {
            _CourseDal.Update(item);
        }
    }
}
