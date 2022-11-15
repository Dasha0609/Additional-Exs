// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается


while (true)
{
   Console.Write("Please enter word: ");
   string? repeat = Console.ReadLine();
   if (repeat == "exit")
   {
    break;
   }
}



