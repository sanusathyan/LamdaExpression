using System;

namespace LamdaExpression
{
    class LamdaFunc
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addNum = (int firstnum, int secondnum) => firstnum + secondnum;

            Func<int, int, int> subNum = (int firstnum, int secondnum) => firstnum - secondnum;

            Func<int, int, int> mulNum = (int firstnum, int secondnum) => firstnum * secondnum;

            Func<int, int, int> divNum = (int firstnum, int secondnum) => firstnum / secondnum;

            Calculator(addNum, 50, 10);
            Calculator(subNum, 50, 10);
            Calculator(mulNum, 50, 10);
            Calculator(divNum, 50, 10);        
        }

        static void Calculator(Func<int, int, int> cal, int firstnum, int secondnum)
        {
            Console.WriteLine(cal(firstnum,secondnum));
        }
    }
    
}
