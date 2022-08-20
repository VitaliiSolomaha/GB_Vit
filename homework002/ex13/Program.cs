//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int value = Convert.ToInt32(Console.ReadLine());
if (value < 100) 
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while ( value > 999 )
    {
        value = value / 10;
    }
    Console.WriteLine(value % 10);
}