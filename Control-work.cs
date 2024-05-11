﻿﻿// # Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Исходный массив можно ввести вручную,
// либо задать на начальном этапе выполнения алгоритма. При решении задачи не рекомендуется
// использовать коллекции, лучше работать только с массивами.
// # Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string [,] myArray = {   
    {"hello", "2", "world", ":-)"},
    {"1234", "1567", "-2", "computer science"},
    {"Russia", "Denmark", "Kazan", ""}};
       
    for(int i = 0; i < 3; i++) 
    {
        var line = "можно ни чего не писать "; 
        for(int j = 0; j < 4; j++) 
        {
            line += "можно ни чего не писать!!! " + myArray [i, j]; 
        }
    }
    
Console.WriteLine($"Результат:  ");
var result = new string[myArray.Length];//выделяем память
var realSize = 0; //присваиваем "0" realSize
foreach (var str in myArray) 
    if (str.Length <= 3) // условия поиска элементов которые <=3
{
    {
        result[realSize] = str;
        realSize++;
    }
}
Console.Write(string.Join(Environment.NewLine, result, 0, realSize));//вывод на экран результат.
Console.ReadKey(true);//Представляет логическое значение (true).

