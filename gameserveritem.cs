internal struct gameserveritem_t // TypeDefIndex: 5512
{
	internal servernetadr_t NetAdr;
	internal int Ping;
	internal bool HadSuccessfulResponse;
	internal bool DoNotRefresh;
	internal byte[] GameDir;
	internal byte[] Map;
	internal byte[] GameDescription;
	internal uint AppID;
	internal int Players;
	internal int MaxPlayers;
	internal int BotPlayers;
	internal bool Password;
	internal bool Secure;
	internal uint TimeLastPlayed;
	internal int ServerVersion;
	internal byte[] ServerName;
	internal byte[] GameTags;
	internal ulong SteamID;


	internal string GameDirUTF8() { }

	internal string MapUTF8() { }

	internal string GameDescriptionUTF8() { }

	internal string ServerNameUTF8() { }

	internal string GameTagsUTF8() { }

}

