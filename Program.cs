
//ماشین حساب عملگر ضرب
using System.Transactions;

Console.WriteLine("Enter Your FIrst Password");
var Number1=int.Parse(Console.ReadLine());
Console.WriteLine("Enter your second password");
var Number2=int.Parse(Console.ReadLine());
Console.WriteLine($"{Number1}*{Number2}={Number1*Number2}");
//چاپ اعداد 0تا 10
for  (int i = 0; i < 200; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
//تعیین زوج یا فرد بودن عدد

Console.Write("Enter a number:");
int N=int .Parse(Console.ReadLine());
if (N % 2 == 0)
{
    Console.WriteLine("Number is evan");
}
else
{
    Console.WriteLine("number is ood");
}

//رمز و پسوورد
while (true)
{

    Console.Clear();
    Console.WriteLine("Enter your username:");
    var username = Console.ReadLine();
    Console.WriteLine("Enter your password:")
        ;
    var password = Console.ReadLine();
    if (password == "Beny" && username == "BENY1382")
    {
        Console.WriteLine("welcom");
        return;
    }
    else
    {
        Console.WriteLine("invalid");
        continue;
    }
}
    //عملگر جمع
    Console.WriteLine("Enter Your First Numer");
    var Num1=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Your Second Number");
    var Num2 = int.Parse(Console.ReadLine());
    Console.Write($"{Num1}+{Num2}={Num1 + Num2}");




