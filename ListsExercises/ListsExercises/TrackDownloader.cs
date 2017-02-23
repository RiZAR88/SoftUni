using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExercises
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blacklist = Console.ReadLine().Split(' ');

            var downloadedTracks = new List<string>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var isInBlacklist = false;
                foreach (var blacklistedWord in blacklist)
                {
                    if (line.Contains(blacklistedWord))
                    {
                        isInBlacklist = true;
                        break;
                    }
                }
                if (!isInBlacklist)
                {
                    downloadedTracks.Add(line);
                    
                }
                line = Console.ReadLine();
            }
            downloadedTracks.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, downloadedTracks));
        }
    }
}