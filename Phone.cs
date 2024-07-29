namespace ConsoleApp49;

public class Phone 
{
    public void GetInfoSms(MyMessage messageType)
    {
        if (Equals(messageType.MessageType))
        {
            ReceiveSms(messageType);
        }
    }
    private void ReceiveSms(MyMessage msg)
    {
        if (msg.MessageType == "sms")
        {
            Console.WriteLine($"Получил смс {msg.Message}");
        }
    }
}