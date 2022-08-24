internal struct SessionMask // TypeDefIndex: 1621
{
	private uint m_mask; 

public static SessionMask All { get; }
public bool Item { get; set; }


public void .ctor(uint mask = 0) { }

public bool IsEqualOrSupersetOf(SessionMask m) { }

public static SessionMask get_All() { }

public static SessionMask FromId(int perEventSourceSessionId) { }

public ulong ToEventKeywords() { }

public static SessionMask FromEventKeywords(ulong m) { }

public bool get_Item(int perEventSourceSessionId) { }

public void set_Item(int perEventSourceSessionId, bool value) { }

public static ulong op_Explicit(SessionMask m) { }

public static uint op_Explicit(SessionMask m) { }

}

