using System;
class Program
{
    static void Main()
    {
        int[] nums = { 12,34,5,1,2 };
        //int[] nums2;
        //int searchNum = 2;

        Array.ForEach(nums, delegate(int x) { x = x + 2; });
        foreach (int item in nums)
        {
            Console.Write(item + " ");
        }


        #region Comments
        /*
        Array.Copy(nums, nums2, nums.Length);
        foreach (int item in nums2)
        {
            Console.Write(item + " ");
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
         * ////////////////////////////////////////////////////////////////
        myclass[] newItems = new myclass[5];
        newItems[0] = new myclass(5);
        newItems[1] = new myclass(1);
        newItems[3] = new myclass(2);
        newItems[2] = new myclass(3);
        newItems[4] = new myclass(4);
        Array.ForEach(newItems, Program.Negate);

        foreach (myclass item in newItems)
        {
            Console.Write(item.i+" ");    
        }
        */
        #endregion

        Console.ReadLine();
    }
    static void Negate(int o)
    {
        o *= o;
    }
    static void Negate(myclass o)
    {
        o.i = -o.i;
    }
}
class myclass
{
    public int i;
    public myclass(int i)
    {
        this.i = i;
    }
}