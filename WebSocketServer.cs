public class WebSocketServer : IDisposable // TypeDefIndex: 6931
{	// Fields
	private readonly string _scheme; // 0x10
	private readonly IPAddress _locationIP; // 0x18
	private Action<IWebSocketConnection> _config; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ISocket <ListenerSocket>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <Location>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <SupportDualStack>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Port>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private X509Certificate2 <Certificate>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SslProtocols <EnabledSslProtocols>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <RestartAfterListenError>k__BackingField; // 0x4C

	// Properties
	public ISocket ListenerSocket { get; set; }
	public bool SupportDualStack { get; }
	public int Port { get; set; }
	public X509Certificate2 Certificate { get; set; }
	public SslProtocols EnabledSslProtocols { get; }
	public bool RestartAfterListenError { get; set; }
	public bool IsSecure { get; }

	// Methods

	// RVA: 0x2206F60 Offset: 0x2206360 VA: 0x182206F60
	public void .ctor(string location, bool supportDualStack = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public ISocket get_ListenerSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_ListenerSocket(ISocket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_SupportDualStack() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	public int get_Port() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1150 Offset: 0x8B0550 VA: 0x1808B1150
	private void set_Port(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public X509Certificate2 get_Certificate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_Certificate(X509Certificate2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public SslProtocols get_EnabledSslProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC1C200 Offset: 0xC1B600 VA: 0x180C1C200
	public bool get_RestartAfterListenError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC1C210 Offset: 0xC1B610 VA: 0x180C1C210
	public void set_RestartAfterListenError(bool value) { }

	// RVA: 0x2207160 Offset: 0x2206560 VA: 0x182207160
	public bool get_IsSecure() { }

	// RVA: 0x22063B0 Offset: 0x22057B0 VA: 0x1822063B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2206900 Offset: 0x2205D00 VA: 0x182206900
	private IPAddress ParseIPAddress(Uri uri) { }

	// RVA: 0x2206A70 Offset: 0x2205E70 VA: 0x182206A70 Slot: 5
	public void Start(Action<IWebSocketConnection> config) { }

	// RVA: 0x2206400 Offset: 0x2205800 VA: 0x182206400
	private void ListenForClients() { }

	// RVA: 0x2206520 Offset: 0x2205920 VA: 0x182206520
	private void OnClientConnect(ISocket clientSocket) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2206D90 Offset: 0x2206190 VA: 0x182206D90
	private void <ListenForClients>b__35_0(Exception e) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2206EF0 Offset: 0x22062F0 VA: 0x182206EF0
	private WebSocketHttpRequest <OnClientConnect>b__36_0(ArraySegment<byte> bytes) { }

}

private sealed class WebSocketServer.<>c // TypeDefIndex: 6932
{	// Fields
	public static readonly WebSocketServer.<>c <>9; // 0x0
	public static Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> <>9__36_1; // 0x8
	public static Action<Exception> <>9__36_2; // 0x10

	// Methods

	// RVA: 0x2204580 Offset: 0x2203980 VA: 0x182204580
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2203970 Offset: 0x2202D70 VA: 0x182203970
	internal IHandler <OnClientConnect>b__36_1(IWebSocketConnection c, WebSocketHttpRequest r) { }

	// RVA: 0x2203980 Offset: 0x2202D80 VA: 0x182203980
	internal void <OnClientConnect>b__36_2(Exception e) { }

}

