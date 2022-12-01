public class ObjectIDGenerator // TypeDefIndex: 1036
{
	internal int m_currentCount;
	internal int m_currentSize;
	internal long[] m_ids;
	internal object[] m_objs;
	private static readonly int[] sizes;


	public void .ctor() { }

	private int FindElement(object obj, out bool found) { }

	public virtual long GetId(object obj, out bool firstTime) { }

	public virtual long HasId(object obj, out bool firstTime) { }

	private void Rehash() { }

	private static void .cctor() { }

}

