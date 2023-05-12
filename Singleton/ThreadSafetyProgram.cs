using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class ThreadSafetyProgram
    {
        public static void CallThreadSafetyProgram()
        {
            Parallel.Invoke(
                () => PrintStudentdetails(),
                () => PrintEmployeeDetails()
                );
            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            /*
             * Assuming Singleton is created from employee class
             * we refer to the GetInstance property from the Singleton class
             */
            ThreadSafetySingleton fromEmployee = ThreadSafetySingleton.GetInstance;
            fromEmployee.PrintDetails("From Employee2");
        }

        private static void PrintStudentdetails()
        {
            /*
            * Assuming Singleton is created from student class
            * we refer to the GetInstance property from the Singleton class
            */
            ThreadSafetySingleton fromStudent = ThreadSafetySingleton.GetInstance;
            fromStudent.PrintDetails("From Student2");
        }
    }
}