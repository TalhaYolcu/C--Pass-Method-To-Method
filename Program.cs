using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMethodToMethod
{
    public class Program
    {

        public enum ResultEnum
        {
            SUCCESS,
            FAILURE,
        }


        static void Main(string[] args)
        {
            MyGenericMethod myGenericMethod = new MyGenericMethod();
            int x = 0, y = 1, z = 2;
            string str1 = "str1", str2 = "str2", str3 = "str3";
            double d1 = 0.5, d2 = 1.5, d3 = 2.5;

            Console.WriteLine(myGenericMethod.RunTakeSquareInt(x));
            Console.WriteLine(myGenericMethod.RunTakeSquareDouble(d3));


            Console.ReadLine();
        }
    }
}
