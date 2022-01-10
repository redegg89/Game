using UnityEngine;
using UnityEngine.UI;
using Global;
using Player;
using API;
using locale;

public class UI : MonoBehaviour
{
    //UI elements
    public Text GlobalTimerUI;
    public Text SpeedonUI;
    public GameObject DebugCanvas;
    public Text FPS;

    //Variables for cross-file stuff
    public Timer timer;
    public ThirdPersonMovement Player;
    public Math math;
    public FPSCount framerate;

    //misc vars
    bool DebugMenuDisabled;
    private float _timer;
    float fpsRefreshRate = 1f;

    void Start()
    {
        DebugCanvas.SetActive(false);
        DebugMenuDisabled = false;
        lang.initDebug();
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
        SpeedonUI.text = lang.Speed + ": " + Player.speed.ToString();
        GlobalTimerUI.text = lang.GlobalTimer + ": " + timer.GlobalTimer.ToString();
        //FPS count (https://forum.unity.com/threads/fps-counter.505495/)
        if (Time.unscaledTime > _timer)
        {
            int fps = (int)(1f / Time.unscaledDeltaTime);
            FPS.text = "FPS:" + framerate.avgfps.ToString();
            _timer = Time.unscaledTime + fpsRefreshRate;
        }
        
    }
}
