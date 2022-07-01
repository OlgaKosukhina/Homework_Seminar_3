/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "You input not a number. Please input the correct number";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int x1 = GetNumber("Insert coordinate x of first point");
int y1 = GetNumber("Insert coordinate y of first point");
int z1 = GetNumber("Insert coordinate z of first point");
int x2 = GetNumber("Insert coordinate x of second point");
int y2 = GetNumber("Insert coordinate y of second point");
int z2 = GetNumber("Insert coordinate z of second point");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"The distance between two points is {distance}");