using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicassigmentsolve
{
    public class leapyear
    {

        public static void checkyear()
        {
                int check_year;
                Console.Write("\n\n");
                Console.Write("Check whether a given year is leap year or not:\n");
                Console.Write("Input an year : ");
                check_year = Convert.ToInt32(Console.ReadLine());
                if ((check_year % 400) == 0)
                    Console.WriteLine("{0} is a leap year.\n", check_year);
                else
                    Console.WriteLine("{0} is not a leap year.\n", check_year);


            }
        }

    }






