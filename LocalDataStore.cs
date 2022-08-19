internal sealed class LocalDataStore // TypeDefIndex: 146
{	// Fields
	private LocalDataStoreElement[] m_DataTable; // 0x10
	private LocalDataStoreMgr m_Manager; // 0x18

	// Methods

	// RVA: 0x166F510 Offset: 0x166E910 VA: 0x18166F510
	public void .ctor(LocalDataStoreMgr mgr, int InitialCapacity) { }

	// RVA: 0x166EF10 Offset: 0x166E310 VA: 0x18166EF10
	internal void Dispose() { }

	// RVA: 0x166EFA0 Offset: 0x166E3A0 VA: 0x18166EFA0
	public object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x166F3A0 Offset: 0x166E7A0 VA: 0x18166F3A0
	public void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x166EF40 Offset: 0x166E340 VA: 0x18166EF40
	internal void FreeData(int slot, long cookie) { }

	// RVA: 0x166F0F0 Offset: 0x166E4F0 VA: 0x18166F0F0
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

}

