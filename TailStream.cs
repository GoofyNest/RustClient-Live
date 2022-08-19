internal sealed class TailStream : Stream // TypeDefIndex: 970
{	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17C1380 Offset: 0x17C0780 VA: 0x1817C1380
	public void .ctor(int bufferSize) { }

	// RVA: 0x15ADF60 Offset: 0x15AD360 VA: 0x1815ADF60
	public void Clear() { }

	// RVA: 0x17C0FF0 Offset: 0x17C03F0 VA: 0x1817C0FF0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17C1400 Offset: 0x17C0800 VA: 0x1817C1400
	public byte[] get_Buffer() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x11769F0 Offset: 0x1175DF0 VA: 0x1811769F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x17C1480 Offset: 0x17C0880 VA: 0x1817C1480 Slot: 10
	public override long get_Length() { }

	// RVA: 0x17C14F0 Offset: 0x17C08F0 VA: 0x1817C14F0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17C1560 Offset: 0x17C0960 VA: 0x1817C1560 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x17C1130 Offset: 0x17C0530 VA: 0x1817C1130 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17C11A0 Offset: 0x17C05A0 VA: 0x1817C11A0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x17C10C0 Offset: 0x17C04C0 VA: 0x1817C10C0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x17C1210 Offset: 0x17C0610 VA: 0x1817C1210 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

}

