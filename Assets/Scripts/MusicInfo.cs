using UnityEngine;

class MusicInfo
{
    public string name;
    public string title;
    public Vector3 position;

    public MusicInfo(string name, string title, Vector3 position)
    {
        this.name = name;
        this.title = title;
        this.position = position;
    }
}