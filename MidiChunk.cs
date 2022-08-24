public abstract class MidiChunk // TypeDefIndex: 7510
{
	[CompilerGeneratedAttribute] 
	private readonly string <ChunkId>k__BackingField; 

	public string ChunkId { get; }


	protected void .ctor(string id) { }

	[CompilerGeneratedAttribute] 
	public string get_ChunkId() { }

	internal void Read(MidiReader reader, ReadingSettings settings) { }

	protected abstract void ReadContent(MidiReader reader, ReadingSettings settings, uint size);

}

