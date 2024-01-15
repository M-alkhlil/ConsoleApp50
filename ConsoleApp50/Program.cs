using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.program
{
    internal class Program
    {
        public class Car1
        {
            public string color1 = "Red";
        }
        public class Car2
        {
            public string color2 = "Blue";
        }
        static void Main(string[] args)
        {
            Car1 obj = new Car1();
            Car2 obj2 = new Car2();
            Console.WriteLine(obj.color1);
            Console.WriteLine(obj2.color2);

        }

    }
}
