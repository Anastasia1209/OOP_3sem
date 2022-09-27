using System;

namespace Lab02
{
    partial class Student
    {
        private readonly int id;
        private string surname;
        private string name;
        private string patronymic;
        private string birthDay;
        private string adress;
        private int number;
        private string faculty;
        private int course;
        private int group;
        static int NumOfStudents;
        const int minAge = 17;

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            
            set
            {
                if (!String.IsNullOrEmpty(surname))
                {
                    surname = value;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (!String.IsNullOrEmpty(name))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }
        public string Patronymic
        {
            get
            {
                return patronymic;
            }

            set
            {
                if (!String.IsNullOrEmpty(patronymic))
                {
                    patronymic = value;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }
        public string BbirthDay
        {
            get
            {
                return birthDay;
            }

            set
            {
                if (!String.IsNullOrEmpty(birthDay))
                {
                    birthDay = value;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                if (!String.IsNullOrEmpty(adress))
                {
                    adress = value;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }
        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value < 1000000000 || value > 999999999)
                {
                    Console.WriteLine("Неверно введены данные");
                }
                else
                {
                    number = value;
                }
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                if (!String.IsNullOrEmpty(faculty))
                {
                    faculty = value;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }
        public int Course
        {
            get
            {
                return course;
            }

            set
            {
                if (value < 1 || value > 5)
                {
                    Console.WriteLine("Неверно введены данные");
                }
                else
                {
                    number = value;
                }
            }
        }
        public int Group
        {
            get
            {
                return group;
            }

            set
            {
                if (value < 1 || value > 10)
                {
                    Console.WriteLine("Неверно введены данные");
                }
                else
                {
                    number = value;
                }
            }
        }
        //конструктор по умолчанию
        public Student()
        {
            surname = "Unknown";
            name = "Unknown";
            patronymic = "Unknown";
            birthDay = "00.00.0000";
            adress = "Unknown";
            faculty = "Unknown";
            number = 123456789;
            course = 1;
            group = 1;
            NumOfStudents++;
            id = GetHashCode();
        }
        //неполный конструктор
        public Student(string userSurname, string userName, string userBirth, string userAdress, int userCourse, int userGroup)
        {
            surname = userSurname;
            name = userName;
            birthDay = userBirth;
            adress = userAdress;
            course = userCourse;
            group = userGroup;
            NumOfStudents++;
            id = GetHashCode();
        }
        //полный конструктор
        public Student(string userSurname, string userName, string userPatron, string userBirth, string userAdress, string userFaculty, int userNum, int userCourse, int userGroup)
        {
            surname = userSurname;
            name = userName;
            patronymic = userPatron;
            birthDay = userBirth;
            adress = userAdress;
            faculty = userFaculty;
            number = userNum;
            course = userCourse;
            group = userGroup;
            NumOfStudents++;
            id = GetHashCode();
        }
        //статический конструктор
        static Student()
        {
            NumOfStudents = 0;
        }
        public int getStudentAge()
        {
            int Age = Convert.ToInt32(birthDay.Substring(6));
            return DateTime.Now.Year - Age;
        }

        public string getStudenFaculty(ref string facult)
        {
            if (facult == faculty)
            {
                return name;
            }
            else
            {
                return null;
            }
        }

        public string getStudenGroup(int groupe)
        {
            if (groupe == group)
            {
                return name;
            }
            else
            {
                return null;
            }
        }
        //сравнение возраста студентов
        public void Equals(Student stud1, Student stud2)
        {
            switch (String.Compare(stud1.birthDay, stud2.birthDay))
            {
                case 0:
                    Console.WriteLine("Возраст студентов равен");
                    break;
                case 1:
                    Console.WriteLine("Первый студент старше второго");
                    break;
                case -1:
                    Console.WriteLine("Первый студент младше второго");
                    break;
            }
        }

    }

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
            

            
        }
    }
}
