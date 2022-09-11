// Виды методов (функций)
// Вид 1
void Method1()
{
    System.Console.WriteLine("Автор ...");
}

//Method1(); //вызов метода




// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения"); //или можно сделать Method2(msg: "Текст сообщения")

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count) 
    {
        Console.WriteLine(msg);
        i++; //увеличение на 1 называется инкримент, а умньшение декримент
    }
}
//Method21("Текст", 4);   // или Method21(msg:"Текст", count: 4); 
                        // или Method21(count: 4, msg:"Новый Текст"); 



//Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;                          // return обязательно
// }
// int year = Method3();
// Console.WriteLine(year);




//Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = "";   //кладем изначально пустое значение или string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(10, "z");
//Console.WriteLine(res);



// ЦИКЛ for
// string Method4(int count, string text)
// {
//     string result = String.Empty;   //кладем изначально пустое значение или string result = String.Empty; == string result = "";
//     for(int i = 0; i < count; i++)                    //инициализация счетчика - проверка условия - увеличение счетчика (инкримент)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);


//вывод таблицы умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}

