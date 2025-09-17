// using System;

// class Method
// {
//     public static double CalculateStats(out int min, out int max,params int[] nums)
//     {
//         if (nums == null || nums.Length == 0)
//         {
//             min = 0;
//             max = 0;
//             return 0;
//         }

//         min = nums[0];
//         max = nums[0];
//         int sum = 0;

//         foreach (int n in nums)
//         {
//             if (n < min)
//                 min = n;
//             if (n > max)
//                 max = n;

//             sum += n;
//         }

//         return (double)sum / nums.Length;
//     }

//     static void Main()
//     {
//         int min, max;
//         double avg = CalculateStats( out min, out max, 23,5,78,90,54);

//         Console.WriteLine($"Min: {min}");
//         Console.WriteLine($"Max: {max}");
//         Console.WriteLine($"Average: {avg}");
//     }
// }
