using UnityEngine;

class MusicChangeState : StateBase
{
    string name;

    public MusicChangeState(string name)
    {
        this.name = name;
    }

    public override void Init()
    {
        var audioSource = Camera.main.GetComponent<AudioSource>();
        var clip = Resources.Load<AudioClip>(name);
        audioSource.clip = clip;

        MainController.gui.titleText.text = MainController.musics[name].title;

        Transition(new PlayState(name));
    }
}