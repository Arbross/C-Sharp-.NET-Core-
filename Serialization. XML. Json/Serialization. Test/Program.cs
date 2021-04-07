using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Serialization._Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some();
            Song song = new Song() { Name = "Beliver", Singer = "Imagine Dragon", Duration = TimeSpan.FromMinutes(3.5) };
            Song song1 = new Song() { Name = "Nirvana", Singer = "Smells Like Teen Spirit", Duration = TimeSpan.FromMinutes(250) };
            Song song2 = new Song() { Name = "Green Day", Singer = "Boulevard Of Broken Dreams", Duration = TimeSpan.FromMinutes(350) };
            Song song3 = new Song() { Name = "Bruises", Singer = "Lewis Capaldi", Duration = TimeSpan.FromMinutes(100) };

            string fname = "song.json";
            string jsonStr = System.Text.Json.JsonSerializer.Serialize<Song>(song);
            File.WriteAllText(fname, jsonStr);
            Console.WriteLine("------------------JSON");
            Console.WriteLine(jsonStr);
            Song result = System.Text.Json.JsonSerializer.Deserialize<Song>(jsonStr);
            Console.WriteLine($"\nRecovered song\n{result}");

            string json_ = JsonConvert.SerializeObject(song);
            Console.WriteLine(json_);
            Song res = JsonConvert.DeserializeObject<Song>(json_);
            Console.WriteLine(res);

            WebClient wc = new WebClient();
            string x = wc.DownloadString("http://google.com/");
            File.WriteAllText("text1.html", x);
            // Console.WriteLine(json__);
        }

        private static void Some()
        {
            Song song = new Song() { Name = "Beliver", Singer = "Imagine Dragon", Duration = TimeSpan.FromMinutes(3.5) };
            //Console.WriteLine(song);
            Song song1 = new Song() { Name = "Nirvana", Singer = "Smells Like Teen Spirit", Duration = TimeSpan.FromMinutes(250) };
            Song song2 = new Song() { Name = "Green Day", Singer = "Boulevard Of Broken Dreams", Duration = TimeSpan.FromMinutes(350) };
            Song song3 = new Song() { Name = "Bruises", Singer = "Lewis Capaldi", Duration = TimeSpan.FromMinutes(100) };
            //Console.WriteLine(song1);

            //BinaryFormatter bf = new BinaryFormatter();
            //using (FileStream fs = new FileStream("Song.dat", FileMode.OpenOrCreate))
            //{
            //    bf.Serialize(fs, song);
            //    fs.Position = 0;
            //    Song result = (Song)bf.Deserialize(fs);
            //    Console.WriteLine($"Recovered song : {result}");
            //}

            List<Song> list = new List<Song>();
            list.Add(song);
            list.Add(song1);
            list.Add(song2);
            list.Add(song3);
            BinaryFormatter bf_ = new BinaryFormatter();
            using (FileStream fs = new FileStream("SongList.dat", FileMode.OpenOrCreate))
            {
                bf_.Serialize(fs, list);
                list.Clear();
                fs.Position = 0;
                list.AddRange((List<Song>)bf_.Deserialize(fs));
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            XmlSerializer xs = new XmlSerializer(typeof(Song));
            using (TextWriter tw = new StreamWriter("test.dat"))
            {
                xs.Serialize(tw, song2);
            }
            using (TextReader tr = new StreamReader("test.dat"))
            {
                Song result = (Song)xs.Deserialize(tr);
                Console.WriteLine($"Recovered song {result}");
            }
        }
    }
}
