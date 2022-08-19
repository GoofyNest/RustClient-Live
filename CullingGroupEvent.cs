public struct CullingGroupEvent // TypeDefIndex: 3365
{	// Fields
	private int m_Index; // 0x0
	private byte m_PrevState; // 0x4
	private byte m_ThisState; // 0x5

	// Properties
	public int index { get; }
	public int currentDistance { get; }
	public int previousDistance { get; }

	// Methods

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public int get_index() { }

	// RVA: 0x2131D0 Offset: 0x2125D0 VA: 0x1802131D0
	public int get_currentDistance() { }

	// RVA: 0x2131E0 Offset: 0x2125E0 VA: 0x1802131E0
	public int get_previousDistance() { }

}

