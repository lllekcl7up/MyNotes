﻿// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    //   || это ИЛИ
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
    // обязательно i = 1 , так как это не массив 
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}