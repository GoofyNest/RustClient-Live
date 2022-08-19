public class RCon // TypeDefIndex: 11986
{	// Fields
	public static string Password; // 0x0
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

	// Methods

	// RVA: 0x794E50 Offset: 0x794250 VA: 0x180794E50
	public static void Initialize() { }

	// RVA: 0x795CD0 Offset: 0x7950D0 VA: 0x180795CD0
	public static void Shutdown() { }

	// RVA: 0x794C00 Offset: 0x794000 VA: 0x180794C00
	public static void Broadcast(RCon.LogType type, object obj) { }

	// RVA: 0x795E50 Offset: 0x795250 VA: 0x180795E50
	public static void Update() { }

	// RVA: 0x794AE0 Offset: 0x793EE0 VA: 0x180794AE0
	public static void BanIP(IPAddress addr, float seconds) { }

	// RVA: 0x7954B0 Offset: 0x7948B0 VA: 0x1807954B0
	public static bool IsBanned(IPAddress addr) { }

	// RVA: 0x7955A0 Offset: 0x7949A0 VA: 0x1807955A0
	private static void OnCommand(RCon.Command cmd) { }

	// RVA: 0x795A10 Offset: 0x794E10 VA: 0x180795A10
	private static void OnMessage(string message, string stacktrace, LogType type) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x796360 Offset: 0x795760 VA: 0x180796360
	private static void .cctor() { }

}

public struct RCon.Command // TypeDefIndex: 11987
{	// Fields
	public IPAddress Ip; // 0x0
	public int ConnectionId; // 0x8
	public string Name; // 0x10
	public string Message; // 0x18
	public int Identifier; // 0x20

}

public enum RCon.LogType // TypeDefIndex: 11988
{	// Fields
	public int value__; // 0x0
	public const RCon.LogType Generic = 0;
	public const RCon.LogType Error = 1;
	public const RCon.LogType Warning = 2;
	public const RCon.LogType Chat = 3;
	public const RCon.LogType Report = 4;

}

public struct RCon.Response // TypeDefIndex: 11989
{	// Fields
	public string Message; // 0x0
	public int Identifier; // 0x8
	[JsonConverterAttribute] // RVA: 0xCA860 Offset: 0xC9C60 VA: 0x1800CA860
	public RCon.LogType Type; // 0xC
	public string Stacktrace; // 0x10

}

internal struct RCon.BannedAddresses // TypeDefIndex: 11990
{	// Fields
	public IPAddress addr; // 0x0
	public float banTime; // 0x8

}

internal class RCon.RConClient // TypeDefIndex: 11991
{	// Fields
	private Socket socket; // 0x10
	private bool isAuthorised; // 0x18
	private string connectionName; // 0x20
	private int lastMessageID; // 0x28
	private bool runningConsoleCommand; // 0x2C
	private bool utf8Mode; // 0x2D

	// Methods

	// RVA: 0x7941B0 Offset: 0x7935B0 VA: 0x1807941B0
	internal void .ctor(Socket cl) { }

	// RVA: 0x793940 Offset: 0x792D40 VA: 0x180793940
	internal bool IsValid() { }

	// RVA: 0x793F40 Offset: 0x793340 VA: 0x180793F40
	internal void Update() { }

	// RVA: 0x793340 Offset: 0x792740 VA: 0x180793340
	internal bool HandleMessage(int type, string msg) { }

	// RVA: 0x792FA0 Offset: 0x7923A0 VA: 0x180792FA0
	internal bool HandleMessage_UnAuthed(int type, string msg) { }

	// RVA: 0x793950 Offset: 0x792D50 VA: 0x180793950
	private void Output_OnMessage(string message, string stacktrace, LogType type) { }

	// RVA: 0x793BB0 Offset: 0x792FB0 VA: 0x180793BB0
	internal void Reply(int id, int type, string msg) { }

	// RVA: 0x792DB0 Offset: 0x7921B0 VA: 0x180792DB0
	internal void Close(string strReasn) { }

	// RVA: 0x793A50 Offset: 0x792E50 VA: 0x180793A50
	internal string ReadNullTerminatedString(BinaryReader read) { }

}

internal class RCon.RConListener // TypeDefIndex: 11992
{	// Fields
	private TcpListener server; // 0x10
	private List<RCon.RConClient> clients; // 0x18

	// Methods

	// RVA: 0x7948B0 Offset: 0x793CB0 VA: 0x1807948B0
	internal void .ctor() { }

	// RVA: 0x794760 Offset: 0x793B60 VA: 0x180794760
	internal void Shutdown() { }

	// RVA: 0x794250 Offset: 0x793650 VA: 0x180794250
	internal void Cycle() { }

	// RVA: 0x794380 Offset: 0x793780 VA: 0x180794380
	private void ProcessConnections() { }

	// RVA: 0x7947A0 Offset: 0x793BA0 VA: 0x1807947A0
	private void UpdateClients() { }

	// RVA: 0x794660 Offset: 0x793A60 VA: 0x180794660
	private void RemoveDeadClients() { }

}

private sealed class RCon.RConListener.<>c // TypeDefIndex: 11993
{	// Fields
	public static readonly RCon.RConListener.<>c <>9; // 0x0
	public static Predicate<RCon.RConClient> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x7980A0 Offset: 0x7974A0 VA: 0x1807980A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x797E90 Offset: 0x797290 VA: 0x180797E90
	internal bool <RemoveDeadClients>b__7_0(RCon.RConClient x) { }

}

private sealed class RCon.<>c // TypeDefIndex: 11994
{	// Fields
	public static readonly RCon.<>c <>9; // 0x0
	public static Action<IPAddress, int, string> <>9__11_0; // 0x8
	public static Predicate<RCon.BannedAddresses> <>9__15_0; // 0x10

	// Methods

	// RVA: 0x798220 Offset: 0x797620 VA: 0x180798220
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x797C70 Offset: 0x797070 VA: 0x180797C70
	internal void <Initialize>b__11_0(IPAddress ip, int id, string msg) { }

	// RVA: 0x797EF0 Offset: 0x7972F0 VA: 0x180797EF0
	internal bool <Update>b__15_0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass18_0 // TypeDefIndex: 11995
{	// Fields
	public IPAddress addr; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x797F90 Offset: 0x797390 VA: 0x180797F90
	internal bool <BanIP>b__0(RCon.BannedAddresses x) { }

}

private sealed class RCon.<>c__DisplayClass19_0 // TypeDefIndex: 11996
{	// Fields
	public IPAddress addr; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x797FA0 Offset: 0x7973A0 VA: 0x180797FA0
	internal bool <IsBanned>b__0(RCon.BannedAddresses x) { }

}

