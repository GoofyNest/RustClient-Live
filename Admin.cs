public class AdminExistingSellOrder : MonoBehaviour // TypeDefIndex: 8728
{	public VirtualItemIcon MerchandiseIcon; // 0x18
	public VirtualItemIcon CurrencyIcon; // 0x20
	private VendingPanelAdmin adminPanel; // 0x28
	private int index; // 0x30


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
{	[ClientVar] // RVA: 0x80BE0 Offset: 0x7FFE0 VA: 0x180080BE0
	public static float admintime; // 0x0
	[ClientVar] // RVA: 0x80D30 Offset: 0x80130 VA: 0x180080D30
	public static float adminlight; // 0x4
	[ClientVar] // RVA: 0x80E60 Offset: 0x80260 VA: 0x180080E60
	public static float adminreflectionmultiplier; // 0x8
	[ClientVar] // RVA: 0x80FD0 Offset: 0x803D0 VA: 0x180080FD0
	public static float adminambientmultiplier; // 0xC
	[ReplicatedVar] // RVA: 0x81180 Offset: 0x80580 VA: 0x180081180
	public static bool allowAdminUI; // 0x10
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static bool underwater_effect; // 0x11
	[ClientVar] // RVA: 0x812A0 Offset: 0x806A0 VA: 0x1800812A0
	public static float underwater_scatter; // 0x14
	[ClientVar] // RVA: 0x814D0 Offset: 0x808D0 VA: 0x1800814D0
	public static bool woundedfreecam; // 0x18
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool ddraw_netupdate; // 0x19

	[ClientVar] // RVA: 0x849E0 Offset: 0x83DE0 VA: 0x1800849E0
	public static float adminclouds { get; set; }
	[ClientVar] // RVA: 0x84C40 Offset: 0x84040 VA: 0x180084C40
	public static float adminfog { get; set; }
	[ClientVar] // RVA: 0x84DD0 Offset: 0x841D0 VA: 0x180084DD0
	public static float adminwind { get; set; }
	[ClientVar] // RVA: 0x84F60 Offset: 0x84360 VA: 0x180084F60
	public static float adminrain { get; set; }


	[ServerVar] // RVA: 0x816B0 Offset: 0x80AB0 VA: 0x1800816B0
	public static void status(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81760 Offset: 0x80B60 VA: 0x180081760
	public static void stats(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void killplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void injureplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void recoverplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void kick(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void kickall(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B40 Offset: 0x80F40 VA: 0x180081B40
	public static void ban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void moderatorid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void ownerid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void removemoderator(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void removeowner(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83000 Offset: 0x82400 VA: 0x180083000
	public static void banid(ConsoleSystem.Arg arg) { }

	private static bool TryGetBanExpiry(ConsoleSystem.Arg arg, int n, out long expiry, out string durationSuffix) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void unban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void skipqueue(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x833C0 Offset: 0x827C0 VA: 0x1800833C0
	public static void players(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x834F0 Offset: 0x828F0 VA: 0x1800834F0
	public static void say(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x836E0 Offset: 0x82AE0 VA: 0x1800836E0
	public static void users(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x836E0 Offset: 0x82AE0 VA: 0x1800836E0
	public static void sleepingusers(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83820 Offset: 0x82C20 VA: 0x180083820
	public static void sleepingusersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x838F0 Offset: 0x82CF0 VA: 0x1800838F0
	public static void usersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x839A0 Offset: 0x82DA0 VA: 0x1800839A0
	public static void usersinrangeofplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83B00 Offset: 0x82F00 VA: 0x180083B00
	public static void banlist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83C30 Offset: 0x83030 VA: 0x180083C30
	public static void banlistex(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83D10 Offset: 0x83110 VA: 0x180083D10
	public static void listid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void mute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x840C0 Offset: 0x834C0 VA: 0x1800840C0
	public static void mutelist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void clientperf(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static void clientperf_frametime(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x843A0 Offset: 0x837A0 VA: 0x1800843A0
	public static void carstats(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84470 Offset: 0x83870 VA: 0x180084470
	public static string ent(ConsoleSystem.Arg args) { }

	public static float get_adminclouds() { }

	public static void set_adminclouds(float value) { }

	public static float get_adminfog() { }

	public static void set_adminfog(float value) { }

	public static float get_adminwind() { }

	public static void set_adminwind(float value) { }

	public static float get_adminrain() { }

	public static void set_adminrain(float value) { }

	[ClientVar] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	public static void AdminUI_ReceivePlayerList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	public static void AdminUI_ReceiveServerInfo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	public static void AdminUI_ReceiveCommands(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	public static void AdminUI_ReceiveUGCList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84960 Offset: 0x83D60 VA: 0x180084960
	public static void hudcomponent(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Admin.PlayerInfo // TypeDefIndex: 11872
{	public string SteamID; // 0x0
	public string OwnerSteamID; // 0x8
	public string DisplayName; // 0x10
	public int Ping; // 0x18
	public string Address; // 0x20
	public int ConnectedSeconds; // 0x28
	public float VoiationLevel; // 0x2C
	public float CurrentLevel; // 0x30
	public float UnspentXp; // 0x34
	public float Health; // 0x38

}

public struct Admin.ServerInfoOutput // TypeDefIndex: 11873
{	public string Hostname; // 0x0
	public int MaxPlayers; // 0x8
	public int Players; // 0xC
	public int Queued; // 0x10
	public int Joining; // 0x14
	public int EntityCount; // 0x18
	public string GameTime; // 0x20
	public int Uptime; // 0x28
	public string Map; // 0x30
	public float Framerate; // 0x38
	public int Memory; // 0x3C
	public int Collections; // 0x40
	public int NetworkIn; // 0x44
	public int NetworkOut; // 0x48
	public bool Restarting; // 0x4C
	public string SaveCreatedTime; // 0x50
	public int Version; // 0x58
	public string Protocol; // 0x60

}

public struct Admin.ServerConvarInfo // TypeDefIndex: 11874
{	public string FullName; // 0x0
	public string Value; // 0x8
	public string Help; // 0x10

}

public struct Admin.ServerUGCInfo // TypeDefIndex: 11875
{	public uint entityId; // 0x0
	public uint[] crcs; // 0x8
	public UGCType contentType; // 0x10
	public uint entityPrefabID; // 0x14
	public string shortPrefabName; // 0x18
	public ulong[] playerIds; // 0x20

}

