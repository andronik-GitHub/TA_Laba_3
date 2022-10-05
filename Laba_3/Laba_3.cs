using System;

class Laba_3
{
    static void Main()
    {
        Console.Write("Size: ");
        int? size = Convert.ToInt16(Console.ReadLine());


        int[] arr = new int[(int)size];

        for (int i = 0; i < size; i++)
        {
            Random rand = new();
            arr[i] = rand.Next(0, 50);
        }

        Console.WriteLine("\nArray");
        output(arr);


        Console.WriteLine("\n\nSorting");
        sorting(arr);
        output(arr);


        Console.ReadKey();
    }

    static void output(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write($"{arr[i]} ");
    }

    static void sorting(int[] arr) 
    { 
        for (int i = 1; i < arr.Length; i++)
        {
            int temp = arr[i];
            int j = i;

            while (j > 0 && arr[j - 1] > temp)
            {
                int Temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;

                j--;
            }

            arr[j] = temp;
        }
    }
}