// Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю ввести числа и вывести их на экран.


Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new  int[n];

for (int  i = 0; i < 8; i++)
{
    array[i] = new  Random().Next(0, 100);
            Console.WriteLine();
            Console.WriteLine(array [i]);
            }
            






            
