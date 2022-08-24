public class WebSocketServer : IDisposable // TypeDefIndex: 6931
{
	private readonly string _scheme; 
	private readonly IPAddress _locationIP; 
	private Action<IWebSocketConnection> _config; 
	[CompilerGeneratedAttribute] 
	private ISocket <ListenerSocket>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly string <Location>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly bool <SupportDualStack>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Port>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private X509Certificate2 <Certificate>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private SslProtocols <EnabledSslProtocols>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <RestartAfterListenError>k__BackingField; 

public ISocket ListenerSocket { get; set; }
public bool SupportDualStack { get; }
public int Port { get; set; }
public X509Certificate2 Certificate { get; set; }
public SslProtocols EnabledSslProtocols { get; }
public bool RestartAfterListenError { get; set; }
public bool IsSecure { get; }


public void .ctor(string location, bool supportDualStack = True) { }

	[CompilerGeneratedAttribute] 
public ISocket get_ListenerSocket() { }

	[CompilerGeneratedAttribute] 
public void set_ListenerSocket(ISocket value) { }

	[CompilerGeneratedAttribute] 
public bool get_SupportDualStack() { }

	[CompilerGeneratedAttribute] 
public int get_Port() { }

	[CompilerGeneratedAttribute] 
private void set_Port(int value) { }

	[CompilerGeneratedAttribute] 
public X509Certificate2 get_Certificate() { }

	[CompilerGeneratedAttribute] 
public void set_Certificate(X509Certificate2 value) { }

	[CompilerGeneratedAttribute] 
public SslProtocols get_EnabledSslProtocols() { }

	[CompilerGeneratedAttribute] 
public bool get_RestartAfterListenError() { }

	[CompilerGeneratedAttribute] 
public void set_RestartAfterListenError(bool value) { }

public bool get_IsSecure() { }

public void Dispose() { }

private IPAddress ParseIPAddress(Uri uri) { }

public void Start(Action<IWebSocketConnection> config) { }

private void ListenForClients() { }

private void OnClientConnect(ISocket clientSocket) { }

	[CompilerGeneratedAttribute] 
private void <ListenForClients>b__35_0(Exception e) { }

	[CompilerGeneratedAttribute] 
private WebSocketHttpRequest <OnClientConnect>b__36_0(ArraySegment<byte> bytes) { }

}

private sealed class WebSocketServer.<>c // TypeDefIndex: 6932
{
	public static readonly WebSocketServer.<>c <>9; 
	public static Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> <>9__36_1; 
	public static Action<Exception> <>9__36_2; 


private static void .cctor() { }

public void .ctor() { }

internal IHandler <OnClientConnect>b__36_1(IWebSocketConnection c, WebSocketHttpRequest r) { }

internal void <OnClientConnect>b__36_2(Exception e) { }

}

