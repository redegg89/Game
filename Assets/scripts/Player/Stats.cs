using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace stats
{
    public class Stats
    {
        public int LV; //Level
        public int HP; //health
        public int MAXHP; //Max HP
        public int ATK; //attack
        public int DEF; //defense
        public int XP; //experience (used for when to increase level)
        public int LVUP; //Level up requirement (Amount of XP needed for next level up)
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Graph stuff here, I guess (https://www.desmos.com/calculator/qxgxn3r11g)
        }
    }
}