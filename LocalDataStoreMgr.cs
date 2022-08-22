internal sealed class LocalDataStoreMgr // TypeDefIndex: 148
{	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30


	public LocalDataStoreHolder CreateLocalDataStore() { }

	public void DeleteLocalDataStore(LocalDataStore store) { }

	public LocalDataStoreSlot AllocateDataSlot() { }

	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	public void FreeNamedDataSlot(string name) { }

	internal void FreeDataSlot(int slot, long cookie) { }

	public void ValidateSlot(LocalDataStoreSlot slot) { }

	internal int GetSlotTableLength() { }

	public void .ctor() { }

}

