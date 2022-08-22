public sealed class LocalDataStoreSlot // TypeDefIndex: 147
{	private LocalDataStoreMgr m_mgr; // 0x10
	private int m_slot; // 0x18
	private long m_cookie; // 0x20

	internal LocalDataStoreMgr Manager { get; }
	internal int Slot { get; }
	internal long Cookie { get; }


	internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

	internal LocalDataStoreMgr get_Manager() { }

	internal int get_Slot() { }

	internal long get_Cookie() { }

	protected override void Finalize() { }

}

