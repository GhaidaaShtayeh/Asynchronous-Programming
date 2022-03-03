using System;

namespace Asynchronous_Programming
{
    class OparitionCalling
    {
        static async Task Main(string[] args)
        {
            // Varibels needed :
            List<Route> Routes = new List<Route>();
            int num, pos;
            bool exitLoop = false;
            RouterMenu routerMenu = new();
            int SelectOpt = 0;
            RouterOperation op = new();
            RouteSyncAndAsyncMethods routeSyncAndAsyncMethods = new();

            // menu and operations runs :
            while (!exitLoop)
            {
                SelectOpt = routerMenu.MenuSelection();
                if (SelectOpt == 1)
                {
                    Routes.Add(op.CreatRoute());
                    Routes[^1].ReadInput();
                    Routes[^1].OutPut();
                }
                else if (SelectOpt == 2)
                {
                    Console.WriteLine("please enter the num u wanna add  : ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter the pos of route: ");
                    pos = Convert.ToInt32(Console.ReadLine());
                    op.AddRouter(pos, num, Routes);

                }
                else if (SelectOpt == 3)
                {
                    exitLoop = true;
                }
                else
                {
                    Console.WriteLine(" \n Invalid Input \n");
                }
            }
            Console.WriteLine("thank u for using our program the results are : \n ");
            var x = routeSyncAndAsyncMethods.SyncBestRoute(Routes);
            var b = RouteSyncAndAsyncMethods.AsyncBestRoute(Routes);
            Console.WriteLine("Best route is : ");
            Console.WriteLine(x);
            Console.WriteLine(b);





        }
    }
}
