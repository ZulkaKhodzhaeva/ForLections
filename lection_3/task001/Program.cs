// ========Работа с текстом==========
// Дан текст. В тексте нужно все проблелы заменить черточнками,
// маленькие буквы "к" заменить большими "К", 
// а большие "С" аменить маленькими "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"  
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             012345 
// s[3]  r третий символ

string Replace(string  text, char oldValue, char newValue)    //char - конкретный символ
{
    string result = String.Empty; //вывод пустой строки

    int length = text.Length; //узнаем длину текста
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);


