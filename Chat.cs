internal enum ChatEntryType // TypeDefIndex: 5139
{
	public int value__; 
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
{
	public TextMeshProUGUI text; 
	public RawImage avatar; 
	public CanvasGroup canvasGroup; 
	public float lifeStarted; 
	public ulong steamid; 
	private Texture defaultTexture; 
	private Action<ChatEntry> clickedAction; 

public float age { get; }


public float get_age() { }

public void Setup(Chat.ChatChannel channel, ulong steamid, string message, float volume, Action<ChatEntry> clickedAction) { }

private void SetMessageText(Chat.ChatChannel channel, string message) { }

protected void Update() { }

public void OnClicked() { }

public void .ctor() { }

}

public class Chat : ConsoleSystem // TypeDefIndex: 11882
{
private const float textRange = 50;
private const float textVolumeBoost = 0,2;
	[ServerVar] 
	[ClientVar] 
	public static bool enabled; 
	public static Chat.MuteList muted; 

	[ClientVar] 
public static bool muteglobal { get; set; }


public static bool get_muteglobal() { }

public static void set_muteglobal(bool value) { }

public static void LoadMuteList() { }

	[ClientVar] 
public static void add(ConsoleSystem.Arg arg) { }

	[ClientVar] 
public static void add2(ConsoleSystem.Arg arg) { }

	[ClientVar] 
public static void mute(ConsoleSystem.Arg arg) { }

	[ClientVar] 
public static void unmute(ConsoleSystem.Arg arg) { }

	[ClientVar] 
public static void mutelist(ConsoleSystem.Arg arg) { }

public static void MuteSteamID(ulong id) { }

public static void UnmuteSteamID(ulong id) { }

public static void UnMuteAll() { }

public static bool IsSteamIDMuted(ulong id) { }

	[ClientVar] 
public static void unmuteall(ConsoleSystem.Arg arg) { }

	[ClientVar] 
public static void open() { }

	[ClientVar] 
public static void clear() { }

public void .ctor() { }

private static void .cctor() { }

}

public enum Chat.ChatChannel // TypeDefIndex: 11883
{
	public int value__; 
public const Chat.ChatChannel Global = 0;
public const Chat.ChatChannel Team = 1;
public const Chat.ChatChannel Server = 2;
public const Chat.ChatChannel Cards = 3;

}

public struct Chat.ChatEntry // TypeDefIndex: 11884
{
	[CompilerGeneratedAttribute] 
	private Chat.ChatChannel <Channel>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Message>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <UserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Username>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Color>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Time>k__BackingField; 

public Chat.ChatChannel Channel { get; set; }
public string Message { get; set; }
public string UserId { get; set; }
public string Username { get; set; }
public string Color { get; set; }
public int Time { get; set; }


	[CompilerGeneratedAttribute] 
public Chat.ChatChannel get_Channel() { }

	[CompilerGeneratedAttribute] 
public void set_Channel(Chat.ChatChannel value) { }

	[CompilerGeneratedAttribute] 
public string get_Message() { }

	[CompilerGeneratedAttribute] 
public void set_Message(string value) { }

	[CompilerGeneratedAttribute] 
public string get_UserId() { }

	[CompilerGeneratedAttribute] 
public void set_UserId(string value) { }

	[CompilerGeneratedAttribute] 
public string get_Username() { }

	[CompilerGeneratedAttribute] 
public void set_Username(string value) { }

	[CompilerGeneratedAttribute] 
public string get_Color() { }

	[CompilerGeneratedAttribute] 
public void set_Color(string value) { }

	[CompilerGeneratedAttribute] 
public int get_Time() { }

	[CompilerGeneratedAttribute] 
public void set_Time(int value) { }

}

public struct Chat.MuteEntry // TypeDefIndex: 11885
{
	public ulong UserID; 
	public string UserName; 
	public string DateTime; 


public void .ctor(ulong id, string name) { }

}

public class Chat.MuteList // TypeDefIndex: 11886
{
	private Dictionary<ulong, Chat.MuteEntry> entries; 

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
{
	public static readonly Chat.<>c <>9; 
	public static Action<UIChat> <>9__23_0; 


private static void .cctor() { }

public void .ctor() { }

internal void <clear>b__23_0(UIChat chat) { }

}

