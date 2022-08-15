Console.WriteLine("введите число:");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);
int count2 = 0;
int result = 0;
for (result = number; result > 0; count2++) result = result /10;

Console.WriteLine($"В числе {number} {count2} цифр");

//3 вариант

int num = Convert.ToInt32(Console.ReadLine());
int GetCountNumbers(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /=10;
    }
    return count;
}

Console.WriteLine($"Количество чисел: {GetCountNumbers(num)}");

