using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = ""; // 这里定义了私有字符型变量k，它可供此类中所有对象访问,因此只要是这个类中的方法或其他均可访问k
        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString(); // 由于j是在for代码块外部定义的，因此在for内部可以访问
                k = i.ToString();
                Console.WriteLine(i);

                if (i==9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l); // 同样的,由于l是在if内部定义的，因此在if外无法访问

            }
            //Console.WriteLine(i); // 由于i是在for、循环代码块内部定义的，因此无法在for外部使用
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);
            HelperMethod();
            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }
}
