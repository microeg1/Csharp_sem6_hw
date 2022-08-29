using System;
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
class Program
{
    static void FillNums(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static int CheckNums(int[] arr)
    {
        int count = 0;
          for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0) count++;
        }
        return count;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел, которые хотите проверить.");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[length];
        Console.WriteLine("Введите значения.");
        FillNums(nums);
        Console.WriteLine($"{CheckNums(nums)} введенных чисел больше нуля.");
      
    }
}