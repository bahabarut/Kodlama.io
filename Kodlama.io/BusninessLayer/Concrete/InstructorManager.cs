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
    public class InstructorManager : IGenericService<Instructor>
    {
        private readonly IGenericDal<Instructor> _instructorDal;

        public InstructorManager(IGenericDal<Instructor> instroctorDal)
        {
            _instructorDal = instroctorDal;
        }

        public void Add(Instructor item)
        {
            _instructorDal.Add(item);
        }

        public void Delete(Instructor item)
        {
            _instructorDal.Delete(item);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetList();
        }
        public Instructor GetById(int id)
        {
            return _instructorDal.GetById(id);
        }
        public void Update(Instructor item)
        {
            _instructorDal.Update(item);
        }
    }
}
