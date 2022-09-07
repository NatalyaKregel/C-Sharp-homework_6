/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.Write("Введите количество чисел M - "); 
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пользователь ввел с клавиатуры: "); 
int []array = new int[M];
FillArray(array);
FindPositiveNumber(array);

// метод заполнения массива
void FillArray (int[]array)
{
    for (int i=0; i < M; i++)
    {
        array[i]=new Random().Next(-10,11);
        Console.Write(array[i]+ ", ");
    }
Console.WriteLine();
}

//Метод нахождения положительных чисел
void FindPositiveNumber(int[]array)
{
    int count = 0;
    for (int j = 0; j < M; j++)
    {
        if (array [j] >= 0)
        {
            count++;
        }        
    }
    Console.WriteLine($"Из них {count} чисел являются положительными (т.е.> 0) ");
}
Console.WriteLine();


