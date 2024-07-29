namespace ConsoleApp49;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите тип сообщение: ");
        string MassageTipe = Console.ReadLine();
        Console.Write("Введите сообщение: ");
        string Massage = Console.ReadLine();
        MyMessage myMessage = new MyMessage(MassageTipe,Massage);
        Phone phone = new Phone();
        Mail mail = new Mail();
        phone.GetInfoSms(myMessage);
        mail.GetInfoMail(myMessage);
    }
}