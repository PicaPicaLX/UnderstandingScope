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

            Car myCar = new Car();
            myCar.DoSomething(); // 在不同的类中，只能相互调用公共方法，这里就是DoSomething()方法

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }

    // 下面讨论关键字 public 和 private 的区别
    class Car
    {
        public void DoSomething() // 自定义公共方法DoSomething()
        {
            Console.WriteLine(HelperMethod()); // 在同一个Car类中，不同的方法间可以相互调用，即使是private方法
        }

        private string HelperMethod() // 自定义私有方法HelperMethod()
        {
            return "Hello World!";
        }
    } 
    /* 应着重掌握公共方法的使用，尽量使自定义公共方法能够被使用者简单、直接地被调用
     * 为了防止你的方法以你不愿看到方式使用，私有方法应尽量隐藏，避免使用者修改或使用私有方法
     * 除了 public 和 private 外，还有 protected 和 internal 修饰符
     */

}
