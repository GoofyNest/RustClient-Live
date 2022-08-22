public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 1060
{	private string[] m_members; // 0x10
	private object[] m_data; // 0x18
	private Type[] m_types; // 0x20
	private int m_numItems; // 0x28
	private int m_currItem; // 0x2C
	private bool m_current; // 0x30

	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }


	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	public bool MoveNext() { }

	private object System.Collections.IEnumerator.get_Current() { }

	public SerializationEntry get_Current() { }

	public void Reset() { }

	public string get_Name() { }

	public object get_Value() { }

	public Type get_ObjectType() { }

}

