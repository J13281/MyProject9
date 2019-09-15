using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

class Program
{
    public static void Load(out List<string> musicList, out Dictionary<string, MusicInfo> musics)
    {
        var source = new[] {
            new { title = "河童界のはずれ", name = "music\\河童界のはずれ" },
            new { title = "みなとにようこそ", name = "music\\みなとにようこそ" },
            new { title = "廃獄を超えて", name = "music\\廃獄を超えて" },
            new { title = "華と逆月と音と光", name = "music\\華と逆月と音と光" },
            new { title = "3rd party!!", name = "music\\3rd party!!" },
            new { title = "二等天変", name = "music\\二等天変" },
            new { title = "フラワー・グラン", name = "music\\フラワー・グラン" },
        };

        musicList = source.Select(x => x.name).ToList();

        var y = 450;
        musics = new Dictionary<string, MusicInfo>();
        foreach (var item in source)
        {
            musics[item.name] = new MusicInfo(item.name, item.title, new Vector3(0, y -= 50, 0));
        }
    }
}