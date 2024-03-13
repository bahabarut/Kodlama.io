using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.EnitityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccessLayer.Concrete
{
    public class InstructorDal : IGenericDal<Instructor>
    {
        List<Instructor> list;
        public InstructorDal()
        {
            list = new List<Instructor>()
            {
                new Instructor { Id = 1, Name = "Baha", , Mail = "baha@mail.com", Phone = "0354351" },
                new Instructor { Id = 2, Name = "Ahmet", Mail = "ahmet@mail.com", Phone = "06964313" },
                new Instructor { Id = 3, Name = "Ali", Mail = "ali@mail.com", Phone = "0555555" },
            };
        }
        public void Add(Instructor item)
        {
            Console.WriteLine("New Instructor Added");
        }

        public void Delete(Instructor item)
        {
            Console.WriteLine("Instructor Deleted");
        }
        public Instructor GetById(int id)
        {
            var course = list.FirstOrDefault(x => x.Id == id);
            return course;
        }
        public List<Instructor> GetList()
        {
            return list;
        }

        public void Update(Instructor item)
        {
            Console.WriteLine("Instructor Updated");
        }
    }
}
