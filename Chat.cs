internal enum ChatEntryType // TypeDefIndex: 5139
{	// Fields
	public int value__; // 0x0
	public const ChatEntryType Invalid = 0;
	public const ChatEntryType ChatMsg = 1;
	public const ChatEntryType Typing = 2;
	public const ChatEntryType InviteGame = 3;
	public const ChatEntryType Emote = 4;
	public const ChatEntryType LeftConversation = 6;
	public const ChatEntryType Entered = 7;
	public const ChatEntryType WasKicked = 8;
	public const ChatEntryType WasBanned = 9;
	public const ChatEntryType Disconnected = 10;
	public const ChatEntryType HistoricalChat = 11;
	public const ChatEntryType LinkBlocked = 14;

}

public class ChatEntry : MonoBehaviour // TypeDefIndex: 10828
{	// Fields
	public TextMeshProUGUI text; // 0x18
	public RawImage avatar; // 0x20
	public CanvasGroup canvasGroup; // 0x28
	public float lifeStarted; // 0x30
	public ulong steamid; // 0x38
	private Texture defaultTexture; // 0x40
	private Action<ChatEntry> clickedAction; // 0x48

	// Properties
	public float age { get; }

	// Methods

	// RVA: 0x550080 Offset: 0x54F480 VA: 0x180550080
	public float get_age() { }

	// RVA: 0x54FC70 Offset: 0x54F070 VA: 0x18054FC70
	public void Setup(Chat.ChatChannel channel, ulong steamid, string message, float volume, Action<ChatEntry> clickedAction) { }

	// RVA: 0x54FBD0 Offset: 0x54EFD0 VA: 0x18054FBD0
	private void SetMessageText(Chat.ChatChannel channel, string message) { }

	// RVA: 0x54FEE0 Offset: 0x54F2E0 VA: 0x18054FEE0
	protected void Update() { }

	// RVA: 0x54FB80 Offset: 0x54EF80 VA: 0x18054FB80
	public void OnClicked() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class Chat : ConsoleSystem // TypeDefIndex: 11882
{	// Fields
	private const float textRange = 50;
	private const float textVolumeBoost = 0,2;
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool enabled; // 0x0
	public static Chat.MuteList muted; // 0x8

	// Properties
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool muteglobal { get; set; }

	// Methods

	// RVA: 0x6CB5A0 Offset: 0x6CA9A0 VA: 0x1806CB5A0
	public static bool get_muteglobal() { }

	// RVA: 0x6CBBD0 Offset: 0x6CAFD0 VA: 0x1806CBBD0
	public static void set_muteglobal(bool value) { }

	// RVA: 0x6CA7A0 Offset: 0x6C9BA0 VA: 0x1806CA7A0
	public static void LoadMuteList() { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6CB1C0 Offset: 0x6CA5C0 VA: 0x1806CB1C0
	public static void add(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6CAF30 Offset: 0x6CA330 VA: 0x1806CAF30
	public static void add2(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CB640 Offset: 0x6CAA40 VA: 0x1806CB640
	public static void mute(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CBC70 Offset: 0x6CB070 VA: 0x1806CBC70
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CB6C0 Offset: 0x6CAAC0 VA: 0x1806CB6C0
	public static void mutelist(ConsoleSystem.Arg arg) { }

	// RVA: 0x6CA8D0 Offset: 0x6C9CD0 VA: 0x1806CA8D0
	public static void MuteSteamID(ulong id) { }

	// RVA: 0x6CACF0 Offset: 0x6CA0F0 VA: 0x1806CACF0
	public static void UnmuteSteamID(ulong id) { }

	// RVA: 0x6CABD0 Offset: 0x6C9FD0 VA: 0x1806CABD0
	public static void UnMuteAll() { }

	// RVA: 0x6CA6F0 Offset: 0x6C9AF0 VA: 0x1806CA6F0
	public static bool IsSteamIDMuted(ulong id) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CBDF0 Offset: 0x6CB1F0 VA: 0x1806CBDF0
	public static void unmuteall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CBB10 Offset: 0x6CAF10 VA: 0x1806CBB10
	public static void open() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CB3E0 Offset: 0x6CA7E0 VA: 0x1806CB3E0
	public static void clear() { }

	// RVA: 0x6CAED0 Offset: 0x6CA2D0 VA: 0x1806CAED0
	public void .ctor() { }

	// RVA: 0x6CAE10 Offset: 0x6CA210 VA: 0x1806CAE10
	private static void .cctor() { }

}

public enum Chat.ChatChannel // TypeDefIndex: 11883
{	// Fields
	public int value__; // 0x0
	public const Chat.ChatChannel Global = 0;
	public const Chat.ChatChannel Team = 1;
	public const Chat.ChatChannel Server = 2;
	public const Chat.ChatChannel Cards = 3;

}

public struct Chat.ChatEntry // TypeDefIndex: 11884
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Chat.ChatChannel <Channel>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Message>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <UserId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Username>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Color>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Time>k__BackingField; // 0x28

	// Properties
	public Chat.ChatChannel Channel { get; set; }
	public string Message { get; set; }
	public string UserId { get; set; }
	public string Username { get; set; }
	public string Color { get; set; }
	public int Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public Chat.ChatChannel get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_Channel(Chat.ChatChannel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
	public string get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1360 Offset: 0xF0760 VA: 0x1800F1360
	public void set_UserId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1370 Offset: 0xF0770 VA: 0x1800F1370
	public void set_Username(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3860 Offset: 0xF2C60 VA: 0x1800F3860
	public string get_Color() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF13D0 Offset: 0xF07D0 VA: 0x1800F13D0
	public void set_Color(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DC0 Offset: 0xF31C0 VA: 0x1800F3DC0
	public int get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DF0 Offset: 0xF31F0 VA: 0x1800F3DF0
	public void set_Time(int value) { }

}

public struct Chat.MuteEntry // TypeDefIndex: 11885
{	// Fields
	public ulong UserID; // 0x0
	public string UserName; // 0x8
	public string DateTime; // 0x10

	// Methods

	// RVA: 0xF4000 Offset: 0xF3400 VA: 0x1800F4000
	public void .ctor(ulong id, string name) { }

}

public class Chat.MuteList // TypeDefIndex: 11886
{	// Fields
	private Dictionary<ulong, Chat.MuteEntry> entries; // 0x10

	// Properties
	public List<Chat.MuteEntry> All { get; }
	public bool IsGlobalMuted { get; }

	// Methods

	// RVA: 0x6E4CC0 Offset: 0x6E40C0 VA: 0x1806E4CC0
	public List<Chat.MuteEntry> get_All() { }

	// RVA: 0x6E4B90 Offset: 0x6E3F90 VA: 0x1806E4B90
	public void SetGlobalMuted(bool flag) { }

	// RVA: 0x6E4D20 Offset: 0x6E4120 VA: 0x1806E4D20
	public bool get_IsGlobalMuted() { }

	// RVA: 0x6E48A0 Offset: 0x6E3CA0 VA: 0x1806E48A0
	public bool IsMuted(ulong steamId) { }

	// RVA: 0x6E49D0 Offset: 0x6E3DD0 VA: 0x1806E49D0
	public void Mute(ulong steamID, string steamName) { }

	// RVA: 0x6E4BD0 Offset: 0x6E3FD0 VA: 0x1806E4BD0
	public void UnMute(ulong steamID) { }

	// RVA: 0x6E47E0 Offset: 0x6E3BE0 VA: 0x1806E47E0
	public void Clear() { }

	// RVA: 0x6E4900 Offset: 0x6E3D00 VA: 0x1806E4900
	public void Load() { }

	// RVA: 0x6E4B20 Offset: 0x6E3F20 VA: 0x1806E4B20
	private void Save() { }

	// RVA: 0x6E4C50 Offset: 0x6E4050 VA: 0x1806E4C50
	public void .ctor() { }

}

private sealed class Chat.<>c // TypeDefIndex: 11887
{	// Fields
	public static readonly Chat.<>c <>9; // 0x0
	public static Action<UIChat> <>9__23_0; // 0x8

	// Methods

	// RVA: 0x6E6010 Offset: 0x6E5410 VA: 0x1806E6010
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6E5B00 Offset: 0x6E4F00 VA: 0x1806E5B00
	internal void <clear>b__23_0(UIChat chat) { }

}

