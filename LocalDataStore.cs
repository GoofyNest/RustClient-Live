internal sealed class LocalDataStore // TypeDefIndex: 146
{
	private LocalDataStoreElement[] m_DataTable; 
	private LocalDataStoreMgr m_Manager; 


	public void .ctor(LocalDataStoreMgr mgr, int InitialCapacity) { }

	internal void Dispose() { }

	public object GetData(LocalDataStoreSlot slot) { }

	public void SetData(LocalDataStoreSlot slot, object data) { }

	internal void FreeData(int slot, long cookie) { }

	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

}

