public class RCon // TypeDefIndex: 11986
{	public static string Password; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int Port; // 0x8
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string Ip; // 0x10
	[ServerVar] // RVA: 0xCA580 Offset: 0xC9980 VA: 0x1800CA580
	public static bool Web; // 0x18
	[ServerVar] // RVA: 0xCA7C0 Offset: 0xC9BC0 VA: 0x1800CA7C0
	public static bool Print; // 0x19
	internal static RCon.RConListener listener; // 0x20
	internal static Listener listenerNew; // 0x28
	private static Queue<RCon.Command> Commands; // 0x30
	private static float lastRunTime; // 0x38
	internal static List<RCon.BannedAddresses> bannedAddresses; // 0x40
	private static int responseIdentifier; // 0x48
	private static int responseConnection; // 0x4C
	private static bool isInput; // 0x50
	internal static int SERVERDATA_AUTH; // 0x54
	internal static int SERVERDATA_EXECCOMMAND; // 0x58
	internal static int SERVERDATA_AUTH_RESPONSE; // 0x5C
	internal static int SERVERDATA_RESPONSE_VALUE; // 0x60
	internal static int SERVERDATA_CONSOLE_LOG; // 0x64
	internal static int SERVERDATA_SWITCH_UTF8; // 0x68


	public static void Initialize() { }

	public static void Shutdown() { }

	public static void Broadcast(RCon.LogType type, object obj) { }

	public static void Update() { }

	public static void BanIP(IPAddress addr, float seconds) { }

	public static bool IsBanned(IPAddress addr) { }

	private static void OnCommand(RCon.Command cmd) { }

	private static void OnMessage(string message, string stacktrace, LogType type) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct RCon.Command // TypeDefIndex: 11987
{	public IPAddress Ip; // 0x0
	public int ConnectionId; // 0x8
	public string Name; // 0x10
	public string Message; // 0x18
	public int Identifier; // 0x20

}

public enum RCon.LogType // TypeDefIndex: 11988
{	public int value__; // 0x0
	public const RCon.LogType Generic = 0;
	public const RCon.LogType Error = 1;
	public const RCon.LogType Warning = 2;
	public const RCon.LogType Chat = 3;
	public const RCon.LogType Report = 4;

}

public struct RCon.Response // TypeDefIndex: 11989
{	public string Message; // 0x0
	public int Identifier; // 0x8
	[JsonConverterAttribute] // RVA: 0xCA860 Offset: 0xC9C60 VA: 0x1800CA860
	public RCon.LogType Type; // 0xC
	public string Stacktrace; // 0x10

}

internal struct RCon.BannedAddresses // TypeDefIndex: 11990
{	public IPAddress addr; // 0x0
	public float banTime; // 0x8

}

internal class RCon.RConClient // TypeDefIndex: 11991
{	private Socket socket; // 0x10
	private bool isAuthorised; // 0x18
	private string connectionName; // 0x20
	private int lastMessageID; // 0x28
	private bool runningConsoleCommand; // 0x2C
	private bool utf8Mode; // 0x2D


	internal void .ctor(Socket cl) { }

	internal bool IsValid() { }

	internal void Update() { }

	internal bool HandleMessage(int type, string msg) { }

	internal bool HandleMessage_UnAuthed(int type, string msg) { }

	private void Output_OnMessage(string message, string stacktrace, LogType type) { }

	internal void Reply(int id, int type, string msg) { }

	internal void Close(string strReasn) { }

	internal string ReadNullTerminatedString(BinaryReader read) { }

}

internal class RCon.RConListener // TypeDefIndex: 11992
{	private TcpListener server; // 0x10
	private List<RCon.RConClient> clients; // 0x18


	internal void .ctor() { }

	internal void Shutdown() { }

	internal void Cycle() { }

	private void ProcessConnections() { }

	private void UpdateClients() { }

	private void RemoveDeadClients() { }

}

private sealed class RCon.RConListener.<>c // TypeDefIndex: 11993
{	public static readonly RCon.RConListener.<>c <>9; // 0x0
	public static Predicate<RCon.RConClient> <>9__7_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <RemoveDeadClients>b__7_0(RCon.RConClient x) { }

}

private sealed class RCon.<>c // TypeDefIndex: 11994
{	public static readonly RCon.<>c <>9; // 0x0
	public static Action<IPAddress, int, string> <>9__11_0; // 0x8
	public static Predicate<RCon.BannedAddresses> <>9__15_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Initialize>b__11_0(IPAddress ip, int id, string msg) { }

	internal bool <Update>b__15_0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass18_0 // TypeDefIndex: 11995
{	public IPAddress addr; // 0x10


	public void .ctor() { }

	internal bool <BanIP>b__0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass19_0 // TypeDefIndex: 11996
{	public IPAddress addr; // 0x10


	public void .ctor() { }

	internal bool <IsBanned>b__0(RCon.BannedAddresses x) { }

}

