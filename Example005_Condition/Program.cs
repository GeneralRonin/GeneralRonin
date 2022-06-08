Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "сергей")
{
    Console.WriteLine("Ура, это же Сиёжа");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}