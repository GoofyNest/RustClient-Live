public class AdminExistingSellOrder : MonoBehaviour // TypeDefIndex: 8728
{
	public VirtualItemIcon MerchandiseIcon; 
	public VirtualItemIcon CurrencyIcon; 
	private VendingPanelAdmin adminPanel; 
	private int index; 


	public void Setup(VendingMachine.SellOrder so, int newIndex, VendingPanelAdmin admin) { }

	public void DeleteClick() { }

	public void .ctor() { }

}

public class AdminUI : MonoBehaviour // TypeDefIndex: 10824
{

	public bool IsVisible() { }

	public void OnPanelOpened() { }

	public void Update() { }

	public void .ctor() { }

}

public class Admin : ConsoleSystem // TypeDefIndex: 11871
{
	[ClientVar] 
	public static float admintime; 
	[ClientVar] 
	public static float adminlight; 
	[ClientVar] 
	public static float adminreflectionmultiplier; 
	[ClientVar] 
	public static float adminambientmultiplier; 
	[ReplicatedVar] 
	public static bool allowAdminUI; 
	[ClientVar] 
	public static bool underwater_effect; 
	[ClientVar] 
	public static float underwater_scatter; 
	[ClientVar] 
	public static bool woundedfreecam; 
	[ClientVar] 
	public static bool ddraw_netupdate; 

	[ClientVar] 
	public static float adminclouds { get; set; }
	[ClientVar] 
	public static float adminfog { get; set; }
	[ClientVar] 
	public static float adminwind { get; set; }
	[ClientVar] 
	public static float adminrain { get; set; }


	[ServerVar] 
	public static void status(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void stats(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void killplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void injureplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void recoverplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void kick(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void kickall(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void ban(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void moderatorid(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void ownerid(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void removemoderator(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void removeowner(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void banid(ConsoleSystem.Arg arg) { }

	private static bool TryGetBanExpiry(ConsoleSystem.Arg arg, int n, out long expiry, out string durationSuffix) { }

	[ServerVar] 
	public static void unban(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void skipqueue(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void players(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void say(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void users(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void sleepingusers(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void sleepingusersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void usersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void usersinrangeofplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void banlist(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void banlistex(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void listid(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void mute(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void mutelist(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void clientperf(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void clientperf_frametime(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	public static void carstats(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static string ent(ConsoleSystem.Arg args) { }

	public static float get_adminclouds() { }

	public static void set_adminclouds(float value) { }

	public static float get_adminfog() { }

	public static void set_adminfog(float value) { }

	public static float get_adminwind() { }

	public static void set_adminwind(float value) { }

	public static float get_adminrain() { }

	public static void set_adminrain(float value) { }

	[ClientVar] 
	public static void AdminUI_ReceivePlayerList(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void AdminUI_ReceiveServerInfo(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void AdminUI_ReceiveCommands(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void AdminUI_ReceiveUGCList(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void hudcomponent(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Admin.PlayerInfo // TypeDefIndex: 11872
{
	public string SteamID; 
	public string OwnerSteamID; 
	public string DisplayName; 
	public int Ping; 
	public string Address; 
	public int ConnectedSeconds; 
	public float VoiationLevel; 
	public float CurrentLevel; 
	public float UnspentXp; 
	public float Health; 

}

public struct Admin.ServerInfoOutput // TypeDefIndex: 11873
{
	public string Hostname; 
	public int MaxPlayers; 
	public int Players; 
	public int Queued; 
	public int Joining; 
	public int EntityCount; 
	public string GameTime; 
	public int Uptime; 
	public string Map; 
	public float Framerate; 
	public int Memory; 
	public int Collections; 
	public int NetworkIn; 
	public int NetworkOut; 
	public bool Restarting; 
	public string SaveCreatedTime; 
	public int Version; 
	public string Protocol; 

}

public struct Admin.ServerConvarInfo // TypeDefIndex: 11874
{
	public string FullName; 
	public string Value; 
	public string Help; 

}

public struct Admin.ServerUGCInfo // TypeDefIndex: 11875
{
	public uint entityId; 
	public uint[] crcs; 
	public UGCType contentType; 
	public uint entityPrefabID; 
	public string shortPrefabName; 
	public ulong[] playerIds; 

}

