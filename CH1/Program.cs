using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 設定輸出編碼為 UTF-8

            //// 1-1 寫一程式，輸入a,b,c,d，計算((𝑎+￿𝑏))/((𝑐−𝑑))×2。
            //Console.Write("請輸入整數a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數b:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數c:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數d:");
            //int d = Convert.ToInt32(Console.ReadLine());
            //double result = (((double)(a + b) / (c - d)) * 2);
            //if (c - d == 0)
            //{
            //    Console.WriteLine("c-d不得為0");
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}

            ////1 - 2 寫一程式，輸入一組二元一次方程式之係數，輸出方程式的解。
            //Console.Write("請輸入整數a1:");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數b1:");
            //int b1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數c1:");
            //int c1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數a2:");
            //int a2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數b2:");
            //int b2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數c2:");
            //int c2 = Convert.ToInt32(Console.ReadLine());

            //double x = (double)(c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
            //double y = (double)(c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);

            //Console.WriteLine($"x = {x}");
            //Console.WriteLine($"y = {y}");

            ////1-3 輸入a和b，求： 
            //Console.Write("請輸入整數a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數b:");
            //int b = Convert.ToInt32(Console.ReadLine());

            //double y = (Double)(Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));
            //Console.WriteLine($"y = {y}");

            //// 1-4 輸入a和b，求
            //Console.Write("請輸入整數a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數b:");
            //int b = Convert.ToInt32(Console.ReadLine());

            //double y = (Double)Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
            //Console.WriteLine($"y = {y}");

            //// 1-5 輸入a、b和c，求：y = a - (b + c)(3a - c)

            //Console.Write("請輸入整數a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數b:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數c:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //double y = (Double)a - (b + c) * (3 * a - c);
            //Console.WriteLine($"y = {y}");

            //// 1-6 請隨意輸入正負數，取絕對值輸出
            //Console.Write("請輸入正負數:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double result = Math.Abs(a);
            //Console.WriteLine($"result = {result}");

            //// 1 - 7 輸入的西元年份轉換成民國年份後輸出
            //Console.Write("請輸入西元年份:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int result = a - 1911;
            //Console.WriteLine($"西元{a}年 = 民國{result}年");

            ////1 - 8 請輸入身高體重，輸出BMI
            //Console.Write("請輸入身高(公分):");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.Write("請輸入體重(公斤):");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //double result = weight / Math.Pow((height / 100), 2);
            //Console.WriteLine($"BMI = {result}");

            ////2 - 1.寫一程式，輸入x和y，如果x >= y，則列印x，否則列印y
            //Console.Write("請輸入整數x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數y:");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x >= y)
            //{
            //    Console.WriteLine($"result = {x}");
            //}
            //else
            //{
            //    Console.WriteLine($"result = {y}");
            //}

            //// 2 - 2.寫一程式，輸入x和y，如果x和y都是正數，令z = 1，如兩者均為負數，令z = -1，否則令z = 0
            //Console.Write("請輸入整數x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數y:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //int z;


            //if (x > 0 && y > 0)
            //{
            //    z = 1;
            //}
            //else if (x < 0 && y < 0)
            //{
            //    z = -1;
            //}
            //else
            //{
            //    z = 0;
            //}

            //Console.WriteLine($"z = {z}");


            //// 2 - 3.寫一程式，輸入x、y、u、v，如果(x + y) > (u + v)，則令z = x + y，否則令z = u + v
            //Console.Write("請輸入整數x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數y:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數u:");
            //int u = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數v:");
            //int v = Convert.ToInt32(Console.ReadLine());
            //int z;

            //if ((x + y) > (u + v))
            //{
            //    z = x + y;
            //}
            //else
            //{
            //    z = u + v;
            //}

            //Console.WriteLine($"z = {z}");

            //// 2-4
            //Console.Write("請輸入整數x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數y:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數u:");
            //int u = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數v:");
            //int v = Convert.ToInt32(Console.ReadLine());
            //int z;

            //if ((x + y) / (u + v) >= 2)
            //{
            //    z = x + y;
            //}
            //else
            //{
            //    z = u + v;
            //}

            //Console.WriteLine($"z = {z}");

            //// 2-5 寫一程式，輸入x和y，如果x>=y，令z=x2，否則令z=y2
            //Console.Write("請輸入整數x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數y:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //double z;

            //if (x >= y)
            //{
            //    z = Math.Pow(x, 2);
            //}
            //else
            //{
            //    z = Math.Pow(y, 2);
            //}

            //Console.WriteLine($"z = {z}");

            //// 2 - 6.依照以下的流程圖，寫一程式。
            //Console.Write("請輸入income:");
            //int income = Convert.ToInt32(Console.ReadLine());
            //double rate;
            //int difference;
            //double tax;

            //if (income > 4090000)
            //{
            //    rate = 0.4;
            //    difference = 721100;
            //}
            //else if (income > 2180000)
            //{
            //    rate = 0.3;
            //    difference = 312100;
            //}
            //else if (income > 1090000)
            //{
            //    rate = 0.21;
            //    difference = 115900;
            //}
            //else if (income > 410000)
            //{
            //    rate = 0.13;
            //    difference = 28700;
            //}
            //else
            //{
            //    rate = 0.06;
            //    difference = 0;
            //}

            //tax = (income * rate) - difference;

            //Console.WriteLine($"tax = {tax}");

            //// 2 - 7.流程圖
            //Console.Write("請輸入整數x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入整數y:");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x > 0)
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine($"({x},{y})");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine($"({x},0)");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"({x},{y})");
            //    }
            //}
            //else if (x == 0)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine($"(0,0)");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"(0,{y})");
            //    }
            //}
            //else
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine($"({x},{y})");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine($"({x},0)");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"({x},{y})");
            //    }
            //}

            //// Ch2增加一題：使用switch改寫：輸入一個學生的分數，輸出該成績級別
            //Console.Write("請輸入分數:");
            //int score = Convert.ToInt32(Console.ReadLine());

            //switch (score / 10)
            //{
            //    case 10:
            //    case 9:

            //        Console.WriteLine("grade = A");

            //        break;
            //    case 8:

            //        Console.WriteLine("grade = B");

            //        break;
            //    case 7:

            //        Console.WriteLine("grade = C");

            //        break;
            //    case 6:

            //        Console.WriteLine("grade = D");

            //        break;
            //    default:
            //        Console.WriteLine("grade = F");
            //        break;
            //}

            ///*補充習題1.Eason 是一位高中電腦老師，這學期正在教學生寫C++程式。他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，去計算出對應的得分。規則如下：
            //    答對題數在 0~10 者，每題給6分。
            //    題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
            //    題數在 21~40 者，從第21題開始，每題給1分。
            //    題數在 40 以上者，一律100分。
            //    請輸入答對題數，輸出統計後分數 。*/

            //Console.Write("請輸入答對題數:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int grade;


            //if (number > 40)
            //{
            //    Console.WriteLine("分數 : 100 分");
            //}
            //else if (number > 20)
            //{
            //    grade = (number - 20) + 80;
            //    Console.WriteLine($"分數 : {grade} 分");
            //}
            //else if (number > 10)
            //{
            //    grade = (number - 10) + 60;
            //    Console.WriteLine($"分數 : {grade} 分");
            //}
            //else
            //{
            //    grade = number * 6;
            //    Console.WriteLine($"分數 : {grade} 分");
            //}

            //// 補充習題2.請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。
            //Console.Write("請輸入身高(公分):");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.Write("請輸入體重(公斤):");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //double result = weight / Math.Pow((height / 100), 2);


            //if (result < 18.5)
            //{
            //    Console.WriteLine($"BMI = {result}，過輕。");
            //}
            //else if (result > 24)
            //{
            //    Console.WriteLine($"BMI = {result}，過重。");
            //}
            //else
            //{
            //    Console.WriteLine($"BMI = {result}，正常。");
            //}

            //// 補充習題3.請隨意輸入三個數，請由大到小依序印出。

            //Console.WriteLine("請隨意輸入三個數");
            //Console.Write("請輸入第一個數:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入第二個數:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入第三個數:");
            //int z = Convert.ToInt32(Console.ReadLine());

            //if (x >= y)
            //{
            //    if (y >= z)
            //    {
            //        Console.WriteLine($"({x}, {y}, {z})");
            //    }
            //    else
            //    {
            //        if (x >= z)
            //        {
            //            Console.WriteLine($"({x}, {z}, {y})");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"({z}, {x}, {y})");
            //        }
            //    }

            //}
            //else
            //{
            //    if (x >= z)
            //    {
            //        Console.WriteLine($"( {y} ,  {x} ,  {z} )");
            //    }
            //    else
            //    {
            //        if (y >= z)
            //        {
            //            Console.WriteLine($"( {y} ,  {z} ,  {x} )");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"( {z} ,  {y} ,  {x} )");
            //        }
            //    }
            //}

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






            C# CH3  for迴圈指令

            // 例題3.1讀入五個整數，求這五個整數的和。

            int sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                sum += get;
            }

            Console.WriteLine($"五個整數的和: {sum}");

            // 例題3.1改為While寫法

            int sum = 0;
            int i = 1;

            while (i <= 5)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                sum += get;
                i++;
            }

            Console.WriteLine($"五個整數的和: {sum}");


            //例題3.2求N個整數的和，N由使用者輸入。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                sum += get;
            }

            Console.WriteLine($"{number}個整數的和: {sum}");

            //例題3.2改為While寫法

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 1;

            do
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                sum += get;
                i++;

            } while (i <= number);

            Console.WriteLine($"{number}個整數的和: {sum}");


            //例題3.3假設有N個正整數，求其中的最大值。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int max = 0;

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"請輸入第{i}個正整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                if (get > max)
                {
                    max = get;
                }
            }

            Console.WriteLine($"最大值: {max}");

            //例題3.3改為While寫法

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int max = 0;
            int i = 1;

            while (i <= number)
            {
                Console.Write($"請輸入第{i}個正整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                if (get > max)
                {
                    max = get;
                }

                i++;
            }

            Console.WriteLine($"最大值: {max}");

            //例題3.4假設有N個正整數，求最大奇數值。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int max = 0;

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"請輸入第{i}個正整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                if (get > max && get % 2 == 1)
                {
                    max = get;
                }
            }

            if (max == 0)
            {
                Console.WriteLine($"無奇數值");
            }
            else
            {
                Console.WriteLine($"最大奇數值: {max}");
            }


            //例題3.4改為While寫法

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int max = 0;
            int i = 1;

            do
            {
                Console.Write($"請輸入第{i}個正整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                if (get > max && get % 2 == 1)
                {
                    max = get;
                }

                i++;

            } while (i <= number);

            if (max == 0)
            {
                Console.WriteLine($"無奇數值");
            }
            else
            {
                Console.WriteLine($"最大奇數值: {max}");
            }

            // 例題3.5求N階層。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine($"N階層: {result}");

            //例題3.5改為While寫法

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            int i = 1;

            while (i <= number)
            {
                result *= i;
                i++;
            }

            Console.WriteLine($"N階層: {result}");

            // 例題3.6 輸出一個九九乘法表。

            Console.WriteLine($"開始輸出99乘法表：");

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
            }

            //例題3.6改為While寫法
            Console.WriteLine($"開始輸出99乘法表：");

            int i = 1;

            while (i < 10)
            {
                int j = 1;

                while (j < 10)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                    j++;
                }

                i++;
            }

            // 例題3.7 輸出一個九九乘法表。(表格化)(2層迴圈)
            Console.WriteLine($"開始輸出99乘法表：");

            int i = 1;

            for (int x = 1; x <= 3; x++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}\t{i + 1} X {j} = {(i + 1) * j}\t{i + 2} X {j} = {(i + 2) * j}\n");
                }

                Console.WriteLine();
                Console.WriteLine();

                i += 3;
            }


            // 例題3.7 輸出一個九九乘法表。(表格化)(3層迴圈)
            not finished

            Console.WriteLine($"開始輸出99乘法表：");

            int i = 1;

            for (int x = 1; x <= 3; x++)
            {
                for (int y = i; y <= 3; y++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        Console.Write($"{y} X {j} = {y * j}\t");
                    }
                    Console.WriteLine();

                }

                Console.WriteLine();
                Console.WriteLine();

                i += 3;
            }

            // 例題3.7改為While寫法
            Console.WriteLine($"開始輸出99乘法表：");

            int i = 1;
            int x = 1;

            while (x <= 3)
            {

                int j = 1;

                while (j < 10)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}\t{i + 1} X {j} = {(i + 1) * j}\t{i + 2} X {j} = {(i + 2) * j}\n");
                    j++;
                }

                Console.WriteLine();
                Console.WriteLine();

                x++;
                i += 3;
            }





            以下為CH3習題

            // 3 - 1.寫一程式，輸入10個整數，求其最小值。

            Console.Write("請輸入第1個整數:");
            int min = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i <= 10; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get < min)
                {
                    min = get;
                }
            }

            Console.WriteLine($"最小值: {min}");


            // 3 - 1.改為While寫法

            Console.Write("請輸入第1個整數:");
            int min = Convert.ToInt32(Console.ReadLine());

            int i = 2;

            while (i <= 10)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get < min)
                {
                    min = get;
                }

                i++;
            }

            Console.WriteLine($"最小值: {min}");


            //3 - 2.寫一程式，輸入N個整數，求其最小值。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("請輸入第1個整數:");
            int min = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i <= number; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get < min)
                {
                    min = get;
                }
            }

            Console.WriteLine($"最小值: {min}");

            // 3 - 2.改為While寫法
            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("請輸入第1個整數:");
            int min = Convert.ToInt32(Console.ReadLine());

            int i = 2;

            while (i <= number)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get < min)
                {
                    min = get;
                }

                i++;
            }

            Console.WriteLine($"最小值: {min}");


            // 3 - 3.寫一程式，輸入10個整數，列出其中所有大於12的數字。

            string result = "";


            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get > 12)
                {
                    result += Convert.ToString(get) + " ";
                }
            }

            Console.WriteLine($"大於12的數字: {result}");

            // 3 - 3.改為While寫法

            string result = "";
            int i = 1;

            do
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get > 12)
                {
                    result += Convert.ToString(get) + " ";
                }

                i++;
            } while (i <= 10);

            Console.WriteLine($"大於12的數字: {result}");


            // 3 - 4.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。

            string result = "";
            int sum = 0;


            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get > 12)
                {
                    result += Convert.ToString(get) + " ";
                    sum += get;
                }
            }
            Console.WriteLine($"大於12的數字: {result}");

            Console.WriteLine($"所有大於12的數字的總和: {sum}");

            // 3 - 4.改為While寫法

            string result = "";
            int sum = 0;

            int i = 1;

            do
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get > 12)
                {
                    result += Convert.ToString(get) + " ";
                    sum += get;
                }

                i++;

            } while (i <= 10);

            Console.WriteLine($"大於12的數字: {result}");

            Console.WriteLine($"所有大於12的數字的總和: {sum}");



            //  3 - 5.寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue;

            bool hasOdd = false;

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                if (get % 2 != 0)
                {
                    if (get > max)
                    {
                        max = get;
                    }
                    hasOdd = true;
                }
            }

            if (hasOdd == false)
            {
                Console.WriteLine("您沒有輸入任何奇數!");

            }
            else
            {
                Console.WriteLine(max);
            }

            // 3 - 5.改為While寫法
            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue;

            bool hasOdd = false;

            int i = 1;

            while (i <= number)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());

                if (get % 2 != 0)
                {
                    if (get > max)
                    {
                        max = get;
                    }
                    hasOdd = true;
                }

                i++;
            }

            if (hasOdd == false)
            {
                Console.WriteLine("您沒有輸入任何奇數!");

            }
            else
            {
                Console.WriteLine(max);
            }


            // 3 - 6.寫一程式，輸入N個數字，求其所有正數之平方的加總。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());
            double sum = 0;


            for (int i = 1; i <= number; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                sum += Math.Pow(Math.Abs(get), 2);
            }

            Console.WriteLine($"所有正數之平方的加總: {sum}");

            // 3 - 6.改為While寫法

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            int i = 1;

            while (i <= number)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                sum += Math.Pow(Math.Abs(get), 2);

                i++;
            }

            Console.WriteLine($"所有正數之平方的加總: {sum}");

            //3 - 7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如 - 7會被轉換成7。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = "";

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                result += Math.Abs(get) + " ";
            }

            Console.WriteLine($"負數轉換成正數: {result}");

            // 3 - 7.改為While寫法

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = "";

            int i = 1;

            while (i <= number)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                result += Math.Abs(get) + " ";

                i++;
            }

            Console.WriteLine($"負數轉換成正數: {result}");


            //補充習題1.判斷101 - 200之間有多少個質數，並輸出所有質數。

            for (int i = 101; i <= 200; i++)
            {
                bool isPrime = true;

                for (int x = 2; x < i - 1; x++)
                {
                    if (i % x == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }
            }

            // 補充習題1.改為While寫法

            int i = 101;

            while (i <= 200)
            {
                bool isPrime = true;

                int x = 2;

                while (x < i - 1)
                {
                    if (i % x == 0)
                    {
                        isPrime = false;
                    }

                    x++;
                }

                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }
                i++;
            }


            //補充習題2.輸入一個數，輸出其質因數

            Console.Write($"請輸入1個整數:");
            int get = Convert.ToInt32(Console.ReadLine());


            for (int x = 2; x <= get; x++)
            {
                if (get % x == 0)
                {

                    bool isPrime = true;

                    for (int i = 2; i < x - 1; i++)
                    {
                        if (x % i == 0)
                        {
                            isPrime = false;
                        }
                    }

                    if (isPrime == true)
                    {
                        Console.WriteLine(x);
                    }
                }
            }

            // 補充習題2.改為While寫法
            Console.Write($"請輸入1個整數:");
            int get = Convert.ToInt32(Console.ReadLine());

            int x = 2;

            while (x <= get)
            {
                if (get % x == 0)
                {

                    bool isPrime = true;

                    int i = 2;

                    while (i < x - 1)
                    {
                        if (x % i == 0)
                        {
                            isPrime = false;
                        }

                        i++;
                    }

                    if (isPrime == true)
                    {
                        Console.WriteLine(x);
                    }
                }

                x++;
            }



            //補充習題3.求100到300中可以被3與7整除的個數。

            string result = "";

            for (int i = 100; i <= 300; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    result += i + " ";
                }
            }

            Console.WriteLine($"100到300中可以被3與7整除的個數: {result}");

            //補充習題3 改為While寫法

            string result = "";

            int i = 100;

            while (i <= 300)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    result += i + " ";
                }

                i++;
            }

            Console.WriteLine($"100到300中可以被3與7整除的個數: {result}");




            CH4

            //例題4.1
            //讀入一連串的數字，但事先不知道數字的數目。
            //設定一個特殊的數字，一旦讀到這個數字就終止迴圈。
            //假設輸入的都是正數，一旦讀到負數就終止。

            // 待改進

            int specialNumber = 57;
            bool isNumberOrNegative = false;

            do
            {
                Console.Write("請輸入整數數字:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get == specialNumber || get < 0)
                {
                    Console.WriteLine("迴圈終止");
                    isNumberOrNegative = true;
                    break;
                }
            } while (!isNumberOrNegative);


            // 例題4.2 輸入2個數，求最大公約數

            Console.Write($"請輸入第一個正整數:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write($"請輸入第二個正整數:");
            int y = Convert.ToInt32(Console.ReadLine());

            int gcd = 1;

            int i = 1;
            while (i <= Math.Min(x, y))
            {
                if (x % i == 0 && y % i == 0)
                {
                    gcd = i;
                }
                i++;
            }

            Console.Write($"最大公約數:{gcd}");

            // 例題4.2 輸入2個數，求最大公約數(輾轉相除法)
            待理解

            Console.Write($"請輸入第一個正整數:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write($"請輸入第二個正整數:");
            int b = Convert.ToInt32(Console.ReadLine());

            while (b != 0) // 當 b 不為 0
            {
                int temp = b;
                b = a % b; // 計算餘數
                a = temp; // 交換 a 和 b
            }

            Console.Write($"最大公約數:{a}");


            //例題4.3(與3.2改為While寫法一樣)
            //計算N個數字的和。
            //檢查i有沒有超過N，
            //超過就不做了。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 1;

            do
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                sum += get;
                i++;

            } while (i <= number);

            Console.WriteLine($"{number}個整數的和: {sum}");


            //4 - 1.利用while寫一程式求N個數字的最大值。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("請輸入第1個整數:");
            int max = Convert.ToInt32(Console.ReadLine());

            int i = 2;

            while (i <= number)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get > max)
                {
                    max = get;
                }

                i++;
            }

            Console.WriteLine($"最大值: {max}");


            // 4 - 2.利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。(即從起始值開始，間格差，共N個 的總和)

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入起始值:");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入數字間的間格差:");
            int interval = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 1;

            while (i <= number)
            {
                sum += startNumber + interval;
                i++;
            }

            Console.WriteLine($"等差級數數字的和: {sum}");


            //4 - 3.利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            int i = 1;

            while (i <= number)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get < 13)
                {
                    sum += get;
                }

                i++;
            }

            Console.WriteLine($"所有小於13的數字的和: {sum}");


            //4 - 4.利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。

            Console.Write("請輸入N:");
            int number = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i <= number)
            {
                Console.Write($"請輸入第{i}個整數:");
                int get = Convert.ToInt32(Console.ReadLine());
                if (get > 7 && get < 10)
                {
                    Console.WriteLine($"第一個大於7而小於10的數字: {get}");
                    break;
                }

                i++;
            }

            //4 - 5.利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai > bi，即停止，並列印出ai及bi。

            int i = 1;

            while (i <= 5)
            {
                Console.Write($"請輸入a{i}:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write($"請輸入b{i}:");
                int b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine($"a{i} = {a}, b{i} = {b}");
                    break;
                }

                i++;
            }


            // 補充題目1.Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
            // 假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。

            int burgerPrice = 39;

            Console.Write("請輸入一個時間區間(分鐘):");
            int time = Convert.ToInt32(Console.ReadLine());

            int number = 0;

            if (time < 5)
            {
                Console.WriteLine($"{time}分鐘Eric吃不完一個漢堡");
            }
            else
            {
                while (time > 5)
                {
                    number++;
                    time -= 5;
                }

                Console.WriteLine($"Eric在時間內可以吃完{number}個漢堡, 並會花費{number * burgerPrice}元");
            }

            // 補充題目2.小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。

            int loan = 5600000;
            int pay = 40000;
            int bonus = 10000;
            int month = 0;

            while (loan >= 0)
            {
                loan -= pay;
                month++;
                if (month % 12 == 0)
                {
                    loan -= bonus;
                }
            }

            Console.WriteLine($"小明需要{month}個月還清");

            // 補充題目3.系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。
            int secret = 52;
            bool isCorrect = false;

            do
            {
                Console.Write("請輸入一個整數數字:");
                int get = Convert.ToInt32(Console.ReadLine());

                if (get > secret)
                {
                    Console.WriteLine("猜小一點");
                }
                else if (get < secret)
                {
                    Console.WriteLine("猜大一點");
                }
                else
                {
                    Console.WriteLine("猜對了");
                    isCorrect = true;
                }
            } while (!isCorrect);

            // Bonus1：P.34附圖的依據輸入客製化的聖誕樹
            Console.Write("請輸入要建立多高的聖誕樹:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入聖誕樹要顯示的符號:");
            string symbol = Console.ReadLine();


            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number - i + 1; j++)
                {
                    Console.Write(" ");
                }

                for (int x = 1; x <= i * 2 - 1; x++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
            for (int y = 1; y <= 3; y++)
            {
                for (int z = 1; z <= number - 1; z++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("| |");
            }








        }
    }
}
