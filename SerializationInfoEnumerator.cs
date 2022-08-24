public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 1060
{
	private string[] m_members; 
	private object[] m_data; 
	private Type[] m_types; 
	private int m_numItems; 
	private int m_currItem; 
	private bool m_current; 

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

