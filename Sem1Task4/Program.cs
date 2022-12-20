string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

int max=0;

if (num1Line != null && num2Line != null)
if (num3Line !=null)

{
    int firstNumber = int.Parse(num1Line);
    int secondNumber = int.Parse(num2Line);
    int thirdNumber = int.Parse(num3Line);

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("max = " + max);

}
