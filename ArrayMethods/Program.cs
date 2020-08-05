using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesL =
            { "quick", "fox", "the" , "lazy"};
            LinkedList<string> lList = new LinkedList<string>(namesL);

            foreach (string str in lList)
            {
                Console.WriteLine(str);
            }

            // add first method 
            lList.AddFirst("jombo");
            Console.WriteLine("added a new node in first");
            foreach (string str in lList)
            {
                Console.WriteLine(str);
            }

           var newnode = lList.AddLast("dumbo");
            Console.WriteLine("added a new node in last");
            foreach (string str in lList)
            {
                Console.WriteLine(str);
            }

            lList.AddAfter(newnode ,"zenbra");
            Console.WriteLine("add after using");
            foreach (string str in lList)
            {
                Console.WriteLine(str);
            }

            lList.AddBefore(newnode, "kabra");
            Console.WriteLine("add addbefore using");
            foreach (string str in lList)
            {
                Console.WriteLine(str);
            }

          var temp = lList.Find("fox");
            Console.WriteLine("find using" );
            Console.WriteLine(temp.Value);

            var temp1 = lList.FindLast("lazy");
            Console.WriteLine("findLast using");
            Console.WriteLine(temp1.Value);




        }
}
}
