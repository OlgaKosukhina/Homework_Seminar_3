/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Insert number");
string number = Console.ReadLine();
int length = number.Length;
int i = 0;
int palindrom = 0;

for (i = 0; i < length / 2; i++)
{
    if(number[i] != number[length - 1 - i])
    {
        palindrom = 1;
    }
}

if (palindrom == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
