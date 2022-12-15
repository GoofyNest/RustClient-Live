internal struct QueryIdTokenOptionsInternal : ISettable<QueryIdTokenOptions>, IDisposable // TypeDefIndex: 9705
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_TargetAccountId;

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetAccountId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetAccountId(EpicAccountId value) { }

	public void Set(ref QueryIdTokenOptions other) { }

	public void Set(ref Nullable<QueryIdTokenOptions> other) { }

	public void Dispose() { }

}

