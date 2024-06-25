//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < N; i++)
{
Console.Write("{0}>", i + 1);
array[i] = Convert.ToInt32(Console.ReadLine());
}

void ArrayReverse(int i)
{
	if (i == 0)
		return;
	Console.Write($"{array[i-1]}; ");
	ArrayReverse(i - 1);
}

ArrayReverse(N);