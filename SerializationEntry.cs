public struct SerializationEntry // TypeDefIndex: 1059
{	// Fields
	private Type m_type; // 0x0
	private object m_value; // 0x8
	private string m_name; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public object get_Value() { }

	// RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
	public string get_Name() { }

	// RVA: 0x1DFA00 Offset: 0x1DEE00 VA: 0x1801DFA00
	internal void .ctor(string entryName, object entryValue, Type entryType) { }

}

