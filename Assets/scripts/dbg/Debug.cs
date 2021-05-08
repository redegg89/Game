using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

class Debug : MonoBehaviour
{
    public static bool OpenConsole = false;
    void Start()
    {
        Openconsole();
    }
    public static void Openconsole()
    {
        if (OpenConsole == true)
            return;
        else
        {
            Console.OpenStandardOutput();
            OpenConsole = true;
        }
    }
    public static void Log(string Log)
    {
        Console.WriteLine(Log);
    }
}

