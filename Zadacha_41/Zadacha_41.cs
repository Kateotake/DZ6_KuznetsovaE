// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
  {
      Console.Write($"{arr[i]} ");
  }
}
Console.WriteLine("Введите целое число M- кол-во чисел");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int[M];

for (int i = 0; i < M; i++)
{
  Console.WriteLine ($"Введите {i+1}е число ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArray(array);
Console.WriteLine();

int count = 0;
foreach (int item in array ) 
{
    if (item > 0) count++;
}
Console.WriteLine ($"Количество чисел больше 0 равно {count}");



