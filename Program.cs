
using System.Collections;
using System.Globalization;
using Behavioral_Patterns.Command;
using Behavioral_Patterns.Iterator;

public class Program
{
    public static void Main(string[] args)
    {
        foreach (var song in new Playlist())
            Console.WriteLine(song);
    }
}