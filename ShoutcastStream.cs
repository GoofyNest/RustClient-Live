public class ShoutcastStream : IDisposable // TypeDefIndex: 13674
{
	private static HttpClient client; 
	[CompilerGeneratedAttribute] 
	private bool <SocketConnected>k__BackingField; 
	private MP3Stream MP3Stream; 
	private CancellationTokenSource cancelSource; 
	private CancellationToken cancelToken; 
	private bool disconnected; 
	private bool connecting; 
	private static TimeSince lastStreamInit; 
	private static int sessionCount; 
	private int sessionId; 
	private bool reading; 
	private string url; 
	private static List<float[]> pooledBuffers; 
	public const uint MaxSampleBuffer = 163840;
	[CompilerGeneratedAttribute] 
	private uint <currentWriteIndex>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float[] <floatSamples>k__BackingField; 
	private byte[] buffer; 
	public float[] floatBuffer; 
	public const uint bufferSize = 32768;
	private const float const_1_div_32768_ = 3,051758E-05;
	private List<ShoutcastStreamer> connectedStreamers; 
	private static List<ShoutcastStream> connections; 
	private static List<ShoutcastStream> active; 
	private static int lastFrameUpdate; 
	private float[] intToFloatBuffer; 
	private short[] zeroResult; 
	private short[] byteResult; 

	public bool SocketConnected { get; set; }
	public int Frequency { get; }
	public uint currentWriteIndex { get; set; }
	public float[] floatSamples { get; set; }


	[CompilerGeneratedAttribute] 
	public bool get_SocketConnected() { }

	[CompilerGeneratedAttribute] 
	private void set_SocketConnected(bool value) { }

	public int get_Frequency() { }

	[CompilerGeneratedAttribute] 
	public uint get_currentWriteIndex() { }

	[CompilerGeneratedAttribute] 
	private void set_currentWriteIndex(uint value) { }

	[CompilerGeneratedAttribute] 
	public float[] get_floatSamples() { }

	[CompilerGeneratedAttribute] 
	private void set_floatSamples(float[] value) { }

	public static void RunConnections() { }

	public static ShoutcastStream GetExistingStream(string host) { }

	public uint GetLeadStreamerReadIndex() { }

	public bool IsLeadStream(ShoutcastStreamer stream) { }

	public void ResetSamples(uint read) { }

	public void InitialiseConnection(string host, ShoutcastStreamer forStreamer) { }

	public void RegisterNewStreamer(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] 
	private Task ConnectAsync() { }

	[AsyncStateMachineAttribute] 
	public Task<bool> ReadDataAsync(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] 
	private Task<bool> ReadDataAsync(byte[] byteBuffer) { }

	private float[] IntToFloat(short[] from) { }

	private short[] ByteToInt16(byte[] buffer) { }

	private float[] ByteToFloat(byte[] bArray) { }

	private void Disconnect() { }

	private void ClearFloatSamples() { }

	public void Dispose() { }

	[AsyncStateMachineAttribute] 
	private Task ShutdownSafely() { }

	public void AttemptDisconnect(ShoutcastStreamer streamer) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class ShoutcastStream.<>c__DisplayClass42_0 // TypeDefIndex: 13675
{
	public Stream stream; 


	public void .ctor() { }

	internal MP3Stream <ConnectAsync>b__0() { }

}

private struct ShoutcastStream.<ConnectAsync>d__42 : IAsyncStateMachine // TypeDefIndex: 13676
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public ShoutcastStream <>4__this; 
	private ShoutcastStream.<>c__DisplayClass42_0 <>8__1; 
	private TaskAwaiter<HttpResponseMessage> <>u__1; 
	private TaskAwaiter<Stream> <>u__2; 
	private TaskAwaiter<MP3Stream> <>u__3; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ReadDataAsync>d__43 : IAsyncStateMachine // TypeDefIndex: 13677
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<bool> <>t__builder; 
	public ShoutcastStreamer forStreamer; 
	public ShoutcastStream <>4__this; 
	private TaskAwaiter<bool> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ReadDataAsync>d__44 : IAsyncStateMachine // TypeDefIndex: 13678
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<bool> <>t__builder; 
	public ShoutcastStream <>4__this; 
	public byte[] byteBuffer; 
	private TaskAwaiter<int> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ShutdownSafely>d__54 : IAsyncStateMachine // TypeDefIndex: 13679
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public ShoutcastStream <>4__this; 
	private Stopwatch <stopwatch>5__2; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

