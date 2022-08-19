public class Listener // TypeDefIndex: 7338
{
// Namespace: Facepunch.Rcon
public class Listener // TypeDefIndex: 7338
	// Fields
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

	// Methods

	// RVA: 0x230CED0 Offset: 0x230C2D0 VA: 0x18230CED0
	public void Start() { }

	// RVA: 0x230CE90 Offset: 0x230C290 VA: 0x18230CE90
	public void Shutdown() { }

	// RVA: 0x230C8D0 Offset: 0x230BCD0 VA: 0x18230C8D0
	public void BroadcastMessage(string str) { }

	// RVA: 0x230CCE0 Offset: 0x230C0E0 VA: 0x18230CCE0
	public void SendMessage(int target, string str) { }

	// RVA: 0x230D240 Offset: 0x230C640 VA: 0x18230D240
	public void .ctor() { }

}

private sealed class Listener.<>c__DisplayClass10_0 // TypeDefIndex: 7339
{	// Fields
	public string requiredPath; // 0x10
	public Listener <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230D350 Offset: 0x230C750 VA: 0x18230D350
	internal void <Start>b__0(IWebSocketConnection socket) { }

}

private sealed class Listener.<>c__DisplayClass10_1 // TypeDefIndex: 7340
{	// Fields
	public int id; // 0x10
	public IWebSocketConnection socket; // 0x18
	public IPAddress ipAddress; // 0x20
	public Listener.<>c__DisplayClass10_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230D7F0 Offset: 0x230CBF0 VA: 0x18230D7F0
	internal void <Start>b__1() { }

	// RVA: 0x230D910 Offset: 0x230CD10 VA: 0x18230D910
	internal void <Start>b__2() { }

	// RVA: 0x230DA30 Offset: 0x230CE30 VA: 0x18230DA30
	internal void <Start>b__3(string s) { }

}

private sealed class Listener.<>c // TypeDefIndex: 7341
{	// Fields
	public static readonly Listener.<>c <>9; // 0x0
	public static Action<Exception> <>9__10_4; // 0x8

	// Methods

	// RVA: 0x230DAB0 Offset: 0x230CEB0 VA: 0x18230DAB0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x230D2E0 Offset: 0x230C6E0 VA: 0x18230D2E0
	internal void <Start>b__10_4(Exception e) { }

}

