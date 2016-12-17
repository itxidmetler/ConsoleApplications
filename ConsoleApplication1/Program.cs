using System;
class Program
{
    static void Main()
    {
        int[] nums = { 12,34,5,1,2 };
        int[] nums2=new int[nums.Length];
        Array.Copy(nums, nums2, nums.Length);
        foreach (int item in nums2)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
        nums2[0] = 0;
        foreach (int item in nums)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        foreach (int item in nums2)
        {
            Console.Write(item + " ");
        }
        Console.ReadLine();
    }
}