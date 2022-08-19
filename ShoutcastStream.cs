public class ShoutcastStream : IDisposable // TypeDefIndex: 11978
{	// Fields
	private static HttpClient client; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <SocketConnected>k__BackingField; // 0x10
	private MP3Stream MP3Stream; // 0x18
	private CancellationTokenSource cancelSource; // 0x20
	private CancellationToken cancelToken; // 0x28
	private bool disconnected; // 0x30
	private bool connecting; // 0x31
	private static TimeSince lastStreamInit; // 0x8
	private static int sessionCount; // 0xC
	private int sessionId; // 0x34
	private bool reading; // 0x38
	private string url; // 0x40
	private static List<float[]> pooledBuffers; // 0x10
	public const uint MaxSampleBuffer = 163840;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <currentWriteIndex>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float[] <floatSamples>k__BackingField; // 0x50
	private byte[] buffer; // 0x58
	public float[] floatBuffer; // 0x60
	public const uint bufferSize = 32768;
	private const float const_1_div_32768_ = 3,051758E-05;
	private List<ShoutcastStreamer> connectedStreamers; // 0x68
	private static List<ShoutcastStream> connections; // 0x18
	private static List<ShoutcastStream> active; // 0x20
	private static int lastFrameUpdate; // 0x28
	private float[] intToFloatBuffer; // 0x70
	private short[] zeroResult; // 0x78
	private short[] byteResult; // 0x80

	// Properties
	public bool SocketConnected { get; set; }
	public int Frequency { get; }
	public uint currentWriteIndex { get; set; }
	public float[] floatSamples { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_SocketConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	private void set_SocketConnected(bool value) { }

	// RVA: 0x5B1C70 Offset: 0x5B1070 VA: 0x1805B1C70
	public int get_Frequency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public uint get_currentWriteIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90
	private void set_currentWriteIndex(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public float[] get_floatSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	private void set_floatSamples(float[] value) { }

	// RVA: 0x5B1770 Offset: 0x5B0B70 VA: 0x1805B1770
	public static void RunConnections() { }

	// RVA: 0x5B0D70 Offset: 0x5B0170 VA: 0x1805B0D70
	public static ShoutcastStream GetExistingStream(string host) { }

	// RVA: 0x5B0F00 Offset: 0x5B0300 VA: 0x1805B0F00
	public uint GetLeadStreamerReadIndex() { }

	// RVA: 0x5B12D0 Offset: 0x5B06D0 VA: 0x1805B12D0
	public bool IsLeadStream(ShoutcastStreamer stream) { }

	// RVA: 0x5B1610 Offset: 0x5B0A10 VA: 0x1805B1610
	public void ResetSamples(uint read) { }

	// RVA: 0x5B0FC0 Offset: 0x5B03C0 VA: 0x1805B0FC0
	public void InitialiseConnection(string host, ShoutcastStreamer forStreamer) { }

	// RVA: 0x5B15A0 Offset: 0x5B09A0 VA: 0x1805B15A0
	public void RegisterNewStreamer(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] // RVA: 0xC9710 Offset: 0xC8B10 VA: 0x1800C9710
	// RVA: 0x5B0930 Offset: 0x5AFD30 VA: 0x1805B0930
	private Task ConnectAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xC9880 Offset: 0xC8C80 VA: 0x1800C9880
	// RVA: 0x5B1360 Offset: 0x5B0760 VA: 0x1805B1360
	public Task<bool> ReadDataAsync(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] // RVA: 0xC99E0 Offset: 0xC8DE0 VA: 0x1800C99E0
	// RVA: 0x5B1480 Offset: 0x5B0880 VA: 0x1805B1480
	private Task<bool> ReadDataAsync(byte[] byteBuffer) { }

	// RVA: 0x5B11F0 Offset: 0x5B05F0 VA: 0x1805B11F0
	private float[] IntToFloat(short[] from) { }

	// RVA: 0x5B0790 Offset: 0x5AFB90 VA: 0x1805B0790
	private short[] ByteToInt16(byte[] buffer) { }

	// RVA: 0x5B0560 Offset: 0x5AF960 VA: 0x1805B0560
	private float[] ByteToFloat(byte[] bArray) { }

	// RVA: 0x5B0A30 Offset: 0x5AFE30 VA: 0x1805B0A30
	private void Disconnect() { }

	// RVA: 0x5B08E0 Offset: 0x5AFCE0 VA: 0x1805B08E0
	private void ClearFloatSamples() { }

	// RVA: 0x5B0C80 Offset: 0x5B0080 VA: 0x1805B0C80 Slot: 4
	public void Dispose() { }

	[AsyncStateMachineAttribute] // RVA: 0xC9BB0 Offset: 0xC8FB0 VA: 0x1800C9BB0
	// RVA: 0x5B0C80 Offset: 0x5B0080 VA: 0x1805B0C80
	private Task ShutdownSafely() { }

	// RVA: 0x5B03F0 Offset: 0x5AF7F0 VA: 0x1805B03F0
	public void AttemptDisconnect(ShoutcastStreamer streamer) { }

	// RVA: 0x5B1B40 Offset: 0x5B0F40 VA: 0x1805B1B40
	public void .ctor() { }

	// RVA: 0x5B1A20 Offset: 0x5B0E20 VA: 0x1805B1A20
	private static void .cctor() { }

}

private sealed class ShoutcastStream.<>c__DisplayClass42_0 // TypeDefIndex: 11979
{	// Fields
	public Stream stream; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BE320 Offset: 0x5BD720 VA: 0x1805BE320
	internal MP3Stream <ConnectAsync>b__0() { }

}

private struct ShoutcastStream.<ConnectAsync>d__42 : IAsyncStateMachine // TypeDefIndex: 11980
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	private ShoutcastStream.<>c__DisplayClass42_0 <>8__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x30
	private TaskAwaiter<Stream> <>u__2; // 0x38
	private TaskAwaiter<MP3Stream> <>u__3; // 0x40

	// Methods

	// RVA: 0xF3390 Offset: 0xF2790 VA: 0x1800F3390 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ReadDataAsync>d__43 : IAsyncStateMachine // TypeDefIndex: 11981
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ShoutcastStreamer forStreamer; // 0x20
	public ShoutcastStream <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3470 Offset: 0xF2870 VA: 0x1800F3470 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3480 Offset: 0xF2880 VA: 0x1800F3480 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ReadDataAsync>d__44 : IAsyncStateMachine // TypeDefIndex: 11982
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	public byte[] byteBuffer; // 0x28
	private TaskAwaiter<int> <>u__1; // 0x30

	// Methods

	// RVA: 0xF34D0 Offset: 0xF28D0 VA: 0x1800F34D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF34E0 Offset: 0xF28E0 VA: 0x1800F34E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ShutdownSafely>d__54 : IAsyncStateMachine // TypeDefIndex: 11983
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	private Stopwatch <stopwatch>5__2; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF3550 Offset: 0xF2950 VA: 0x1800F3550 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

