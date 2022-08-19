internal class Hybi13Handler : IHandler, IDisposable // TypeDefIndex: 6935
{	// Fields
	private static readonly Encoding UTF8; // 0x0
	private static readonly SHA1 SHA1; // 0x8
	private static readonly ThreadLocal<StringBuilder> StringBuilder; // 0x10
	private readonly WebSocketHttpRequest _request; // 0x10
	private readonly IWebSocketConnection _connection; // 0x18
	private byte[] _data; // 0x20
	private int _dataLen; // 0x28
	private Nullable<FrameType> _frameType; // 0x2C
	private byte[] _message; // 0x30
	private int _messageLen; // 0x38

	// Methods

	// RVA: 0x22020A0 Offset: 0x22014A0 VA: 0x1822020A0
	public void .ctor(WebSocketHttpRequest request, IWebSocketConnection connection) { }

	// RVA: 0x2200BE0 Offset: 0x21FFFE0 VA: 0x182200BE0 Slot: 8
	public void Dispose() { }

	// RVA: 0x2201E80 Offset: 0x2201280 VA: 0x182201E80 Slot: 4
	public void Receive(Span<byte> newData) { }

	// RVA: 0x22008A0 Offset: 0x21FFCA0 VA: 0x1822008A0 Slot: 5
	public MemoryBuffer CreateHandshake() { }

	// RVA: 0x2201150 Offset: 0x2200550 VA: 0x182201150 Slot: 6
	public MemoryBuffer FrameText(string text) { }

	// RVA: 0x22013B0 Offset: 0x22007B0 VA: 0x1822013B0 Slot: 9
	public MemoryBuffer FrameText(MemoryBuffer utf8StringBytes) { }

	// RVA: 0x2200CB0 Offset: 0x22000B0 VA: 0x182200CB0 Slot: 7
	public MemoryBuffer FrameClose(ushort code) { }

	// RVA: 0x2201050 Offset: 0x2200450 VA: 0x182201050
	private static MemoryBuffer FrameData(MemoryBuffer payload, FrameType frameType) { }

	// RVA: 0x2200EA0 Offset: 0x22002A0 VA: 0x182200EA0
	private static MemoryBuffer FrameData(Span<byte> payload, FrameType frameType) { }

	// RVA: 0x22019F0 Offset: 0x2200DF0 VA: 0x1822019F0
	private void ReceiveData() { }

	// RVA: 0x2201570 Offset: 0x2200970 VA: 0x182201570
	private void ProcessFrame(FrameType frameType, ArraySegment<byte> buffer) { }

	// RVA: 0x2200890 Offset: 0x21FFC90 VA: 0x182200890
	private void Clear() { }

	// RVA: 0x2200B00 Offset: 0x21FFF00 VA: 0x182200B00
	internal static string CreateResponseKey(string requestKey) { }

	// RVA: 0x2201920 Offset: 0x2200D20 VA: 0x182201920
	internal static string ReadUTF8PayloadData(ArraySegment<byte> bytes) { }

	// RVA: 0x2201F70 Offset: 0x2201370 VA: 0x182201F70
	private static void .cctor() { }

}

private sealed class Hybi13Handler.<>c // TypeDefIndex: 6936
{	// Fields
	public static readonly Hybi13Handler.<>c <>9; // 0x2B0AC04

	// Methods

	// RVA: 0x22045E0 Offset: 0x22039E0 VA: 0x1822045E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2203C30 Offset: 0x2203030 VA: 0x182203C30
	internal StringBuilder <.cctor>b__28_0() { }

}

