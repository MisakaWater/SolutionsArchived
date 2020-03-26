using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            Sort sort = new Sort();
            var result = solution.NextGreatestLetter(new char[] { 'c', 'f', 'j' },'a');

        }

    }
    public class Sort
    {
        /// <summary>
        /// 冒泡算法，找出数组中最大的数
        /// </summary>
        /// <param name="nums">数组</param>
        /// <param name="n">对前n项冒泡</param>
        /// <returns></returns>
        public int[] Bubble(int[] nums, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    var temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                }
            }
            return nums;
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] nums)
        {
            for (int i = nums.Length; i >= 1; i--)
            {
                Bubble(nums, i);
            }
            return nums;
        }
    }
    /// <summary>
    /// leetcode-cn.com 题库
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 744. 寻找比目标字母大的最小字母
        /// </summary>
        /// <param name="letters"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public char NextGreatestLetter(char[] letters, char target)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i]>target)
                {
                    return letters[i];
                }
            }
            return letters[0];
        }

        /// <summary>
        /// 724. 寻找数组的中心索引
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int PivotIndex(int[] nums)
        {
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                left += nums[i];
                int right = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    right += nums[j];
                }
                if (left==right)
                {
                    return i;
                }

            }
            return -1;
        }


        /// <summary>
        /// 709. 转换成小写字母
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ToLowerCase(string str)
        {
            var arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    arr[i] = (char)(arr[i] | 0x20);
                }
            }
            return new string(arr);
        }

        /// <summary>
        /// 461. 汉明距离
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int HammingDistance(int x, int y)
        {
            int n = x ^ y;
            int count = 0;
            while (n != 0)
            {
                n = (n & n - 1);
                ++count;
            }
            return count;
        }

        /// <summary>
        /// 1323. 6 和 9 组成的最大数字
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int Maximum69Number(int num)
        {
            string str = num + "";
            int index = str.IndexOf("6");
            if (index == -1)
            {
                return num;
            }
            char[] arr = str.ToCharArray();
            arr[index] = '9';
            return int.Parse(new string(arr));
        }

        /// <summary>
        /// 912. 排序数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SortArray(int[] nums)
        {

            for (int i = nums.Length; i >= 1; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            return nums;
        }

        /// <summary>
        /// 面试题 16.01. 交换数字
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] SwapNumbers(int[] numbers)
        {
            numbers[0] = numbers[0] ^ numbers[1];
            numbers[1] = numbers[0] ^ numbers[1];
            numbers[0] = numbers[0] ^ numbers[1];
            return numbers;
        }

        /// <summary>
        /// 面试题64. 求1+2+…+n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SumNums(int n)
        {
            int sum = n;
            bool b = (n > 0) && ((sum += SumNums(n - 1)) > 0);
            return sum;
        }


        /// <summary>
        /// 1108. IP 地址无效化
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public string DefangIPaddr(string address)
        {
            StringBuilder stringBuilder = new StringBuilder(address);
            const char dot = '.';
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] == dot)
                {
                    stringBuilder.Insert(i + 1, ']');
                    stringBuilder.Insert(i, '[');
                    i += 3;
                }
            }
            return stringBuilder + "";
        }
        /// <summary>
        /// 771. 宝石与石头
        /// </summary>
        /// <param name="J"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        public int NumJewelsInStones(string J, string S)
        {

            //var list = S.ToList();
            //IEnumerable<char> b = null;
            //for (int i = 0; i < J.Length; i++)
            //{
            //    b = list.Where(x => x == J[i]);
            //}
            //return b.Count();
            int Count = 0;
            foreach (var item in J)
            {
                foreach (var Sitem in S)
                {
                    if (item == Sitem)
                    {
                        Count++;
                    }
                }
            }
            return Count;

        }


        /// <summary>
        /// 1295. 统计位数为偶数的数字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindNumbers(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var a = (int)Math.Log10(nums[i]);
                if ((int)(Math.Log10(nums[i]) + 1) % 2 == 0)
                {
                    count++;
                }
            }
            return count;
            #region 解2
            //int count = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if ((nums[i] + "").Length % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //return count;
            #endregion
            //#region 解1
            //int num = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int count = 0;
            //    while (nums[i] > 0)
            //    {
            //        nums[i] /= 10;
            //        count++;
            //    }
            //    if (count % 2 == 0)
            //    {
            //        num++;
            //    }
            //}
            //return num;
            //#endregion
        }

        /// <summary>
        /// 1281. 整数的各位积和之差
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SubtractProductAndSum(int n)
        {
            int sum = 0;
            int product = 1;
            while (n > 0)
            {
                int digit = n % 10;//！取出每一位数字
                n /= 10;
                sum += digit;
                product *= digit;
            }
            return product - sum;
        }
        /// <summary>
        /// 面试题 10.01. 合并排序的数组
        /// </summary>
        /// <param name="A"></param>
        /// <param name="m"></param>
        /// <param name="B"></param>
        /// <param name="n"></param>
        public void Merge(int[] A, int m, int[] B, int n)
        {
            var sorted = new int[A.Length];
            int pa = 0;
            int pb = 0;
            int cur;
            while (pa < m || pb < n)
            {
                if (pa == m)
                    cur = B[pb++];
                else if (pb == n)
                    cur = A[pa++];
                else if (A[pa] < B[pb])
                    cur = A[pa++];
                else
                    cur = B[pb++];
                sorted[pa + pb - 1] = cur;
            }
            for (int i = 0; i != m + n; i++)
            {
                A[i] = sorted[i];
            }
            ;
        }

        /// <summary>
        /// 1365. 有多少小于当前数字的数字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        arr[i]++;
                    }
                }
            }
            return arr;
        }
        /// <summary>
        /// 缺失数字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumber(int[] nums)
        {
            var list = nums.ToList();
            list.Sort();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != list[i])
                {
                    return i;
                }

            }
            return -1;
        }
        /// <summary>
        /// 打印从1到最大的n位数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] PrintNumbers(int n)
        {
            int[] nums = new int[((int)Math.Pow((double)10, (double)n)) - 1];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }
            return nums;
        }

        /// <summary>
        /// 按既定顺序创建目标数组
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var target = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                target.Insert(index[i], nums[i]);
            }
            return target.ToArray();
        }
        /// <summary>
        /// 左旋转字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string ReverseLeftWords(string s, int n)
        {
            //return s[n..s.Length] + s[0..n];//C#8.0,NetCore3.0数组切片新特性
            var strRight = "";
            var strLeft = "";
            for (int i = 0; i < s.Length; i++)
            {
                _ = i < n ? strLeft += s[i] : strRight += s[i];

                //if (i < n)
                //{
                //    strLeft += s[i];
                //}
                //else
                //{
                //    strRight += s[i];
                //}

            }
            return strRight + strLeft;
        }

        /// <summary>
        /// 最小的k个数
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            Array.Sort(arr);
            return arr[0..k];//C#8.0,NetCore3.0数组切片新特性
            var nums = new int[k];
            Array.Copy(arr, 0, nums, 0, k);
            return nums;
        }


        /// <summary>
        /// 替换空格
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReplaceSpace(string s)
        {
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                str += s[i] == ' ' ? "%20" : s[i].ToString();
            }
            return str;
        }
        /// <summary>
        /// 将数字变成 0 的操作次数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int NumberOfSteps(int num)
        {
            int Count = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                Count++;
            }
            return Count;
        }
    }
}
