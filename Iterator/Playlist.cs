using System.Collections;

namespace Behavioral_Patterns.Iterator;

public class Playlist: IEnumerable
{
    private List<(string title, string artist)> _rockSongs = new()
    {
        ("Bohemian Rhapsody", "Queen"),
        ("Stairway to Heaven", "Led Zeppelin")
    };
    private LinkedList<(string title, string artist)> _popSongs =
        new(new[]
        {
            ("Thriller", "Michael Jackson"),
            ("Like a Prayer", "Madonna")
        });
    
    public IEnumerator GetEnumerator()
    {
        foreach (var song in _rockSongs)
        {
            yield return song;
        }

        foreach (var song in _popSongs)
        {
            yield return song;
        }
    }
}