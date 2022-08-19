public sealed class InvalidChunkSizeException : MidiException // TypeDefIndex: 7573
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <ChunkId>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <ExpectedSize>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <ActualSize>k__BackingField; // 0x98

	// Methods

	// RVA: 0x1393D30 Offset: 0x1393130 VA: 0x181393D30
	internal void .ctor(string chunkId, long expectedSize, long actualSize) { }

}

