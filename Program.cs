using System;
using System.Reflection;

namespace AssemblyReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the assembly path: ");
            string assemblyPath = Console.ReadLine();

            Assembly assembly = Assembly.LoadFrom(assemblyPath);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Class: " + type.Name);

                MethodInfo[] methods = type.GetMethods();

                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("\tMethod: " + method.Name);
                    Console.WriteLine("\t\tReturn Type: " + method.ReturnType.Name);
                    Console.WriteLine("\t\tArguments:");

                    ParameterInfo[] parameters = method.GetParameters();

                    foreach (ParameterInfo parameter in parameters)
                    {
                        Console.WriteLine("\t\t\t" + parameter.ParameterType.Name + " " + parameter.Name);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
