using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignments
{
    internal class Assignment6
    {
        static void Main()
        {
            LinkedList<Song> playlist = new LinkedList<Song>();

            Console.Write("Enter number of songs: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Song s = new Song();

                Console.Write("\nEnter Song Id: ");
                s.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Title: ");
                s.Title = Console.ReadLine();

                Console.Write("Enter Artist: ");
                s.Artist = Console.ReadLine();

                if (playlist.Count == 0)
                {
                    playlist.AddFirst(s); 
                }
                else
                {
                    playlist.AddLast(s); 
                }
            }

            Song firstSong = new Song { Id = 100, Title = "Intro", Artist = "System" };
            playlist.AddFirst(firstSong);

            Song lastSong = new Song { Id = 200, Title = "Outro", Artist = "System" };
            playlist.AddLast(lastSong);

            var node = playlist.First.Next;
            Song middleSong = new Song { Id = 150, Title = "MidSong", Artist = "DJ" };
            playlist.AddAfter(node, middleSong);

            Console.Write("\nEnter song title to remove: ");
            string removeTitle = Console.ReadLine();

            foreach (var song in playlist)
            {
                if (song.Title == removeTitle)
                {
                    playlist.Remove(song);
                    Console.WriteLine("Song removed");
                    break;
                }
            }

            Console.WriteLine("\nPlaylist (Forward):");
            foreach (var song in playlist)
            {
                Console.WriteLine($"{song.Id} - {song.Title} - {song.Artist}");
            }

            Console.WriteLine("\nPlaylist (Backward):");
            var current = playlist.Last;
            while (current != null)
            {
                Console.WriteLine($"{current.Value.Id} - {current.Value.Title} - {current.Value.Artist}");
                current = current.Previous;
            }

            Console.Write("\nEnter song title to search: ");
            string searchTitle = Console.ReadLine();

            foreach (var song in playlist)
            {
                if (song.Title == searchTitle)
                {
                    Console.WriteLine($"Found: {song.Title} by {song.Artist}");
                }
            }

            Console.WriteLine("\nPlay Next Feature:");
            var currentSong = playlist.First;

            while (currentSong != null)
            {
                Console.WriteLine("Playing: " + currentSong.Value.Title);
                currentSong = currentSong.Next;
            }

        }
    }
}
