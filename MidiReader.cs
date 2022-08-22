public sealed class MidiReader : IDisposable // TypeDefIndex: 7587
{	private static readonly byte[] EmptyByteArray; // 0x0
	private readonly ReaderSettings _settings; // 0x10
	private readonly Stream _stream; // 0x18
	private readonly bool _isStreamWrapped; // 0x20
	private readonly bool _useBuffering; // 0x21
	private byte[] _buffer; // 0x28
	private int _bufferSize; // 0x30
	private int _bufferPosition; // 0x34
	private long _bufferStart; // 0x38
	private long _position; // 0x40
	private bool _disposed; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <Length>k__BackingField; // 0x50

	public long Position { get; set; }
	public long Length { get; }
	public bool EndReached { get; }


	public void .ctor(Stream stream, ReaderSettings settings) { }

	public long get_Position() { }

	public void set_Position(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

private sealed class MidiReader.<>c // TypeDefIndex: 7588
{	public static readonly MidiReader.<>c <>9; // 0x0
	public static Func<byte[], IEnumerable<byte>> <>9__22_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal IEnumerable<byte> <ReadBytes>b__22_0(byte[] bytes) { }

}

