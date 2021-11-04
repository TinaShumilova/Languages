void Method2(string msg)                // создание метода
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");             // вызов метода

void Method21(string msg, int count)    // создание метода
{
    int i = 0;
    while(i < count)
    {
         Console.WriteLine(msg);
         i++;
    }
    
}

Method21(msg: "Текст", count: 3);       // вызов метода
Method21(count: 3, msg: "новый Текст"); // перемена порядка вызова
