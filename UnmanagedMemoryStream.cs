public class UnmanagedMemoryStream : Stream // TypeDefIndex: 659
{
	private SafeBuffer _buffer;
	private byte* _mem;
	private long _length;
	private long _capacity;
	private long _position;
	private long _offset;
	private FileAccess _access;
	internal bool _isOpen;
	private Task<int> _lastReadTask;

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute]
	public byte* PositionPointer { get; }


	protected void .ctor() { }

	[CLSCompliantAttribute]
	public void .ctor(byte* pointer, long length) { }

	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public byte* get_PositionPointer() { }

	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute]
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override int ReadByte() { }

	public override long Seek(long offset, SeekOrigin loc) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute]
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override void WriteByte(byte value) { }

}

