Console.WriteLine("Введите имя пользователя :");
string user = Console.ReadLine();

if(
    user.ToLower() == "петя")
{
    Console.WriteLine("Это же " + user + "!!!");
}
else
{
    Console.WriteLine("Привет, " + user);
}
Console.WriteLine(user.ToUpper());