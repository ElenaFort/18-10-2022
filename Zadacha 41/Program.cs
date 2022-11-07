/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа через запятую");
string str = Console.ReadLine();
string[] strArray = str.Split(',');
int[] numArray = new int[strArray.Length];
for (int i = 0; i < strArray.Length; i++)
{
    numArray[i] = int.Parse(strArray[i]);
}

int count = 0;
for (int i = 0; i < numArray.Length; i++)
{
    if (numArray[i] > 0)
        count = count + 1;
}
Console.WriteLine($"{count}");
