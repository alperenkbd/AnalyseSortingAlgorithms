using System;

namespace sortingAlgorithmsAnalyse
{
    public class DataAttachmentToArray
    {

        
        Random rand = new Random();

        public int[] randomArray(int size){
            int[] unsortedArray = new int[size];

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = rand.Next(0,100);
            }
            
                
            return unsortedArray;
        }
    }
}