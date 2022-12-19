using System.Reflection;

namespace Lab11
{
    static class A
    {
        //public void Anum() { }
        public static void Byes(int i) { }

        //public A() { }

        static private int firstpub = 0;
        static public int secondpr = 0;

        static public string Third { get; set; }
        static private string Fourth { get; set; }

    }
    class FlowerInvoke
    {
        //public void Anum() { }
        public void WriteFlower(List<string> list)
        {
            foreach (var flower in list)
            {
                Console.WriteLine(flower);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            
            Assembly assembly = Assembly.LoadFrom(@"D:\Универ\2курс\OOP_3sem\Lab04\Lab04\bin\Debug\netcoreapp3.1\Lab04.dll");
            Console.WriteLine(assembly.FullName);
            foreach (Module module in assembly.GetModules())
            {
                Console.WriteLine(module.FullyQualifiedName);
                foreach (Type type in module.GetTypes())
                {
                    Console.WriteLine(type.FullName);
                }
            }
            

            Reflector.ExploreClass("Lab11.Flower");
            Reflector.ExploreClass("Lab11.Employees");

            Console.WriteLine("\nТест метода Invoke:\n");
            Reflector.Invoke("Lab11.FlowerInvoke", "WriteFlower");

            Console.WriteLine("\nТест метода Create:\n");

            object obj = Reflector.Create("Lab11.Flower");
            Console.WriteLine(obj);
        }
    }
}