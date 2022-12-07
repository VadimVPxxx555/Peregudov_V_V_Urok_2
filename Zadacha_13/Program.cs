//Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет
Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int number3 = 0;
int numberGap = 0;

if(number < 100)
{
    Console.WriteLine ($"{number} -> третьей цифры нет ");
}
else
{
  numberGap = number;  
  while(number > 1000)
 {
     number = number / 10;
 }
   number3 = number % 10;
   Console.WriteLine ($"{numberGap} -> {number3}");
}




// number = number / 10;
// int number2 =  number % 10;

// Console.WriteLine ($"втарая цыфра {number2} ");