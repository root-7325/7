using System;
class pribavlenie
{
    static void Main()
    {
        int[] firstarr = { 1, 3, -5, 4 };
        int[] secondarr = { 1, 4, -5, -2 };
        for(int i = 0; i < firstarr.Length; i++)
        {
            Console.WriteLine(firstarr[i] * secondarr[i]);
        }
        Console.ReadKey(true);
    }
}
