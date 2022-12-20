string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

int max = 0;
int min = 0;

if (num1Line != null && num2Line != null)
{
    int firstNumber = int.Parse(num1Line);
    int secondNumber = int.Parse(num2Line);

if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);

}
