internal class ObjectHolderListEnumerator // TypeDefIndex: 1043
{	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	internal ObjectHolder Current { get; }


	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	internal bool MoveNext() { }

	internal ObjectHolder get_Current() { }

}

