public class WebSocketConnection : IWebSocketConnection // TypeDefIndex: 6959
{
	[CompilerGeneratedAttribute] 
	private ISocket <Socket>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IHandler <Handler>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action <OnOpen>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action <OnClose>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<string> <OnMessage>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BinaryDataHandler <OnBinary>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BinaryDataHandler <OnPing>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BinaryDataHandler <OnPong>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<Exception> <OnError>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IWebSocketConnectionInfo <ConnectionInfo>k__BackingField; 
	private readonly Action<IWebSocketConnection> _initialize; 
	private readonly Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> _handlerFactory; 
	private readonly Func<ArraySegment<byte>, WebSocketHttpRequest> _parseRequest; 
	private byte[] _receiveBuffer; 
	private int _receiveOffset; 
	private bool _closing; 
	private bool _closed; 

	public ISocket Socket { get; set; }
	public IHandler Handler { get; set; }
	public Action OnOpen { get; set; }
	public Action OnClose { get; set; }
	public Action<string> OnMessage { get; set; }
	public BinaryDataHandler OnBinary { get; set; }
	public BinaryDataHandler OnPing { get; set; }
	public BinaryDataHandler OnPong { get; set; }
	public Action<Exception> OnError { get; set; }
	public IWebSocketConnectionInfo ConnectionInfo { get; set; }
	public bool IsAvailable { get; }


	[CompilerGeneratedAttribute] 
	public ISocket get_Socket() { }

	[CompilerGeneratedAttribute] 
	public void set_Socket(ISocket value) { }

	[CompilerGeneratedAttribute] 
	public IHandler get_Handler() { }

	[CompilerGeneratedAttribute] 
	public void set_Handler(IHandler value) { }

	[CompilerGeneratedAttribute] 
	public Action get_OnOpen() { }

	[CompilerGeneratedAttribute] 
	public void set_OnOpen(Action value) { }

	[CompilerGeneratedAttribute] 
	public Action get_OnClose() { }

	[CompilerGeneratedAttribute] 
	public void set_OnClose(Action value) { }

	[CompilerGeneratedAttribute] 
	public Action<string> get_OnMessage() { }

	[CompilerGeneratedAttribute] 
	public void set_OnMessage(Action<string> value) { }

	[CompilerGeneratedAttribute] 
	public BinaryDataHandler get_OnBinary() { }

	[CompilerGeneratedAttribute] 
	public void set_OnBinary(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] 
	public BinaryDataHandler get_OnPing() { }

	[CompilerGeneratedAttribute] 
	public void set_OnPing(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] 
	public BinaryDataHandler get_OnPong() { }

	[CompilerGeneratedAttribute] 
	public void set_OnPong(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] 
	public Action<Exception> get_OnError() { }

	[CompilerGeneratedAttribute] 
	public void set_OnError(Action<Exception> value) { }

	[CompilerGeneratedAttribute] 
	public IWebSocketConnectionInfo get_ConnectionInfo() { }

	[CompilerGeneratedAttribute] 
	private void set_ConnectionInfo(IWebSocketConnectionInfo value) { }

	public bool get_IsAvailable() { }

	public void .ctor(ISocket socket, Action<IWebSocketConnection> initialize, Func<ArraySegment<byte>, WebSocketHttpRequest> parseRequest, Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> handlerFactory) { }

	public void Send(string message) { }

	private void SendImpl(MemoryBuffer buffer) { }

	public void Close() { }

	public void Close(ushort code) { }

	public bool CreateHandler(ArraySegment<byte> data) { }

	public void StartReceiving() { }

	private void HandleReadSuccess(int bytesRead) { }

	private void HandleReadError(Exception e) { }

	private void Receive(byte[] buffer, int offset) { }

	private void HandleWriteError(Exception e) { }

	private void SendBytes(MemoryBuffer bytes, Action<WebSocketConnection, bool> callback) { }

	private void CloseSocket() { }

}

private sealed class WebSocketConnection.<>c // TypeDefIndex: 6960
{
	public static readonly WebSocketConnection.<>c <>9; 
	public static Action <>9__50_0; 
	public static Action <>9__50_1; 
	public static Action<string> <>9__50_2; 
	public static BinaryDataHandler <>9__50_3; 
	public static BinaryDataHandler <>9__50_4; 
	public static BinaryDataHandler <>9__50_5; 
	public static Action<Exception> <>9__50_6; 
	public static Action<WebSocketConnection, bool> <>9__58_0; 
	public static Action<WebSocketConnection, bool> <>9__59_0; 
	public static AsyncCallback <>9__63_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.ctor>b__50_0() { }

	internal void <.ctor>b__50_1() { }

	internal void <.ctor>b__50_2(string x) { }

	internal void <.ctor>b__50_3(Span<byte> x) { }

	internal void <.ctor>b__50_4(Span<byte> x) { }

	internal void <.ctor>b__50_5(Span<byte> x) { }

	internal void <.ctor>b__50_6(Exception x) { }

	internal void <Close>b__58_0(WebSocketConnection i, bool s) { }

	internal void <CreateHandler>b__59_0(WebSocketConnection instance, bool success) { }

	internal void <Receive>b__63_0(IAsyncResult result) { }

}

private sealed class WebSocketConnection.<>c__DisplayClass65_0 // TypeDefIndex: 6961
{
	public MemoryBuffer bytes; 
	public Action<WebSocketConnection, bool> callback; 


	public void .ctor() { }

	internal void <SendBytes>b__0(IAsyncResult result) { }

}

