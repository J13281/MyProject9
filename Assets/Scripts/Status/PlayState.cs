using System;
using System.Collections.Generic;
using UnityEngine;

class PlayState : StateBase
{
    AudioSource audioSource;
    string name;

    public PlayState(string name)
    {
        this.name = name;
    }

    public override void Init()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
        audioSource.Play();

        MainController.gui.startButton.gameObject.SetActive(false);
        MainController.gui.pauseButton.gameObject.SetActive(true);
    }

    public override void OnMusicSelect(string name)
    {
        Transition(new MusicChangeState(name));
    }

    public override void OnPause()
    {
        Transition(new PauseState(name));
    }

    public override void Update()
    {
        if (audioSource.isPlaying)
        {
            MainController.gui.timeSlider.maxValue = audioSource.clip.length;
            MainController.gui.timeSlider.value = audioSource.time;

            MainController.gui.timeText.text =
                $"{timeFormat(audioSource.time)} / {timeFormat(audioSource.clip.length)}";
        }
        else
        {
            var next = nextItem(name, MainController.musicList);
            Transition(new MusicChangeState(next));
        }
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

    static string timeFormat(float length)
    {
        var n = (int)length;
        return $"{length / 60}:{length % 60:D2}";
    }
}