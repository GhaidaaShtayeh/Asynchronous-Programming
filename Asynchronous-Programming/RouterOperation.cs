using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    public class RouterOperation
    {        
        public Route CreatRoute()
        {
            return new Route();
        }

        public Route AddRouter(int pos , int routerr , List <Route> Routes)
        {
            if (pos < 0 || pos > Routes.Count)
            {
                    Console.WriteLine(" \n Invalid input \n ");
                return null;
            }
            else
            {
                Routes[pos].routers[^1].RouterValue = routerr;
                return Routes[pos];
            }
             
        }

    }
}
