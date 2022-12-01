internal struct GetFriendsVisibleOptionsInternal : ISettable<GetFriendsVisibleOptions>, IDisposable // TypeDefIndex: 8339
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;

	public EpicAccountId LocalUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref GetFriendsVisibleOptions other) { }

	public void Set(ref Nullable<GetFriendsVisibleOptions> other) { }

	public void Dispose() { }

}

