using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     *  Sealed ensures the class being inherited and
     *  object instantiation is restricted in the derived class
     */
    public sealed class Singleton
    {
        private static int counter = 0;

        /*
         * Private property initilized with null
         * ensures that only one instance of the object is created
         * based on the null condition
         */
        private static Singleton? instance = null;

        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        /*
        * Sealed class will prevent to inheritant class. 
        * If you are not using sealed class then you are able to create derived class and 
        * with the use of this class you can create multiple instances. 
        * hence it will violate the singleton rule.
        */
        // public class DerivedSingleton : Singleton
        // {
        // }
    }
}