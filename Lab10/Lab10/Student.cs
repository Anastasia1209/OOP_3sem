using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Student
    {
        private readonly int id;
        private string surname;
        private string name;
        private string patronymic;
        private string birthDay;
        private string adress;
        private int number;
        private string faculty;
        private string speciality;
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
        public string Speciality
        {
            get
            {
                return speciality;
            }

            set
            {
                if (!String.IsNullOrEmpty(speciality))
                {
                    speciality = value;
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
       
        //полный конструктор
        public Student(string userSurname, string userName, string userPatron, string userBirth, string userAdress, string userFaculty,string userSpeciality, int userNum, int userCourse, int userGroup)
        {
            surname = userSurname;
            name = userName;
            patronymic = userPatron;
            birthDay = userBirth;
            adress = userAdress;
            faculty = userFaculty;
            speciality = userSpeciality;
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
        //сравнение объектов
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            Student stud = obj as Student;
            if (stud == null)
                return false;
            return this.surname == stud.surname && this.name == stud.name && this.patronymic == stud.patronymic && this.birthDay == stud.birthDay && this.adress == stud.adress && this.number == stud.number && this.faculty == stud.faculty && this.course == stud.course && this.group == stud.group;

        }
        public override int GetHashCode()
        {
            var hashSum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                hashSum += Convert.ToInt32(name[i]);
            }
            return hashSum;
        }
        public override string ToString()
        {
            Console.WriteLine("Фамилия: " + surname);
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Отчество: " + patronymic);
            Console.WriteLine("Дата рождения: " + birthDay);
            Console.WriteLine("Адрес: " + adress);
            Console.WriteLine("Номер телефона: " + number);
            Console.WriteLine("Факультет: " + faculty);
            Console.WriteLine("Курс: " + course);
            Console.WriteLine("Группа: " + group);
            return "";
        }
        public static int getStaticInfo()
        {
            return NumOfStudents;
        }
    }
}
