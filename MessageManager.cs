namespace ConsoleApp49;


public class MessageManager 
{
    public delegate string UI();
    public Phone phone = new Phone();
    public MyMessage MyMessage;
    public Mail mail = new Mail();
    
    public event UI NewMessage
    {
        add
        {
            if (MyMessage.MessageType == null)
            {
                MyMessage.MessageType += value;
                if (MyMessage.Message == null)
                {
                    MyMessage.Message += value;
                }
            }
        }
        remove => Console.WriteLine("Вы не правильно вели");
    }
}