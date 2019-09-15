using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class MainController : MonoBehaviour
{
    public static GUIController gui;
    public static StateBase current;

    public static List<string> musicList;
    public static Dictionary<string, MusicInfo> musics;

    public string currentMusic;

    public void Start()
    {
        Program.Load(out musicList, out musics);
        current = new InitState();
        InitGUI();
    }

    void InitGUI()
    {
        var prefab = Resources.Load<GameObject>("ButtonPrefab");

        foreach (var name in musicList)
        {
            var obj = Instantiate(prefab, gui.canvas.transform);
            obj.name = name;
            obj.GetComponentInChildren<Text>().text = musics[name].title;
            obj.transform.position += musics[name].position;
        }
    }

    public void Update()
    {
        if (current.isComplate) current = current.nextState;
        current.Update();
    }
}