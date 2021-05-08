using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    public class Class1
    {
        static void Main(string[] args)
        {
            ArrayList w = new ArrayList();

            w.Add("Ashwin");
            w.Add("Menon");
            w.Add(26);
            w.Add(true);
            w.Add(32.11);

            foreach(var i in w)
            {
                Console.WriteLine(i);
            }


        }
    }
}
