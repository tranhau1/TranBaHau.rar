using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranBaHau.rar
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string Class { get; set; }
        public double Mark1 { get; set; }
        public double Mark2 { get; set; }
        public double Mark3 { get; set; }
        public double DiemTB { get; set; }
        public void mark_AVG(Student sv)
        {
            double DiemTB = (sv.Mark1 + sv.Mark2 + sv.Mark3) / 3;
        }
    }
}

