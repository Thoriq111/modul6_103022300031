using System;
using System.Collections;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title)) throw new ArgumentException("Judul video tidak boleh null atau kosong");
        if (title.Length > 200) throw new ArgumentException("Judul video tidak boleh lebih dari 200 karakter");
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0) throw new ArgumentException("Jumlah play count tidak boleh negatif.");
        if (count 25000000) throw new ArgumentException("Jumlah play count maksimal adalah 25.000.000");

        checked 
        {
            if (playCount + count > int.MaxValue) throw new OverflowException("Total play count melebihi batas maksimum integer");
            this.playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}

    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username)) throw new ArgumentException("Username tidak boleh null atau kosong");
            if (username.Length > 100) throw new ArgumentException("Username tidak boleh lebih dari 100 karakter");
            Random randomUser = new Random();
            this.id = randomUser.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
        }

    public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
             if (video == null) throw new ArgumentException("Video tidak boleh null");
             if (uploadedVideos.Count >= 8) throw new InvalidOperationException("Maksimal hanya dapat menambahkan 8 video");
             uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"Usaer: {username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }

class Program 
{
    static void Main() 
    {
        SayaTubeUser user = new SayaTubeUser("Muhamad_Thoriq_Marcello");

        SayaTubeVideo video1 = new SayaTubeVideo($"Review Film Inception {user.username}");
        user.AddVideo(video1);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video2 = new SayaTubeVideo($"Review Film The Dark Knight {user.username}");
        user.AddVideo(video2);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video3 = new SayaTubeVideo($"Review Film The Godfather {user.username}");
        user.AddVideo(video3);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video4 = new SayaTubeVideo($"Review Film Money Heist {user.username}");
        user.AddVideo(video4);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video5 = new SayaTubeVideo($"Review Film Lupin {user.username}");
        user.AddVideo(video5);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video6 = new SayaTubeVideo($"Review Film Parasite {user.username}");
        user.AddVideo(video6);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video7 = new SayaTubeVideo($"Review Film Redemption {user.username}");
        user.AddVideo(video7);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video8 = new SayaTubeVideo($"Review Film Breaking Bed {user.username}");
        user.AddVideo(video8);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video9 = new SayaTubeVideo($"Review Film The Witcher {user.username}");
        user.AddVideo(video9);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video10 = new SayaTubeVideo($"Review Film The Matrix {user.username}");
        user.AddVideo(video10);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
        user.PrintAllVideoPlayCount();
    }
}