using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.EnitityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccessLayer.Concrete
{
    public class CourseDal : IGenericDal<Course>
    {
        List<Course> list;
        public CourseDal()
        {
            list = new List<Course>()
            {
                new Course { Id = 1, Name = "Javascript", CreateDate = DateTime.Now, Description = "Basic Javascript", Image = "", CategoryId = 1, InstructorId = 1  },
                new Course { Id = 1, Name = "Flutter", CreateDate = DateTime.Now.AddDays(-3), Description = "Basic Flutter", Image = "", CategoryId = 2, InstructorId = 2  },
                new Course { Id = 1, Name = "Windows Form Application", CreateDate = DateTime.Now.AddDays(-5), Description = "Basic Windows Form Application", Image = "", CategoryId = 3, InstructorId = 3  },
            };
        }
        public void Add(Course item)
        {
            Console.WriteLine("New Course Added");
        }

        public void Delete(Course item)
        {
            Console.WriteLine("Course Deleted");
        }
        public Course GetById(int id)
        {
            var course = list.FirstOrDefault(x => x.Id == id);
            return course;
        }
        public List<Course> GetList()
        {
            return list;
        }

        public void Update(Course item)
        {
            Console.WriteLine("Course Updated");
        }
    }
}
