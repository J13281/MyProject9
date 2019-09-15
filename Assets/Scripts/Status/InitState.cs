using System;
using UnityEngine;

class InitState : StateBase
{
    public override void Update()
    {
        var audioSource = Camera.main.GetComponent<AudioSource>();
        var name = MainController.musicList[0];
        var clip = Resources.Load<AudioClip>(name);

        audioSource.clip = clip;

        MainController.gui.titleText.text = MainController.musics[name].title;
        MainController.gui.timeText.text = $"0:00 / {timeFormat(clip.length)}";

        Transition(new PauseState(name));
    }

    string timeFormat(float length)
    {
        var n = (int)length;
        return $"{length / 60}:{length % 60:D2}";
    }
}