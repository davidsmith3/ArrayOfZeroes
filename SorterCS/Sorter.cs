using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterCS
{
    public class Sorter
    {
        public int[] Sort(int[] nums) {
            if ((nums.Length == 0) || (nums.Length == 1)) return nums;
            int lo = 0;
            int hi = nums.Length - 1;
            do {
                while ((hi > lo) && (nums[hi] == 0)) hi--;
                while ((lo < hi) && (nums[lo] != 0)) lo++;
                if (lo < hi) Swap(nums, lo, hi);
            } while (lo < hi);
            return nums;
        }

        private void Swap(int[] nums, int p, int q) {
            int temp = nums[p];
            nums[p] = nums[q];
            nums[q] = temp;
        }
    }
}
