public sealed class ChunksCollection : ICollection<MidiChunk>, IEnumerable<MidiChunk>, IEnumerable // TypeDefIndex: 7513
{	private readonly List<MidiChunk> _chunks; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsReadOnly>k__BackingField; // 0x18

	public int Count { get; }
	public bool IsReadOnly { get; }


	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsReadOnly() { }

	public void Add(MidiChunk chunk) { }

	public bool Remove(MidiChunk chunk) { }

	public void Clear() { }

	public IEnumerator<MidiChunk> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool Contains(MidiChunk item) { }

	public void CopyTo(MidiChunk[] array, int arrayIndex) { }

	public void .ctor() { }

}

