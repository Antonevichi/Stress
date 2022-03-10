Console.WriteLine("Введите ваше имя:   ");
string username = Console.ReadLine();

if (username.ToLower() == "слава") 
{
    Console.WriteLine ("Ура! Это наш Супергерой!!!");
}

else
{
    Console.Write ("Привет  ");
    Console.Write (username);
}
