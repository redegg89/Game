using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class StartMenu : MonoBehaviour {

    public Text option1;
    public Button option1Button;
    public Text option2;
    public Button option2Button;
    public Text option3;
    public Button option3Button;

    public Button SelectedButton;
    public Button DeselectedButton;

    private int numberOfOptions = 3;

    private int selectedOption;

    // Use this for initialization
    void Start () {
        ColorBlock selected = SelectedButton.colors;
        ColorBlock deselected = DeselectedButton.colors;
        //selected.normalColor = new Color32(59, 59, 59, 255);
        selectedOption = 1;
        option1.color = new Color32(255, 255, 255, 255);
        option1Button.colors = selected;
        option2.color = new Color32(0, 0, 0, 255);
        option2Button.colors = deselected;
        option3.color = new Color32(0, 0, 0, 255);
        option3Button.colors = deselected;
    }

    // Update is called once per frame
    void Update () 
    {
        ColorBlock selected = SelectedButton.colors;
        ColorBlock deselected = DeselectedButton.colors;
        if (Input.GetAxisRaw("Keyboard W") <=-0.1 || Input.GetAxisRaw("Vertical") <=-0.1)
        { //Input telling it to go up or down.
            selectedOption += 1;
            if (selectedOption > numberOfOptions) //If at end of list go back to top
            {
                selectedOption = 1;
            }

            option1.color = new Color32(0, 0, 0, 255); //Make sure all others will be black (or do any visual you want to use to indicate this)
            option2.color = new Color32(0, 0, 0, 255);
            option3.color = new Color32(0, 0, 0, 255);
            option1Button.colors = deselected;
            option2Button.colors = deselected;
            option3Button.colors = deselected;
            switch (selectedOption) //Set the visual indicator for which option you are on.
        {
            case 1:
                option1.color = new Color32(255, 255, 255, 255);
                option1Button.colors = selected;
                break;
            case 2:
                option2.color = new Color32(255, 255, 255, 255);
                option2Button.colors = selected;
                break;
            case 3:
                option3.color = new Color32(255, 255, 255, 255);
                option3Button.colors = selected;
                break;
        }
            Thread.Sleep(300);
        }

        if (Input.GetAxisRaw("Keyboard W") >= 0.1f || Input.GetAxisRaw("Vertical") >= 0.1f)
        { //Input telling it to go up or down.
            selectedOption -= 1;
            if (selectedOption < 1) //If at end of list go back to top
            {
                selectedOption = numberOfOptions;
            }

            option1.color = new Color32(0, 0, 0, 255); //Make sure all others will be black (or do any visual you want to use to indicate this)
            option2.color = new Color32(0, 0, 0, 255);
            option3.color = new Color32(0, 0, 0, 255);
            option1Button.colors = deselected;
            option2Button.colors = deselected;
            option3Button.colors = deselected;
            switch (selectedOption) //Set the visual indicator for which option you are on.
            {
                case 1:
                    option1.color = new Color32(255, 255, 255, 255);
                    option1Button.colors = selected;
                    break;
                case 2:
                    option2.color = new Color32(255, 255, 255, 255);
                    option2Button.colors = selected;
                    break;
                case 3:
                    option3.color = new Color32(255, 255, 255, 255);
                    option3Button.colors = selected;
                    break;
            }
            Thread.Sleep(300);
        }

        if (Input.GetKeyDown(KeyCode.Return) ||  Input.GetKeyDown("joystick button 0")){
            Debug.Log("Picked: " + selectedOption); //For testing as the switch statment does nothing right now.

            switch (selectedOption) //Set the visual indicator for which option you are on.
            {
                case 1:
                    SceneManager.LoadScene("Game");
                    break;
                case 2:
                    /*Do option two*/
                    break;
                case 3:
                    Application.Quit();
                    break;
            }
        }
    }
}