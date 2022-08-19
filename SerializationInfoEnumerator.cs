public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 1060
{	// Fields
	private string[] m_members; // 0x10
	private object[] m_data; // 0x18
	private Type[] m_types; // 0x20
	private int m_numItems; // 0x28
	private int m_currItem; // 0x2C
	private bool m_current; // 0x30

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x12A1C70 Offset: 0x12A1070 VA: 0x1812A1C70
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x12A1AD0 Offset: 0x12A0ED0 VA: 0x1812A1AD0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x12A1B00 Offset: 0x12A0F00 VA: 0x1812A1B00 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12A1CF0 Offset: 0x12A10F0 VA: 0x1812A1CF0
	public SerializationEntry get_Current() { }

	// RVA: 0x12A1AF0 Offset: 0x12A0EF0 VA: 0x1812A1AF0 Slot: 6
	public void Reset() { }

	// RVA: 0x12A1E40 Offset: 0x12A1240 VA: 0x1812A1E40
	public string get_Name() { }

	// RVA: 0x12A1FA0 Offset: 0x12A13A0 VA: 0x1812A1FA0
	public object get_Value() { }

	// RVA: 0x12A1EF0 Offset: 0x12A12F0 VA: 0x1812A1EF0
	public Type get_ObjectType() { }

}

