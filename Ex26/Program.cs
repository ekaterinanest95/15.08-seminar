Console.WriteLine("введите число:");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);
int count2 = 0;
int result = 0;
for (result = number; result > 0; count2++) result = result /10;

Console.WriteLine($"В числе {number} {count2} цифр");

