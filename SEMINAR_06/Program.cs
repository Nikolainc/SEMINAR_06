class Program
{
    private static void Main(string[] args)
    {
        #region SEMINAR

        #region Задача 1         
        //Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
        //с сторонами такой длины.

        //int A;
        //int B;
        //int C;
        //Console.Write("Введите длинну первой стороны треугольника: ");
        //int.TryParse(Console.ReadLine(), out A);
        //Console.Write("Введите длинну второй стороны треугольника: ");
        //int.TryParse(Console.ReadLine(), out B);
        //Console.Write("Введите длинну третьей стороны треугольника: ");
        //int.TryParse(Console.ReadLine(), out C);

        //if (A + B > C && B + C > A && A + C > B)
        //{
        //    Console.WriteLine("Это треугольник!");
        //}
        //else
        //{
        //    Console.WriteLine("Это не треугольник :(");
        //}

        #endregion

        #region Задача 2
        //**Задача 42:**Напишите программу, которая будет преобразовывать десятичное число в двоичное.
        //45-> 101101
        //3-> 11
        //2-> 10

        //int value;
        //int.TryParse(Console.ReadLine(), out value);

        //Console.WriteLine(Convert.ToString(value, 2));

        //string result = "";

        //while (value > 0)
        //{
        //    value = Math.DivRem(value, 2, out var rem);
        //    result += rem.ToString();
        //}

        //Console.WriteLine(new string (result.Reverse().ToArray()));

        #endregion

        #region Задача 3
        //**Задача 44:**Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
        //Если N = 5-> 0 1 1 2 3
        //Если N = 3-> 0 1 1
        //Если N = 7-> 0 1 1 2 3 5 8
        //Console.WriteLine("Введите N: ");
        //int[] array = new int[int.Parse(Console.ReadLine())];
        //array[0] = 0;
        //array[1] = 1;

        //for (int i = 2; i < array.Length; i++)
        //{
        //    array[i] = array[i - 1] + array[i - 2];
        //}
        //Console.WriteLine(String.Join(" ", array));

        #endregion

        #region Задача 4
        //Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

        //int[] array = GetArray(10, -10, 10);
        //PrintArray(array);
        //int[] array2 = new int[array.Length];

        //for (int i = 0; i < array.Length; i++)
        //{
        //    array2[i] = array[i];
        //}

        //Console.WriteLine();
        //PrintArray(array2);

        #endregion

        #endregion

        #region HOMEWORK

        #region Задача 41
        //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        //0, 7, 8, -2, -2-> 2
        //1, -7, 567, 89, 223-> 3

        //int[] myArray = GetArray(10, -10, 10); // можно создать массив
        //FillArray(myArray); // можно вручную заполнить
        //int counter = 0;

        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] > 0)
        //    {
        //        counter++;
        //    }
        //}

        //Console.Write($"Количество четных чисел в массиве: ");
        //PrintArray(myArray);
        //Console.WriteLine($"\n>{counter} шт");

        #endregion

        #region Задача 43
        //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
        //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        //b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

        float y;
        float x;
        float b1;
        float k1;
        float b2;
        float k2;
        Console.Write("Заполните значения первого отрезка: \n");
        Console.Write("b1: ");
        float.TryParse(Console.ReadLine(), out b1);
        Console.Write("k1: ");
        float.TryParse(Console.ReadLine(), out k1);
        Console.Write("Заполните значения первого отрезка: \n");
        Console.Write("b2: ");
        float.TryParse(Console.ReadLine(), out b2);
        Console.Write("k2: ");
        float.TryParse(Console.ReadLine(), out k2);

        if (b2 == b1 || k1 == k2)
        {
            Console.WriteLine("Отрезки не пересекаются");
        }
        else
        {
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;

            Console.WriteLine($"Точка пересечения отрезков ({x}, {y})");
        }

        #endregion

        #endregion
    }
    static int[] GetArray()
    {
        int[] array = new int[10];

        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0, 10);
        }

        return array;
    }
    static int[] GetArray(int size, int min, int max)
    {
        int[] array = new int[size];

        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(min, max);
        }

        return array;
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
    static void FillArray(int[] array)
    {
        Console.WriteLine("=== Заполнение массива в ручную ===");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите значение для {i} элемента: ");
            array[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"Массив заполнен");
        PrintArray(array);
    }
}
