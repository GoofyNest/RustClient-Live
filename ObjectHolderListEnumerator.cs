internal class ObjectHolderListEnumerator // TypeDefIndex: 1043
{	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x128DDA0 Offset: 0x128D1A0 VA: 0x18128DDA0
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x128DCF0 Offset: 0x128D0F0 VA: 0x18128DCF0
	internal bool MoveNext() { }

	// RVA: 0x128DE10 Offset: 0x128D210 VA: 0x18128DE10
	internal ObjectHolder get_Current() { }

}

