// Квадрат введенного числа
Console.Clear();
Console.Write("Ведите число: ");
string? usernum = Console.ReadLine();
int num = Convert.ToInt32(usernum);
num = num * num;
Console.Write("Квадрат числа = ");
Console.WriteLine(num);