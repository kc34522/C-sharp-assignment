using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 設定輸出編碼為 UTF-8

            // 1-1 寫一程式，輸入a,b,c,d，計算((𝑎+𝑏))/((𝑐−𝑑))×2。
            Console.Write("請輸入整數a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數d:");
            int d = Convert.ToInt32(Console.ReadLine());
            double result = (((double)(a + b) / (c - d)) * 2);
            if (c - d == 0)
            {
                Console.WriteLine("c-d不得為0");
            }
            else
            {
                Console.WriteLine(result);
            }

            //1 - 2 寫一程式，輸入一組二元一次方程式之係數，輸出方程式的解。
            Console.Write("請輸入整數a1:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數b1:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數c1:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數a2:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數b2:");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數c2:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            double x = (double)(c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
            double y = (double)(c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            //1-3 輸入a和b，求： 
            Console.Write("請輸入整數a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數b:");
            int b = Convert.ToInt32(Console.ReadLine());

            double y = (Double)(Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));
            Console.WriteLine($"y = {y}");

            // 1-4 輸入a和b，求
            Console.Write("請輸入整數a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數b:");
            int b = Convert.ToInt32(Console.ReadLine());

            double y = (Double)Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine($"y = {y}");

            // 1-5 輸入a、b和c，求：y = a - (b + c)(3a - c)

            Console.Write("請輸入整數a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數c:");
            int c = Convert.ToInt32(Console.ReadLine());
            double y = (Double)a - (b + c) * (3 * a - c);
            Console.WriteLine($"y = {y}");

            // 1-6 請隨意輸入正負數，取絕對值輸出
            Console.Write("請輸入正負數:");
            double a = Convert.ToDouble(Console.ReadLine());
            double result = Math.Abs(a);
            Console.WriteLine($"result = {result}");

            // 1 - 7 輸入的西元年份轉換成民國年份後輸出
            Console.Write("請輸入西元年份:");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = a - 1911;
            Console.WriteLine($"西元{a}年 = 民國{result}年");

            //1 - 8 請輸入身高體重，輸出BMI
            Console.Write("請輸入身高(公分):");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("請輸入體重(公斤):");
            double weight = Convert.ToDouble(Console.ReadLine());
            double result = weight / Math.Pow((height / 100), 2);
            Console.WriteLine($"BMI = {result}");

            //2 - 1.寫一程式，輸入x和y，如果x >= y，則列印x，否則列印y
            Console.Write("請輸入整數x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數y:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= y)
            {
                Console.WriteLine($"result = {x}");
            }
            else
            {
                Console.WriteLine($"result = {y}");
            }

            // 2 - 2.寫一程式，輸入x和y，如果x和y都是正數，令z = 1，如兩者均為負數，令z = -1，否則令z = 0
            Console.Write("請輸入整數x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數y:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z;


            if (x > 0 && y > 0)
            {
                z = 1;
            }
            else if (x < 0 && y < 0)
            {
                z = -1;
            }
            else
            {
                z = 0;
            }

            Console.WriteLine($"z = {z}");


            // 2 - 3.寫一程式，輸入x、y、u、v，如果(x + y) > (u + v)，則令z = x + y，否則令z = u + v
            Console.Write("請輸入整數x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數u:");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數v:");
            int v = Convert.ToInt32(Console.ReadLine());
            int z;

            if ((x + y) > (u + v))
            {
                z = x + y;
            }
            else
            {
                z = u + v;
            }

            Console.WriteLine($"z = {z}");

            // 2-4
            Console.Write("請輸入整數x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數u:");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數v:");
            int v = Convert.ToInt32(Console.ReadLine());
            int z;

            if ((x + y) / (u + v) >= 2)
            {
                z = x + y;
            }
            else
            {
                z = u + v;
            }

            Console.WriteLine($"z = {z}");

            // 2-5 寫一程式，輸入x和y，如果x>=y，令z=x2，否則令z=y2
            Console.Write("請輸入整數x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數y:");
            int y = Convert.ToInt32(Console.ReadLine());
            double z;

            if (x >= y)
            {
                z = Math.Pow(x, 2);
            }
            else
            {
                z = Math.Pow(y, 2);
            }

            Console.WriteLine($"z = {z}");

            // 2 - 6.依照以下的流程圖，寫一程式。
            Console.Write("請輸入income:");
            int income = Convert.ToInt32(Console.ReadLine());
            double rate;
            int difference;
            double tax;

            if (income > 4090000)
            {
                rate = 0.4;
                difference = 721100;
            }
            else if (income > 2180000)
            {
                rate = 0.3;
                difference = 312100;
            }
            else if (income > 1090000)
            {
                rate = 0.21;
                difference = 115900;
            }
            else if (income > 410000)
            {
                rate = 0.13;
                difference = 28700;
            }
            else
            {
                rate = 0.06;
                difference = 0;
            }

            tax = (income * rate) - difference;

            Console.WriteLine($"tax = {tax}");

            // 2 - 7.流程圖
            Console.Write("請輸入整數x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入整數y:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine($"({x},{y})");
                }
                else if (y == 0)
                {
                    Console.WriteLine($"({x},0)");
                }
                else
                {
                    Console.WriteLine($"({x},{y})");
                }
            }
            else if (x == 0)
            {
                if (y == 0)
                {
                    Console.WriteLine($"(0,0)");
                }
                else
                {
                    Console.WriteLine($"(0,{y})");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine($"({x},{y})");
                }
                else if (y == 0)
                {
                    Console.WriteLine($"({x},0)");
                }
                else
                {
                    Console.WriteLine($"({x},{y})");
                }
            }

            // Ch2增加一題：使用switch改寫：輸入一個學生的分數，輸出該成績級別
            Console.Write("請輸入分數:");
            int score = Convert.ToInt32(Console.ReadLine());

            switch (score / 10)
            {
                case 10:
                case 9:

                    Console.WriteLine("grade = A");

                    break;
                case 8:

                    Console.WriteLine("grade = B");

                    break;
                case 7:

                    Console.WriteLine("grade = C");

                    break;
                case 6:

                    Console.WriteLine("grade = D");

                    break;
                default:
                    Console.WriteLine("grade = F");
                    break;
            }

            /*補充習題1.Eason 是一位高中電腦老師，這學期正在教學生寫C++程式。他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，去計算出對應的得分。規則如下：
                答對題數在 0~10 者，每題給6分。
                題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
                題數在 21~40 者，從第21題開始，每題給1分。
                題數在 40 以上者，一律100分。
                請輸入答對題數，輸出統計後分數 。*/

            Console.Write("請輸入答對題數:");
            int number = Convert.ToInt32(Console.ReadLine());
            int grade;


            if (number > 40)
            {
                Console.WriteLine("分數 : 100 分");
            }
            else if (number > 20)
            {
                grade = (number - 20) + 80;
                Console.WriteLine($"分數 : {grade} 分");
            }
            else if (number > 10)
            {
                grade = (number - 10) + 60;
                Console.WriteLine($"分數 : {grade} 分");
            }
            else
            {
                grade = number * 6;
                Console.WriteLine($"分數 : {grade} 分");
            }

            // 補充習題2.請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。
            Console.Write("請輸入身高(公分):");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("請輸入體重(公斤):");
            double weight = Convert.ToDouble(Console.ReadLine());
            double result = weight / Math.Pow((height / 100), 2);


            if (result < 18.5)
            {
                Console.WriteLine($"BMI = {result}，過輕。");
            }
            else if (result > 24)
            {
                Console.WriteLine($"BMI = {result}，過重。");
            }
            else
            {
                Console.WriteLine($"BMI = {result}，正常。");
            }

            // 補充習題3.請隨意輸入三個數，請由大到小依序印出。

            Console.WriteLine("請隨意輸入三個數");
            Console.Write("請輸入第一個數:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入第二個數:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入第三個數:");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x >= y)
            {
                if (y >= z)
                {
                    Console.WriteLine($"({x}, {y}, {z})");
                }
                else
                {
                    if (x >= z)
                    {
                        Console.WriteLine($"({x}, {z}, {y})");
                    }
                    else
                    {
                        Console.WriteLine($"({z}, {x}, {y})");
                    }
                }

            }
            else
            {
                if (x >= z)
                {
                    Console.WriteLine($"( {y} ,  {x} ,  {z} )");
                }
                else
                {
                    if (y >= z)
                    {
                        Console.WriteLine($"( {y} ,  {z} ,  {x} )");
                    }
                    else
                    {
                        Console.WriteLine($"( {z} ,  {y} ,  {x} )");
                    }
                }
            }

            // 補充習題4: 企業發放的獎金根據利潤提成。
            //利潤低於或等於10萬元時，獎金可提10 %；
            //利潤高于10萬元，低於20萬元時，低於10萬元的部分按10 % 提成，高於10萬元的部分，可提成7.5 %；
            //20萬到40萬之間時，高於20萬元的部分，可提成5 %；
            //40萬到60萬之間時高於40萬元的部分，可提成3 %；
            //60萬到100萬之間時，高於60萬元的部分，可提成1.5 %，高於100萬元時；
            //超過100萬元的部分按1 % 提成。
            //請寫一程式，輸入當月利潤，輸出發放獎金總數？

            //Console.Write("請輸入當月利潤:");
            //int profit = Convert.ToInt32(Console.ReadLine());
            //double bonus;

            //if (profit > 1000000)
            //{
            //    bonus = profit * 0.01;
            //}
            //else if (profit > 600000)
            //{
            //    bonus = 33500 + (profit - 600000) * 0.015;
            //}
            //else if (profit > 400000)
            //{
            //    bonus = 27500 + (profit - 400000) * 0.03;
            //}

            //else if (profit > 200000)
            //{
            //    bonus = 17500 + (profit - 200000) * 0.05;
            //}
            //else if (profit > 100000)
            //{
            //    bonus = 10000 + (profit - 100000) * 0.075;
            //}
            //else
            //{
            //    bonus = profit * 0.1;
            //}

            //Console.WriteLine($"獎金 : {bonus} 元");







        }
    }
}
