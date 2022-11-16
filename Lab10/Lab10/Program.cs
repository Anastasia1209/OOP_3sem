using Lab10;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Lab10
{
    class Stud
    {
        public string faculty;
        public string spec;

        public Stud(string faculty, string spec)
        {
            this.faculty = faculty;
            this.spec = spec;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arrStudents = new Student[1];
            arrStudents[0] = new Student("Golodok", "Anastasiya", "Yuryevna", "12.09.2003", "Kachana", "FIT", "POIT", 445959897, 2, 4);
        
            string facultyExs = "FIT";

            //-------------------------
            Console.WriteLine("Введите номер задания:");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    string[] months =
                        { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

                    /*запрос выбирающий последовательность месяцев с длиной строки равной n*/
                    Console.ForegroundColor = ConsoleColor.White;
                    var n = 5;
                    Console.WriteLine("Months length n symbol: ");
                    foreach (string item in from m in months where m.Length == n select m) Console.WriteLine(item);

                    /*запрос возвращающий только летние и зимние месяцы, */
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Summer and winter months:");
                    foreach (string item in from m in months
                                            where Array.IndexOf(months, m) < 2 ||
                                                  Array.IndexOf(months, m) > 4 && Array.IndexOf(months, m) < 8 ||
                                                  Array.IndexOf(months, m) == 11
                                            select m
                    ) Console.WriteLine(item);

                    /*запрос вывода месяцев в алфавитном порядке,*/
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Months sorted alphabetly:");
                    foreach (string item in from m in months orderby m select m) Console.WriteLine(item);

                    /*запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4-х*/
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Months contains letter 'u' and length not less than 4:");
                    foreach (string item in from m in months where m.Contains('u') && m.Length >= 4 select m) Console.WriteLine(item);
                    break;

                case 2:
                    List<Student> studList = new List<Student>();
                    studList.Add(new Student("Gemza", "Alexandr", "Ivanovich", "01.09.2004", "Belorusskaya", "FIT", "POIT", 123456789, 1, 1));
                    studList.Add(new Student("Gomza", "Alexandr", "Ivanovich", "15.10.2003", "Belorusskaya", "FIT", "ISIT", 123456789, 1, 3));
                    studList.Add(new Student("Petrova", "Anna", "Sergeevna", "23.06.2001", "Belorusskaya", "PIM", "ABC", 223366441, 3, 1));
                    studList.Add(new Student("Ivanov", "Ivan", "Ivanovich", "10.01.2002", "Belorusskaya", "XTIT", "BBB", 123456789, 2, 6));
                    studList.Add(new Student("Glushenya", "Polina", "Andreevna", "11.03.2004", "Belorusskaya", "FIT", "POIT", 445583119, 2, 4));
                    studList.Add(new Student("Viktorovich", "Irina", "Sergeevna", "13.03.2004", "Belorusskaya", "FIT", "POIT", 293366992, 2, 4));
                    studList.Add(new Student("Vortnitskiy", "Vovan", "Igorevich", "06.10.2004", "Belorusskaya", "XTIT", "BBB", 987456321, 2, 6));
                    studList.Add(new Student("Nekhayonak", "Artyom", "Olegovich", "23.09.2003", "Belorusskaya", "FIT", "POIT", 332659897, 2, 4));
                    studList.Add(new Student("Panchuk", "Ilya", "Eduardovich", "12.08.2004", "Belorusskaya", "FIT", "POIT", 291590073, 2, 6));
                    studList.Add(new Student("Shylov", "Arseniy", "Igorevich", "29.06.2004", "Belorusskaya", "FIT", "POIT", 293366998, 2, 6));

                    //список студентов по алфавиту
                    Console.WriteLine("Введите специальность");
                    string userSpec = Console.ReadLine();
                    foreach (var temp in studList.Where(a => a.Speciality == userSpec).OrderBy(a => a.Surname[0])) Console.WriteLine(temp.Surname);
                    

                    //список группы и факудьтета
                    Console.WriteLine("\nВведите группу и факультет");
                    int userGr = Convert.ToInt32(Console.ReadLine());
                    string userFak = Console.ReadLine();
                    foreach (var temp in studList.Where(a => a.Group == userGr && a.Faculty == userFak)) Console.WriteLine(temp.Surname);

                    //самого молодого студента
                    Console.WriteLine("\nСортировка по году");
                    foreach (var temp in studList.OrderBy(a => Convert.ToInt32(a.BbirthDay.Substring(6, 4)))) Console.WriteLine(temp.Surname);

                    //
                    Console.WriteLine("Введите группу");
                    int UserSur = Convert.ToInt32(Console.ReadLine());
                    int sum = 0;
                    foreach (var temp in from s in studList
                                      where UserSur == s.Group
                                      orderby s.Surname
                                      select s)
                    {
                        sum++;
                        Console.WriteLine(temp.Surname);
                    }
                    Console.WriteLine($"Количество студентов {sum}");


                    //
                    Console.WriteLine("Введите имя");
                    string userName = Console.ReadLine();
                    var stud = studList.First(a => a.Name == userName);
                    Console.WriteLine(stud.Surname);
                    break;

                case 4:
                    //свой запрос
                    List<Student> studList2 = new List<Student>();
                    studList2.Add(new Student("Gemza", "Alexandr", "Ivanovich", "01.09.2004", "Belorusskaya", "FIT", "POIT", 123456789, 1, 1));
                    studList2.Add(new Student("Gomza", "Alexandr", "Ivanovich", "15.10.2003", "Belorusskaya", "FIT", "ISIT", 123456789, 1, 3));
                    studList2.Add(new Student("Petrova", "Anna", "Sergeevna", "23.06.2001", "Belorusskaya", "PIM", "ABC", 223366441, 3, 1));
                    studList2.Add(new Student("Ivanov", "Ivan", "Ivanovich", "10.01.2002", "Belorusskaya", "XTIT", "BBB", 123456789, 2, 6));
                    studList2.Add(new Student("Glushenya", "Polina", "Andreevna", "11.03.2004", "Belorusskaya", "FIT", "POIT", 445583119, 2, 4));
                    studList2.Add(new Student("Viktorovich", "Irina", "Sergeevna", "13.03.2004", "Belorusskaya", "FIT", "POIT", 293366992, 2, 4));
                    studList2.Add(new Student("Vortnitskiy", "Vovan", "Igorevich", "06.10.2004", "Belorusskaya", "XTIT", "BBB", 987456321, 2, 6));
                    studList2.Add(new Student("Nekhayonak", "Artyom", "Olegovich", "23.09.2003", "Belorusskaya", "FIT", "POIT", 332659897, 2, 4));
                    studList2.Add(new Student("Panchuk", "Ilya", "Eduardovich", "12.08.2004", "Belorusskaya", "FIT", "POIT", 291590073, 2, 6));
                    studList2.Add(new Student("Shylov", "Arseniy", "Igorevich", "29.06.2004", "Belorusskaya", "FIT", "POIT", 293366998, 2, 6));

                    int strsNum = studList2.OrderBy(str => str.Surname).Where(str => str.Faculty == "FIT").Skip(2).GroupBy(str => str.Group == 4).Count();
                    Console.WriteLine(strsNum);
                    break;

                case 5:
                    List<Student> studList3 = new List<Student>();
                    studList3.Add(new Student("Gemza", "Alexandr", "Ivanovich", "01.09.2004", "Belorusskaya", "FIT", "POIT", 123456789, 1, 1));
                    studList3.Add(new Student("Gomza", "Alexandr", "Ivanovich", "15.10.2003", "Belorusskaya", "FIT", "ISIT", 123456789, 1, 3));
                    studList3.Add(new Student("Petrova", "Anna", "Sergeevna", "23.06.2001", "Belorusskaya", "PIM", "ABC", 223366441, 3, 1));
                    studList3.Add(new Student("Ivanov", "Ivan", "Ivanovich", "10.01.2002", "Belorusskaya", "XTIT", "BBB", 123456789, 2, 6));
                    studList3.Add(new Student("Glushenya", "Polina", "Andreevna", "11.03.2004", "Belorusskaya", "FIT", "POIT", 445583119, 2, 4));
                    studList3.Add(new Student("Viktorovich", "Irina", "Sergeevna", "13.03.2004", "Belorusskaya", "FIT", "POIT", 293366992, 2, 4));
                    studList3.Add(new Student("Vortnitskiy", "Vovan", "Igorevich", "06.10.2004", "Belorusskaya", "XTIT", "BBB", 987456321, 2, 6));
                    studList3.Add(new Student("Nekhayonak", "Artyom", "Olegovich", "23.09.2003", "Belorusskaya", "FIT", "POIT", 332659897, 2, 4));
                    studList3.Add(new Student("Panchuk", "Ilya", "Eduardovich", "12.08.2004", "Belorusskaya", "FIT", "POIT", 291590073, 2, 6));
                    studList3.Add(new Student("Shylov", "Arseniy", "Igorevich", "29.06.2004", "Belorusskaya", "FIT", "POIT", 293366998, 2, 6));

                    List<Stud> studList4 = new List<Stud>();
                    studList4.Add(new Stud("FIT", "programmer"));
                    studList4.Add(new Stud("XTIT", "chemist"));
                    studList4.Add(new Stud("PIM", "hz voobshee"));

                    var union = from first in studList3
                                join sec in studList4 on first.Faculty equals sec.faculty
                                select new { surname = first.Surname, faculty = first.Faculty, speciality = sec.spec };
                    foreach(var tmp in union)
                    {
                        Console.WriteLine($"{tmp.surname} - {tmp.faculty} - {tmp.speciality}");
                    }
                    break;
            }
        }
    }
}