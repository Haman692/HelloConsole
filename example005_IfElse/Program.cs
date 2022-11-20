Console.Write("Введите имя ");
string Username = Console.ReadLine();
if(Username.ToLower() == "данила")
{
    Console.Write("Приветствую, ");
    Console.WriteLine(Username);
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(Username);
}