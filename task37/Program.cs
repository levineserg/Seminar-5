// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}
Console.Write("ВВедите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(",", array));
int newLength = array.Length / 2 + array.Length % 2;

int[] prod = new int[newLength];
for (int i = 0; i < array.Length / 2; i++)
{
   prod[i] = array[i] * array[array.Length - i - 1];
    
}

if(array.Length % 2 > 0)
    {
        prod[prod.Length - 1] = array[array.Length / 2];
    }
Console.WriteLine();
Console.Write("Ваш новый массив: ");
Console.Write(string.Join(",", prod));
