internal class ObjectHolderList // TypeDefIndex: 1042
{
	internal ObjectHolder[] m_values;
	internal int m_count;

	internal int Version { get; }
	internal int Count { get; }


	internal void .ctor() { }

	internal void .ctor(int startingSize) { }

	internal virtual void Add(ObjectHolder value) { }

	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	private void EnlargeArray() { }

	internal int get_Version() { }

	internal int get_Count() { }

}

