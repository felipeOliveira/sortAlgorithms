using System.Collections.Generic;

namespace SortAlgorithms.Sorts
{
    public class BubbleSort
    {
        //best case O(n)
        //worst case O(n²)
        public List<int> Sort(List<int> unsorted)
        {
            bool swap;

            do
            {
                swap = false;
                for (int i = unsorted.Count-1; i > 0; i--)
                {
                    if (unsorted[i] < unsorted[i -1])
                    {
                        int aux = unsorted[i];
                        unsorted[i] = unsorted[i -1];
                        unsorted[i-1] = aux;
                        swap = true;
                    }
                }
            } while (swap);

            return unsorted;
        }
    }
}