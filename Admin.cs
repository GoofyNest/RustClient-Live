public class AdminExistingSellOrder : MonoBehaviour // TypeDefIndex: 8728
{	// Fields
	public VirtualItemIcon MerchandiseIcon; // 0x18
	public VirtualItemIcon CurrencyIcon; // 0x20
	private VendingPanelAdmin adminPanel; // 0x28
	private int index; // 0x30

	// Methods

	// RVA: 0xA9B040 Offset: 0xA9A440 VA: 0x180A9B040
	public void Setup(VendingMachine.SellOrder so, int newIndex, VendingPanelAdmin admin) { }

	// RVA: 0xA9AFC0 Offset: 0xA9A3C0 VA: 0x180A9AFC0
	public void DeleteClick() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class AdminUI : MonoBehaviour // TypeDefIndex: 10824
{	// Methods

	// RVA: 0xA9B120 Offset: 0xA9A520 VA: 0x180A9B120
	public bool IsVisible() { }

	// RVA: 0xA9B280 Offset: 0xA9A680 VA: 0x180A9B280
	public void OnPanelOpened() { }

	// RVA: 0xA9B2D0 Offset: 0xA9A6D0 VA: 0x180A9B2D0
	public void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class Admin : ConsoleSystem // TypeDefIndex: 11871
{	// Fields
	[ClientVar] // RVA: 0x80BE0 Offset: 0x7FFE0 VA: 0x180080BE0
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

	// Properties
	[ClientVar] // RVA: 0x849E0 Offset: 0x83DE0 VA: 0x1800849E0
	public static float adminclouds { get; set; }
	[ClientVar] // RVA: 0x84C40 Offset: 0x84040 VA: 0x180084C40
	public static float adminfog { get; set; }
	[ClientVar] // RVA: 0x84DD0 Offset: 0x841D0 VA: 0x180084DD0
	public static float adminwind { get; set; }
	[ClientVar] // RVA: 0x84F60 Offset: 0x84360 VA: 0x180084F60
	public static float adminrain { get; set; }

	// Methods

	[ServerVar] // RVA: 0x816B0 Offset: 0x80AB0 VA: 0x1800816B0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void status(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81760 Offset: 0x80B60 VA: 0x180081760
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void stats(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void killplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void injureplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void recoverplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void kick(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void kickall(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x81B40 Offset: 0x80F40 VA: 0x180081B40
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void moderatorid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ownerid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void removemoderator(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void removeowner(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83000 Offset: 0x82400 VA: 0x180083000
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void banid(ConsoleSystem.Arg arg) { }

	// RVA: 0x6C7650 Offset: 0x6C6A50 VA: 0x1806C7650
	private static bool TryGetBanExpiry(ConsoleSystem.Arg arg, int n, out long expiry, out string durationSuffix) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void unban(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void skipqueue(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x833C0 Offset: 0x827C0 VA: 0x1800833C0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void players(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x834F0 Offset: 0x828F0 VA: 0x1800834F0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void say(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x836E0 Offset: 0x82AE0 VA: 0x1800836E0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void users(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x836E0 Offset: 0x82AE0 VA: 0x1800836E0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void sleepingusers(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83820 Offset: 0x82C20 VA: 0x180083820
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void sleepingusersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x838F0 Offset: 0x82CF0 VA: 0x1800838F0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void usersinrange(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x839A0 Offset: 0x82DA0 VA: 0x1800839A0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void usersinrangeofplayer(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83B00 Offset: 0x82F00 VA: 0x180083B00
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void banlist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83C30 Offset: 0x83030 VA: 0x180083C30
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void banlistex(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x83D10 Offset: 0x83110 VA: 0x180083D10
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void listid(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void mute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x840C0 Offset: 0x834C0 VA: 0x1800840C0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void mutelist(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void clientperf(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void clientperf_frametime(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x843A0 Offset: 0x837A0 VA: 0x1800843A0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void carstats(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84470 Offset: 0x83870 VA: 0x180084470
	// RVA: 0x6C7890 Offset: 0x6C6C90 VA: 0x1806C7890
	public static string ent(ConsoleSystem.Arg args) { }

	// RVA: 0x6C7B10 Offset: 0x6C6F10 VA: 0x1806C7B10
	public static float get_adminclouds() { }

	// RVA: 0x6C83D0 Offset: 0x6C77D0 VA: 0x1806C83D0
	public static void set_adminclouds(float value) { }

	// RVA: 0x6C7C00 Offset: 0x6C7000 VA: 0x1806C7C00
	public static float get_adminfog() { }

	// RVA: 0x6C84C0 Offset: 0x6C78C0 VA: 0x1806C84C0
	public static void set_adminfog(float value) { }

	// RVA: 0x6C7DE0 Offset: 0x6C71E0 VA: 0x1806C7DE0
	public static float get_adminwind() { }

	// RVA: 0x6C86A0 Offset: 0x6C7AA0 VA: 0x1806C86A0
	public static void set_adminwind(float value) { }

	// RVA: 0x6C7CF0 Offset: 0x6C70F0 VA: 0x1806C7CF0
	public static float get_adminrain() { }

	// RVA: 0x6C85B0 Offset: 0x6C79B0 VA: 0x1806C85B0
	public static void set_adminrain(float value) { }

	[ClientVar] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	// RVA: 0x6C7440 Offset: 0x6C6840 VA: 0x1806C7440
	public static void AdminUI_ReceivePlayerList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	// RVA: 0x6C74F0 Offset: 0x6C68F0 VA: 0x1806C74F0
	public static void AdminUI_ReceiveServerInfo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	// RVA: 0x6C7390 Offset: 0x6C6790 VA: 0x1806C7390
	public static void AdminUI_ReceiveCommands(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x845E0 Offset: 0x839E0 VA: 0x1800845E0
	// RVA: 0x6C75A0 Offset: 0x6C69A0 VA: 0x1806C75A0
	public static void AdminUI_ReceiveUGCList(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x84960 Offset: 0x83D60 VA: 0x180084960
	// RVA: 0x6C7ED0 Offset: 0x6C72D0 VA: 0x1806C7ED0
	public static void hudcomponent(ConsoleSystem.Arg arg) { }

	// RVA: 0x6C7830 Offset: 0x6C6C30 VA: 0x1806C7830
	public void .ctor() { }

	// RVA: 0x6C7760 Offset: 0x6C6B60 VA: 0x1806C7760
	private static void .cctor() { }

}

public struct Admin.PlayerInfo // TypeDefIndex: 11872
{	// Fields
	public string SteamID; // 0x0
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
{	// Fields
	public string Hostname; // 0x0
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
{	// Fields
	public string FullName; // 0x0
	public string Value; // 0x8
	public string Help; // 0x10

}

public struct Admin.ServerUGCInfo // TypeDefIndex: 11875
{	// Fields
	public uint entityId; // 0x0
	public uint[] crcs; // 0x8
	public UGCType contentType; // 0x10
	public uint entityPrefabID; // 0x14
	public string shortPrefabName; // 0x18
	public ulong[] playerIds; // 0x20

}

