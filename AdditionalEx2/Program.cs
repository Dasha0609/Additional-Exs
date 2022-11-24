/*Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому). Например:
SetName – Установить имя
Help – вывести список команд
SetPassword – Установить пароль
Exit – выход
WriteName – вывести имя после ввода пароля*/


while (true)
{
   Console.Write("Please enter word: ");
   string? repeat = Console.ReadLine();
   if (repeat == "exit")
   {
    break;
   }
   if (repeat == "name")
   {
      Console.WriteLine("Please enter your name here: ");
      string name = Console.ReadLine();
      Console.WriteLine("Hello " + name);
      Console.WriteLine("Would you like to set password: Yes or No");
      string pas = Console.ReadLine();
      
      if (pas == "yes")
      {
         Console.WriteLine("Pls enter your password here: ");
         string password = Console.ReadLine();
         Console.WriteLine("You password is " + password);
      }
   }
   if (repeat == "age")
   {
      Console.WriteLine("Please enter your age here: ");
      string input = Console.ReadLine();
      int age = Convert.ToInt32(input);

      if (age < 18)
      {
         Console.Write("You're too young for alcohol");
      }
      else
      {
         Console.WriteLine("Enjoy you time");
      }

   }
   if (repeat == "help")
   {
      Console.WriteLine("used commands: age, name, help and exit");
   }
}



