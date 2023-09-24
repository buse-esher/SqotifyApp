using spotify_deneme.Entities;
using spotify_deneme.Services;

Console.WriteLine("Spotify - Music for Noone");

var song1=new Song("Requiem", "Mozart", "Orcehtre de France", null);   
var song2=new Song("Sonata Major", "Beethoven", "Fazıl Say", "Warner Music");
var song3 = new Song("Moonlight", "Beethoven", "Various Artists", "Classical Records");
var song4 = new Song("Four Seasons", "Vivaldi", "Chamber", "Baroque");
var song5 = new Song("Symphony no9", "Beethoven", "Philharmonic", "Classic Harmony");

var playlist1 = new Playlist(song1); 
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);

Console.WriteLine("Before Shuffle");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();

Console.WriteLine("\n\nAfter Shuffle");
Console.WriteLine(playlist1.GetSongs());

NotepadService notepadService = new ();
notepadService.WriteToNotepad(playlist1);