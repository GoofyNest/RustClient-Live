public sealed class ChunksCollection : ICollection<MidiChunk>, IEnumerable<MidiChunk>, IEnumerable // TypeDefIndex: 7513
{	// Fields
	private readonly List<MidiChunk> _chunks; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsReadOnly>k__BackingField; // 0x18

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1391A30 Offset: 0x1390E30 VA: 0x181391A30 Slot: 4
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1391620 Offset: 0x1390A20 VA: 0x181391620 Slot: 6
	public void Add(MidiChunk chunk) { }

	// RVA: 0x1391880 Offset: 0x1390C80 VA: 0x181391880 Slot: 10
	public bool Remove(MidiChunk chunk) { }

	// RVA: 0x13916E0 Offset: 0x1390AE0 VA: 0x1813916E0 Slot: 7
	public void Clear() { }

	// RVA: 0x1391800 Offset: 0x1390C00 VA: 0x181391800 Slot: 11
	public IEnumerator<MidiChunk> GetEnumerator() { }

	// RVA: 0x1391940 Offset: 0x1390D40 VA: 0x181391940 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1391730 Offset: 0x1390B30 VA: 0x181391730 Slot: 8
	public bool Contains(MidiChunk item) { }

	// RVA: 0x1391790 Offset: 0x1390B90 VA: 0x181391790 Slot: 9
	public void CopyTo(MidiChunk[] array, int arrayIndex) { }

	// RVA: 0x13919C0 Offset: 0x1390DC0 VA: 0x1813919C0
	public void .ctor() { }

}

