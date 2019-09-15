using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class ButtonController : MonoBehaviour
{
    public void OnMusicSelect() => MainController.current.OnMusicSelect(name);
    public void OnStart() => MainController.current.OnStart();
    public void OnPause() => MainController.current.OnPause();
    public void OnNext() => MainController.current.OnNext();
    public void OnPrev() => MainController.current.OnPrev();
}
