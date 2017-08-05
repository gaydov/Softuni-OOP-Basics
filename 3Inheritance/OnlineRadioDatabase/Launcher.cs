using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRadioDatabase
{
    public class Launcher
    {
        public static void Main()
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] songInfo = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (songInfo.Length != 3)
                    {
                        throw new InvalidSongException();
                    }

                    string artistName = songInfo[0];
                    string songName = songInfo[1];
                    string length = songInfo[2];

                    string[] lengthArgs = length.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    int minutes;
                    int seconds;

                    if (int.TryParse(lengthArgs[0], out minutes) && int.TryParse(lengthArgs[1], out seconds))
                    {
                        Song song = new Song(artistName, songName, minutes, seconds);
                        songs.Add(song);
                        Console.WriteLine("Song added.");
                    }
                    else
                    {
                        throw new InvalidSongLengthException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}");

            long totalLengthInSeconds = songs.Sum(s => s.Minutes * 60) + songs.Sum(s => s.Seconds);
            TimeSpan playlistLength = TimeSpan.FromSeconds(totalLengthInSeconds);
            Console.WriteLine($"Playlist length: {playlistLength.Hours}h {playlistLength.Minutes}m {playlistLength.Seconds}s");
        }
    }
}
