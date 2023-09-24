﻿using spotify_deneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify_deneme.Services
{
    internal class NotepadService
    {
        public void PlaylistToNotepad(Playlist playlist)
        {
            //Saving to notepad...
            //
            string directory = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\\Playlists";

            if (!File.Exists(directory))
                Directory.CreateDirectory(directory);
            

          
            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");

            File.WriteAllText(saveFile, playlist.GetSongs());
            Console.WriteLine("Data Successfully Saved to Notepad!");
        }
    }
}
