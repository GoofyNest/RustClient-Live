internal class Hybi13Handler : IHandler, IDisposable // TypeDefIndex: 6968
{
	private static readonly Encoding UTF8; 
	private static readonly SHA1 SHA1; 
	private static readonly ThreadLocal<StringBuilder> StringBuilder; 
	private readonly WebSocketHttpRequest _request; 
	private readonly IWebSocketConnection _connection; 
	private byte[] _data; 
	private int _dataLen; 
	private Nullable<FrameType> _frameType; 
	private byte[] _message; 
	private int _messageLen; 


	public void .ctor(WebSocketHttpRequest request, IWebSocketConnection connection) { }

	public void Dispose() { }

	public void Receive(Span<byte> newData) { }

	public MemoryBuffer CreateHandshake() { }

	public MemoryBuffer FrameText(string text) { }

	public MemoryBuffer FrameText(MemoryBuffer utf8StringBytes) { }

	public MemoryBuffer FrameClose(ushort code) { }

	private static MemoryBuffer FrameData(MemoryBuffer payload, FrameType frameType) { }

	private static MemoryBuffer FrameData(Span<byte> payload, FrameType frameType) { }

	private void ReceiveData() { }

	private void ProcessFrame(FrameType frameType, ArraySegment<byte> buffer) { }

	private void Clear() { }

	internal static string CreateResponseKey(string requestKey) { }

	internal static string ReadUTF8PayloadData(ArraySegment<byte> bytes) { }

	private static void .cctor() { }

}

private sealed class Hybi13Handler.<>c // TypeDefIndex: 6969
{
	public static readonly Hybi13Handler.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

	internal StringBuilder <.cctor>b__28_0() { }

}

