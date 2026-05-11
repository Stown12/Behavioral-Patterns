using Behavioral_Patterns.Chain_Responsability;
using Behavioral_Patterns.Command;
using Behavioral_Patterns.Observer;

public class Program
{
    public static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        EditorInvoker invoker = new EditorInvoker();
        invoker.ExecuteCommand(new AddTextCommand(editor, "Hello"));
        invoker.ExecuteCommand(new AddTextCommand(editor, " World"));
        invoker.ExecuteCommand(new DeleteTextCommand(editor, 5));

        Console.WriteLine(editor.GetText());
        invoker.Undo();
        
        Console.WriteLine(editor.GetText());
        invoker.Undo();
        
        Console.WriteLine(editor.GetText());
    }
}