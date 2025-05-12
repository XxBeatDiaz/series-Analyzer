using System.Globalization;
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
                List<float> input = newSeries();//לכאן יכנס הסדרה הראשונה || זמני!!!

                Console.Write("pleas enter number: ");
                int user1 = int.Parse(Console.ReadLine()!);//בקשת מספר מהמשתמש לבחירת פונקציה|| זמני!!!

                switch (user1)
                {
                    case 1:          
                        input = newSeries();    
                        break;

                    case 2:                    
                        Console.WriteLine("b");
                        break;

                    case 3:                    
                        Console.WriteLine("c");
                        break;

                    case 4:                    
                        Console.WriteLine("d");
                        break;

                    case 5:                    
                        Console.WriteLine("e");
                        break;

                    case 6:                    
                        Console.WriteLine("f");
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
            //פונקציה מספר 1
            List <float> newSeries()
            {
                string numbers = Console.ReadLine()!;//קבלת סטרינג מהמשתמש 
                if(isEmpty(numbers))// בדיקה אם ריק
                {
                    Console.WriteLine("The series empty try egain");
                    List<float> error = new List<float>{0};
                    return error; //שולח הודעה שהסטרינג ריק ומחזיר ליסט עם הספרה אפס                 
                }

                string cleanNumbers = cleanString(numbers); // ניקוי מסימנים ואותיות
                List <float> listNums = makeListNums(cleanNumbers); //הופך את הסטרינג לליסט

                return listNums;
            }


            string cleanString(string numbers) //פונקציה לניקוי סטרינג
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


            bool isEmpty(string numbers)//פונקציה הבודקת האם הסטרינג ריק
            {
                bool empty = false;

                    if(numbers == "")
                    {
                        empty = true; 
                    }
                return empty;
            }


            List<float> makeListNums(string numbers)// פונקציה היוצרת מהסטרינג ליסט
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
        }   
    }
}