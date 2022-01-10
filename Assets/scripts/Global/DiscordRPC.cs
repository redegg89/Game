using System;
using Discord;
using UnityEngine;

public class DiscordRPC : MonoBehaviour
{
    public Discord.Discord discord;
    void Start()
    {
        long elapsed = DateTimeOffset.Now.ToUnixTimeSeconds();
        discord = new Discord.Discord(838809067203854346, (System.UInt64)Discord.CreateFlags.NoRequireDiscord);
        var activityManager = discord.GetActivityManager();

        var activity = new Discord.Activity{
            State = "Dev-ing",
            Details = "No clue what I'm doing",
            Timestamps =
            {
                Start = elapsed,
            },
            Assets = 
            {
                LargeText = "Unity"
            }
        };
        activityManager.UpdateActivity(activity, (res => {}));
    }
        void Update()
        {
            discord.RunCallbacks();
        }
    
}
