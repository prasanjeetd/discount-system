using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams
{
    public class Node
    {
        public int city { get; set; }

        public bool isTemple { get; set; }

        public List<Node> routes { get; set; }

        public Node(int city)
        {
            this.city = city;
            this.isTemple = false;
            routes = new List<Node>();
        }

    }

    public class Setu
    {
        public static void Solution()
        {
            var line1 = Console.ReadLine();
            //Console.WriteLine("line1:" + line1);

            string[] inp1 = line1.Split(" ");

            int cities = Convert.ToInt32(inp1[0]);
            int temples = Convert.ToInt32(inp1[1]);

            Dictionary<int, Node> routes = new Dictionary<int, Node>();

            for (int i = 0; i < cities - 1; i++)
            {
                var line2 = Console.ReadLine();
                //Console.WriteLine("line2:" + line2);

                string[] inp2 = line2.Split(" ");
                int cityFrom = Convert.ToInt32(inp2[0]);
                int cityTo = Convert.ToInt32(inp2[1]);

                Node cityF;
                Node cityT;

                if (routes.ContainsKey(cityFrom))
                {
                    cityF = routes[cityFrom];
                }
                else
                {
                    cityF = new Node(cityFrom);
                    routes.Add(cityFrom, cityF);
                }

                if (routes.ContainsKey(cityTo))
                {
                    cityT = routes[cityTo];
                }
                else
                {
                    cityT = new Node(cityTo);
                    routes.Add(cityTo, cityT);
                }

                //MapRoute
                cityF.routes.Add(cityT);

            }

            var line3 = Console.ReadLine();
            //Console.WriteLine("line2:" + line3);
            string[] templeCities = line3.Split(" ");

            foreach (var tc in templeCities)
            {
                int city = Convert.ToInt32(tc);
                if (routes.ContainsKey(city))
                {
                    Node tCity = routes[city];
                    tCity.isTemple = true;
                }
            }

            int visit = Travel(routes[1]);

            //Console.WriteLine("Visit:" + visit);
            Console.WriteLine(visit);
        }

        public static int Travel(Node city, int visit = 0)
        {

            //Console.WriteLine("First City:" + city.city);
            //Console.WriteLine("First City:" + city.routes.Count);
            //Console.WriteLine("First City:" + city.isTemple);

            foreach (var cityT in city.routes)
            {
                if (!cityT.isTemple)
                {
                    visit++;
                    visit = Travel(cityT, visit);
                }
            }

            return visit;
        }
    }
}
