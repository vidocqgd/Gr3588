﻿String? inputLine = Console.ReadLine();

if (inputLine!=null)
{
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "понедельник";
    dayOfWeek[1] = "вторник";
    dayOfWeek[2] = "среда";
    dayOfWeek[3] = "четверг";
    dayOfWeek[4] = "пятница";
    dayOfWeek[5] = "суббота";
    dayOfWeek[6] = "воскресенье";

    int inputNumber = int.Parse(inputLine);

    string outDayOfWeek=dayOfWeek [inputNumber-1];

    Console.WriteLine(outDayOfWeek);
}
