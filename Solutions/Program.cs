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
            Solution.WordsFrequency w = new Solution.WordsFrequency(new string[]{"i", "have", "an", "apple", "he", "have", "a", "pen"});
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var a = w.Get("have");
            var result = solution.BusyStudent(new int[] { 1, 2, 3 }, new int[] { 3, 2, 7 }, 4);
            stopwatch.Stop();
            Console.WriteLine($"Result:{result}");
            Console.WriteLine($"Run Time:{stopwatch.ElapsedMilliseconds}");
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
        //面试题 16.02. 单词频率
        public class WordsFrequency
        {
            private string[] Book{get;set;}
            public WordsFrequency(string[] book)
            {
                Book = book;
            }

            public int Get(string word)
            {
                var count = 0;
                var b = Book.GroupBy(b=>b);
                return count;
            }
        }

        //1450. 在既定时间做作业的学生人数
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                {
                    count++;
                }
            }
            return count;
        }


        //989. 数组形式的整数加法

        //类型长度不够
        // 输入：A = [9,9,9,9,9,9,9,9,9,9], K = 1
        // 输出：[1,0,0,0,0,0,0,0,0,0,0]
        // 解释：9999999999 + 1 = 10000000000

        public IList<int> AddToArrayForm(int[] A, int K)
        {

            var sb = new StringBuilder();
            for (int i = 0; i < A.Length; i++)
            {
                sb.Append(A[i]);
            }
            ulong numA = 0;
            ulong.TryParse(sb.ToString(), out numA);
            var str = (numA + (ulong)K) + "";
            var list = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                ulong _ = 0;
                ulong.TryParse(str[i] + "", out _);
                list.Add((int)_);
            }
            return list;
        }
        //905. 按奇偶排序数组
        public int[] SortArrayByParity(int[] A)
        {
            var odd = new List<int>();
            var even = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 1)
                {
                    odd.Add(A[i]);
                }
                else
                {
                    even.Add(A[i]);
                }
            }
            even.AddRange(odd);
            return even.ToArray();
        }
        //344. 反转字符串
        public void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                (s[i], s[j]) = (s[j], s[i]);
                i++;
                j--;
            }
        }


        //1480. 一维数组的动态和
        public int[] RunningSum(int[] nums)
        {
            var runingnums = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                var sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += nums[j];
                }
                runingnums.Add(sum);
            }
            return runingnums.ToArray();
        }
        //剑指 Offer 03. 数组中重复的数字
        public int FindRepeatNumber(int[] nums)
        {
            Array.Sort(nums);
            var num = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (num == nums[i])
                {
                    return num;
                }
                num = nums[i];
            }
            return 0;
        }
        //1523. 在区间范围内统计奇数数目
        public int CountOdds(int low, int high)
        {
            int num = 1;
            if (low % 2 == 0 && high % 2 == 0)
            {
                num = 0;
            }
            return ((high - low) / 2) + num;
        }
        //557. 反转字符串中的单词 III
        public string ReverseWords557(string s)
        {
            var arr = s.Split(" ");
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Clear();
                for (int j = 0; j < arr[i].Length; j++)
                {
                    stack.Push(arr[i][j]);
                }
                arr[i] = new string(stack.ToArray());
            }
            return string.Join(' ', arr);
        }

        //1. 两数之和
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        //剑指 Offer 15. 二进制中1的个数
        public int HammingWeight(uint n)
        {
            var bit = Convert.ToString(n, 2);
            int count = 0;
            for (int i = 0; i < bit.Length; i++)
            {
                if (bit[i] == '1')
                {
                    count++;
                }
            }
            return count;
        }

        //551. 学生出勤记录 I
        public bool CheckRecord(string s)
        {
            if (s.IndexOf("LLL") != -1)
            {
                return false;
            }

            int sub = 0;
            int count = 0;
            for (int i = 0; i < 2; i++)
            {
                var indexof = s[sub..s.Length].IndexOf("A");
                if (indexof != -1)
                {
                    sub = indexof + 1;
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count == 2)
            {
                return false;
            }

            return true;
        }

        //剑指 Offer 58 - I. 翻转单词顺序
        public string ReverseWords(string s)
        {
            var arr = s.Split(' ');
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    stack.Push(arr[i]);
                }
            }
            return string.Join(' ', stack);
        }

        //面试题 05.06. 整数转换
        public int ConvertInteger(int A, int B)
        {
            //汉明距离
            int n = A ^ B;
            int count = 0;
            while (n != 0)
            {
                n = (n & n - 1);
                ++count;
            }
            return count;
        }
        //1009. 十进制整数的反码
        public int BitwiseComplement(int N)
        {
            string bit = Convert.ToString(N, 2);
            List<char> result = new List<char>();
            for (int i = 0; i < bit.Length; i++)
            {
                if (bit[i] == '0')
                {
                    result.Add('1');
                }
                else
                {
                    result.Add('0');
                }
            }
            var str = new string(result.ToArray());
            return Convert.ToInt32(str, 2);
        }
        public int ArrangeCoins(int n)
        {
            int i = 1;
            while (n > 0)
            {
                n = n - i;
                if (n < 0)
                {
                    break;
                }
                i++;
            }
            return i - 1;
        }

        //public int[] MaxSlidingWindow(int[] nums, int k)
        //{
        //    var result = new List<int>();
        //    for (int i = 0; i < nums.Length-1; i++)
        //    {
        //        if (i+k<=nums.Length)
        //        {
        //            var windowNums = nums[i..(i + k)];
        //            for (int j = 0; j < windowNums.Length-1; j++)
        //            {
        //                if (windowNums[j]>windowNums[j+1])
        //                {
        //                    var temp = windowNums[j];
        //                    windowNums[j] = windowNums[j + 1];
        //                    windowNums[j + 1] = temp;
        //                }
        //            }
        //            result.Add(windowNums[windowNums.Length - 1]);
        //        }
        //    }
        //    return result.ToArray();
        //}

        /// <summary>
        /// 9. 回文数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            var str = x + "";
            var left = 0;
            var right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        /// <summary>
        /// 1346. 检查整数及其两倍数是否存在
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[j] == 2 * arr[i])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 1317. 将整数转换为两个无零整数的和
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] GetNoZeroIntegers(int n)
        {

            var target = new int[] { 1, n - 1 };
            bool flg = true;
            while (flg)
            {
                if (target[0].ToString().IndexOf('0') != -1 || target[1].ToString().IndexOf('0') != -1)
                {
                    target[0] += 1;
                    target[1] -= 1;
                }
                else
                {
                    flg = false;
                }
            }
            return target;
        }

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
                if (letters[i] > target)
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
                if (left == right)
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
