using System;
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
        public int[] LVREQ = new int[]{2,4,8,18,24,32,52,69,81,98,105,128,138,147,157,168,184,215,256,273,294,300,328,357,400,450,502,559,605,680,720,800,900,1024,1200};

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Graph stuff here, I guess (https://www.desmos.com/calculator/qxgxn3r11g)
            if(XP == LVUP)
            {
                LevelInc();
            }
        }
        void LevelInc()
        {
            MAXHP = (int) Math.Pow(MAXHP,2);
            HP = MAXHP;
            if(LV <= 50)
            {
                ATK = LV * 5;
            }
            else
            {
                ATK = LV * 2 + 175;
            }
            DEF = ATK + 100;
            if(LV > 36)
            {
                LVUP = (int) Math.Pow(LV,2);
            }
            else
            {
                LVUP = LVREQ[LV];
            }
            LV++;
        }
    }
}