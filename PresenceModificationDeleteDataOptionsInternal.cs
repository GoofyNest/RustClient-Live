internal struct PresenceModificationDeleteDataOptionsInternal : ISettable<PresenceModificationDeleteDataOptions>, IDisposable // TypeDefIndex: 8839
{
	private int m_ApiVersion; 
	private int m_RecordsCount; 
	private IntPtr m_Records; 

	public PresenceModificationDataRecordId[] Records { set; }


	public void set_Records(PresenceModificationDataRecordId[] value) { }

	public void Set(ref PresenceModificationDeleteDataOptions other) { }

	public void Set(ref Nullable<PresenceModificationDeleteDataOptions> other) { }

	public void Dispose() { }

}

