public class LZ4Stream : Stream // TypeDefIndex: 6990
{	// Fields
	private readonly Stream _innerStream; // 0x28
	private readonly LZ4StreamMode _compressionMode; // 0x30
	private readonly bool _highCompression; // 0x34
	private readonly bool _interactiveRead; // 0x35
	private readonly bool _isolateInnerStream; // 0x36
	private readonly int _blockSize; // 0x38
	private byte[] _buffer; // 0x40
	private int _bufferLength; // 0x48
	private int _bufferOffset; // 0x4C

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x225C350 Offset: 0x225B750 VA: 0x18225C350
	public void .ctor(Stream innerStream, LZ4StreamMode compressionMode, LZ4StreamFlags compressionFlags = 0, int blockSize = 1048576) { }

	// RVA: 0x225BAE0 Offset: 0x225AEE0 VA: 0x18225BAE0
	private static NotSupportedException NotSupported(string operationName) { }

	// RVA: 0x225B7F0 Offset: 0x225ABF0 VA: 0x18225B7F0
	private static EndOfStreamException EndOfStream() { }

	// RVA: 0x225BF30 Offset: 0x225B330 VA: 0x18225BF30
	private bool TryReadVarInt(out ulong result) { }

	// RVA: 0x225BD10 Offset: 0x225B110 VA: 0x18225BD10
	private ulong ReadVarInt() { }

	// RVA: 0x225BBC0 Offset: 0x225AFC0 VA: 0x18225BBC0
	private int ReadBlock(byte[] buffer, int offset, int length) { }

	// RVA: 0x225C130 Offset: 0x225B530 VA: 0x18225C130
	private void WriteVarInt(ulong value) { }

	// RVA: 0x225B840 Offset: 0x225AC40 VA: 0x18225B840
	private void FlushCurrentChunk() { }

	// RVA: 0x225B440 Offset: 0x225A840 VA: 0x18225B440
	private bool AcquireNextChunk() { }

	// RVA: 0x1327A20 Offset: 0x1326E20 VA: 0x181327A20 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x5F7B70 Offset: 0x5F6F70 VA: 0x1805F7B70 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x225BAA0 Offset: 0x225AEA0 VA: 0x18225BAA0 Slot: 18
	public override void Flush() { }

	// RVA: 0xEBF9B0 Offset: 0xEBEDB0 VA: 0x180EBF9B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0xEBF9B0 Offset: 0xEBEDB0 VA: 0x180EBF9B0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x225C430 Offset: 0x225B830 VA: 0x18225C430 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x225BC50 Offset: 0x225B050 VA: 0x18225BC50 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x225BD80 Offset: 0x225B180 VA: 0x18225BD80 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x225BEB0 Offset: 0x225B2B0 VA: 0x18225BEB0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x225BEF0 Offset: 0x225B2F0 VA: 0x18225BEF0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x225C030 Offset: 0x225B430 VA: 0x18225C030 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x225C200 Offset: 0x225B600 VA: 0x18225C200 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x225B790 Offset: 0x225AB90 VA: 0x18225B790 Slot: 17
	protected override void Dispose(bool disposing) { }

}

public enum LZ4Stream.ChunkFlags // TypeDefIndex: 6991
{	// Fields
	public int value__; // 0x0
	public const LZ4Stream.ChunkFlags None = 0;
	public const LZ4Stream.ChunkFlags Compressed = 1;
	public const LZ4Stream.ChunkFlags HighCompression = 2;
	public const LZ4Stream.ChunkFlags Passes = 28;

}

