using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDojo
{
    class MaximumLengthOfRepeatedSubarray
    {
        public int FindLength(int[] nums1, int[] nums2)
        {
            int max = 0;
            int[,] matrix = new int[nums1.Length + 1, nums2.Length + 1];
            for (int i = 0; i < nums1.Length; i++)
                for (int j = 0; j < nums2.Length; j++)
                    if (nums1[i] == nums2[j])
                    {
                        matrix[i + 1, j + 1] = matrix[i, j] + 1;
                        max = Math.Max(max, matrix[i + 1, j + 1]);
                    }
            return max;
        }
    }
}
