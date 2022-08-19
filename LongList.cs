internal class LongList // TypeDefIndex: 1041
{	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x128DAB0 Offset: 0x128CEB0 VA: 0x18128DAB0
	internal void .ctor() { }

	// RVA: 0x128DB10 Offset: 0x128CF10 VA: 0x18128DB10
	internal void .ctor(int startingSize) { }

	// RVA: 0x128D820 Offset: 0x128CC20 VA: 0x18128D820
	internal void Add(long value) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	internal int get_Count() { }

	// RVA: 0x128DAA0 Offset: 0x128CEA0 VA: 0x18128DAA0
	internal void StartEnumeration() { }

	// RVA: 0x128D9A0 Offset: 0x128CDA0 VA: 0x18128D9A0
	internal bool MoveNext() { }

	// RVA: 0x128DB80 Offset: 0x128CF80 VA: 0x18128DB80
	internal long get_Current() { }

	// RVA: 0x128DA10 Offset: 0x128CE10 VA: 0x18128DA10
	internal bool RemoveElement(long value) { }

	// RVA: 0x128D910 Offset: 0x128CD10 VA: 0x18128D910
	private void EnlargeArray() { }

}

