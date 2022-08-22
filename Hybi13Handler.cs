internal class Hybi13Handler : IHandler, IDisposable // TypeDefIndex: 6935
{	private static readonly Encoding UTF8; // 0x0
	private static readonly SHA1 SHA1; // 0x8
	private static readonly ThreadLocal<StringBuilder> StringBuilder; // 0x10
	private readonly WebSocketHttpRequest _request; // 0x10
	private readonly IWebSocketConnection _connection; // 0x18
	private byte[] _data; // 0x20
	private int _dataLen; // 0x28
	private Nullable<FrameType> _frameType; // 0x2C
	private byte[] _message; // 0x30
	private int _messageLen; // 0x38


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

private sealed class Hybi13Handler.<>c // TypeDefIndex: 6936
{	public static readonly Hybi13Handler.<>c <>9; // 0x2B0AC04


	private static void .cctor() { }

	public void .ctor() { }

	internal StringBuilder <.cctor>b__28_0() { }

}

