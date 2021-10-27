using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Global
{
    public class FPSCount : MonoBehaviour
    {
        public int avgfps;
        
        void Update()
        {
            float fps = 0;
            fps = (int)(1f / Time.unscaledDeltaTime);
            avgfps = (int)fps;
        }
    }
}
