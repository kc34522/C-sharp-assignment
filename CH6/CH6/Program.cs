using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Schema;

namespace CH6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 設定輸出編碼為 UTF-8
            Console.InputEncoding = Encoding.UTF8;  // 設定輸入編碼

            //Console.Write("請輸入對話框文字:");
            //string text = Console.ReadLine();
            //bool a = IsNumber(text);
            //Console.WriteLine(a);

            //Console.WriteLine(IsNumber("123"));      // ✅ true
            //Console.WriteLine(IsNumber("3.14"));     // ✅ true
            //Console.WriteLine(IsNumber("-99.9"));    // ✅ true
            //Console.WriteLine(IsNumber("abc"));      // ❌ false
            //Console.WriteLine(IsNumber(""));         // ❌ false
            //Console.WriteLine(IsNumber(" "));        // ❌ false
            //Console.WriteLine(IsNumber(null));       // ❌ false
            //Console.WriteLine(IsNumber("12e3"));     // ✅ true (科學記數法 12 × 10³ = 12000)
            //Console.WriteLine(IsNumber("1,000"));    // ❌ false (因為 `,` 不能直接被 `double.TryParse` 解析)
            //Console.WriteLine(IsNumber("1,999,000"));    // ❌ false (因為 `,` 不能直接被 `double.TryParse` 解析)

            //Console.WriteLine(IsMobileNumber("user@yahoo.com.tw"));  // ✅ true
            //Console.WriteLine(IsEmail("someone.123@yahoo.com.tw"));  // ✅ true
            //Console.WriteLine(IsEmail("user@domain..com"));  // ❌ false
            //Console.WriteLine(IsEmail("user@.com"));  // ❌ false

            //Console.WriteLine(IsMobileNumber("0812345678"));
            //Console.WriteLine(IsMobileNumber("092345678"));
            //Console.WriteLine(IsMobileNumber("0912345678"));

            //Console.WriteLine("0912345678hhhhhhhhhhh"));   // ✅ true (正確)
            //Console.WriteLine(words("09123456789",8));  // ⚠️ true (錯誤！應該 false)
            //Console.WriteLine(IsMobileNumber("0912345678123")); // ⚠️ true (錯誤！應該 false)

            //Console.WriteLine(FileName());
            //string result = GetFileExtension("apple.jpg");
            //Console.WriteLine(result);  // 輸出: jpg

            //string result2 = GetFileExtension("apple");
            //Console.WriteLine(result2);  // 輸出: 無效

            //string result3 = GetFileExtension("");
            //Console.WriteLine(result3);  // 輸出: 無效

            //Console.WriteLine(CheckFiveChar());

            //Console.WriteLine(ReplaceWord());
            //Console.WriteLine(GetLength());

            // Console.WriteLine(TimeFormat("12:XX"));
            //ConvertHtml();
            //Console.WriteLine(ReverseString(" jiojio pj. ").Length);

            //Console.WriteLine(Luck());

            //HasDuplicated();

            //ToWave();

            //ConvertHtml();

            //Console.WriteLine(ToSum());


        }

        //1. 寫一個function 可以把一般對話框的文字轉成HTML。> 轉成 &gt; < 轉成 &lt; \r\n 轉成<br> | 轉成 &brvbar; 空白 轉成 &nbsp;
        public static string ToHtml(string text)  // `Replace()` 產生新字串，但 `text` 本身沒變
        {
            return text.Replace(">", "&gt;")
                       .Replace("<", "&lt;")
                       .Replace("\r\n", "<br>")
                       .Replace("|", "&brvbar;")
                       .Replace(" ", "&nbsp;");
        }

        // 2. 寫一個function，回傳輸入的值是否數字
        public static bool IsNumber(string insertValue)
        {
            if (string.IsNullOrWhiteSpace(insertValue))
            {
                return false;
            }
            else
            {
                return double.TryParse(insertValue, out double _);
            }
        }


        // 3. 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
        public static bool IsEmail(string insert)
        {
            string pattern = @"^(?!.*\.\.)[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}(?:\.[a-zA-Z]{2,})?$";

            Regex email = new Regex(pattern);

            return email.IsMatch(insert);
        }


        // 4. 寫一個function，回傳輸入的值是否符合手機格式
        public static bool IsMobileNumber(string insert)
        {
            string pattern = @"^09\d{8}$";

            Regex number = new Regex(pattern);

            return number.IsMatch(insert);
        }

        // 5. 寫一個function，回傳輸入的值是否符合身分證字號格式
        // 待優化
        public static bool IsId(string insert)
        {
            string pattern = @"^[A-Z][1-2]\d{8}$";

            Regex id = new Regex(pattern);

            return id.IsMatch(insert);
        }

        // 6. 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點

        public static string ShortenText(string input, int N)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "請輸入有效文字!";
            }

            if (input.Length > N)
            {
                return input.Substring(0, N) + "...";
            }

            return input;
        }

        public static string ShortenText()
        {
            Console.Write("請輸入N: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.Write("請輸入文字: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    return "請輸入有效文字!";
                }

                if (input.Length > n)
                {
                    return input.Substring(0, n) + "...";
                }

                return input;

            }
            return "請輸入有效數字N!";
        }


        // 7. 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
        public static string convertDate()
        {
            string date = "";
            Console.WriteLine("請輸入民國年:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入月:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入日:");
            int day = Convert.ToInt32(Console.ReadLine());
            date = year + "/" + month + "/" + day;
            return date;

        }

        // 8. 寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式
        // 可再優化
        public static string ConvertDay()
        {
            string date = "";
            Console.WriteLine("請輸入民國年:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入月:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入日:");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime inputDate = new DateTime(year + 1911, month, day);

            int dayOfWeek = (int)inputDate.DayOfWeek;

            string[] week = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };

            date = $"民國{year}年{month}月{day}日 {week[dayOfWeek]}";

            return date;

        }

        // 9. 寫一個function，回傳輸入的年是否閏年
        // 待優化

        public static string IsLeapYear()
        {
            Console.WriteLine("請輸入西元年: ");

            if (int.TryParse(Console.ReadLine(), out int year) && year >= 0)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            return $"西元{year}年是閏年!";
                        }

                        return $"西元{year}年不是閏年!";

                    }

                    return $"西元{year}年是閏年!";

                }

                return $"西元{year}年不是閏年!";

            }

            return "請輸入有效西元年!";

        }

        // 10. 寫一個function，輸入手機號碼，回傳今天運勢
        // (手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)
        public static bool IsMobileNumber(string insert)
        {
            string pattern = @"^09\d{8}$";

            Regex number = new Regex(pattern);

            return number.IsMatch(insert);
        }
        public static string Luck()
        {
            Console.Write("請輸入手機號碼: ");
            string number = Console.ReadLine();

            string totalLuck = @"0 有點特殊................... 大吉

        1 大展鴻圖．可獲成功　吉

        2 一盛一衰．勞而無功　凶

        3 蒸蒸日上．百事順遂　吉

        4 坎坷前途．苦難折磨　凶

        5 生意欣榮．名利雙收　吉

        6 天降幸運．可成大功　吉

        7 和氣致祥．必獲成功　吉

        8 貫徹志望．成功可期　吉

        9 獨營無力．財利無望　凶

        10 空費心力．徒勞無功　凶

        11 穩健著實．必得人望　吉

        12 薄弱無力．謀事難成　凶

        13 天賦吉運．能得人望　吉

        14 是成是敗．惟*堅毅 凶

        15 大事成就．一定興隆　吉

        16 成就大業．名利雙收　吉

        17 有貴人助．可得成功　吉

        18 順利昌隆．百事亨通　吉

        19 內外不合．障礙重重　凶

        20 歷盡艱難．焦心憂勞　凶

        21 專心經營．善用智能　吉

        22 懷才不遇．事不如意　凶

        23 名顯四方．終成大業　吉

        24 須*自力．能奏大功　吉

        25 天時地利．再得人格　吉

        26 波瀾起伏．凌駕萬難　凶

        27 一盛一衰．可守成功　凶帶吉

        28 遇衰轉吉. 遇厄轉好 吉

        29 青雲直上．才略奏功　吉

        30 吉凶參半．得失相伴　凶

        31 名利雙收．大業成就　吉

        32 池中之龍．成功可望　吉

        33 智能慎始．必可昌隆　吉

        34 災難不絕．難望成功　凶

        35 中吉之數．進退保守　吉

        36 波瀾重疊．常陷窮困　凶

        37 逢凶化吉．風調雨順　吉

        38 名雖可得．利則難獲　凶帶吉

        39 光明坦途．指日可待　吉

        40 一盛一衰．浮沉不定　吉帶凶

        41 天賦吉運．前途無限　吉

        42 事業不專．十九不成　吉帶凶

        43 忍耐自重．轉凶為吉　吉帶凶

        44 事難遂願．貪功好進　凶

        45 綠葉發枝．一舉成名　吉

        46 坎坷不平．艱難重重　凶

        47 有貴人助．可成大業　吉

        48 名利俱全．繁榮富貴　吉

        49 遇吉則吉．遇凶則凶　凶

        50 吉凶互見．一成一敗　吉帶凶

        51 一盛一衰．浮沉不常　吉帶凶

        52 雨過天青．即獲成功　吉

        53 盛衰參半．先吉後凶　吉帶凶

        54 雖傾全力．難望成功　凶

        55 外觀隆昌．內隱禍患　吉帶凶

        56 事與願違．終難成功　凶

        57 努力經營．時來運轉　吉

        58 浮沉多端．始凶終吉　凶帶吉

        59 遇事猶疑．難望成事　凶

        60 心迷意亂．難定方針　凶

        61 雲遮半月．百隱風波　吉帶凶

        62 煩悶懊惱．事事難展　凶

        63 萬物化育．繁榮之象　吉

        64 十九不成．徒勞無功　凶

        65 吉運自來．能享盛名　吉

        66 內外不和．信用缺乏　凶

        67 事事如意．富貴自來　吉

        68 不失先機．可望成功　吉

        69 動搖不安．常陷逆境　凶

        70 慘澹經營．難免貧困　凶

        71 吉凶參半．惟賴勇氣　吉帶凶

        72 得而復失．難以安順　凶

        73 安樂自來．自然吉祥　吉

        74 如無智謀．難望成功　凶

        75 吉中帶凶．進不如守　吉帶凶

        76 此數大凶．破產之象　凶

        77 先苦後甘．不致失敗　吉帶凶

        78 有得有失．華而不實　吉帶凶

        79 前途無光．希望不大　凶";

            string[] arrays = totalLuck.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (IsMobileNumber(number))
            {
                int luckyNumber = Convert.ToInt32(number.Substring(6, 4));
                luckyNumber = luckyNumber % 80;
                return arrays[luckyNumber];
            }

            return "請輸入有效手機號碼!";

        }




        // 字串題目

        // 1. 輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi ~Justin。
        public static void GetGreeting()
        {
            Console.Write("請輸入姓名:");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("請輸入正確格式!");
            }
            else
            {
                Console.WriteLine($"Hi~{name}");
            }
        }

        public static string GetGreeting(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "請輸入正確格式!";
            }
            else
            {
                return $"Hi~{name}";
            }
        }

        // 2. 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
        public static bool IsContained()
        {
            Console.Write("請輸入任何一個字:");
            string get = Console.ReadLine();
            string sentence = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";

            if (string.IsNullOrWhiteSpace(get))
            {
                Console.WriteLine("請輸入有效的字！");
                return false;
            }
            return sentence.Contains(get);
        }

        public static bool IsContained(string insert)
        {
            string sentence = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";

            if (string.IsNullOrWhiteSpace(insert))
            {
                return false;
            }
            return sentence.Contains(insert);
        }


        // 3. 輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
        // 浪費記憶體 有更好寫法
        public static string AddDash()
        {
            Console.Write("請輸入一段字:");
            string get = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(get))
            {
                return "請輸入正確格式!";
            }
            else
            {
                int number = get.Length;

                for (int i = 1; i < number * 2 - 1; i += 2)
                {
                    get = get.Insert(i, "-");
                }
                return get;
            }
        }

        // 4. 輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
        public static string GetFileExtension()
        {
            Console.Write("請輸入一個檔名: ");
            string fileName = Console.ReadLine();

            int index = fileName.LastIndexOf('.');

            if (string.IsNullOrWhiteSpace(fileName) || index <= 0 || index == fileName.Length - 1)
            {
                return "請輸入有效的檔名!";
            }

            return $"副檔名: {fileName.Substring(index + 1)}";
        }

        public static string GetFileExtension(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return "請輸入有效的檔名!";
            }

            int index = fileName.LastIndexOf('.');

            if (index <= 0 || index == fileName.Length - 1)
            {
                return "請輸入有效的檔名!";
            }

            return fileName.Substring(index + 1);
        }


        // 5. 輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length Substring()

        public static string CheckFiveChar()
        {
            Console.Write("請輸入一個大於五個字的單字: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return "請輸入有效的單字!";
            }
            else
            {
                if (input.Length < 5)
                {
                    return "長度不夠";
                }
                return input.Substring(0, 3);
            }
        }
        public static string CheckFiveChar(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "請輸入有效的單字!";
            }

            if (input.Length < 5)
            {
                return "長度不夠";
            }
            return input.Substring(0, 3);

        }

        // 6. 輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()
        public static string ReplaceWord()
        {
            Console.Write("請輸入一段字: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return "請輸入有效的一段字!";
            }

            return input.Replace("我", "小明");
        }

        public static string ReplaceWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "請輸入有效的一段字!";
            }

            return input.Replace("我", "小明");
        }

        // 7. 輸入一串字，顯示輸入幾個字。Length

        public static string GetLength()
        {
            Console.Write("請輸入一串字: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return "請輸入有效的一串字!";
            }

            return $"共輸入 {input.Length} 個字";
        }

        public static int GetLength(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return -1;
            }

            return input.Length;
        }


        // 字串補充練習題

        // 1. 連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。

        public static void HasDuplicated()
        {
            List<string> inputList = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"請輸入第{i}組字: ");

                string input = Console.ReadLine();

                bool result = inputList.Contains(input);

                if (result)
                {
                    Console.WriteLine("輸入過");
                }
                else
                {
                    inputList.Add(input);
                    Console.WriteLine("沒出現過");
                }
            }
        }



        // 2. 用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出        
        public static void ToWave()
        {
            Console.Write("請輸入一個英文單字: ");
            string input = Console.ReadLine().ToLower();
            int inputLength = input.Length;
            for (int i = 0; i < inputLength; i++)
            {
                Console.WriteLine(input.Substring(0, i) + input[i].ToString().ToUpper() + input.Substring(i + 1, inputLength - (i + 1)));
            }
        }


        // 3. 輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。

        public static string TimeFormat()
        {
            Console.Write("請輸入時間: ");
            string input = Console.ReadLine().Trim();

            if (input.Contains(':'))
            {
                string[] split = input.Split(':');

                if (split.Length == 2 && int.TryParse(split[0], out int hour) && int.TryParse(split[1], out int minute) && hour <= 23 && minute <= 59 && hour >= 0 && minute >= 0)
                {
                    return $"{hour}點{minute}分";
                }
            }
            return "請輸入有效的時間!";
        }

        public static string TimeFormat(string time)
        {
            if (string.IsNullOrWhiteSpace(time) || !time.Contains(':'))
            {
                return "請輸入有效的時間!";
            }

            string[] split = time.Split(':');

            if (split.Length == 2 && int.TryParse(split[0], out int hour) && int.TryParse(split[1], out int minute) && hour <= 23 && minute <= 59 && hour >= 0 && minute >= 0)
            {

                return $"{hour}點{minute}分";
            }

            return "請輸入有效的時間!";
        }

        // 4. 輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
        //<ul>
        //	<li>Justin<li>	
        //	<li>Amy<li>
        //	<li>David<li>
        //</ul>

        public static void ConvertHtml()
        {
            Console.Write("請輸入list內容物(用逗號分開): ");
            string input = Console.ReadLine().Trim();

            string[] list = input.Split(',');

            int number = list.Length;

            Console.WriteLine("<ul>");

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"    <li>{list[i].Trim()}</li>");
            }

            Console.WriteLine("</ul>");
        }

        // 5. 輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
        // 待優化 可用foreach

        public static string ToSum()
        {
            Console.Write("請輸入隨意欲計算總合的數字(用空白隔開): ");
            string input = Console.ReadLine().Trim();

            //string[] list = input.Split(' ');

            string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int result))
                {
                    sum += result;
                }

                else
                {
                    Console.WriteLine($"{numbers[i]}非數字, 未進行加總!");
                }

            }

            return $"輸入{string.Join(" ", numbers)} , 總和是{sum}!";
        }

        // 6. 輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
        public static void ReverseString()
        {
            Console.Write("請輸入一串文字: ");
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("請輸入有效的一串文字!");
                return;
            }

            int length = input.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            Console.WriteLine();
        }

        public static void ReverseString()
        {
            Console.Write("請輸入一串文字: ");
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("請輸入有效的一串文字!");
                return;
            }

            //Char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //string result = new string (charArray);
            //Console.WriteLine(result);

            Console.WriteLine(new string(input.Reverse().ToArray())); // LinQ寫法

        }

        public static string ReverseString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "請輸入有效的一串文字!";
            }

            return new string(input.Trim().Reverse().ToArray()); // LinQ寫法

        }



    }
}

