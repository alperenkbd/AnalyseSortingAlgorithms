using System;


namespace sortingAlgorithmsAnalyse
{
    public class insertionSort : DataAttachmentToArray
    {
        
        private DateTime timeStart, timeFinish;

        public void insertionSortMethod(int size)
        {
             int[] unsortedarr = new int[size];
            int first, i, j;
            timeStart = DateTime.Now;

            for (i = 1; i < unsortedarr.Length; ++i)
            {


                first = unsortedarr[i];
                j = i - 1;
                while (0 <= j && first < unsortedarr[j])
                {
                    unsortedarr[j + 1] = unsortedarr[j];
                    j--;
                }
                unsortedarr[j+1] = first;
            }

            timeFinish = DateTime.Now;
            TimeSpan ts = (timeFinish - timeStart);
            
            Console.Write("\ninsertion sort execution time complexity : "+ts.ToString("ffff")+" ms");
            // for (int a = 0; a < unsortedarr.Length; a++)
            // {
            //     Console.Write(unsortedarr[a] + " ");
            // }
        }



    }
}