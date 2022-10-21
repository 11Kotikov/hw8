//Здраствуйте, Татьяна :)

//Задача 1 (10): Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int x)
{
    int digit1 = x%100;
    int digit2 = digit1/10;
    return digit2;
}
Console.WriteLine ("Input three-digit number, please");
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondDigit(num);
Console.WriteLine ($"You typed {num} and your second digit is {result} ");
*/

//Задача 2 (13): Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdDigit(int x)
{
   
      if (x>1000)
   {
        int digit2 = x;
        while (digit2>1000)
        {
            digit2 = digit2/10;
        }
        int digit3 = digit2%10;
        Console.WriteLine ($"You typed {x} and the third is {digit3}");
   }
    
    else if (x < 1000 & x > 99)
    {
        int digit1 = x%10;
        Console.WriteLine($"You typed {x} and the 3rd digit is {digit1}");
    }
   
   else Console.WriteLine("There is no 3rd digit"); 
 
    
    return x; // не понимаю, правильно ли я вернул значение "x"?" всё работает, но не понимаю, 
    //что возвращать, или в каждом ветвлении возвращать результат "digit(n)..."?
    // и вообще, кажется, что ничего возвращать вовсе не нужно 
}
Console.WriteLine("input a positive number pls");
int x = Convert.ToInt32(Console.ReadLine());
ThirdDigit(x);
*/

// Задача (3) 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void weekEnds (int day)
{
if (day>0&day<=5)
{
    System.Console.WriteLine("It's a weekday, sorry, but you need to work"); //испозьзую быстрый вызов "CW" - cw
}
else if (day==6||day==7)
{
    System.Console.WriteLine("It's a weekend, let's go to the party!");
}
else System.Console.WriteLine("sorry, it's not a day of the week, but it's probably weekday, because you're looking tired, it's time to bed");
}

System.Console.WriteLine("Type a day of the week, please");
int day = Convert.ToInt32(Console.ReadLine()); 
weekEnds (day);
