using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9.Models
{
    public class Music
    {
        public string Name { get; set; }

        public MusicCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Music(string name, MusicCategory category, string audioFile, string imgFile)
        {
            Name = name;
            Category = category;
            AudioFile = audioFile;
            ImageFile = imgFile;
        }
    }
    public enum MusicCategory
    {
        Vu,
        Binz,
        Masew,
        JeremyZucker,
        Den
    }

    public class MusicManager
    {
        public static List<Music> GetMusics()
        {
            var musics = new List<Music>();

            musics.Add(new Music("Lối Nhỏ", MusicCategory.Den, "Assets/Musics/loinho.mp3", "Assets/Images/loinho.jpg"));
            musics.Add(new Music("Cuới Thôi", MusicCategory.Masew, "Assets/Musics/cuoithoi.mp3", "Assets/Images/cuoithoi.jpg"));
            musics.Add(new Music("Comethru", MusicCategory.JeremyZucker, "Assets/Musics/comethru.mp3", "Assets/Images/comethru.jpg"));
            musics.Add(new Music("Happy For You", MusicCategory.Vu, "Assets/Musics/happyforyou.mp3", "Assets/Images/happyforyou.jpg"));
            musics.Add(new Music("Cho Mình Em", MusicCategory.Binz, "Assets/Musics/chominhem.mp3", "Assets/Images/chominhem.jpg"));

            return musics;
        }

        public static void GetAllMusic(ObservableCollection<Music> music)
        {
            var allSounds = GetMusics();
            music.Clear();
            allSounds.ForEach(p => music.Add(p));
        }

        public static void GetMusicByCategory(ObservableCollection<Music> musics, MusicCategory musicCategory)
        {
            var allMusic = GetMusics();
            var filteredMusic = allMusic.Where(p => p.Category == musicCategory).ToList();
            musics.Clear();
            filteredMusic.ForEach(p => musics.Add(p));
        }

        public static void GetMusicByName(ObservableCollection<Music> musics, string name)
        {
            var allMusic = GetMusics();
            var filteredSounds = allMusic.Where(p => p.Name == name).ToList();
            musics.Clear();
            filteredSounds.ForEach(p => musics.Add(p));
        }
    }
}
