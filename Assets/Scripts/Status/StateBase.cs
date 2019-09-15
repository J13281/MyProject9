using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

abstract class StateBase
{
    public StateBase nextState;
    public bool isComplate;

    public virtual void Init() { }
    public virtual void End() { }

    public virtual void Update() { }
    public virtual void OnMusicSelect(string name) { }
    public virtual void OnPause() { }
    public virtual void OnStart() { }
    public virtual void OnPrev() { }
    public virtual void OnNext() { }

    public void Transition(StateBase nextState)
    {
        this.nextState = nextState;
        isComplate = true;
        End();

        Debug.Log($"{GetType().Name} -> {nextState.GetType().Name}");

        nextState.Init();
    }
}
