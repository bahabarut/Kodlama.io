using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.EnitityLayer
{
    public class Category : BaseEntity
    {
        public List<Course> Courses { get; set; }
    }
}
