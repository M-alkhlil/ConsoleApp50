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
        public class Car3
        {
            public string color3 = "Black";
        }
        static void Main(string[] args)
        {
            Car1 obj = new Car1();
            Car2 obj2 = new Car2();
            Car3 obj3 = new Car3();

            Console.WriteLine(obj.color1);
            Console.WriteLine(obj2.color2);
            Console.WriteLine(obj3.color3);

        }

    }
}
