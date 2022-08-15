/*Console.WriteLine("введите чяисло:");
int A = Convert.ToInt32(Console.ReadLine());
int product = 1;
for (int i = 1; i <= A; i++)
{
    product *= i;
}
Console.WriteLine($"Произведение чисел от 1 до {A} = {product} ");
*/


int num = Convert.ToInt32(Console.ReadLine());
int GetMultiply(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;

}
Console.WriteLine($"Факториал от {num}: = {GetMultiply(num)}");2

