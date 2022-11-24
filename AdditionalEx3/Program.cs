/*Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля*/


string userString = "";
do
{
    Console.Write("Please enter your name: ");
    userString = Console.ReadLine();  
    Console.WriteLine("Your infomation is: " + userString);

} while (userString != "exit");
