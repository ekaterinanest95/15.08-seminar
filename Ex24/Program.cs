/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

/*int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for(int i = 1; i <= A; i++)
{
    sum += i; //sum = sum + i;
    
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");
*/

//2 вариант - через цикл for

/*int GetSumNumbers(int number)
{
    int sum = 0;

    for(int i = 1; i <= number; i++)
{
    sum += i; //sum = sum + i;
    
}
return sum;
}

int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

sum = GetSumNumbers(A);
Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");
*/

//3 вариант - через цикл while

int GetSumNumbers(int number)
{
    int sum = 0;
    int start = 1;

    while(start <= number)
{
    sum += start; //sum = sum + i;
    start++; 
    
}
return sum;
}

int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");




