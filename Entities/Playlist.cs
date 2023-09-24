using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace spotify_deneme.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }

        private Random random;


        public Playlist(Song firstSong)
        {
            Id = Guid.NewGuid();
            Songs = new List<Song>();
            random = new Random();
            AddSong(firstSong);
        }

        public void AddSong(Song song)
        {
            if (song != null)
                Songs.Add(song);
        }

        public string GetSongs()
        {
            
            return string.Join("\n", Songs.Select(x => $"{x.Title} - {x.Composer}" ));
        }

        public void ShuffleSongs()
        {
            int count = Songs.Count;
            
            while (count > 0)
            {
                count--;

                Song song = Songs[count];  
                int randomIndex = random.Next(count);
                Songs[count] = Songs[randomIndex];
                Songs[randomIndex] = song;
            }
        }
    }
}


      

