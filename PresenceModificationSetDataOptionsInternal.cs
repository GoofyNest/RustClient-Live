internal struct PresenceModificationSetDataOptionsInternal : ISettable<PresenceModificationSetDataOptions>, IDisposable // TypeDefIndex: 8850
{
	private int m_ApiVersion; 
	private int m_RecordsCount; 
	private IntPtr m_Records; 

	public DataRecord[] Records { set; }


	public void set_Records(DataRecord[] value) { }

	public void Set(ref PresenceModificationSetDataOptions other) { }

	public void Set(ref Nullable<PresenceModificationSetDataOptions> other) { }

	public void Dispose() { }

}

