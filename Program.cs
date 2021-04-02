using System;

namespace sortingAlgorithmsAnalyse
{

    class Program
    {
        static void choosing()
        {
            Console.WriteLine("enter array size between 10 and 10000");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose your method: \n0-insertion sort\n1-selection sort");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    insertionSort insertion = new insertionSort();
                    insertion.randomArray(sizeOfArray);
                    insertion.insertionSortMethod(sizeOfArray);
                    break;
                case 1:
                    SelectionSort selection = new SelectionSort();
                    selection.randomArray(sizeOfArray);
                    selection.selectionSortMethod(sizeOfArray);
                    break;
                default:
                    Console.WriteLine("bug!");
                    break;
            }

            Console.Read();
        }


        static void Main(string[] args)
        {
            choosing();
        }
    }
}
