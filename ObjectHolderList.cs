internal class ObjectHolderList // TypeDefIndex: 1042
{	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x128E110 Offset: 0x128D510 VA: 0x18128E110
	internal void .ctor() { }

	// RVA: 0x128E0A0 Offset: 0x128D4A0 VA: 0x18128E0A0
	internal void .ctor(int startingSize) { }

	// RVA: 0x128DE50 Offset: 0x128D250 VA: 0x18128DE50 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x128E010 Offset: 0x128D410 VA: 0x18128E010
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x128DF80 Offset: 0x128D380 VA: 0x18128DF80
	private void EnlargeArray() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	internal int get_Version() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	internal int get_Count() { }

}

