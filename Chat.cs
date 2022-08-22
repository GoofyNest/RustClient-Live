internal enum ChatEntryType // TypeDefIndex: 5139
{	public int value__; // 0x0
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
{	public TextMeshProUGUI text; // 0x18
	public RawImage avatar; // 0x20
	public CanvasGroup canvasGroup; // 0x28
	public float lifeStarted; // 0x30
	public ulong steamid; // 0x38
	private Texture defaultTexture; // 0x40
	private Action<ChatEntry> clickedAction; // 0x48

	public float age { get; }


	public float get_age() { }

	public void Setup(Chat.ChatChannel channel, ulong steamid, string message, float volume, Action<ChatEntry> clickedAction) { }

	private void SetMessageText(Chat.ChatChannel channel, string message) { }

	protected void Update() { }

	public void OnClicked() { }

	public void .ctor() { }

}

public class Chat : ConsoleSystem // TypeDefIndex: 11882
{	private const float textRange = 50;
	private const float textVolumeBoost = 0,2;
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool enabled; // 0x0
	public static Chat.MuteList muted; // 0x8

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool muteglobal { get; set; }


	public static bool get_muteglobal() { }

	public static void set_muteglobal(bool value) { }

	public static void LoadMuteList() { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static void add(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static void add2(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void mute(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void unmute(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void mutelist(ConsoleSystem.Arg arg) { }

	public static void MuteSteamID(ulong id) { }

	public static void UnmuteSteamID(ulong id) { }

	public static void UnMuteAll() { }

	public static bool IsSteamIDMuted(ulong id) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void unmuteall(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void open() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void clear() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Chat.ChatChannel // TypeDefIndex: 11883
{	public int value__; // 0x0
	public const Chat.ChatChannel Global = 0;
	public const Chat.ChatChannel Team = 1;
	public const Chat.ChatChannel Server = 2;
	public const Chat.ChatChannel Cards = 3;

}

public struct Chat.ChatEntry // TypeDefIndex: 11884
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public Chat.ChatChannel Channel { get; set; }
	public string Message { get; set; }
	public string UserId { get; set; }
	public string Username { get; set; }
	public string Color { get; set; }
	public int Time { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Chat.ChatChannel get_Channel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Channel(Chat.ChatChannel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_UserId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Username(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Color() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Color(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Time(int value) { }

}

public struct Chat.MuteEntry // TypeDefIndex: 11885
{	public ulong UserID; // 0x0
	public string UserName; // 0x8
	public string DateTime; // 0x10


	public void .ctor(ulong id, string name) { }

}

public class Chat.MuteList // TypeDefIndex: 11886
{	private Dictionary<ulong, Chat.MuteEntry> entries; // 0x10

	public List<Chat.MuteEntry> All { get; }
	public bool IsGlobalMuted { get; }


	public List<Chat.MuteEntry> get_All() { }

	public void SetGlobalMuted(bool flag) { }

	public bool get_IsGlobalMuted() { }

	public bool IsMuted(ulong steamId) { }

	public void Mute(ulong steamID, string steamName) { }

	public void UnMute(ulong steamID) { }

	public void Clear() { }

	public void Load() { }

	private void Save() { }

	public void .ctor() { }

}

private sealed class Chat.<>c // TypeDefIndex: 11887
{	public static readonly Chat.<>c <>9; // 0x0
	public static Action<UIChat> <>9__23_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <clear>b__23_0(UIChat chat) { }

}

