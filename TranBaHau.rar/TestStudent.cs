using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TranBaHau.rar
{
    class TestStudent
    {
        private List<Student> ListStudent = null;
        public TestStudent()
        {
            ListStudent = new List<Student>();
        }
            private int GenerateID()
            {
                int max = 1;
                if (ListStudent != null && ListStudent.Count > 0)
                {
                    max = ListStudent[0].Id;
                    foreach (Student sv in ListStudent)
                    {
                        if (max < sv.Id)
                        {
                            max = sv.Id;
                        }
                    }
                    max++;
                }
                return max;
            }
            public int SoluongStudent()
            {
                int Count = 0;
                if (ListStudent == null)
                {
                    Count = ListStudent.Count;
                }
                return Count;
            }
            public void NhapStudent()
            {
                Student sv = new Student();
                sv.Id = GenerateID();
                Console.Write("Nhap ten sinh vien: ");
                sv.Name = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap gioi tinh hoc sinh: ");
                sv.Gender = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap tuoi: ");
                sv.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap ngay sinh : ");
                sv.DateOfBirth = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap ten lop: ");
                sv.Class = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap diem mon 1: ");
                sv.Mark1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap diem mon 2: ");
                sv.Mark2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap diem mon 3: ");
                sv.Mark3 = Convert.ToDouble(Console.ReadLine());
            }
            public Student FindByID(int Id)
            {
                Student searchResult = null;
                if (ListStudent != null && ListStudent.Count > 0)
                {
                    foreach (Student sv in ListStudent)
                    {
                        if (sv.Id == Id)
                        {
                            searchResult = sv;
                        }
                    }
                }
                return searchResult;
            }
            public Student FindByName(int Name)
            {
                Student searchResult = null;
                if (ListStudent != null && ListStudent.Count > 0)
                {
                    foreach (Student sv in ListStudent)
                    {
                        if (sv.Name == Name)
                        {
                            searchResult = sv;
                        }
                    }
                }
                return searchResult;
            }
        
    }
}
