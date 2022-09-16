using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OverLoading
    {
       public int Addition(int num1,int num2)
        {
            return num1 + num2;
        }
        public int Addition(int num1,int num2,int num3)
        {
            return (num1 + num2 + num3);
        }
        public double Addition(int num1,double num2)
        {
            return num1 + num2;
        }
        public double Addition(double num1,double num2)
        {
            return num1 + num2;
        }


    }
    public class Calculation
    {
        static void Main(string[] args)
        {
            OverLoading C1=new OverLoading();
            Console.WriteLine(C1.Addition(10,20));
            Console.WriteLine(C1.Addition(20,30.5));
            Console.WriteLine(C1.Addition(10,30,40));
        }
    }
}
