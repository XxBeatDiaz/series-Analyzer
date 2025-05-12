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
        }   
    }
}