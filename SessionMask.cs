internal struct SessionMask // TypeDefIndex: 1621
{	// Fields
	private uint m_mask; // 0x0

	// Properties
	public static SessionMask All { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x19F520 Offset: 0x19E920 VA: 0x18019F520
	public void .ctor(uint mask = 0) { }

	// RVA: 0x19F500 Offset: 0x19E900 VA: 0x18019F500
	public bool IsEqualOrSupersetOf(SessionMask m) { }

	// RVA: 0x10DFA70 Offset: 0x10DEE70 VA: 0x1810DFA70
	public static SessionMask get_All() { }

	// RVA: 0x10DFA30 Offset: 0x10DEE30 VA: 0x1810DFA30
	public static SessionMask FromId(int perEventSourceSessionId) { }

	// RVA: 0x19F510 Offset: 0x19E910 VA: 0x18019F510
	public ulong ToEventKeywords() { }

	// RVA: 0x10DFA20 Offset: 0x10DEE20 VA: 0x1810DFA20
	public static SessionMask FromEventKeywords(ulong m) { }

	// RVA: 0x19F530 Offset: 0x19E930 VA: 0x18019F530
	public bool get_Item(int perEventSourceSessionId) { }

	// RVA: 0x19F550 Offset: 0x19E950 VA: 0x18019F550
	public void set_Item(int perEventSourceSessionId, bool value) { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static ulong op_Explicit(SessionMask m) { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static uint op_Explicit(SessionMask m) { }

}

