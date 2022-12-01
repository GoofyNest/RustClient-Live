internal struct QueryPresenceOptionsInternal : ISettable<QueryPresenceOptions>, IDisposable // TypeDefIndex: 8862
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref QueryPresenceOptions other) { }

	public void Set(ref Nullable<QueryPresenceOptions> other) { }

	public void Dispose() { }

}

