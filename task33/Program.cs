// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
int[] array = new int[5];
FillArrayWithRandom(array);
Console.Write("Задайте число ");
int number = Convert.ToInt32(Console.ReadLine());
bool isOk = false;

Console.Write(number + " ;Ваш случайный массив ");
Console.Write(string.Join(",", array) + "->");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        isOk = true;
        break;
    }
}
if (isOk)
{
    Console.Write("Да");
}
else Console.Write("Нет");




