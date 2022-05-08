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
    public movement Player;
    public Timer timer;
    public Math math;
    public FPSCount framerate;

    //misc vars
    //public bool DebugMenuDisabled;    Just a reminder this exists
    private float _timer;
    float fpsRefreshRate = 1f;

    #if (DEVELOPMENT_BUILD || UNITY_EDITOR)
        public bool DebugMenuDisabled = false;
    #else
        public bool DebugMenuDisabled = true;
    #endif

    void Update()
    {
        if(Input.GetButtonDown("F3"))
        {
            DebugMenuDisabled = !DebugMenuDisabled;
        }
        DebugCanvas.SetActive(!DebugMenuDisabled);
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
