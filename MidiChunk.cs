public abstract class MidiChunk // TypeDefIndex: 7510
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <ChunkId>k__BackingField; // 0x10

	public string ChunkId { get; }


	protected void .ctor(string id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_ChunkId() { }

	internal void Read(MidiReader reader, ReadingSettings settings) { }

	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, uint size);

}

