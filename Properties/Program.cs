using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box box = new Box();
            //box.SetLenght(3);
            //box.Height = 4;
            //box.Width = 5;

            Box box = new Box(4,5,3);

            Console.WriteLine("Box lenght is {0}", box.GetLenght());
            Console.WriteLine("Box Volume is {0}", box.Volume);
            Console.WriteLine("Box FrontSurface is {0}", box.FrontSurface);
            box.DisplayInfo();

        }
    }
}
