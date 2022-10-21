public class Listener // TypeDefIndex: 7346
{

public class Listener
	public string Password; 
	public int Port; 
	public string Address; 
	public string SslCertificate; 
	public string SslCertificatePassword; 
	public Action<IPAddress, int, string> OnMessage; 
	private int nextClientId; 
	private readonly Dictionary<int, IWebSocketConnection> clients; 
	private readonly List<int> deadClients; 
	private WebSocketServer server; 


	public void Start() { }

	public void Shutdown() { }

	public void BroadcastMessage(string str) { }

	public void SendMessage(int target, string str) { }

	public void .ctor() { }

}

private sealed class Listener.<>c__DisplayClass10_0 // TypeDefIndex: 7347
{
	public string requiredPath; 
	public Listener <>4__this; 


	public void .ctor() { }

	internal void <Start>b__0(IWebSocketConnection socket) { }

}

private sealed class Listener.<>c__DisplayClass10_1 // TypeDefIndex: 7348
{
	public int id; 
	public IWebSocketConnection socket; 
	public IPAddress ipAddress; 
	public Listener.<>c__DisplayClass10_0 CS$<>8__locals1; 


	public void .ctor() { }

	internal void <Start>b__1() { }

	internal void <Start>b__2() { }

	internal void <Start>b__3(string s) { }

}

private sealed class Listener.<>c // TypeDefIndex: 7349
{
	public static readonly Listener.<>c <>9; 
	public static Action<Exception> <>9__10_4; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Start>b__10_4(Exception e) { }

}

