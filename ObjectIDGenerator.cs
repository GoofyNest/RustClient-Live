public class ObjectIDGenerator // TypeDefIndex: 1036
{	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x128F5F0 Offset: 0x128E9F0 VA: 0x18128F5F0
	public void .ctor() { }

	// RVA: 0x128EE90 Offset: 0x128E290 VA: 0x18128EE90
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x128EF50 Offset: 0x128E350 VA: 0x18128EF50 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x128F130 Offset: 0x128E530 VA: 0x18128F130 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x128F220 Offset: 0x128E620 VA: 0x18128F220
	private void Rehash() { }

	// RVA: 0x128F580 Offset: 0x128E980 VA: 0x18128F580
	private static void .cctor() { }

}

