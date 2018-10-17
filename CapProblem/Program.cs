using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//上传github

namespace CapProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int dollar = 100;//初始有10元
            int price = 2;//每瓶啤酒2元
            int sum = 0;//瓶数

            sum += dollar / price;

            int capNum = sum;
            int emptyBottleNum = sum;


            while (capNum > 3 || emptyBottleNum > 1)
            {
                int tempNum = 0;
                if(capNum/4>0)
                {
                    tempNum += capNum / 4;
                    capNum = capNum % 4;
                }
                if (emptyBottleNum/2 > 0)
                {
                    tempNum += emptyBottleNum / 2;
                    emptyBottleNum = emptyBottleNum % 2;
                }
                sum += tempNum;
                capNum += tempNum;
                emptyBottleNum += tempNum;

            }

            Console.WriteLine("sum:{0}",sum);
            Console.WriteLine("capNum:{0}",capNum);
            Console.WriteLine("emptyBottleNum:{0}",emptyBottleNum);

            Console.ReadKey();
        }
    }
}
