using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    public class RouterMenu
    {
        public int MenuSelection()
        {

            Console.WriteLine(" \n \n   -------- MENU --------   \n \n");
            Console.WriteLine("     1: Create a new route      ");
            Console.WriteLine("     2: Add a router to given route      ");
            Console.WriteLine("     3: Exit      ");
            int opt = Convert.ToInt32(Console.ReadLine());
            return opt;


        }
    }
}
