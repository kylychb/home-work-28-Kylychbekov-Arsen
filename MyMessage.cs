namespace ConsoleApp49;

public class MyMessage
{
    public string MessageType { get; set; }

    public string Message { get; set; }


    public MyMessage(string type, string message)

    {

        MessageType = type;

        Message = message;

    }
}