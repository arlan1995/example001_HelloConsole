Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "котенчик")
{
    Console.WriteLine("Ура, это же Котенчик!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}