internal struct QueryUserInfoByDisplayNameOptionsInternal : ISettable<QueryUserInfoByDisplayNameOptions>, IDisposable // TypeDefIndex: 8320
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_DisplayName;

	public EpicAccountId LocalUserId { set; }
	public Utf8String DisplayName { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_DisplayName(Utf8String value) { }

	public void Set(ref QueryUserInfoByDisplayNameOptions other) { }

	public void Set(ref Nullable<QueryUserInfoByDisplayNameOptions> other) { }

	public void Dispose() { }

}

