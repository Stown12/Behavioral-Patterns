namespace Behavioral_Patterns.Memento;

public class Editor
{
    private string _mementoText;

    public void SetText(string text) => _mementoText = text;

    public string GetText() => _mementoText;

    public EditorMemento Save() => new EditorMemento(_mementoText);
    
    public void Restore(EditorMemento memento) => _mementoText = memento.GetText();
    
}

public class EditorMemento
{
    private string _text;
    public EditorMemento(string text)
    {
        _text = text;
    }
    public string GetText() => _text;
}

public class History
{
    private Stack<EditorMemento> _mementos = new Stack<EditorMemento>();

    public void Push(EditorMemento memento) => _mementos.Push(memento);

    public EditorMemento Pop() => _mementos.Pop();
}