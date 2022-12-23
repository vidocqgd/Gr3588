System.Random numberSintezator = new System.Random();

int number = numberSintezator.Next(10,100);

Console.WriteLine(number);

int firstnumber = number/10;
int secondnumber = number%10;

if(firstnumber>secondnumber)

{
    Console.WriteLine(firstnumber);
}
else
{
    Console.WriteLine(secondnumber);
}    

// Вариант 2
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

firstnumber = ((int)digits[0])-48;
secondnumber = ((int)digits[1])-48;

int resultNumber = firstnumber>secondnumber?resultNumber=firstnumber:resultNumber=secondnumber;

Console.WriteLine(resultNumber);


