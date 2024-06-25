//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

	
	void PrintRange(int i, int lim) {
	     if (i <= lim) 
	    {
		Console.Write($"{i}, ");
		PrintRange(i + 1, lim);
	}
	}

    PrintRange(M, N);