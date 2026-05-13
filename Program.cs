
using System.Collections;
using System.Globalization;
using Behavioral_Patterns.Command;
using Behavioral_Patterns.Iterator;

public class Program
{
    public static void Main(string[] args)
    {
        IEnumerator playlist = new Playlist().GetEnumerator();
        while (playlist.MoveNext())
        {
            Console.WriteLine(playlist.Current);
        }
    }
}