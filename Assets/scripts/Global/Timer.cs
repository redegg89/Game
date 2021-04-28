using UnityEngine;

namespace Global
{
    public class Timer : MonoBehaviour
    {
        public short GlobalTimer;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            GlobalTimer += 1;
        }
    }
}
