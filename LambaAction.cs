using System;

namespace LambaAction
{
    class LambaAction
    {
        static void Main(string[] args)
        {
            Action<int, int> addNum = (int firstnum, int secondnum) =>
            Console.WriteLine(firstnum + secondnum);

            Action<int, int> subNum = (int firstnum, int secondnum) =>
            Console.WriteLine(firstnum - secondnum);

            Action<int, int> mulNum = (int firstnum, int secondnum) =>
            Console.WriteLine(firstnum * secondnum);

            Action<int, int> divNum = (int firstnum, int secondnum) =>
            Console.WriteLine(firstnum / secondnum);

            calculator(addNum += subNum += mulNum += divNum, 50, 10);
        }

        static void calculator(Action<int,int> cal,int firstnum, int secondnum)
        {
            cal(firstnum, secondnum);
        }
    }
}
