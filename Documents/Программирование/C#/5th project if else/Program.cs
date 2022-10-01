Console.Write("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "rin")
{
    Console.WriteLine("Hello, Rin, glad to see you");
}
else
{
    Console.Write("Go away, ");
    Console.Write(username);
}
