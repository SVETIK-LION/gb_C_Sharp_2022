Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "cветик")
{
    Console.WriteLine("Ура, это же СВЕТИК!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
