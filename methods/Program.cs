using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var num =int.Parse("abc"); //Throws error bcoz abc can't be converted to int
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion Failed");
            }

            //TryParse is differetn because it doesnot throw Exception.
            //TryParse returns boolean result which indicates conversion is successful or not.
            int number;
            var result =int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Failed!!");


            Console.ReadLine();
        }


        static void useparams()
        {
            var calc = new calculator();
            Console.WriteLine(calc.add(1, 2));
            Console.WriteLine(calc.add(new int[] { 2, 4, 6, 8 }));
        }
        static void usepoints()
        {
            try
            {
                var point = new point(10, 20);
                point.move(null);
                Console.WriteLine("Point lies at ({0}, {1})", point.X, point.Y);

                point.move(100, 200);
                Console.WriteLine("Point lies at ({0}, {1})", point.X, point.Y);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error Occured!!!");
                //throw ex;
            }

        }
    }
}
