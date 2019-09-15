using System.Collections.Generic;
using UnityEngine;

class PauseState : StateBase
{
    AudioSource audioSource;
    string name;

    public PauseState(string name)
    {
        this.name = name;
    }

    public override void Init()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
        audioSource.Pause();

        MainController.gui.startButton.gameObject.SetActive(true);
        MainController.gui.pauseButton.gameObject.SetActive(false);
    }

    public override void OnMusicSelect(string name)
    {
        Transition(new MusicChangeState(name));

    }

    public override void OnStart()
    {
        Transition(new PlayState(name));
    }

    public override void OnNext()
    {
        var next = nextItem(name, MainController.musicList);
        Transition(new MusicChangeState(next));
    }

    public override void OnPrev()
    {
        var prev = prevItem(name, MainController.musicList);
        Transition(new MusicChangeState(prev));
    }

    static T nextItem<T>(T item, List<T> list)
    {
        var n = list.IndexOf(item);
        return list[(n + 1) % list.Count];
    }

    static T prevItem<T>(T item, List<T> list)
    {
        var n = list.IndexOf(item);
        return list[(list.Count + n - 1) % list.Count];
    }
}