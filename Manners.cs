using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_2
{
    class Manners
    {
          string step;
          string a, b;
          public void manners()
          {
               Console.WriteLine("请输入两个整数");
               try
               {
                   a = Console.ReadLine();
                   b = Console.ReadLine();
                   Console.WriteLine("请输入要执行的操作+ - * /");
                   step = Console.ReadLine();
                   switch (step)
                   {
                       case "+":
                           {
                               Add();
                               break;
                           }
                       case "-":
                           {
                               Subtraction();
                               break;
                           }
                       case "*":
                           {
                               Multiplication();
                               break;
                           }
                       case "/":
                           {
                               Division();
                               break;
                           }
                   }
               }
               catch
               {
                   Console.WriteLine("发生异常，请重启程序");
               }
          }
          private void Add()
          {
              bool flag=false;
              for (int i = 0; i < a.Length; i++)
              {
                  if (a[i] < 48 || a[i] > 57)
                      flag = true;
              }
              if (flag)
                  Console.WriteLine("{0}+{1}={2}",a,b,a+b);
             else
              {
                  float c = float.Parse(a);
                  float d = float.Parse(b);
                  Console.WriteLine("{0}+{1}={2}", a, b, c + d);
              }
          }
          private void Subtraction()
          {
             bool flag = false;
              for (int i = 0; i < a.Length; i++)
              {
                  if (a[i] < 48 || a[i] > 57)
                      flag = true;
              }
              if (flag == true)
              {
                  string c="";
                  for (int i = 0; i < a.Length; i++)
                  {
                      if (a[i] == b[0])
                      {
                          for (int j = 0; j < a.Length - b.Length; j++)
                          {
                              if(j<i)
                                 c += a[j];
                          }
                          for (int k = i + b.Length; k < a.Length; k++)
                          {
                              c += a[k];
                          }
                      }
                  }
                  Console.WriteLine("{0}-{1}={2}", a, b, c);
              }
              else
              {
                  float c = float.Parse(a);
                  float d = float.Parse(b);
                  Console.WriteLine("{0}-{1}={2}", a, b, c - d);
              }
          }
          private void Multiplication()
          {
              float c = float.Parse(a);
              float d = float.Parse(b);
              Console.WriteLine("{0}*{1}={2}", a, b, c*d);
          }
          private void Division()
          {
              float c = float.Parse(a);
              float d = float.Parse(b);
              Console.WriteLine("{0}/{1}={2}", a, b, c/d);
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
