using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using startmenu;
namespace menu
{ 
    public class StartGame : MonoBehaviour
    {
    public StartMenu Menu;
    #if (DEVELOPMENT_BUILD || UNITY_EDITOR)
    public void onClick()
    {
        ColorBlock selected = Menu.SelectedButton.colors;
        ColorBlock deselected = Menu.DeselectedButton.colors;
        Menu.UnderstandCanvas.SetActive(true);
        Menu.StartCanvas.SetActive(false);
        if (Input.GetKeyDown(KeyCode.Return) ||  Input.GetKeyDown("joystick button 0") && Menu.UnderstandTextShown == true){
            SceneManager.LoadScene("Game");
        }
        Menu.UnderstandTextShown = true;
        Menu.UnderstandButton.colors = selected;
        Menu.Understand.color = new Color32(255, 255, 255, 255);
    }
    #endif
    }
}