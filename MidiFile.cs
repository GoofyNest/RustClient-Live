public sealed class MidiFile // TypeDefIndex: 7585
{	// Fields
	internal Nullable<ushort> _originalFormat; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimeDivision <TimeDivision>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ChunksCollection <Chunks>k__BackingField; // 0x20

	// Properties
	public TimeDivision TimeDivision { get; set; }
	public ChunksCollection Chunks { get; }

	// Methods

	// RVA: 0x139C410 Offset: 0x139B810 VA: 0x18139C410
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public ChunksCollection get_Chunks() { }

	// RVA: 0x139C100 Offset: 0x139B500 VA: 0x18139C100
	public static MidiFile Read(string filePath, ReadingSettings settings) { }

	// RVA: 0x139B8F0 Offset: 0x139ACF0 VA: 0x18139B8F0
	public static MidiFile Read(Stream stream, ReadingSettings settings) { }

	// RVA: 0x139B4D0 Offset: 0x139A8D0 VA: 0x18139B4D0
	private static MidiChunk ReadChunk(MidiReader reader, ReadingSettings settings, int actualTrackChunksCount, Nullable<int> expectedTrackChunksCount) { }

	// RVA: 0x139B450 Offset: 0x139A850 VA: 0x18139B450
	private static void ReactOnUnexpectedTrackChunksCount(UnexpectedTrackChunksCountPolicy policy, int actualTrackChunksCount, int expectedTrackChunksCount) { }

	// RVA: 0x139B3E0 Offset: 0x139A7E0 VA: 0x18139B3E0
	private static void ReactOnNotEnoughBytes(NotEnoughBytesPolicy policy, Exception exception) { }

	// RVA: 0x139C1F0 Offset: 0x139B5F0 VA: 0x18139C1F0
	private static MidiChunk TryCreateChunk(string chunkId, ChunkTypesCollection chunksTypes) { }

	// RVA: 0x139B2A0 Offset: 0x139A6A0 VA: 0x18139B2A0
	private static bool IsChunkType(Type type) { }

}

