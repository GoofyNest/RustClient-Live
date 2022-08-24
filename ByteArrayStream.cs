public class ByteArrayStream : Stream // TypeDefIndex: 4833
{
	private byte[] _data; 
	private int _base; 
	private int _length; 
	private int _position; 

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public void .ctor() { }

	public void SetData(byte[] data, int offset, int length) { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override int ReadByte() { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override void WriteByte(byte value) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void Flush() { }

	public override void SetLength(long value) { }

}

