// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// //0, 7, 8, -2, -2 -> 2
// //1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество вводимых с клавиатуры чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int count = 0;

//ввод элементов массива
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите число {i + 1}  ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

//вывод массива
Console.WriteLine("Вывод всех чисел: ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
    
    // считаем количество положительных чисел
    if (array[i] > 0)
    {
        count++;
    }
}
Console.Write("Количество положительных чисел: ");
Console.WriteLine(count);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите число b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.Write("Координата точки пересечения прямых: ");
// Console.WriteLine((x, y));