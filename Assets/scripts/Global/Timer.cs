using UnityEngine;

namespace Global
{
    public class Timer : MonoBehaviour
    {
        public long GlobalTimer;
        void Start()
        {
        }

        void Update()
        {
            GlobalTimer += 1;
        }
    }
}
