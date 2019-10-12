using System.Collections.Generic;

namespace SortAlgorithms.Sorts
{
    public class SelectionSort
    {
        public List<int> Sort(List<int> unsorted)
        {
            for (int i = 0; i < unsorted.Count; i++)
            {
                int minor = i;
                for (int j = i + 1; j < unsorted.Count; j++)
                {
                    if (unsorted[i] > unsorted[j])
                    {
                        minor = j;
                    }
                }

                if (i == minor) continue;
                
                int aux = unsorted[i];
                unsorted[i] = unsorted[minor];
                unsorted[minor] = aux;
            }

            return unsorted;
        }
    }
}