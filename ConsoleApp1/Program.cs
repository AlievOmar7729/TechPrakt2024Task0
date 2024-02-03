Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Введіть перше число");
double one = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть друге число:");

double two = Convert.ToDouble(Console.ReadLine());

double sum = one + two;

Console.WriteLine($"Сумма чисел {one} и {two} равна: {sum}");

Console.ReadKey();