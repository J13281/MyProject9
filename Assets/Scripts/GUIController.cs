using UnityEngine;
using UnityEngine.UI;

class GUIController : MonoBehaviour
{
    public Canvas canvas;
    public Button startButton;
    public Button pauseButton;
    public Text timeText;
    public Text titleText;
    public Slider timeSlider;

    public void Start()
    {
        Screen.SetResolution(360, 640, false, 60);
        MainController.gui = this;
    }
}