using System.Collections.Generic;

namespace SortAlgorithms.Sorts
{
    public class InsertionSort
    {
        public List<int> Sort(List<int> unsorted)
        {
            
            for (int i = 1; i < unsorted.Count; i++)
            {
                int currentValue = unsorted[i];
                int lastPos = i - 1;

                while (lastPos>= 0 && currentValue < unsorted[lastPos])
                {
                    unsorted[lastPos + 1] = unsorted[lastPos];
                    lastPos--;
                }

                unsorted[lastPos + 1] = currentValue;
            }

            return unsorted;
        }
    }
}