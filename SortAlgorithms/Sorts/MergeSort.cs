using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.Sorts
{
    public class MergeSort
    {
        //O(n log n)
        public List<int> Sort(List<int> unsorted)
        {
            if (unsorted.Count == 1)
                return unsorted;

            var dimension = unsorted.Count / 2;
            
            List<int> left = new List<int>(dimension);
            List<int> right = new List<int>(unsorted.Count - dimension);

           left.AddRange(unsorted.GetRange(0, dimension));
           right.AddRange(unsorted.GetRange(dimension, unsorted.Count - dimension));
           

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        private List<int>  Merge(IList<int> left, IList<int> right)
        {
            
            List<int> ordenedList = new List<int>(left.Count + right.Count);
            
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    var leftElement = left.First();
                    var rightElement = right.First();

                    if (leftElement > rightElement)
                    {
                        ordenedList.Add(rightElement);
                        right.Remove(rightElement);
                    }
                    else
                    {
                        ordenedList.Add(leftElement);
                        left.Remove(leftElement);
                    }
                }else if (left.Count > 0)
                {
                    var leftElement = left.First();
                    ordenedList.Add(leftElement);
                    left.Remove(leftElement);
                }
                else 
                {
                    var rightElement = right.First();
                    ordenedList.Add(rightElement);
                    right.Remove(rightElement);
                    
                }
            }

            return ordenedList;
        }
    }
}