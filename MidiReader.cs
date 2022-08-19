public sealed class MidiReader : IDisposable // TypeDefIndex: 7587
{	// Fields
	private static readonly byte[] EmptyByteArray; // 0x0
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

	// Properties
	public long Position { get; set; }
	public long Length { get; }
	public bool EndReached { get; }

	// Methods

	// RVA: 0x139D5D0 Offset: 0x139C9D0 VA: 0x18139D5D0
	public void .ctor(Stream stream, ReaderSettings settings) { }

	// RVA: 0x139D9A0 Offset: 0x139CDA0 VA: 0x18139D9A0
	public long get_Position() { }

	// RVA: 0x139D9E0 Offset: 0x139CDE0 VA: 0x18139D9E0
	public void set_Position(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public long get_Length() { }

	// RVA: 0x139D8B0 Offset: 0x139CCB0 VA: 0x18139D8B0
	public bool get_EndReached() { }

	// RVA: 0x139C990 Offset: 0x139BD90 VA: 0x18139C990
	public byte ReadByte() { }

	// RVA: 0x139D390 Offset: 0x139C790 VA: 0x18139D390
	public sbyte ReadSByte() { }

	// RVA: 0x139CFA0 Offset: 0x139C3A0 VA: 0x18139CFA0
	public byte[] ReadBytes(int count) { }

	// RVA: 0x139D4A0 Offset: 0x139C8A0 VA: 0x18139D4A0
	public ushort ReadWord() { }

	// RVA: 0x139D190 Offset: 0x139C590 VA: 0x18139D190
	public uint ReadDword() { }

	// RVA: 0x139D2B0 Offset: 0x139C6B0 VA: 0x18139D2B0
	public short ReadInt16() { }

	// RVA: 0x139D3A0 Offset: 0x139C7A0 VA: 0x18139D3A0
	public string ReadString(int count) { }

	// RVA: 0x139D490 Offset: 0x139C890 VA: 0x18139D490
	public int ReadVlqNumber() { }

	// RVA: 0x139D3E0 Offset: 0x139C7E0 VA: 0x18139D3E0
	public long ReadVlqLongNumber() { }

	// RVA: 0x139C890 Offset: 0x139BC90 VA: 0x18139C890
	public uint Read3ByteDword() { }

	// RVA: 0x139CBB0 Offset: 0x139BFB0 VA: 0x18139CBB0
	private byte[] ReadBytesInternal(int count) { }

	// RVA: 0x139CD20 Offset: 0x139C120 VA: 0x18139CD20
	private byte[] ReadBytesWithBuffering(int count) { }

	// RVA: 0x139CAD0 Offset: 0x139BED0 VA: 0x18139CAD0
	private byte[] ReadBytesFromBuffer(int count) { }

	// RVA: 0x139CEC0 Offset: 0x139C2C0 VA: 0x18139CEC0
	private byte[] ReadBytesWithoutBuffering(int count) { }

	// RVA: 0x139C510 Offset: 0x139B910 VA: 0x18139C510
	private bool EnsureBufferIsReadyForReading() { }

	// RVA: 0x139C650 Offset: 0x139BA50 VA: 0x18139C650
	private void PrepareBuffer() { }

	// RVA: 0x139C500 Offset: 0x139B900 VA: 0x18139C500 Slot: 4
	public void Dispose() { }

	// RVA: 0x139C500 Offset: 0x139B900 VA: 0x18139C500
	private void Dispose(bool disposing) { }

	// RVA: 0x139D580 Offset: 0x139C980 VA: 0x18139D580
	private static void .cctor() { }

}

private sealed class MidiReader.<>c // TypeDefIndex: 7588
{	// Fields
	public static readonly MidiReader.<>c <>9; // 0x0
	public static Func<byte[], IEnumerable<byte>> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x13A55D0 Offset: 0x13A49D0 VA: 0x1813A55D0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal IEnumerable<byte> <ReadBytes>b__22_0(byte[] bytes) { }

}

