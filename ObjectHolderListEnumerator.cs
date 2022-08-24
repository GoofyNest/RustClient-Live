internal class ObjectHolderListEnumerator // TypeDefIndex: 1043
{
	private bool m_isFixupEnumerator; 
	private ObjectHolderList m_list; 
	private int m_startingVersion; 
	private int m_currPos; 

	internal ObjectHolder Current { get; }


	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	internal bool MoveNext() { }

	internal ObjectHolder get_Current() { }

}

