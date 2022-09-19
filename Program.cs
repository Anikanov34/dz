
Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
   Console.WriteLine("Первое число больше второго"); 
}
else if (num1<num2)
{
     Console.WriteLine("Первое число меньше второго");   
}
else
{
   Console.WriteLine("Оба числа равны"); 
}