public sealed class MidiReader : IDisposable // TypeDefIndex: 7603
{
	private static readonly byte[] EmptyByteArray;
	private readonly ReaderSettings _settings;
	private readonly Stream _stream;
	private readonly bool _isStreamWrapped;
	private readonly bool _useBuffering;
	private byte[] _buffer;
	private int _bufferSize;
	private int _bufferPosition;
	private long _bufferStart;
	private long _position;
	private bool _disposed;
	[CompilerGeneratedAttribute]
	private readonly long <Length>k__BackingField;

	public long Position { get; set; }
	public long Length { get; }
	public bool EndReached { get; }


	public void .ctor(Stream stream, ReaderSettings settings) { }

	public long get_Position() { }

	public void set_Position(long value) { }

	[CompilerGeneratedAttribute]
	public long get_Length() { }

	public bool get_EndReached() { }

	public byte ReadByte() { }

	public sbyte ReadSByte() { }

	public byte[] ReadBytes(int count) { }

	public ushort ReadWord() { }

	public uint ReadDword() { }

	public short ReadInt16() { }

	public string ReadString(int count) { }

	public int ReadVlqNumber() { }

	public long ReadVlqLongNumber() { }

	public uint Read3ByteDword() { }

	private byte[] ReadBytesInternal(int count) { }

	private byte[] ReadBytesWithBuffering(int count) { }

	private byte[] ReadBytesFromBuffer(int count) { }

	private byte[] ReadBytesWithoutBuffering(int count) { }

	private bool EnsureBufferIsReadyForReading() { }

	private void PrepareBuffer() { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	private static void .cctor() { }

}

private sealed class MidiReader.<>c // TypeDefIndex: 7604
{
	public static readonly MidiReader.<>c <>9;
	public static Func<byte[], IEnumerable<byte>> <>9__22_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal IEnumerable<byte> <ReadBytes>

}

