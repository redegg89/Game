using System;
using Discord;
using UnityEngine;
using locale;

public class DiscordRPC : MonoBehaviour
{
    public Discord.Discord discord;
    void Start()
    {
        long elapsed = DateTimeOffset.Now.ToUnixTimeSeconds();
        discord = new Discord.Discord(838809067203854346, (System.UInt64)Discord.CreateFlags.NoRequireDiscord);
        var activityManager = discord.GetActivityManager();

        var activity = new Discord.Activity{
            State = lang.RPCState,
            Details = lang.RPCDetails,
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
