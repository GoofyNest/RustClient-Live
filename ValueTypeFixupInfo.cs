internal class ValueTypeFixupInfo // TypeDefIndex: 1064
{	private long m_containerID; // 0x10
	private FieldInfo m_parentField; // 0x18
	private int[] m_parentIndex; // 0x20

	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }


	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	public long get_ContainerID() { }

	public FieldInfo get_ParentField() { }

	public int[] get_ParentIndex() { }

}

