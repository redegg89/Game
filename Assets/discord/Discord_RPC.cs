using Discord;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discord_RPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void InitDiscord()
    {
        DiscordEventHandlers handlers;
        memset(&handlers, 0, sizeof(handlers));
        handlers.ready = handleDiscordReady;
        handlers.errored = handleDiscordError;
        handlers.disconnected = handleDiscordDisconnected;
        handlers.joinGame = handleDiscordJoinGame;
        handlers.spectateGame = handleDiscordSpectateGame;
        handlers.joinRequest = handleDiscordJoinRequest;

        // Discord_Initialize(const char* applicationId, DiscordEventHandlers* handlers, int autoRegister, const char* optionalSteamId)
        Discord_Initialize("838809067203854346", &handlers, 1, "1234");
    }
    static void Discord_UpdatePresence()
    {
        DiscordRichPresence discordPresence;
        memset(&discordPresence, 0, sizeof(discordPresence));
        discordPresence.state = "Playing Solo";
        discordPresence.startTimestamp = 0;
        discordPresence.largeImageText = "Made by redegg89";
        discordPresence.smallImageText = "Rogue - Level 100";
        discordPresence.joinSecret = "MTI4NzM0OjFpMmhuZToxMjMxMjM= ";
        Discord_UpdatePresence(&discordPresence);
    }
}
