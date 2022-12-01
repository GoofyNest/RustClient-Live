internal struct EndPlayerSessionOptionsAccountIdInternal : IGettable<EndPlayerSessionOptionsAccountId>, ISettable<EndPlayerSessionOptionsAccountId>, IDisposable // TypeDefIndex: 9050
{
	private MetricsAccountIdType m_AccountIdType;
	private IntPtr m_Epic;
	private IntPtr m_External;

	public EpicAccountId Epic { get; set; }
	public Utf8String External { get; set; }


	public EpicAccountId get_Epic() { }

	public void set_Epic(EpicAccountId value) { }

	public Utf8String get_External() { }

	public void set_External(Utf8String value) { }

	public void Set(ref EndPlayerSessionOptionsAccountId other) { }

	public void Set(ref Nullable<EndPlayerSessionOptionsAccountId> other) { }

	public void Dispose() { }

	public void Get(out EndPlayerSessionOptionsAccountId output) { }

}

