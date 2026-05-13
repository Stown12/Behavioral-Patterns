namespace Behavioral_Patterns.Mediator;

public class ChatRoom: IChatMediator
{
    private List<User> _users = [];
    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users)
        {
            if(user == sender) continue;
            user.Receive(message);
        }
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }
}

public class User
{

    private ChatRoom _chatRoom;
    private string _name;
    private string _message;
    public User(string name, ChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
        _name = name;
    }

    public void Send(string message)
    {
        _chatRoom.SendMessage(message, this);
    }

    public void Receive(string message)
    {
        _message = message;
        Console.WriteLine($"[{_name}] received: {_message}");
    }
}