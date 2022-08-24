public class LZ4Stream : Stream // TypeDefIndex: 6990
{
	private readonly Stream _innerStream; 
	private readonly LZ4StreamMode _compressionMode; 
	private readonly bool _highCompression; 
	private readonly bool _interactiveRead; 
	private readonly bool _isolateInnerStream; 
	private readonly int _blockSize; 
	private byte[] _buffer; 
	private int _bufferLength; 
	private int _bufferOffset; 

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public void .ctor(Stream innerStream, LZ4StreamMode compressionMode, LZ4StreamFlags compressionFlags = 0, int blockSize = 1048576) { }

	private static NotSupportedException NotSupported(string operationName) { }

	private static EndOfStreamException EndOfStream() { }

	private bool TryReadVarInt(out ulong result) { }

	private ulong ReadVarInt() { }

	private int ReadBlock(byte[] buffer, int offset, int length) { }

	private void WriteVarInt(ulong value) { }

	private void FlushCurrentChunk() { }

	private bool AcquireNextChunk() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override void Flush() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override int ReadByte() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	public override void WriteByte(byte value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	protected override void Dispose(bool disposing) { }

}

public enum LZ4Stream.ChunkFlags // TypeDefIndex: 6991
{
	public int value__; 
	public const LZ4Stream.ChunkFlags None = 0;
	public const LZ4Stream.ChunkFlags Compressed = 1;
	public const LZ4Stream.ChunkFlags HighCompression = 2;
	public const LZ4Stream.ChunkFlags Passes = 28;

}

