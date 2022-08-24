internal sealed class LocalDataStoreMgr // TypeDefIndex: 148
{
	private bool[] m_SlotInfoTable; 
	private int m_FirstAvailableSlot; 
	private List<LocalDataStore> m_ManagedLocalDataStores; 
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; 
	private long m_CookieGenerator; 


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

