using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Load(out List<string> musicList, out Dictionary<string, MusicInfo> musics)
    {
        var source = new[] {
            new { text = "月世界旅行", name = "a" },
            new { text = "魔法少年", name = "b" },
            new { text = "踊れオーケストラ", name = "c" },
            new { text = "アイアムソフィ", name = "d" },
            new { text = "居残り花子", name = "e" },
        };

        musicList = source.Select(x => x.name).ToList();
        musics = source.ToDictionary(x => x.name, x => new MusicInfo(x.name, x.text));
    }
}