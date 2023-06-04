// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// у нас есть три координаты, можем их представить как x, y, z
//  предположим xA=3, yA=6, zA=8, xB= 

// Console.WriteLine("Введите координаты двух точек ");


// Console.WriteLine("Введите координату xA: ");
// int xA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату yA: ");
// int yA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату zA: ");
// int zA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату xB: ");
// int xB = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату yB: ");
// int yB = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату zB: ");
// int zB = int.Parse(Console.ReadLine());
 
// double dist = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
// Console.WriteLine($"Расстояние между двумя точками = {dist} ");



int User(string msg)
{
    Console.WriteLine(msg);
    int val = int.Parse(Console.ReadLine());
    return val;
}

int xA = User("Введите коордитату xA :");
int yA = User("Введите коордитату yA :");
int zA = User("Введите коордитату zA :");
int xB = User("Введите коордитату xB :");
int yB = User("Введите коордитату yB :");
int zB = User("Введите коордитату zB :");

void Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    Console.WriteLine($"Расстояние между двумя точками = {dist} ");
} 
Dist(xA, yA, zA, xB, yB, zB);