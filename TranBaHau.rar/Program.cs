using TranBaHau.rar;

namespace TranBaHau
{
    public class program
    {
        static void Main(string[] arg)
        {
            TestStudent testStudent = new TestStudent();
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Input information (input details for a student).");
                Console.WriteLine("2. Sorting student asccending by average mark");
                Console.WriteLine("3. Display all the student.");
                Console.WriteLine("4. Search Student by Name");
                Console.WriteLine("5. Delete Student by student ID.");
                Console.WriteLine("6. Exit program.");
                Console.WriteLine("====================================");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them student.");
                        testStudent.NhapStudent();
                        break;  
                }
            }
        }
    }
}