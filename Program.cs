using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manners m = new Manners();
            try
            {
                switch (m.input())
                {
                    case "+":
                        {
                            m.add();
                            break;
                        }
                    case "-":
                        {
                            m.subtraction();
                            break;
                        }
                    case "*":
                        {
                            m.multiplication();
                            break;
                        }
                    case "/":
                        {
                            m.division();
                            break;
                        }
                }
                m.Equals();
            }
            catch
            {
                Console.WriteLine("发生异常，请重启程序");
            }            
        }
    }
}
