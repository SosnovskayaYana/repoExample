// int[,]matrix = new int[5, 8];

// string[,] table = new string[2, 5];

// индексы от нуля. 2 строки, 5 столбцов. 
// первая строка - table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// вторая строка - table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

// string.Empty   - инициализация пустой строки.




/*
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/




/*
void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)    // matrix.GetLength(0) - длина, - 3
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)    // matrix.GetLength(1) - длина, - 4
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();  // пустая строка для красивого вывода столбцов
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

*/




// /* Рекурсия - функция(метод) в функции
// факториал ( 5! )
// 1! = 1;
// 0! = 1; */

// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

//   /*Console.WriteLine(Factorial(5)); // 1*2*3*4*5 = 120 */

// for (int i = 1; i < 40; i++)  // факториал 39. от 1 до 39
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }



/* Числа Фибоначчи */

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 40; i++)  // фибоначи до 40 каждое следующее равно сумме двух предыдущих
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
  }