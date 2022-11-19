Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "бабай")
{
    Console.Write("УРА! Это же Бабай!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}