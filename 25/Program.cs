// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();
Console.Write("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
double result = 1.0;

if (B < 0)
{
  (A, B)=(1.0/A, -B);
}
for (; B != 0; A *=A, B/=2)
{
  if (B%2 != 0)
  {
    result *=A;
      }
      Console.WriteLine(result);
}


