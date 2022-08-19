public sealed class LocalDataStoreSlot // TypeDefIndex: 147
{	// Fields
	private LocalDataStoreMgr m_mgr; // 0x10
	private int m_slot; // 0x18
	private long m_cookie; // 0x20

	// Properties
	internal LocalDataStoreMgr Manager { get; }
	internal int Slot { get; }
	internal long Cookie { get; }

	// Methods

	// RVA: 0x166EED0 Offset: 0x166E2D0 VA: 0x18166EED0
	internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal LocalDataStoreMgr get_Manager() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	internal int get_Slot() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal long get_Cookie() { }

	// RVA: 0x166EE30 Offset: 0x166E230 VA: 0x18166EE30 Slot: 1
	protected override void Finalize() { }

}

