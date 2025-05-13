using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Analayzer
{
    class Program()
    {
        static void Main(string[] args)
        {
            
            Menu();           
            void Menu()
            {
                List<float> input = NewSeries();//לכאן יכנס הסדרה הראשונה || זמני!!!

                Console.Write("pleas enter number: ");
                int user1 = int.Parse(Console.ReadLine()!);//בקשת מספר מהמשתמש לבחירת פונקציה|| זמני!!!

                switch (user1)
                {
                    case 1:          
                        input = NewSeries();// הפונקציה הראשונה ליצירת סדרה חדשה
                        break;

                    case 2:                    
                        ShowSeries(input);// הפונקציה השנייה להדפסת הסדרה הנוכחית
                        break;

                    case 3:   
                        ReversOrder(input); // הפונקציה השלישית להדפסת הסדרה בריוורס                                    
                        break;

                    case 4:                    
                        SortedOrder(input);// הפונקציה הרביעית להדפסת הסדרה בצורה ממויינת מהערך הנמוך לגבוה
                        break;

                    case 5:                    
                        MaxValue(input); // הפונקציה החמישית להדפסת המספר הגבוה
                        break;

                    case 6:                    
                        MinValue(input);
                        break;

                    case 7:                    
                        Console.WriteLine("g");
                        break;

                    case 8:                    
                        Console.WriteLine("h");
                        break;

                    case 9:                    
                        Console.WriteLine("i");
                        break;

                    case 10:                    
                        Console.WriteLine("j");
                        break;

                    default:
                        break;
                }
            }


            //פונקציה היוצרת סדרה חדשה
            List <float> NewSeries()
            {
                string numbers = Console.ReadLine()!;//קבלת סטרינג מהמשתמש 
                if(IsEmpty(numbers))// בדיקה אם ריק
                {
                    Console.WriteLine("The series empty try egain");
                    List<float> error = new List<float>{0};
                    return error; //שולח הודעה שהסטרינג ריק ומחזיר ליסט עם הספרה אפס                 
                }

                string cleanNumbers = CleanString(numbers); // ניקוי מסימנים ואותיות
                List <float> listNums = MakeListNums(cleanNumbers); //הופך את הסטרינג לליסט

                return listNums;
            }


            // פונקציות עזר לפונקציה ליצירת סדרה חדשה
            ///////////////////////////////////////
            
            string CleanString(string numbers) //פונקציה לניקוי סטרינג
            {
                foreach(char num in numbers)
                {
                    if(char.IsDigit(num) || num == ',' || num == '.')
                    {
                        continue;
                    }
                    else
                    {
                       numbers = numbers.Replace(num.ToString(), "");
                       System.Console.WriteLine(num);
                    }
                }
                return numbers;
            }


            bool IsEmpty(string numbers)//פונקציה הבודקת האם הסטרינג ריק
            {
                bool empty = false;

                    if(numbers == "")
                    {
                        empty = true; 
                    }
                return empty;
            }


            List<float> MakeListNums(string numbers)// פונקציה היוצרת מהסטרינג ליסט
            {
                string[] arryNums = numbers.Split(',');

                List<float> listNums = new List<float>();

                foreach(string num in arryNums)
                {
                    float convert = float.Parse(num);
                    listNums.Add(convert);
                }

                return listNums; 
            }

            // סיום פונקציות עזר לפונקציה הראשונה
            /////////////////////////////////////////
            

            void ShowSeries(List<float> series)// פונקציה המציגה את הסדרה המקורית
            {
                Console.WriteLine(string.Join(", ", series));
            }


             void ReversOrder(List<float> series)// פונקציה המציגה את הסדרה בריוורס
            {
                Console.Write("The reversed order: ");
                for(int i = series.Count()-1; i >= 0; i--)
                {
                    Console.Write($"{series[i]}, ");
                }

                Console.WriteLine();
                Console.Write("The original order: ");
                ShowSeries(series); // שימוש בפונקציה השנייה כדי להציג את השוני בין הליסט המקורי לריוורס 
            }  


            void SortedOrder(List<float> series)// פונקציה המציגה את הסדרה באופן ממויין מהערך הנמוך לגבוה
            {
                List<float> sortedList = new List<float>([..series]);
                sortedList.Sort();
                Console.WriteLine(string.Join(", ", sortedList));
            }  

    
            void MaxValue(List<float> series)
            {
                float maxValue = series[0];
                for(int i = 1; i < series.Count; i++)
                {
                    if(series[i] > maxValue)
                    {
                        maxValue = series[i];
                    }  
                }
                Console.WriteLine($"{maxValue}");
            } 


            void MinValue(List<float> series)
            {
                float minValue = series[0];
                for(int i = 1; i < series.Count; i++)
                {
                    if(series[i] > minValue)
                    {
                        minValue = series[i];
                    }  
                }
                Console.WriteLine($"{minValue}");
            }
        }   
    }
}