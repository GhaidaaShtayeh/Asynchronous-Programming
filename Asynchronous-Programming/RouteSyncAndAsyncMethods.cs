using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    public class RouteSyncAndAsyncMethods
    {
        static int CalculateRouter(Route route)
        {
            int total = route.sum(route.routers);
            return total;
        }

        public int SyncBestRoute(List<Route> Routes)
        {
            List<int> RoutesTotal = new();
            foreach (var route in Routes)
            {
                RoutesTotal.Add(CalculateRouter(route));
            }
            int index = RoutesTotal.FindIndex(a => RoutesTotal.Contains(RoutesTotal.Min()));
           Console.WriteLine(RoutesTotal.Min());
            Console.WriteLine(index+1);
            return index;
        }

      /*   public static async Task <int> AsyncBestRoute(List<Route> Routes)
        {
            var tasks = new List<Task<int>>();
            foreach (var route in Routes)
            {
                tasks.Add(Task.Run(() => CalculateRouter(route)));
            }
            int[] results = await Task.WhenAll(tasks);
            int minValue = results.Min();
            Console.WriteLine(minValue);
            return await Task.FromResult(minValue);
        }*/

        public static int BestRoute(List<Route> Routes)
        {
            int x = Routes.AsParallel()
                .WithDegreeOfParallelism(4)
                .Select(route => CalculateRouter(route))
                .Min();
            return x;

        }
        public static async Task<int> AsyncBestRoute(List<Route> Routes)
        {
            var minValue = await Task.Run(() => BestRoute(Routes));
            return minValue;
        }

    }
}
