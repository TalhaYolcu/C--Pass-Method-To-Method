using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMethodToMethod
{
    public class MyGenericMethod
    {
        public delegate int TakeSquareIntMethodDelegate(int number);
        public delegate double TakeSquareDoubleMethodDelegate(double number);

        public int RunTakeSquareInt(int number)
        {
            return _takeSquareIntTakesMethod(_takeSquareInt, number);
        }

        private int _takeSquareInt(int number)
        {
            return number*number;
        }

        private int _takeSquareIntTakesMethod(TakeSquareIntMethodDelegate takeSquareIntMethod, int number)
        {
            return takeSquareIntMethod(number);
        }

        public double RunTakeSquareDouble(double number)
        {
            return _takeSquareDoubleTakesMethod(_takeSquareDouble, number);
        }

        private double _takeSquareDouble(double number)
        {
            return number * number;
        }

        private double _takeSquareDoubleTakesMethod(TakeSquareDoubleMethodDelegate takeSquareDoubleMethod, double number)
        {
            return takeSquareDoubleMethod(number);
        }


    }
}
