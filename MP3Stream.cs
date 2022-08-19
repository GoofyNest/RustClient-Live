public class MP3Stream : Stream // TypeDefIndex: 7379
{	// Fields
	private readonly Bitstream _BitStream; // 0x28
	private readonly Decoder _Decoder; // 0x30
	private readonly Buffer16BitStereo _Buffer; // 0x38
	private readonly Stream _SourceStream; // 0x40
	private const int BACK_STREAM_BYTE_COUNT_REP = 0;
	private short _ChannelCountRep; // 0x48
	private readonly SoundFormat FormatRep; // 0x4C
	private int _FrequencyRep; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsEOF>k__BackingField; // 0x54

	// Properties
	public bool IsEOF { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public int Frequency { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xABA180 Offset: 0xAB9580 VA: 0x180ABA180
	public bool get_IsEOF() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x225D440 Offset: 0x225C840 VA: 0x18225D440
	protected void set_IsEOF(bool value) { }

	// RVA: 0x225D090 Offset: 0x225C490 VA: 0x18225D090
	public void .ctor(Stream sourceStream) { }

	// RVA: 0x225D0A0 Offset: 0x225C4A0 VA: 0x18225D0A0
	public void .ctor(Stream sourceStream, int chunkSize) { }

	// RVA: 0x225D350 Offset: 0x225C750 VA: 0x18225D350 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x225D380 Offset: 0x225C780 VA: 0x18225D380 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x225D3B0 Offset: 0x225C7B0 VA: 0x18225D3B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x225D3E0 Offset: 0x225C7E0 VA: 0x18225D3E0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x225D410 Offset: 0x225C810 VA: 0x18225D410 Slot: 11
	public override long get_Position() { }

	// RVA: 0x225D450 Offset: 0x225C850 VA: 0x18225D450 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	public int get_Frequency() { }

	// RVA: 0x225CD60 Offset: 0x225C160 VA: 0x18225CD60 Slot: 18
	public override void Flush() { }

	// RVA: 0x225CFC0 Offset: 0x225C3C0 VA: 0x18225CFC0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x225CFF0 Offset: 0x225C3F0 VA: 0x18225CFF0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x225D040 Offset: 0x225C440 VA: 0x18225D040 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x225CEF0 Offset: 0x225C2F0 VA: 0x18225CEF0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x225CD40 Offset: 0x225C140 VA: 0x18225CD40 Slot: 16
	public override void Close() { }

	// RVA: 0x225CD90 Offset: 0x225C190 VA: 0x18225CD90
	private bool ReadFrame() { }

}

