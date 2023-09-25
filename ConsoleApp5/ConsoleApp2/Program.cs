namespace ConsoleApp2
{
    internal class StudentWithBackpack
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.Write("Input student name: ");
                string studentName = Console.ReadLine();
                Console.Write("Input student family name: ");
                string studentFamilyName = Console.ReadLine();
                Console.Write("Input student age: ");
                int studentAge = int.Parse(Console.ReadLine());

                BackPack bp = new BackPack() { Color = "Red", Price = 19.99m, Volume = 15.6d };


                Student student = new Student() { Name = studentName, FamilyName = studentFamilyName, Age = studentAge };
                student.BackPack = bp;
                students.Add(student);

                Console.WriteLine("Input another student? Y/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "N")
                {
                    break;
                }
                Console.WriteLine(new string('=', 20));
            }
            Console.WriteLine("Input Grades");
            Console.WriteLine("Choose student from list: ");
            for (int i = 0; i < students.Count; i++)
            {
                var current = students[i];
                Console.WriteLine($"[{i + 1}.] {current.Name} {current.FamilyName}");
            }
            int chosenIndex = int.Parse(Console.ReadLine());
            Student selectedStudent = students[chosenIndex];
            Console.WriteLine("Input grades separated with spaces/ex. 3 5 6 2 ");
            var grades =Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToList();

            Student st1 = new Student() { Name = "Gancho", FamilyName = "Petrov", Age = 15 };
            BackPack bp1 = new BackPack() { Volume = 15.6, Color = "Camoflage", Price = 69.75m };

            st1.BackPack = bp1;
            //st1.Grades = new List<int>();
            st1.Grades.Add(5);
            st1.Grades.Add(6);
            st1.Grades.Add(3);
            st1.Grades.Add(3);

            st1.GetAverageGrades();
            Console.WriteLine($"Average grade is: {st1.GetAverageGrades()}");
        }
    }

    public class BackPack
    {
        public double Volume { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }

    public class Student
    {
        private string name;
        private string familyName;
        public string FamilyName
        {
            get { return familyName.ToUpper().Substring(0, 1) + "."; }
            set => familyName = value;
        }
        public int Age { get; set; }
        public string Name { get; set; }

        public BackPack BackPack { get; set; }

        public List<int> Grades { get; set; } = new List<int>();

        public double GetAverageGrades()
        {
            double result = Grades.Average();

            return result;
        }








    }
}
