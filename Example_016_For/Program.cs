/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
*/

//Таблица умножения (цикл в цикле)
/* 
for(int i = 2; i < 10; i++)
{
    for(int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

/*
========Работа с текстом=============
Дан текст. В тексте все пробелы нужно заменить чёрточками,
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".
*/

string text = "Миры появляются и исчезают, отбрасывают тени и отражения, которые,"
            + " в свою очередь порождают тени теней и отражения отражений. "
            + " И во всех мирах кипит война и льется кровь. Разумные (как смертные"
            + " так и бессмертные) делят земли, нефть, уран... да мало ли чего еще."
            + " И даже если всего достаточно - продолжают сражаться за Веру. Слишком"
            + " велик соблазн определять, что есть Свет и вести к этому Свету других."
            + " И потому вновь и вновь катятся кости брошенных жребиев. Идет Игра...";

Console.WriteLine(text);
Console.WriteLine();

//string text = "qwerty"
//               012345
//text[3] // r 

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for(int index = 0; index < lenght; index++)
    {
        if(text[index] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[index]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);