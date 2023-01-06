/* Задача 41 : 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/

int m;
Console.Write("Введите количества чисел: ");
int.TryParse(Console.ReadLine(), out m);

int count = 0;
int[] array = new int[m];

for (int i = 0; i < m; i++)
{
    Console.Write($"Ведите число {i + 1}: ");
    int.TryParse(Console.ReadLine(), out array[i]);
}
for (int i = 0; i < m; i++)
    if (array[i] > 0)
        count++;
Console.Write($"Положительных чисел: {count}");

