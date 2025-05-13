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
                List<double> input = NewSeries();//This is where the first series will come in || Temporary!!!

                Console.Write("pleas enter number: ");
                int user1 = int.Parse(Console.ReadLine()!);//Request a number from the user to select a function|| Temporary!!!

                switch (user1)
                {
                    case 1:          
                        input = NewSeries();//The first function - to create a new series
                        break;

                    case 2:                    
                        ShowSeries(input);//The second function - which print the original series
                        break;

                    case 3:   
                        ReversOrder(input);//The third function - which returns the series in reverse                                  
                        break;

                    case 4:                    
                        SortedOrder(input);//The fourth function - which returns the series sorted from lowest to highest value
                        break;

                    case 5:                    
                        MaxValue(input);//The fifth function - which returns the highest number in the series
                        break;

                    case 6:                    
                        MinValue(input);//The sixth function - which returns the lowest number in the series
                        break;

                    case 7:                    
                        Average(input);//The seventh function - which returns the numerical average of the series
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


            //Function that creates a new series
            List <double> NewSeries()
            {
                string numbers = Console.ReadLine()!;//Receive a string from the user
                if(IsEmpty(numbers))//Check if the string is empty
                {
                    Console.WriteLine("The series empty try egain");
                    List<double> error = new List<double>{-1};
                    return error; //Sends a message that the string is empty and returns a list with the digit minus one.                
                }

                string cleanNumbers = CleanString(numbers); //Cleaning from signs and letters
                List <double> listNums = MakeListNums(cleanNumbers); //Converts the string to a list

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
                       System.Console.WriteLine(num);
                    }
                }
                return numbers;
            }

            //A function that checks whether a string is empty
            bool IsEmpty(string numbers)
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

            //Ending of helper functions for the first function
            /////////////////////////////////////////
            

            //A function that displays the original series
            void ShowSeries(List<double> series)
            {
                Console.WriteLine(string.Join(", ", series));
            }

            //A function that returns the series in reverse
             void ReversOrder(List<double> series)
            {
                Console.Write("The reversed order: ");
                for(int i = series.Count()-1; i >= 0; i--)
                {
                    Console.Write($"{series[i]}, ");
                }

                Console.WriteLine();
                Console.Write("The original order: ");
                ShowSeries(series);//Using the second function to display the difference between the original and reverse list 
            }  

            //Function that returns the series sorted from lowest to highest value
            void SortedOrder(List<double> series)
            {
                List<double> sortedList = new List<double>([..series]);
                sortedList.Sort();
                Console.WriteLine(string.Join(", ", sortedList));
            }  

            //A function that returns the highest value
            void MaxValue(List<double> series)
            {
                double maxValue = series[0];
                for(int i = 1; i < series.Count; i++)
                {
                    if(series[i] > maxValue)
                    {
                        maxValue = series[i];
                    }  
                }
                Console.WriteLine($"{maxValue}");
            } 

            //A function that returns the lowest value
            void MinValue(List<double> series)
            {
                double minValue = series[0];
                for(int i = 1; i < series.Count; i++)
                {
                    if(series[i] < minValue)
                    {
                        minValue = series[i];
                    }  
                }
                Console.WriteLine($"{minValue}");
            }

            //A function that returns the numerical average of the series
            void Average(List<double> series)
            {
                double sumNums = SumList(series);
                double average = sumNums / series.Count;
                Console.WriteLine($"The average: {average}"); 
            }

            //Helper function for the average function
            double SumList(List<double> series)
            {
                double sumOfNum = 0;
                foreach(double num in series)
                {
                    sumOfNum += num;
                }
                return sumOfNum;
            }
        }   
    }
}