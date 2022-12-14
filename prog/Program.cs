// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] helloWorld = { "Hello", "2", "worid", ":-)" };
string[] helloWorld1 = { "1234", "1567", "-2", "computer science" };
string[] helloWorld2 = { "Russia", "Denmark", "Kazan" };
string[] limitHelloWord = FindLenghtString(helloWorld, 3);
string[] limitHelloWord1 = FindLenghtString(helloWorld1, 3);
string[] limitHelloWord2 = FindLenghtString(helloWorld2, 3);
Console.WriteLine($"[{string.Join(", ", helloWorld)}] -> [{string.Join(", ", limitHelloWord)}]");
Console.WriteLine($"[{string.Join(", ", helloWorld1)}] -> [{string.Join(", ", limitHelloWord1)}]");
Console.WriteLine($"[{string.Join(", ", helloWorld2)}] -> [{string.Join(", ", limitHelloWord2)}]");
string[] FindLenghtString(string[] input, int n)
{
    string[] output = new string[CountLessThan(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}
