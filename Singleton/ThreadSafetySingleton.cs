using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     *  Sealed restricts the inheritance
     */
    public sealed class ThreadSafetySingleton
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private ThreadSafetySingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static ThreadSafetySingleton? instance = null;
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static ThreadSafetySingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new ThreadSafetySingleton();
                    }
                }
                return instance;
            }
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}