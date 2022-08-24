internal sealed class StreamWrapper : Stream // TypeDefIndex: 7636
{
	private readonly Stream _stream; 
	private readonly CircularBuffer<byte> _buffer; 
	private readonly byte[] _peekBuffer; 
	private readonly byte[] _skipBytesBuffer; 
	private long _position; 

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public void .ctor(Stream stream, int bufferCapacity) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public bool IsEndReached() { }

	public override void Flush() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	private void SkipBytes(int count) { }

}

