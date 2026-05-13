
using System.Collections;
using System.Globalization;
using Behavioral_Patterns.Command;
using Behavioral_Patterns.Iterator;
using Behavioral_Patterns.Mediator;

public class Program
{
    public static void Main(string[] args)
    {
        ChatRoom chatRoom = new ChatRoom();

        User jesus = new User("Jesus", chatRoom);
        User ana = new User("Ana", chatRoom);
        User pedro = new User("Pedro", chatRoom);

        chatRoom.AddUser(jesus);
        chatRoom.AddUser(ana);
        chatRoom.AddUser(pedro);

        jesus.Send("Hola a todos!");
        ana.Send("Hola Jesus!");
    }
}