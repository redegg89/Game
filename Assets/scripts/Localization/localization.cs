using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class localization : MonoBehaviour
{
    //Base Locale reader code
    public static void ReadLocale()
    {
        string path = "Locale/en_US.locale";
        StreamReader reader = new StreamReader(path);
        
    }
}
