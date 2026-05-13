
using System.Collections;
using System.Globalization;
using Behavioral_Patterns.Command;
using Behavioral_Patterns.Iterator;
using Behavioral_Patterns.Mediator;
using Behavioral_Patterns.Memento;

public class Program
{
    public static void Main(string[] args)
    {
        Editor editor = new Editor();
        History history = new History();

        editor.SetText("Version 1");
        history.Push(editor.Save());

        editor.SetText("Version 2");
        history.Push(editor.Save());

        editor.SetText("Version 3");
        Console.WriteLine(editor.GetText()); // Version 3

        editor.Restore(history.Pop());
        Console.WriteLine(editor.GetText()); // Version 2

        editor.Restore(history.Pop());
        Console.WriteLine(editor.GetText()); // Version 1
    }
}