using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace The_Series_Analyzer_project
{
    internal class Program
    {
        /*Function to open a menu*/
        static int GetMenuSelection()
        {
            int choose = 0;
            do
            {
                Console.WriteLine(
     @"                         ===== MAIN MENU =====

                Please choose an option from the menu below:

                 1. Input a new series (this will replace the current series).
                 2. Display the series in the order it was entered.
                 3. Display the series in reverse order.
                 4. Display the series sorted from low to high.
                 5. Show the maximum value in the series.
                 6. Show the minimum value in the series.
                 7. Calculate and display the average of the series.
                 8. Show the number of elements in the series.
                 9. Show the sum of all elements in the series.
                10. Exit the program.

                Enter your choice (1-10): ");

                string num = Console.ReadLine();
                bool chack = TryToConvertASingleNumber(num, out choose);
                if (!chack || choose < 1 || choose > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WARNING: Input error, please re-enter according to the item's requirements.");
                    Console.ResetColor();
                }
            }
            while (choose < 1 || choose > 10 );
            return choose;
        }

        /*Converts a single number from a string to a number*/
        static bool TryToConvertASingleNumber(string val, out int chack)
        {   
            return int.TryParse(val, out chack);
        }

        /*Checks whether the list is empty.*/
        static bool IsEmpty(List<int> SeriesLList)
        {
            if (SeriesLList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //static List<int> CreatesANewSeries(int[] series, List<int> SeriesList)
        //{
        //    SeriesList.Clear();
        //    SeriesList.AddRange(series);
        //    return SeriesList;
        //}


        /*A function that creates a new series*/
        static List<int> CreatesANewSeries(List<int>   SeriesList)
        {
            bool run;
            SeriesList.Clear(); //Clears the list
                    do
            {
                Console.WriteLine("enter a series");
                string StrSeries = Console.ReadLine();
                        run = SplitTheSeries(StrSeries, SeriesList); //  Inputs a string and returns me a list
                    }
            while (SeriesList.Count < 3 || !run);
            return SeriesList;   
        }

        //  Splits the string into elements
        static bool SplitTheSeries(String StrSeries, List<int> SeriesList)
        {
            String[] MyArray = StrSeries.Split(' ');
            foreach (string val in MyArray)
            {
                if (TryToConvertASingleNumber(val, out int num))
                {
                    int NewNum = ConvertStringToInt(val);
                    SeriesList.Add(NewNum);
                }
                else
                {
                    return false;
                }

            }
            return true;
        }


        static int ConvertStringToInt(string value)
        {
            return int.Parse(value);
        }

        static void PrintTheList(List<int> SeriesList)
        {
            foreach (int num in SeriesList)
            {
                Console.WriteLine(num);
            }
        }

        static void DisplaysInTheOrderEntered(List<int> SeriesList)
        {
            if (IsEmpty(SeriesList))
            {
                Console.WriteLine("the list is  empty");
            }
            else
            {
                PrintTheList(SeriesList);
            }
        }

        // Displays the list in reverse from the entry.
        static void DisplayReversedSeries(List<int> SeriesList)
        {
            if (IsEmpty(SeriesList))
            {
                return;
            }
            SeriesList.Reverse();
            PrintTheList(SeriesList);
        }

        //Displays the list in sorted order.
        static void DisplaySortedSeries(List<int> SeriesList)
        {
            if (IsEmpty(SeriesList))
            {
                return;
            }
            SeriesList.Sort();
            PrintTheList(SeriesList);
        }


        static void DisplayMaxValue(List<int> SeriesList)
        {
            if (IsEmpty(SeriesList))
            {
                return;
            }
            int maxi = 0;
            foreach (int num in SeriesList)
            {
                if (num > maxi)
                {
                    maxi = num;
                }
            }
            Console.WriteLine(maxi);
        }
        static void DisplayMinValue(List<int> SeriesList)
        {
            if (IsEmpty(SeriesList))
            {
                return;
            }
            int mini = SeriesList[0];
            foreach (int num in SeriesList)
            {
                if (mini > num)
                {
                    mini = num;
                }
            }
            Console.WriteLine(mini);
        }

        static double GetSeriesAverage(List<int> SeriesList)
        {
            if (IsEmpty(SeriesList))
            {
                return 0;
            }
            Double Avg = SumOfASeries(SeriesList) / LenghOfASeries(SeriesList);
            return Avg;
        }
        static int LenghOfASeries(List<int> SeriesList)
        {
            if(IsEmpty(SeriesList))
                { return 0; }

            int lengh = SeriesList.Count;
            return lengh;
        }
        static int SumOfASeries(List<int> SeriesList)
        {
            if (IsEmpty(SeriesList))
                {
                return 0;
            }
            int sumi = 0;
            foreach (int num in SeriesList)
            {
                sumi += num;
            }
            return sumi ;
        }

        static void ProcessMenuSelection(int num, List<int> SeriesList)
        {
            switch (num)
            {
                case 1:
                    CreatesANewSeries(SeriesList);
                    PrintTheList(SeriesList);
                    break;
                case 2:
                    DisplaysInTheOrderEntered(SeriesList);
                    break;
                case 3:
                    DisplayReversedSeries(SeriesList);
                    break;
                case 4:
                    DisplaySortedSeries(SeriesList);
                    break;
                case 5:
                    DisplayMaxValue(SeriesList);
                    break;
                case 6:
                    DisplayMinValue(SeriesList);
                    break;
                case 7:
                    Console.WriteLine( GetSeriesAverage(SeriesList));
                    break;
                case 8:
                    Console.WriteLine( LenghOfASeries(SeriesList));
                    break;
                case 9:
                    Console.WriteLine(SumOfASeries(SeriesList));
                    break;  
            }
        }

        static List<int> ConvertingFromAnArrayToAList(object[] array,List<int> SeriesList)
        {
            string result = string.Join(" ", array);
            SplitTheSeries(result, SeriesList);
            return SeriesList;
        }

        static  bool ChackTheLengh(List<int> SeriesList)
        {
            if (SeriesList.Count < 3)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int choose = 0;
            List<int> SeriesList = new List<int>();

            if (args.Length > 3)

            {
                List  <int> newList = new List<int>();
                int choose1 = GetMenuSelection();
                newList = ConvertingFromAnArrayToAList(args, SeriesList);
                ProcessMenuSelection(choose1, newList);
            }

            do
            {
                choose = GetMenuSelection();
                ProcessMenuSelection(choose, SeriesList);
            }
            while (choose != 10);

        }







    }
}





