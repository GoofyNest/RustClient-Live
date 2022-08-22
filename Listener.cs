public class Listener // TypeDefIndex: 7338
{
public class Listener // TypeDefIndex: 7338
	public string Password; // 0x10
	public int Port; // 0x18
	public string Address; // 0x20
	public string SslCertificate; // 0x28
	public string SslCertificatePassword; // 0x30
	public Action<IPAddress, int, string> OnMessage; // 0x38
	private int nextClientId; // 0x40
	private readonly Dictionary<int, IWebSocketConnection> clients; // 0x48
	private readonly List<int> deadClients; // 0x50
	private WebSocketServer server; // 0x58


	public void Start() { }

	public void Shutdown() { }

	public void BroadcastMessage(string str) { }

	public void SendMessage(int target, string str) { }

	public void .ctor() { }

}

private sealed class Listener.<>c__DisplayClass10_0 // TypeDefIndex: 7339
{	public string requiredPath; // 0x10
	public Listener <>4__this; // 0x18


	public void .ctor() { }

	internal void <Start>b__0(IWebSocketConnection socket) { }

}

private sealed class Listener.<>c__DisplayClass10_1 // TypeDefIndex: 7340
{	public int id; // 0x10
	public IWebSocketConnection socket; // 0x18
	public IPAddress ipAddress; // 0x20
	public Listener.<>c__DisplayClass10_0 CS$<>8__locals1; // 0x28


	public void .ctor() { }

	internal void <Start>b__1() { }

	internal void <Start>b__2() { }

	internal void <Start>b__3(string s) { }

}

private sealed class Listener.<>c // TypeDefIndex: 7341
{	public static readonly Listener.<>c <>9; // 0x0
	public static Action<Exception> <>9__10_4; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Start>b__10_4(Exception e) { }

}

