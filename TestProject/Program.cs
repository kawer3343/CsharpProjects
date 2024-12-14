Console.WriteLine("привет, я исскуственный интелект");
Console.WriteLine("как тебя зовут ");
string name = Console.ReadLine();
Console.WriteLine(name + ", сколько тебе лет: ");
int age = int.Parse(Console.ReadLine());
if (age < 10)
{
    Console.WriteLine("маленький ух");
}
else
{
     Console.WriteLine("большой ух");
}
Console.WriteLine("выбирай чем мне тебе помочь \n1. посмотреть погоду \n2. рассказать супер мега смешной анекдотик \n3. дать советик \n4. попрощаться ");
int choose = int.Parse(Console.ReadLine());
switch(choose)
{
    case 1:
        Console.WriteLine("карты говорят что щас солнечно и все горит от тепла");
        break;
    case 2:
        Console.WriteLine("шкаф упал и сломался");
        break;
    case 4:
        Console.WriteLine("покакаешь дома");
        break;
    case 3:
        Console.WriteLine("жарь яйцо в микроволновке");
        break;
    default:
        Console.WriteLine("вы были забанены по причине:\n цифру надо было выбирать правильную\n\nсрок:бесконечность");
        break;
}
Console.WriteLine("досвиданье");