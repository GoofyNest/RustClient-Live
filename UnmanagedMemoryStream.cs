public class UnmanagedMemoryStream : Stream // TypeDefIndex: 659
{	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x1681AF0 Offset: 0x1680EF0 VA: 0x181681AF0
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1681BF0 Offset: 0x1680FF0 VA: 0x181681BF0
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x1681B50 Offset: 0x1680F50 VA: 0x181681B50
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x1680490 Offset: 0x167F890 VA: 0x181680490
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x1681C90 Offset: 0x1681090 VA: 0x181681C90 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x15ECC10 Offset: 0x15EC010 VA: 0x1815ECC10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1681CA0 Offset: 0x16810A0 VA: 0x181681CA0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1680450 Offset: 0x167F850 VA: 0x181680450 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1680470 Offset: 0x167F870 VA: 0x181680470 Slot: 18
	public override void Flush() { }

	// RVA: 0x1681CC0 Offset: 0x16810C0 VA: 0x181681CC0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1681DD0 Offset: 0x16811D0 VA: 0x181681DD0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1681E10 Offset: 0x1681210 VA: 0x181681E10 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1681CF0 Offset: 0x16810F0 VA: 0x181681CF0
	public byte* get_PositionPointer() { }

	// RVA: 0x1680AF0 Offset: 0x167FEF0 VA: 0x181680AF0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x16806D0 Offset: 0x167FAD0 VA: 0x1816806D0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1680960 Offset: 0x167FD60 VA: 0x181680960 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x1680E60 Offset: 0x1680260 VA: 0x181680E60 Slot: 25
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1681010 Offset: 0x1680410 VA: 0x181681010 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x16816A0 Offset: 0x1680AA0 VA: 0x1816816A0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x16811D0 Offset: 0x16805D0 VA: 0x1816811D0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1681420 Offset: 0x1680820 VA: 0x181681420 Slot: 30
	public override void WriteByte(byte value) { }

}

