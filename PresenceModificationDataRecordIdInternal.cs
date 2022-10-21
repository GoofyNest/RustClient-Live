internal struct PresenceModificationDataRecordIdInternal : IGettable<PresenceModificationDataRecordId>, ISettable<PresenceModificationDataRecordId>, IDisposable // TypeDefIndex: 8837
{
	private int m_ApiVersion; 
	private IntPtr m_Key; 

	public Utf8String Key { get; set; }


	public Utf8String get_Key() { }

	public void set_Key(Utf8String value) { }

	public void Set(ref PresenceModificationDataRecordId other) { }

	public void Set(ref Nullable<PresenceModificationDataRecordId> other) { }

	public void Dispose() { }

	public void Get(out PresenceModificationDataRecordId output) { }

}

