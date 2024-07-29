namespace ConsoleApp49;

public class Mail
{
    public void GetInfoMail(MyMessage myMessage)
    {
        if (Equals(myMessage.Message))
        {
            ReceiveMail(myMessage);
        }
    }
    private void ReceiveMail(MyMessage msg)
    {
        if (msg.MessageType == "email")
        {
            Console.WriteLine($"Получил письмо {msg.Message}");
        }
    }
}