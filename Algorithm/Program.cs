using System;
class Program
{
    static void Main(string[] args)
    {
        int[] coinDenoms = {1,2,5,10,20,50,100};
        int[] coinValues = { 1, 2, 5, 10, 20, 50, 100 };
        int[] coinCount= new int[coinDenoms.Length];

        int amount = 36;
        int[] result= new int[coinDenoms.Length];

        for (int i=coinDenoms.Length - 1; i>=0; i--)
        {
            int count = amount / coinDenoms[i];
            amount -= count * coinDenoms[i];
            result[i] += count;
        }
        Console.WriteLine("Minimum number of coins needed: " + string.Join(",", result));

    }
}