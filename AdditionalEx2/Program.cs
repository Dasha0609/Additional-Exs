// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

   Console.Write("Please enter word: ");
   string? word = Console.ReadLine(); 

while (word != "exit")
{
   Console.Write("Please enter word again: ");
   string? repeat = Console.ReadLine();
   if (repeat == "exit")
   {
    break;
   }
}



