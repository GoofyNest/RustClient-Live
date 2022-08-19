internal sealed class StreamWrapper : Stream // TypeDefIndex: 7636
{	// Fields
	private readonly Stream _stream; // 0x28
	private readonly CircularBuffer<byte> _buffer; // 0x30
	private readonly byte[] _peekBuffer; // 0x38
	private readonly byte[] _skipBytesBuffer; // 0x40
	private long _position; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x13A2EC0 Offset: 0x13A22C0 VA: 0x1813A2EC0
	public void .ctor(Stream stream, int bufferCapacity) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x13A2FB0 Offset: 0x13A23B0 VA: 0x1813A2FB0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x13A2FC0 Offset: 0x13A23C0 VA: 0x1813A2FC0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x13A2B50 Offset: 0x13A1F50 VA: 0x1813A2B50
	public bool IsEndReached() { }

	// RVA: 0x13A2B00 Offset: 0x13A1F00 VA: 0x1813A2B00 Slot: 18
	public override void Flush() { }

	// RVA: 0x13A2BC0 Offset: 0x13A1FC0 VA: 0x1813A2BC0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A2D20 Offset: 0x13A2120 VA: 0x1813A2D20 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x13A2D70 Offset: 0x13A2170 VA: 0x1813A2D70 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x13A2E70 Offset: 0x13A2270 VA: 0x1813A2E70 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x13A2DC0 Offset: 0x13A21C0 VA: 0x1813A2DC0
	private void SkipBytes(int count) { }

}

