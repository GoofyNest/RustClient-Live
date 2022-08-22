public class ObjectIDGenerator // TypeDefIndex: 1036
{	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0


	public void .ctor() { }

	private int FindElement(object obj, out bool found) { }

	public virtual long GetId(object obj, out bool firstTime) { }

	public virtual long HasId(object obj, out bool firstTime) { }

	private void Rehash() { }

	private static void .cctor() { }

}

