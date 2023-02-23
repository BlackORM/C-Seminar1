// Квадрат введенного числа
Console.Clear();
Console.Write("Ведите число: ");
string usernum = Console.ReadLine();
int num = Convert.ToInt32(usernum);
int itog = num * num;
Console.WriteLine($"Квадрат числа {num} = {itog}");
Console.WriteLine("Квадрат числа " + num + " = " + itog);

