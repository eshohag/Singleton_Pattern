using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class SingleObject
    {
        //create an object of SingleObject
        private static SingleObject instance = new SingleObject();

        //Get the only object available
        public static SingleObject GetInstance()
        {
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!-" + DateTime.Now.ToString());
        }
    }
}
