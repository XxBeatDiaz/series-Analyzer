using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Analayzer
{
    class Program()
    {
        static void Main(string[] args)
        {  
            Menu();           
            void Menu()
            {
                bool flag = true;
                while(flag)
                {
                    List<double> input = NewSeries();//This is where the first series will come in || Temporary!!!
                    

                    showMenu();//Print the menu
                    int user1 = int.Parse(Console.ReadLine()!);//Request a number from the user to select a function|| Temporary!!!

                    switch (user1)
                    {
                        case 1:          
                            //The first function - to create a new series
                            input = NewSeries();                      
                            break;

                        case 2:                    
                            //The second function - which print the original series
                            ShowSeries(input);
                            break;

                        case 3:   
                            //The third function - which returns the series in reverse 
                            Console.WriteLine($"Revers series: {string.Join(", ", ReversOrder(input))}");
                            ShowSeries(input);//Using the second function to display the difference between the original and reverse list                                  
                            break;

                        case 4:
                            //The fourth function - which returns the series sorted from lowest to highest value 
                            List<double> sortSeries = SortedOrder(input);                   
                            Console.WriteLine($"Sorted series: {string.Join(", ", sortSeries)}"); 
                            break;

                        case 5:                    
                            //The fifth function - which returns the highest number in the series
                            double maxValue = MaxValue(input);
                            Console.WriteLine($"Max value: {maxValue}");
                            break;

                        case 6:                    
                            //The sixth function - which returns the lowest number in the series
                            double minValue = MinValue(input);
                            Console.WriteLine($"Min value: {minValue}");
                            break;

                        case 7:                    
                            //The seventh function - which returns the numerical average of the series
                            double average = Average(input);
                            Console.WriteLine($"Average: {average}");
                            break;

                        case 8:                    
                            double lenOfSeries = LenSeries(input);
                            Console.WriteLine($"Lentgh of series: {lenOfSeries}");
                            break;

                        case 9:       
                            //The ninth function - which return the sum of the numbers in the list         
                            double sumList = SumSeries(input);
                            Console.WriteLine($"Sum of numbers in the series: {sumList}");
                            break;

                        case 10:                    
                            flag = false;
                            break;

                        default:                          
                            break;
                    }
                }
                
            }


            //Function that creates a new series
            List <double> NewSeries()
            {
                string numbers = Console.ReadLine()!;//Receive a string from the user
                if(IsEmptyString(numbers))//Check if the string is empty
                {
                    Console.WriteLine("The series empty try egain");
                    List<double> error = new List<double>{-1};
                    return error; //Sends a message that the string is empty and returns a list with the digit minus one.                
                }

                string cleanNumbers = CleanString(numbers); //Cleaning from signs and letters
                List<double> listNums = MakeListNums(cleanNumbers); //Converts the string to a list

                return listNums;
            }


            //Helper functions for the function to create a new series
            ///////////////////////////////////////
            
            


            //String cleaning function
            string CleanString(string numbers) 
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
                       Console.WriteLine(num);
                    }
                }
                return numbers;
            }

            //A function that checks whether a string is empty
            bool IsEmptyString(string numbers)
            {
                bool empty = false;

                    if(numbers == "")
                    {
                        empty = true; 
                    }
                return empty;
            }

            //A function that converts a string to a list
            List<double> MakeListNums(string numbers)
            {
                string[] arryNums = numbers.Split(',');
                List<double> listNums = new List<double>();

                foreach(string num in arryNums)
                {
                    double convert = double.Parse(num);
                    listNums.Add(convert);
                }

                return listNums; 
            }

            //

            //Ending of helper functions for the first function
            /////////////////////////////////////////
            

            //A function that displays the original series
            void ShowSeries(List<double> series)
            {
                Console.WriteLine($"Original series: {string.Join(", ", series)}");
            }

            //A function that returns the series in reverse
             List<double> ReversOrder(List<double> series)
            {
                List<double> reversOrderList = new List<double>();
                for(int i = series.Count -1; i >= 0; i--)
                {
                    reversOrderList.Add(series[i]);
                }
                return reversOrderList;
            }  

            //Function that returns the series sorted from lowest to highest value
            List<double> SortedOrder(List<double> series)
            {
                List<double> sortedList = new List<double>([..series]);
                sortedList.Sort();
                return sortedList;
            }  

            //A function that returns the highest value
            double MaxValue(List<double> series)
            {
                double maxValue = series[0];
                for(int i = 1; i < series.Count; i++)
                {
                    if(series[i] > maxValue)
                    {
                        maxValue = series[i];
                    }  
                }
                return maxValue;
            } 

            //A function that returns the lowest value
            double MinValue(List<double> series)
            {
                double minValue = series[0];
                for(int i = 1; i < series.Count; i++)
                {
                    if(series[i] < minValue)
                    {
                        minValue = series[i];
                    }  
                }
                return minValue;
            }

            //A function that returns the numerical average of the series
            double Average(List<double> series)
            {
                double sumNums = SumSeries(series);//Using the ninth function Sum to sum the number in the list
                double average = sumNums / series.Count;
                return average; 
            }
            
            //A function that returns the lentgh of the series
            double LenSeries(List<double> series)
            {
                int counter = 0;
                foreach(int i in series)
                {
                    counter++;
                }
                return counter;
            }

            //A function that returns the sum of the numbers in list
            double SumSeries(List<double> series)
            {
                double sumOfNum = 0;
                foreach(double num in series)
                {
                    sumOfNum += num;
                }
                return sumOfNum;
            }

            //A function that prints a menu
            void showMenu()
            {             
                Console.WriteLine(@"
====================== MENU ======================
1.  Input a Series                (Replace current)
2.  Display Series                (Original order)
3.  Display Series                (Reversed order)
4.  Display Series                (Sorted low to high)
5.  Display Max Value             (Highest number)
6.  Display Min Value             (Lowest number)
7.  Display Average               (Mean of values)
8.  Display Number of Elements    (Count)
9.  Display Sum of Series         (Total)
10. Exit                          (Quit the program)
==================================================
");
                Console.Write("Enter your choice (1-10): ");
            }
        }   
    }
}