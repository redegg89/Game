using UnityEngine;
using UnityEngine.UI;
using Global;
using Player;
using API;

public class UI : MonoBehaviour
{
    //UI elements
    public Text GlobalTimerUI;
    public Text SpeedonUI;
    public GameObject DebugCanvas;

    //Variables for cross-file stuff
    public Timer timer;
    public ThirdPersonMovement Player;
    public Math math;

    //misc vars
    bool DebugMenuDisabled;

    void Start()
    {
        DebugCanvas.SetActive(false);
        DebugMenuDisabled = false;
    }

    void Update()
    {
        if(Input.GetButtonDown("F3") & DebugMenuDisabled == false)
        {
            DebugCanvas.SetActive(true);
            DebugMenuDisabled = true;
        }
        else if(Input.GetButtonDown("F3") & DebugMenuDisabled == true)
        {
            DebugCanvas.SetActive(false);
            DebugMenuDisabled = false;
        }
        SpeedonUI.text = "Speed: " + Player.speed.ToString();
        GlobalTimerUI.text = "Global Timer: " + timer.GlobalTimer.ToString();
    }
}
