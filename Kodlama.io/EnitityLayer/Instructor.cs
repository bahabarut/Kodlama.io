using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.EnitityLayer
{
    public class Instructor : BaseEntity
    {
        public string Mail { get; set; }
        public string Phone { get; set; }
        public List<Course> Courses { get; set; }
    }
}
