using System;

namespace Lines
{
    public struct point
    {
        public int x, y;
    };

    public class Program
    {
        static public int orientation(point p, point q, point r)
        {
            int val = (q.y - p.y) * (r.x - q.x) - (r.y - q.y) * (q.x - p.x);
            if (val != 0)
            {
                return (val > 0) ? 1 : 2;//1: clockwise, 2: anti-clockwise
            }
            return 0;
        }

        static public int doIntersect(point a, point b, point c, point d)
        {
            if (((b.y - a.y) / (b.x - a.x)) != ((d.y - c.y) / (d.x - c.x)))
            {
                if ((orientation(a, b, c) != orientation(a, b, d)) && (orientation(c, d, a) != orientation(c, d, b)))
                {
                    return 1;
                }
            }
            return 0;
        }

        static public int Main()
        {

            int n = int.Parse(Console.ReadLine());// accept the # of test cases
            int[] result = new int[300];

            for (int i = 0; i < n; i++)

            {
                point a, b, c, d;
                // read the coordinates of first point in (x,y) format
                var line1 = Console.ReadLine();
                var numbers1 = line1.Split(' ');
                a.x = int.Parse(numbers1[0]);
                a.y = int.Parse(numbers1[1]);
                b.x = int.Parse(numbers1[2]);
                b.y = int.Parse(numbers1[3]);
                // read the coordinates of second point in (x,y) format
                var line2 = Console.ReadLine();
                var numbers2 = line2.Split(' ');
                c.x = int.Parse(numbers2[0]);
                c.y = int.Parse(numbers2[1]);
                d.x = int.Parse(numbers2[2]);
                d.y = int.Parse(numbers2[3]);

                result[i]=doIntersect(a, b, c, d); // validation
            }

            for(int i = 0; i < n; i++) //display consolidated results
            {
                Console.WriteLine(result[i]);
            }
           
            return 0;
        }
        

    }
}
