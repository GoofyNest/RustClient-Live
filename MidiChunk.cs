public abstract class MidiChunk // TypeDefIndex: 7510
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <ChunkId>k__BackingField; // 0x10

	// Properties
	public string ChunkId { get; }

	// Methods

	// RVA: 0x139AFA0 Offset: 0x139A3A0 VA: 0x18139AFA0
	protected void .ctor(string id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_ChunkId() { }

	// RVA: 0x139ADB0 Offset: 0x139A1B0 VA: 0x18139ADB0
	internal void Read(MidiReader reader, ReadingSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, uint size);

}

