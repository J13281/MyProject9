using UnityEngine;

class MusicInfo
{
    public string name;
    public string title;
    public Vector3 position;

    public MusicInfo(string name, string title)
    {
        this.name = name;
        this.title = title;
        position = Vector3.zero;
    }
}