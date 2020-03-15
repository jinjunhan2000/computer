using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_2
{
    class Manners
    {
          float a, b;
          public string input()
          {
              string step;
              Console.WriteLine("请输入两个整数");
              a = int.Parse(Console.ReadLine());
              b = int.Parse(Console.ReadLine());
              Console.WriteLine("请输入要执行的操作+ - * /");
              step = Console.ReadLine();
              return step;
          }
          public void add()
          {
              Console.WriteLine("{0}+{1}={2}", a, b, a + b);
          }
          public void subtraction()
          {
              Console.WriteLine("{0}-{1}={2}", a, b, a - b);
          }
          public void multiplication()
          {
              Console.WriteLine("{0}*{1}={2}", a, b, a * b);
          }
          public void division()
          {
              Console.WriteLine("{0}/{1}={2}", a, b, a / b);
          }
          public void  Equals() //重载equals
          {
              if (a == b)
                  Console.WriteLine("a=b");
              else
                  Console.WriteLine("a!=b");
          }
               
    }
}
