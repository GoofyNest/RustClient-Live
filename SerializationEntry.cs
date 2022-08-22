public struct SerializationEntry // TypeDefIndex: 1059
{	private Type m_type; // 0x0
	private object m_value; // 0x8
	private string m_name; // 0x10

	public object Value { get; }
	public string Name { get; }


	public object get_Value() { }

	public string get_Name() { }

	internal void .ctor(string entryName, object entryValue, Type entryType) { }

}

