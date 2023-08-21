Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Наконец-то, это ты, Маша!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}