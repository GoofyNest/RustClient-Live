public class WebSocketConnection : IWebSocketConnection // TypeDefIndex: 6925
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ISocket <Socket>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IHandler <Handler>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action <OnOpen>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action <OnClose>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<string> <OnMessage>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BinaryDataHandler <OnBinary>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BinaryDataHandler <OnPing>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BinaryDataHandler <OnPong>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<Exception> <OnError>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IWebSocketConnectionInfo <ConnectionInfo>k__BackingField; // 0x58
	private readonly Action<IWebSocketConnection> _initialize; // 0x60
	private readonly Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> _handlerFactory; // 0x68
	private readonly Func<ArraySegment<byte>, WebSocketHttpRequest> _parseRequest; // 0x70
	private byte[] _receiveBuffer; // 0x78
	private int _receiveOffset; // 0x80
	private bool _closing; // 0x84
	private bool _closed; // 0x85

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public ISocket get_Socket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Socket(ISocket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public IHandler get_Handler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Handler(IHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 17
	public Action get_OnOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30 Slot: 4
	public void set_OnOpen(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 5
	public Action get_OnClose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240 Slot: 6
	public void set_OnClose(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 7
	public Action<string> get_OnMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10 Slot: 8
	public void set_OnMessage(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 9
	public BinaryDataHandler get_OnBinary() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0 Slot: 18
	public void set_OnBinary(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 10
	public BinaryDataHandler get_OnPing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0 Slot: 19
	public void set_OnPing(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 11
	public BinaryDataHandler get_OnPong() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 20
	public void set_OnPong(BinaryDataHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 21
	public Action<Exception> get_OnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 12
	public void set_OnError(Action<Exception> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 15
	public IWebSocketConnectionInfo get_ConnectionInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	private void set_ConnectionInfo(IWebSocketConnectionInfo value) { }

	// RVA: 0x22060E0 Offset: 0x22054E0 VA: 0x1822060E0 Slot: 16
	public bool get_IsAvailable() { }

	// RVA: 0x2205B50 Offset: 0x2204F50 VA: 0x182205B50
	public void .ctor(ISocket socket, Action<IWebSocketConnection> initialize, Func<ArraySegment<byte>, WebSocketHttpRequest> parseRequest, Func<IWebSocketConnection, WebSocketHttpRequest, IHandler> handlerFactory) { }

	// RVA: 0x22058A0 Offset: 0x2204CA0 VA: 0x1822058A0 Slot: 13
	public void Send(string message) { }

	// RVA: 0x2205780 Offset: 0x2204B80 VA: 0x182205780
	private void SendImpl(MemoryBuffer buffer) { }

	// RVA: 0x2204960 Offset: 0x2203D60 VA: 0x182204960 Slot: 14
	public void Close() { }

	// RVA: 0x2204970 Offset: 0x2203D70 VA: 0x182204970
	public void Close(ushort code) { }

	// RVA: 0x2204B90 Offset: 0x2203F90 VA: 0x182204B90
	public bool CreateHandler(ArraySegment<byte> data) { }

	// RVA: 0x2205A70 Offset: 0x2204E70 VA: 0x182205A70
	public void StartReceiving() { }

	// RVA: 0x22052D0 Offset: 0x22046D0 VA: 0x1822052D0
	private void HandleReadSuccess(int bytesRead) { }

	// RVA: 0x2205010 Offset: 0x2204410 VA: 0x182205010
	private void HandleReadError(Exception e) { }

	// RVA: 0x22054A0 Offset: 0x22048A0 VA: 0x1822054A0
	private void Receive(byte[] buffer, int offset) { }

	// RVA: 0x2205440 Offset: 0x2204840 VA: 0x182205440
	private void HandleWriteError(Exception e) { }

	// RVA: 0x2205630 Offset: 0x2204A30 VA: 0x182205630
	private void SendBytes(MemoryBuffer bytes, Action<WebSocketConnection, bool> callback) { }

	// RVA: 0x2204880 Offset: 0x2203C80 VA: 0x182204880
	private void CloseSocket() { }

}

private sealed class WebSocketConnection.<>c // TypeDefIndex: 6926
{	// Fields
	public static readonly WebSocketConnection.<>c <>9; // 0x0
	public static Action <>9__50_0; // 0x8
	public static Action <>9__50_1; // 0x10
	public static Action<string> <>9__50_2; // 0x18
	public static BinaryDataHandler <>9__50_3; // 0x20
	public static BinaryDataHandler <>9__50_4; // 0x28
	public static BinaryDataHandler <>9__50_5; // 0x30
	public static Action<Exception> <>9__50_6; // 0x38
	public static Action<WebSocketConnection, bool> <>9__58_0; // 0x40
	public static Action<WebSocketConnection, bool> <>9__59_0; // 0x48
	public static AsyncCallback <>9__63_0; // 0x50

	// Methods

	// RVA: 0x2204640 Offset: 0x2203A40 VA: 0x182204640
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <.ctor>b__50_0() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <.ctor>b__50_1() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <.ctor>b__50_2(string x) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <.ctor>b__50_3(Span<byte> x) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <.ctor>b__50_4(Span<byte> x) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <.ctor>b__50_5(Span<byte> x) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <.ctor>b__50_6(Exception x) { }

	// RVA: 0x2203920 Offset: 0x2202D20 VA: 0x182203920
	internal void <Close>b__58_0(WebSocketConnection i, bool s) { }

	// RVA: 0x2203940 Offset: 0x2202D40 VA: 0x182203940
	internal void <CreateHandler>b__59_0(WebSocketConnection instance, bool success) { }

	// RVA: 0x22039E0 Offset: 0x2202DE0 VA: 0x1822039E0
	internal void <Receive>b__63_0(IAsyncResult result) { }

}

private sealed class WebSocketConnection.<>c__DisplayClass65_0 // TypeDefIndex: 6927
{	// Fields
	public MemoryBuffer bytes; // 0x10
	public Action<WebSocketConnection, bool> callback; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22042E0 Offset: 0x22036E0 VA: 0x1822042E0
	internal void <SendBytes>b__0(IAsyncResult result) { }

}

