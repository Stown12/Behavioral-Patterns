namespace Behavioral_Patterns.Command;

public interface ICommand
{
    void Execute();
    void Undo();
}

public class AddTextCommand: ICommand
{
    private TextEditor _editor;
    private string _text;
    public AddTextCommand(TextEditor editor, string text)
    {
        _editor = editor;
        _text = text;
    }
    
    public void Execute()
    {
        _editor.AddText(_text);
    }

    public void Undo()
    {
        _editor.DeleteLast(_text.Length);
    }
}

public class DeleteTextCommand : ICommand
{
    TextEditor _editor;
    int _count;
    private string _text;

    public DeleteTextCommand(TextEditor editor, int count)
    {
        _editor = editor;
        _count = count;
    }
    
    public void Execute()
    {
        _text = _editor.DeleteLast(_count);
    }

    public void Undo()
    {
        _editor.AddText(_text);
    }
}