using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeek_IterationThree
{
    class Student : Resources
    {


        public Student()
        {
            StudentInfo = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        }
    }

}




