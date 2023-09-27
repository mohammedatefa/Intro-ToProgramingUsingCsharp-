using System; 
internal class Program
{
    static int Sum(int n)
    {
        
        if (n == 1)
        {
            return 1;
        }
        
        else
        {
            return n + Sum(n - 1);
        }
    }
    static int GCD(int a, int b)
    {
        
        if (b == 0)
        {
            return a;
        }
        
        else
        {
            return GCD(b, a % b);
        }
    }

    static void Main(string[] args)
    {
        // 1- •	Program to add two matrix [2D Array] and put the result in a third one, then print the result

        int[,] matrix_one = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matrix_two = new int[,] { { 10,11,12 }, { 13,14,15 }, { 16,17,18} };

        int numRows = matrix_one.GetLength(0);
        int numCols = matrix_one.GetLength(1);

        int[,] matrix_three = new int[numRows, numCols];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                matrix_three[i, j] = matrix_one[i, j] + matrix_two[i, j];
            }
        }

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write($" {matrix_three[i, j]}  ");
            }
            Console.WriteLine("\n");
        }
        //--------------------------------------------------------------------------------------
        // 2 •	Program to find Sum & Average of 2D Array.
        int[,] avg_matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        int count = avg_matrix.GetLength(0) * avg_matrix.GetLength(1);
        int sum = 0;
        int avg = 0;

        for (int i = 0; i < avg_matrix.GetLength(0); i++)
        {
            for (int j = 0; j < avg_matrix.GetLength(1); j++)
            {
                sum += avg_matrix[i, j];
            }
        }

        avg = sum / count;
        Console.WriteLine($"the sum of matrix is = {sum} and the average is {avg}");

        //----------------------------------------------------------------------------------------
        // 3 •	Program to Find the Frequency of Characters in a String
        string myString = "welcome on ITI";
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (var item in myString)
        {
            if (freq.ContainsKey(item))
            {
                freq[item]++;
            }
            else
            {
                freq.Add(item, 1);
            }
        }

        foreach (var item in freq)
        {
            Console.WriteLine($"the char is {item.Key} and its freq is {item.Value}");
        }

        //4 •	Program to Remove all Characters in a String Except Alphabet
        string myclearstring = "welcome on ITI";
        List<string> myresualt = new List<string>();

        foreach (var item in myclearstring)
        {
            if (char.IsUpper(item)|| char.IsLower(item))
            {
                myresualt.Add(item.ToString());
            }           
        }
        foreach (var item in myresualt)
        {
            Console.WriteLine(item);
        }

        //5 •	Write a function takes array as parameter, and returns the largest number
        int largerNum(int[] arr)
        {
            int larger = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > larger)
                {
                    larger = arr[i];
                }
            }
            return larger;
        }
        int[] arr = { 5, 12, 6, 8, 44, 92, 100, 500 };
        int larger = largerNum(arr);

        //6•	Program that takes an array of integers and pass that array to a function to print array
        //values after multiplying them to 10. 
        int[] multirNum(int[] arr)
        {
            int[] ints = new int[arr.Length];   
            for (int i = 0; i < arr.Length - 1; i++)
            {
                ints[i] = arr[i] * 10;
            }
            return ints;
        }
        int[] nums = {5,2,3,6,7};
        int[] multinum = multirNum(nums);
        foreach (var item in multinum)
        {
            Console.WriteLine(item);
        }

        //7•	Make function that calculate the sum of numbers from 1 to n using recursion.
        Console.WriteLine(Sum(11));

        //8 Console.WriteLine(GCD(24, 36));
        Console.WriteLine(GCD(24, 36));

    }
}