public class MemoryStream : Stream // TypeDefIndex: 635
{	// Fields
	private byte[] _buffer; // 0x28
	private int _origin; // 0x30
	private int _position; // 0x34
	private int _length; // 0x38
	private int _capacity; // 0x3C
	private bool _expandable; // 0x40
	private bool _writable; // 0x41
	private bool _exposable; // 0x42
	private bool _isOpen; // 0x43
	private Task<int> _lastReadTask; // 0x48
	private const int MemStreamMaxLength = 2147483647;

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1621AC0 Offset: 0x1620EC0 VA: 0x181621AC0
	public void .ctor() { }

	// RVA: 0x16219E0 Offset: 0x1620DE0 VA: 0x1816219E0
	public void .ctor(int capacity) { }

	// RVA: 0x1621900 Offset: 0x1620D00 VA: 0x181621900
	public void .ctor(byte[] buffer) { }

	// RVA: 0x1621640 Offset: 0x1620A40 VA: 0x181621640
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x1621610 Offset: 0x1620A10 VA: 0x181621610
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x1621B40 Offset: 0x1620F40 VA: 0x181621B40
	public void .ctor(byte[] buffer, int index, int count, bool writable) { }

	// RVA: 0x1621720 Offset: 0x1620B20 VA: 0x181621720
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0xEE1D30 Offset: 0xEE1130 VA: 0x180EE1D30 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xEE1D30 Offset: 0xEE1130 VA: 0x180EE1D30 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1620370 Offset: 0x161F770 VA: 0x181620370
	private void EnsureWriteable() { }

	// RVA: 0x1620210 Offset: 0x161F610 VA: 0x181620210 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16202A0 Offset: 0x161F6A0 VA: 0x1816202A0
	private bool EnsureCapacity(int value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x16203A0 Offset: 0x161F7A0 VA: 0x1816203A0 Slot: 31
	public virtual byte[] GetBuffer() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x1620470 Offset: 0x161F870 VA: 0x181620470
	internal int InternalGetPosition() { }

	// RVA: 0x16204A0 Offset: 0x161F8A0 VA: 0x1816204A0
	internal int InternalReadInt32() { }

	// RVA: 0x1620420 Offset: 0x161F820 VA: 0x181620420
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x1621B70 Offset: 0x1620F70 VA: 0x181621B70 Slot: 32
	public virtual int get_Capacity() { }

	// RVA: 0x1621C00 Offset: 0x1621000 VA: 0x181621C00 Slot: 33
	public virtual void set_Capacity(int value) { }

	// RVA: 0x1621BA0 Offset: 0x1620FA0 VA: 0x181621BA0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1621BD0 Offset: 0x1620FD0 VA: 0x181621BD0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1621D30 Offset: 0x1621130 VA: 0x181621D30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16208A0 Offset: 0x161FCA0 VA: 0x1816208A0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1620580 Offset: 0x161F980 VA: 0x181620580 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1620840 Offset: 0x161FC40 VA: 0x181620840 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x161FDA0 Offset: 0x161F1A0 VA: 0x18161FDA0 Slot: 15
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1620AF0 Offset: 0x161FEF0 VA: 0x181620AF0 Slot: 25
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1620D00 Offset: 0x1620100 VA: 0x181620D00 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1620E40 Offset: 0x1620240 VA: 0x181620E40 Slot: 34
	public virtual byte[] ToArray() { }

	// RVA: 0x1621320 Offset: 0x1620720 VA: 0x181621320 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x1620EF0 Offset: 0x16202F0 VA: 0x181620EF0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1621180 Offset: 0x1620580 VA: 0x181621180 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1621260 Offset: 0x1620660 VA: 0x181621260 Slot: 35
	public virtual void WriteTo(Stream stream) { }

}

