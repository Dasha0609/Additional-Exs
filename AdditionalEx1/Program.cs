//*В переменной string есть секретное сообщение, во второй есть пароль. 
//Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.


for (int entries = 0; entries < 3; entries++)
{
    Console.Write(" Please enter your password: ");
    string? password = Console.ReadLine(); 
    if (password == "Dasha")
    {
        Console.WriteLine("What a lovely day today =)");
        break;
    }
    }




    


