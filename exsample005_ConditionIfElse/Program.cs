Console.Write("Введите имя пользователя : ");

string username = Console.ReadLine();

if(username.ToLower() == "ринат")
{ 
    Console.WriteLine("Приветствую тебя мой хозяин Ринат");
}

else 
{
    Console.Write("Здравствуй, ");
    Console.WriteLine(username);
}
