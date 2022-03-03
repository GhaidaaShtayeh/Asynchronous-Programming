using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    public class Route
    {
        public List <Router> routers = new();
        bool exitLoop = false;
        public void ReadInput()
        {
            Console.WriteLine(" \n Please enter data Input If u enter 0 u will stop the process : \n ");
            for (int i = 0; !exitLoop ; i++)
            {
                Router router = new();
                router.RouterValue = Convert.ToInt32(Console.ReadLine());
                if (router.RouterValue == 0)
                {
                    exitLoop = true;
                    break;
                }
                routers.Add(router);
                
            }
        }
        public void OutPut()
        {
            Console.WriteLine("out put : \n");
            for (int i = 0; i < routers.Count; i++)
            {
                Console.WriteLine(routers[i].RouterValue);
            }
        }
        public int count()
        {
            return routers.Count;
        }
        public int sum(List<Router> _routers)
        {
            int sum = 0;
            for (int i = 0; i < routers.Count; i++)
                sum += _routers[i].RouterValue;
            return sum;
        }
    }

   
}
