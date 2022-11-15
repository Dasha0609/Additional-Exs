// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

Console.Write(" To stop the program please use EXIT: ");
String? Password = Console.ReadLine(); 
int i = 0;

for (; ; )
{
    i++;
    Console.WriteLine(i);
    if (Password == "exit") break;
    if (i == 15) break;
}
Console.ReadLine();
