using System.Text;

namespace Behavioral_Patterns.Command;

public class TextEditor
{
    private StringBuilder _text = new ();

    public string AddText(string text)
    {
        _text.Append(text);
        return _text.ToString();
    }

    public string DeleteLast(int count)
    {
        var length = _text.Length;
        if( length < count) throw new Exception("Text is too short");
        
        var txt = _text.ToString().Substring(length - count, count);
        _text.Remove(length - count, count );
        
        return txt;
    }
    
    public string GetText() => _text.ToString();
}

public class EditorInvoker
{
    private Stack<ICommand> _commandHistory = new ();
    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void Undo()
    {
        if (_commandHistory.Count > 0)
        {
            ICommand last = _commandHistory.Pop();
            last.Undo(); 
        }
    }
}