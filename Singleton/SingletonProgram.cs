using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class SingletonProgram
    {
        public static void CallSingletonProgram()
        {
            /*
             * Assuming Singleton is created from employee class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee1");
            /*
             * Assuming Singleton is created from student class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student1");

            // Singleton.DerivedSingleton derived = new Singleton.DerivedSingleton();
            // derived.PrintDetails("Derived Singleton");

            Console.ReadLine();
        }
    }
}
