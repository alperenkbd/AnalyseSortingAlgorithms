using System;

namespace sortingAlgorithmsAnalyse
{
    public class SelectionSort : DataAttachmentToArray
    {
        
        private DateTime timeStart, timeFinish;
        private int minSearch;

        public void selectionSortMethod(int size)
        {
             int[] unsortedarr = new int[size];

            timeStart = DateTime.Now;

            for (int i = 0; i < unsortedarr.Length - 1; i++)
            {
                minSearch = i;

                for (int j = i + 1; j < unsortedarr.Length; j++)
                {
                    if (unsortedarr[j] < unsortedarr[minSearch])
                    {
                        minSearch = j;
                    }

                    int temp = unsortedarr[minSearch];
                    unsortedarr[minSearch] = unsortedarr[i];
                    unsortedarr[i] = temp;

                }
            }

            timeFinish = DateTime.Now;
            TimeSpan ts = (timeFinish - timeStart);

            Console.Write("\nselection sort execution time complexity : "+ts.ToString("ffff")+" ms");

            // for (int i = 0; i < unsortedarr.Length; i++)
            // {
            //     Console.Write(unsortedarr[i] + " ");
            // }


        }

    }
}