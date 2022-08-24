public sealed class LocalDataStoreSlot // TypeDefIndex: 147
{
	private LocalDataStoreMgr m_mgr; 
	private int m_slot; 
	private long m_cookie; 

internal LocalDataStoreMgr Manager { get; }
internal int Slot { get; }
internal long Cookie { get; }


internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

internal LocalDataStoreMgr get_Manager() { }

internal int get_Slot() { }

internal long get_Cookie() { }

protected override void Finalize() { }

}

