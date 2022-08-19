internal sealed class LocalDataStoreMgr // TypeDefIndex: 148
{	// Fields
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x166E6C0 Offset: 0x166DAC0 VA: 0x18166E6C0
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x166E840 Offset: 0x166DC40 VA: 0x18166E840
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x166E390 Offset: 0x166D790 VA: 0x18166E390
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x166E5B0 Offset: 0x166D9B0 VA: 0x18166E5B0
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x166EBE0 Offset: 0x166DFE0 VA: 0x18166EBE0
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x166EAF0 Offset: 0x166DEF0 VA: 0x18166EAF0
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x166E930 Offset: 0x166DD30 VA: 0x18166E930
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x166ED00 Offset: 0x166E100 VA: 0x18166ED00
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0xA4F990 Offset: 0xA4ED90 VA: 0x180A4F990
	internal int GetSlotTableLength() { }

	// RVA: 0x166ED80 Offset: 0x166E180 VA: 0x18166ED80
	public void .ctor() { }

}

