int number = ReadData("Введите число: ");
string outLine = LineBilder(number, 1 );
Printdata("", outLine);

outLine = LineBilder(number, 2);
Printdata("", outLine);


void Printdata(string msg, string res)
{
    Console.WriteLine(msg + res);
}

string LineBilder(int n, int pow)
{
    string line = string.Empty;
    for (int i=1; i<n; i++)
    {
            line = line + Math.Pow (i, pow) + " ";
    }
    line = line + Math.Pow (n, pow);
    return line;
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
