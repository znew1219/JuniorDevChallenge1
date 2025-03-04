﻿namespace JuniorDevChallenge1
{
    internal class Program
    {
        static void Main()
        {
            // 建立兩個 List 來儲存學生姓名與成績
            List<string> names = new List<string>();
            List<int> grades = new List<int>();
            string again = "Y";

            // 使用 while 迴圈允許使用者不斷輸入學生資料
            while (again.ToUpper() == "Y")
            {
                Console.WriteLine("請輸入學生姓名: ");
                string n = Console.ReadLine(); // 讀取學生姓名
                
                if (string.IsNullOrEmpty(n)) { break; }

                names.Add(n);

                Console.WriteLine("請輸入學生成績: ");

                //int g = Convert.ToInt32(Console.ReadLine());
                int g = 0; 
                if(int.TryParse(Console.ReadLine(),out g))
                    grades.Add(g);
                else
                    grades.Add(-1);

                Console.WriteLine("是否要輸入另一位學生？(Y/N)");
                again = Console.ReadLine();
            }

            // 根據學生成績輸出對應的等級
            for (int i = 0; i < names.Count; i++)
            {
                if (grades[i] == -1)
                {
                    Console.WriteLine(names[i] + " 成績格式不符");
                }
                else if (grades[i] >= 90)
                {
                    Console.WriteLine(names[i] + " 的成績是 A");
                }
                else if (grades[i] >= 80)
                {
                    Console.WriteLine(names[i] + " 的成績是 B");
                }
                else if (grades[i] >= 70)
                {
                    Console.WriteLine(names[i] + " 的成績是 C");
                }
                else if (grades[i] >= 60)
                {
                    Console.WriteLine(names[i] + " 的成績是 D");
                }
                else
                {
                    Console.WriteLine(names[i] + " 的成績是 F");
                }
            }
        }
    }

}
