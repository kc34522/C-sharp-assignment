using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Xml.XPath;
using System.Text.RegularExpressions;

namespace CH7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //// 檔案處理題目
            //// 1. 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\song.txt";
            //string song = "星期一，猴子穿新衣，\r\n星期二，猴子肚子餓，\r\n星期三，猴子去爬山，\r\n星期四，猴子看電視，\r\n呈期五，猴子去跳舞，\r\n星期六，猴子去斗六，\r\n星期日，猴子過生日。";

            //File.WriteAllText(path, song, Encoding.UTF8);

            //// 1. 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
            //            string path = @"C:\Users\kelly\Desktop\CH1\CH7\song.txt";
            //            string song = @"張國榮 春夏秋冬 歌詞

            //秋天該很好 你若尚在場
            //秋風即使帶涼 亦漂亮
            //深秋中的你 填密我夢想
            //就像落葉飛 輕敲我窗

            //冬天該很好 你若尚在場
            //天空多灰 我們亦放亮
            //一起坐坐 談談來日動向
            //漠視外間低溫 這樣唱";

            //            File.WriteAllText(path, song, Encoding.UTF8);


            //// 2. 讀取1.txt 顯示在畫面上。

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\1.txt";

            //string result = File.ReadAllText(path);
            //Console.WriteLine(result);

            //// 2. 讀取1.txt 顯示在畫面上。

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\1.txt";

            //string[] result = File.ReadAllLines(path);

            //foreach(string line in result)
            //{
            //    Console.WriteLine(line);
            //}


            //// 檔案處理補充練習題
            //// 1. 寫入九九乘法表資料到一個文字檔到自己指定的文字檔。

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\1.txt";

            //string result = "";

            //for (int i = 1; i <= 7; i+=3)
            //{
            //    for(int j = 1; j <= 9; j++)
            //    {
            //        for(int k = i; k <= i+2; k++)
            //        {
            //            result += $"{k} X {j} = {k * j}\t";
            //        }
            //        result += Environment.NewLine;
            //    }
            //    result += Environment.NewLine;
            //}

            //File.WriteAllText(path, result);

            //// 2. 讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF - 8)
            //// 可優化~~~~~~~~~~~

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\1.txt";

            //string result = File.ReadAllText(path, Encoding.UTF8);
            //result = result.Replace('0', '零')
            //               .Replace('1', '壹')
            //               .Replace('2', '貳')
            //               .Replace('3', '叁')
            //               .Replace('4', '肆')
            //               .Replace('5', '伍')
            //               .Replace('6', '陸')
            //               .Replace('7', '柒')
            //               .Replace('8', '捌')
            //               .Replace('9', '玖');

            //File.WriteAllText(path, result, Encoding.UTF8);


            //// 3. 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\fc4bb.csv";

            //string[] table = File.ReadAllLines(path, Encoding.UTF8);

            //string[] header = table[0].Split(',');

            //string result = "";

            //result += $"<table>{Environment.NewLine}<tr>";

            //foreach (string a in header)
            //{
            //    result += "<th>" + a + $"</th>";
            //}
            //result += $"</tr>{Environment.NewLine}";



            //for (int i = 1; i < table.Length; i++)
            //{
            //    string[] row = table[i].Split(',');
            //    result += $"<tr>";
            //    for (int j = 0; j < row.Length; j++)
            //    {
            //        result += "<td>" + row[j] + $"</td>";
            //    }
            //    result += $"</tr>{Environment.NewLine}";
            //}

            //result += "</table>";

            //string htmlPath = @"C:\Users\kelly\Desktop\CH1\CH7\table.html";

            //File.WriteAllText(htmlPath, result, Encoding.UTF8);


            //// 3. 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
            //// 使用StringBuilder, trim()

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\fc4bb.csv";

            //string[] table = File.ReadAllLines(path, Encoding.UTF8);

            //string[] header = table[0].Split(',');

            //StringBuilder result = new StringBuilder();

            //result.Append($"<table>{Environment.NewLine}<tr>");

            //foreach (string a in header)
            //{
            //    result.Append($"<th>{a.Trim()}</th>");
            //}

            //result.AppendLine("</tr>");



            //for (int i = 1; i < table.Length; i++)
            //{
            //    string[] row = table[i].Split(',');
            //    result.Append($"<tr>");
            //    for (int j = 0; j < row.Length; j++)
            //    {
            //        result.Append($"<td>{row[j].Trim()}</td>");
            //    }
            //    result.AppendLine("</tr>");
            //}

            //result.AppendLine("</table>");

            //string htmlPath = @"C:\Users\kelly\Desktop\CH1\CH7\table.html";

            //File.WriteAllText(htmlPath, result.ToString(), Encoding.UTF8);


            //// 3. 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
            //// select

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\fc4bb.csv";

            //string[] table = File.ReadAllLines(path, Encoding.UTF8);

            //string[] header = table[0].Split(',');

            //string result = "";

            //result += $"<table>{Environment.NewLine}<tr>";

            //result += string.Join("", header.Select(h => $"<th>{h}</th>"));

            //result += $"</tr>{Environment.NewLine}";



            //for (int i = 1; i < table.Length; i++)
            //{
            //    string[] row = table[i].Split(',');

            //    result += $"<tr>";

            //    result += string.Join("", row.Select(r => $"<td>{r}</td>"));

            //    result += $"</tr>{Environment.NewLine}";
            //}

            //result += "</table>";

            //string htmlPath = @"C:\Users\kelly\Desktop\CH1\CH7\table.html";

            //File.WriteAllText(htmlPath, result, Encoding.UTF8);


            // 亂數

            //// 1. 請隨機由0~99產生一個數字輸出。
            //// Random rom = new Random();//亂數種子
            //// int I = rom.Next(0, 100);//回傳0-99的亂數

            //Random random = new Random();
            //int result = random.Next(0, 100);

            //Console.WriteLine($"0~99隨機輸出: {result}");


            //// 2. 請隨機由0~99產生10個數字輸出。
            //Random random = new Random();

            //Console.WriteLine("< 0~99隨機輸出10個數字 >");


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"第{i}個數字: {random.Next(0, 100)}");
            //}


            //// 3. 隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。
            //string result = "";
            //result += "學生，" + string.Join("，", "國文", "英文", "數學", "社會", "自然");
            //result += Environment.NewLine;

            //Random random = new Random();

            //for (int i = 1; i <= 10; i++)
            //{
            //    result += $"第{i}位，";
            //    result += string.Join("，", random.Next(0, 101), random.Next(0, 101), random.Next(0, 101), random.Next(0, 101), random.Next(0, 101));
            //    result += Environment.NewLine;
            //}

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\student_grade.txt";

            //File.WriteAllText(path, result);


            // 亂數補充題
            //// 1. 請設計樂透開獎程式。
            //// 待優化~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Random random = new Random();

            //int[] number = new int[6];

            //bool isDuplicated;

            //Console.Write("本期大樂透第一區號碼: ");

            //for (int i = 0; i < 6; i++)
            //{

            //    do
            //    {
            //        isDuplicated = false;
            //        number[i] = random.Next(1, 50);
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (number[i] == number[j])
            //            {
            //                isDuplicated = true;
            //            }
            //        }
            //    } while (isDuplicated == true);

            //    Console.Write($"{number[i]:D2} ");
            //}

            //Console.WriteLine();

            //Console.Write("本期大樂透第二區號碼: ");

            //int specialNumber;

            //do
            //{
            //    isDuplicated = false;
            //    specialNumber = random.Next(1, 50);
            //    for (int i = 0; i < number.Length; i++)
            //    {
            //        if (specialNumber == number[i])
            //        {
            //            isDuplicated = true;
            //        }
            //    }
            //} while (isDuplicated == true);

            //Console.Write(specialNumber.ToString("D2"));

            //Console.WriteLine();

            //Console.Write("請輸入您的號碼(共6個數字,用空格隔開): ");
            //string[] inputNumber = Console.ReadLine().Split(' ');
            //int[] numberList = new int[6];
            //for(int i = 0; i < inputNumber.Length; i++)
            //{
            //    numberList[i] = Convert.ToInt32(inputNumber[i]);
            //}

            //int firstArea = 0;
            //int secondArea = 0;
            //List<int> firstLine = new List<int>();


            //for (int i = 0; i < numberList.Length; i++)
            //{

            //    if (numberList[i] == specialNumber)
            //    {
            //        secondArea++;
            //    }
            //    for(int j = 0; j < number.Length; j++)
            //    {
            //        if (numberList[i] == number[j])
            //        {
            //            firstArea++;
            //            firstLine.Add(number[j]);
            //        }
            //    }               
            //}

            //string result = "";

            //foreach(int i in firstLine)
            //{
            //    result += i.ToString("D2") + " ";
            //}

            //if(secondArea == 1 && firstArea == 2)
            //{
            //    Console.WriteLine("恭喜您中獎了!");
            //    Console.WriteLine($"第一區中獎數字共{firstArea}個: {result}");
            //    Console.WriteLine($"第二區中獎數字共{secondArea}個: {specialNumber.ToString("D2")}");
            //}
            //else if (firstArea >= 3)
            //{
            //    if (secondArea == 0)
            //    {
            //        Console.WriteLine("恭喜您中獎了!");
            //        Console.WriteLine($"第一區中獎數字共 {firstArea} 個: {result}");
            //        Console.WriteLine("第二區中獎數字共 0 個");

            //    }
            //    else
            //    {
            //        Console.WriteLine("恭喜您中獎了!");
            //        Console.WriteLine($"第一區中獎數字共 {firstArea} 個: {result}");
            //        Console.WriteLine($"第二區中獎數字共 {secondArea} 個: {specialNumber.ToString("D2")}");
            //    }   

            //}
            //else
            //{
            //    Console.WriteLine("您未中獎!");
            //    Console.WriteLine($"第一區中獎數字共 {firstArea} 個,第二區中獎數字共 {secondArea} 個。");
            //}


            //// 2. 請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。

            //string path = @"C:\Users\kelly\Desktop\CH1\CH7\stores.txt";
            //string[] stores = { "店家A", "店家B", "店家C", "店家D", "店家E", "店家F" };
            //string result = "";
            //for(int i = 0; i < stores.Length; i++)
            //{
            //    result += stores[i] + Environment.NewLine;
            //}

            //File.WriteAllText(path, result);

            //string[] storeList = File.ReadAllLines(path);

            //Random random = new Random();

            //int number = random.Next(0, storeList.Length); //待確認是否自動去除空行~

            //Console.WriteLine($"今天吃的店家: {storeList[number]}");


            //            // 3.請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
            //            // ~~~~~~~~~ 待優化 ~~~~~~~~~~~~~~~~~

            //            string path = @"C:\Users\kelly\Desktop\CH1\CH7\students.txt";
            //            string studentList = @"Alan
            //Bratt
            //Cherry
            //David
            //Eve
            //Fiona
            //Gary
            //Henry
            //Iris
            //Jerry
            //Karen";
            //            File.WriteAllText(path, studentList, Encoding.UTF8);

            //            string[] students = File.ReadAllLines(path);

            //            List<string> pickedList = new List<string>();

            //            Random random = new Random();

            //            while (pickedList.Count < students.Length)
            //            {
            //                string pickedstudent = students[random.Next(0, students.Length)];

            //                if(!pickedList.Contains(pickedstudent))
            //                {
            //                    pickedList.Add(pickedstudent);
            //                    Console.WriteLine($"今天的值日生: {pickedstudent}");
            //                    Console.ReadLine();
            //                }

            //                if(pickedList.Count == students.Length)
            //                {
            //                    Console.WriteLine("全部學員都被抽過!");
            //                    Console.WriteLine();
            //                    pickedList.Clear();
            //                }
            //            }



            //日期

            ////日期題目1: 顯示現在日期與時間。
            //Console.WriteLine(DateTime.Now);

            ////日期題目2: 顯示再過30天為哪一天。
            //Console.WriteLine(DateTime.Today.AddDays(30).ToString("d"));

            //// 日期題目3: 顯示24小時前的年月日時分秒。
            //Console.WriteLine(DateTime.Now.AddHours(-24));

            //// 日期題目4: 取得目前是幾月。
            //Console.WriteLine(DateTime.Now.ToString("MMMM"));

            //// 日期題目5: 取得明年是否為閏年。(可以試試民國)
            //// ~~~~ 待檢查 ~~~~~~~
            //int nextYear = Convert.ToInt32(DateTime.Now.AddYears(1).ToString("yyyy"));

            //Console.WriteLine($"明年是{nextYear}年!");

            //if (nextYear % 4 == 0 && nextYear % 100 != 0)
            //{
            //    Console.WriteLine("明年是閏年!");
            //}
            //else if (nextYear % 400 == 0)
            //{
            //    Console.WriteLine("明年是閏年!");
            //}
            //else
            //{
            //    Console.WriteLine("明年不是閏年!");
            //}

            //// 日期題目6: 取得離2026年1月1日還有幾天。
            //// ~~~~~~~~ 待確認其他方法 ~~~~~~~~~~~~~~

            //DateTime now = DateTime.Now.Date;
            //DateTime time = new DateTime(2026, 1, 1);
            //int days = Math.Abs(Convert.ToInt32((now - time).TotalDays));
            //Console.WriteLine($"離2026年1月1日還有 {days} 天");

            //            // 日期補充題1: 
            //            // 星期一，猴子穿新衣，星期二，猴子肚子餓，星期三，猴子去爬山，星期四，猴子看電視，呈期五，猴子去跳舞，星期六，猴子去斗六，星期日，猴子過生日。請顯示今天猴子做甚麼事。

            //            int today = ((int)DateTime.Now.DayOfWeek);
            //            string monkey = @"星期一，猴子穿新衣，
            //星期二，猴子肚子餓，
            //星期三，猴子去爬山，
            //星期四，猴子看電視，
            //呈期五，猴子去跳舞，
            //星期六，猴子去斗六，
            //星期日，猴子過生日。"
            //;
            //            string[] monkeyList = monkey.Split('\n');

            //            Console.WriteLine(monkeyList[today-1]);

            //// 日期補充題2: 輸入‘兩個日期，輸出兩個日期相差幾天。
            //// ~~~~~~ 待優化 ~~~~~~~~~~~
            //Console.WriteLine("請輸入第一個日期(舉例: 2000/01/01): ");
            //string time1 = Console.ReadLine();
            //int year1 = Convert.ToInt32(time1.Substring(0, 4));
            //int month1 = Convert.ToInt32(time1.Substring(5, 2));
            //int day1 = Convert.ToInt32(time1.Substring(8, 2));
            //DateTime date1 = new DateTime(year1, month1, day1);

            //Console.WriteLine("請輸入第二個日期(舉例: 2000/01/01): ");
            //string time2 = Console.ReadLine();
            //int year2 = Convert.ToInt32(time2.Substring(0, 4));
            //int month2 = Convert.ToInt32(time2.Substring(5, 2));
            //int day2 = Convert.ToInt32(time2.Substring(8, 2));
            //DateTime date2 = new DateTime(year2, month2, day2);

            //int days = Math.Abs(Convert.ToInt32((date1 - date2).TotalDays));
            //Console.WriteLine($"兩個日期相差 {days} 天!");


            //// 日期補充題3: 兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，時常大排長龍，他想算 得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
            //// M = 月
            //// D = 日
            //// S = (M * 2 + D) % 3
            //// 得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。

            //Random random = new Random();
            //bool isLeapYear = DateTime.IsLeapYear(2025);
            //int daysOfYear;
            //if (isLeapYear)
            //{
            //    daysOfYear = 366;
            //}
            //else
            //{
            //    daysOfYear = 365;
            //}


            //DateTime randomDate = new DateTime(2025, 1, 1).AddDays(random.Next(0, daysOfYear+1));

            //Console.WriteLine(randomDate.ToString("yyyy/MM/dd"));

            //int M = randomDate.Month;
            //int D = randomDate.Day;

            //int S = (M * 2 + D) % 3;

            //switch (S)
            //{
            //    case 0:
            //        Console.WriteLine($"運勢: 普通");
            //        break;
            //    case 1:
            //        Console.WriteLine($"運勢: 吉");
            //        break;
            //    case 2:
            //        Console.WriteLine($"運勢: 大吉");
            //        break;
            //}


        }
    }
}
