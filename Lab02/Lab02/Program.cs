using System;

namespace Lab02
{
    

    class Program
    {
        static void Main(string[] args)
        {

            Student[] arrStudents = new Student[5];
            arrStudents[0] = new Student( "Golodok","Anastasiya", "Yuryevna", "12.09.2003", "Kachana", "FIT", 445959897, 2, 4);
            arrStudents[1] = new Student("Glushenya", "Polina", "11.03.2004", "Bobruysk", 2, 4);
            arrStudents[2] = new Student();
            arrStudents[3] = new Student("Ivanov", "Ivan", "Ivanovich", "10.01.2002", "Belorusskaya", "XTIT", 123456789, 2, 6);
            arrStudents[4] = new Student("Petrova", "Anna", "Sergeevna", "23.06.2001", "Belorusskaya", "PIM", 223366441, 3, 1);
            Console.WriteLine(arrStudents[0].Id);
            Console.WriteLine(Student.getStaticInfo());
            string facultyExs = "FIT";
            foreach (Student i in arrStudents)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.getStudentAge());
                Console.WriteLine(i.getStudenFaculty(ref facultyExs));
                Console.WriteLine(i.getStudenGroup(4));
                Console.WriteLine(i.getStudenGroup(4));

            }
        }
    }
}
