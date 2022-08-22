public class MemoryStream : Stream // TypeDefIndex: 635
{	private byte[] _buffer; // 0x28
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

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }


	public void .ctor() { }

	public void .ctor(int capacity) { }

	public void .ctor(byte[] buffer) { }

	public void .ctor(byte[] buffer, bool writable) { }

	public void .ctor(byte[] buffer, int index, int count) { }

	public void .ctor(byte[] buffer, int index, int count, bool writable) { }

	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	private void EnsureWriteable() { }

	protected override void Dispose(bool disposing) { }

	private bool EnsureCapacity(int value) { }

	public override void Flush() { }

	public virtual byte[] GetBuffer() { }

	internal byte[] InternalGetBuffer() { }

	internal int InternalGetPosition() { }

	internal int InternalReadInt32() { }

	internal int InternalEmulateRead(int count) { }

	public virtual int get_Capacity() { }

	public virtual void set_Capacity(int value) { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override int ReadByte() { }

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	public override long Seek(long offset, SeekOrigin loc) { }

	public override void SetLength(long value) { }

	public virtual byte[] ToArray() { }

	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override void WriteByte(byte value) { }

	public virtual void WriteTo(Stream stream) { }

}

