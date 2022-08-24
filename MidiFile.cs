public sealed class MidiFile // TypeDefIndex: 7585
{
	internal Nullable<ushort> _originalFormat; 
	[CompilerGeneratedAttribute] 
	private TimeDivision <TimeDivision>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly ChunksCollection <Chunks>k__BackingField; 

	public TimeDivision TimeDivision { get; set; }
	public ChunksCollection Chunks { get; }


	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	public TimeDivision get_TimeDivision() { }

	[CompilerGeneratedAttribute] 
	public void set_TimeDivision(TimeDivision value) { }

	[CompilerGeneratedAttribute] 
	public ChunksCollection get_Chunks() { }

	public static MidiFile Read(string filePath, ReadingSettings settings) { }

	public static MidiFile Read(Stream stream, ReadingSettings settings) { }

	private static MidiChunk ReadChunk(MidiReader reader, ReadingSettings settings, int actualTrackChunksCount, Nullable<int> expectedTrackChunksCount) { }

	private static void ReactOnUnexpectedTrackChunksCount(UnexpectedTrackChunksCountPolicy policy, int actualTrackChunksCount, int expectedTrackChunksCount) { }

	private static void ReactOnNotEnoughBytes(NotEnoughBytesPolicy policy, Exception exception) { }

	private static MidiChunk TryCreateChunk(string chunkId, ChunkTypesCollection chunksTypes) { }

	private static bool IsChunkType(Type type) { }

}

