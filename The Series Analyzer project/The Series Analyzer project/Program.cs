using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace The_Series_Analyzer_project
{
    internal class Program
    {
        static int Menu()
        {
            Console.WriteLine(
                @"===== MAIN MENU =====

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
            int choose  = int.Parse(Console.ReadLine());
            return choose;
        }
        static void maneger(int num)
        {

        }
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
        static List<int> NewSeries(int[] series, List<int> SeriesLList)
        {
            SeriesLList.Clear();
            SeriesLList.AddRange(series);
            return SeriesLList;
        }

        static void PrintList(List<int> SeriesLList)
        {
            foreach (int num in SeriesLList)
            {
                Console.WriteLine(num);
            }
        }

        static void DisplayAsInserted(List<int> SeriesLList)
        {
            if (IsEmpty(SeriesLList))
            {
                Console.WriteLine("the list is  empty");
            }
            else
            {
                PrintList(SeriesLList);
            }
        }
        static List<int> ShowsAReverseSeries(List<int> SeriesLList)
        {
            if (IsEmpty(SeriesLList))
            {
                return null;
            }
            SeriesLList.Reverse();
            return SeriesLList;
        }

        static void ShoesReversSeries(List<int> SeriesLList)
        {
            if (IsEmpty(SeriesLList))
            {
                return;
            }
            SeriesLList.Reverse();
            PrintList(SeriesLList);

        }

        static void SortedDisplay(List<int> SeriesLList)
        {
            if (IsEmpty(SeriesLList))
            {
                return;
            }
            SeriesLList.Sort();
            PrintList(SeriesLList);
        }

        static void MaxDisplay(List<int> SeriesLList)
        {
            if (IsEmpty(SeriesLList))
            {
                return;
            }
            int maxi = 0;
            foreach (int num in SeriesLList)
            {
                if (num > maxi)
                {
                    maxi = num;
                }
            }
            Console.WriteLine(maxi);
        }
        static void MinDisplay(List<int> SeriesLList)
        {
            if (IsEmpty(SeriesLList))
            {
                return;
            }
            int mini = SeriesLList[0];
            foreach (int num in SeriesLList)
            {
                if (mini > num)
                {
                    mini = num;
                }
            }
            Console.WriteLine(mini);
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 5, 3, 2, 0 };
            List<int> SeriesLList = new List<int>();

            int choose = Menu();



        }

    }
}

