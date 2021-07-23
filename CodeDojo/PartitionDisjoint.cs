using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDojo
{
    public partial class Solution
    {
        public int PartitionDisjoint(int[] nums)
        {
            var len = 1;
            var max = nums[0];
            var maxSeen = nums[0];
            for (var i = 0; i < nums.Length; i++)
            {
                maxSeen = Math.Max(nums[i], maxSeen);
                if (max <= nums[i]) continue;
                max = maxSeen;
                len = i + 1;
            }
            return len;
        }
    }
}
