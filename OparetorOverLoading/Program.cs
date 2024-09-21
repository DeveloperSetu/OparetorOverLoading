using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OparetorOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NewAdd Obj1 = new NewAdd();
            Obj1.str = " String1";
            Obj1.num1 = 60;
            Obj1.num2 = 40;

            NewAdd Obj2 = new NewAdd();
            Obj2.str = " String1";
            Obj2.num1 = 30;
            Obj2.num2 = 10;

            NewAdd obj3 = new NewAdd();
            obj3 = Obj1 + Obj2;

            NewAdd obj4 = new NewAdd();
            obj4 = Obj1 - Obj2;

            NewAdd obj5 = new NewAdd();
            obj5 = Obj1 * Obj2;

            NewAdd obj6 = new NewAdd();
            obj6 = Obj1 / Obj2;

            Console.WriteLine($"{Obj1.str} + {Obj2.str} = {obj3.str}");
            Console.WriteLine($"{Obj1.num1} + {Obj2.num1} = {obj3.num1}");
            Console.WriteLine($"{Obj1.num2} + {Obj2.num2} = {obj3.num2}");

            Console.WriteLine($"{Obj1.num1} - {Obj2.num1} = {obj4.num1}");
            Console.WriteLine($"{Obj1.num2} - {Obj2.num2} = {obj4.num2}");

            Console.WriteLine($"{Obj1.num1} * {Obj2.num1} = {obj5.num1}");
            Console.WriteLine($"{Obj1.num2} * {Obj2.num2} = {obj5.num2}");

            Console.WriteLine($"{Obj1.num1} / {Obj2.num1} = {obj6.num1}");
            Console.WriteLine($"{Obj1.num2} / {Obj2.num2} = {obj6.num2}");
            Console.ReadKey();
        }
    }



    public class NewAdd
    {
        public string str {  get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }

        public static NewAdd operator + (NewAdd obj1, NewAdd obj2)
        {
            NewAdd obj3 = new NewAdd();
            obj3.str = obj1.str + obj2.str;
            obj3.num1 = obj1.num1 + obj2.num1;
            obj3.num2 = obj1.num2 + obj2.num2;
            return obj3;
        }


        public static NewAdd operator - ( NewAdd obj1, NewAdd obj2)
        {
            NewAdd obj4 = new NewAdd();
            obj4.num1 = obj1.num1 - obj2.num1;
            obj4.num2 = obj1.num2 - obj2.num2;
            return obj4;
        }

        public static NewAdd operator * (NewAdd obj1, NewAdd obj2)
        {
            NewAdd obj5 = new NewAdd();
            obj5.num1 = obj1.num1 * obj2.num1;
            obj5.num2 = obj1.num2 * obj2.num2;
            return obj5;
        }

        public static NewAdd operator / (NewAdd obj1, NewAdd obj2)
        {
            NewAdd obj6 = new NewAdd();
            obj6.num1 = obj1.num1 / obj2.num1;
            obj6.num2 = obj1.num2 / obj2.num2;
            return obj6;
        }
    }
}
