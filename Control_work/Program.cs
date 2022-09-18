string [] array_initial = { "hello" , "how" , "are" , "you", "?",  "good bye"};
string [] array_result = {};
int index_array_result;
index_array_result = 0;
int array_initial_length = array_initial.Length;
Console.WriteLine("Начальный массив");
for (int i = 0; i < array_initial_length; i++)
{
    Console.Write("{0}, ", array_initial[i]);
    if (array_initial[i].Length < 4)
    {
        Array.Resize (ref array_result, index_array_result + 1);
        array_result[index_array_result] = array_initial[i];
        index_array_result++;
    }
}
Console.WriteLine(" ");
Console.WriteLine("Результирующий массив");
for (int i = 0; i < index_array_result; i++)
{
    Console.Write("{0}, ", array_result[i]);
}