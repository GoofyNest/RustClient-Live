internal class ValueTypeFixupInfo // TypeDefIndex: 1064
{	// Fields
	private long m_containerID; // 0x10
	private FieldInfo m_parentField; // 0x18
	private int[] m_parentIndex; // 0x20

	// Properties
	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }

	// Methods

	// RVA: 0x12A4D20 Offset: 0x12A4120 VA: 0x1812A4D20
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public long get_ContainerID() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public FieldInfo get_ParentField() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public int[] get_ParentIndex() { }

}

