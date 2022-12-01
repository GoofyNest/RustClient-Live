public class MemoryStream : Stream // TypeDefIndex: 635
{
	private byte[] _buffer;
	private int _origin;
	private int _position;
	private int _length;
	private int _capacity;
	private bool _expandable;
	private bool _writable;
	private bool _exposable;
	private bool _isOpen;
	private Task<int> _lastReadTask;
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

	[ComVisibleAttribute]
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override int ReadByte() { }

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	public override long Seek(long offset, SeekOrigin loc) { }

	public override void SetLength(long value) { }

	public virtual byte[] ToArray() { }

	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute]
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override void WriteByte(byte value) { }

	public virtual void WriteTo(Stream stream) { }

}

