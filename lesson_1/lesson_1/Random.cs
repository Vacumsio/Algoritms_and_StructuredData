using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    public class Randomizer
    {
        public static int Randomize()
        {
            Random rand = new Random();
            int r;
            r = rand.Next(100);
            return r;
        }
        public static int RandomizeHandler()
        {
            string s = DateTime.Now.ToString("ff");
            int r;
            var x = int.TryParse(s, out r);
            return r;
        }
    }
}
