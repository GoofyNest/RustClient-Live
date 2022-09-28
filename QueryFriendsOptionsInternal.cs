internal struct QueryFriendsOptionsInternal : ISettable<QueryFriendsOptions>, IDisposable // TypeDefIndex: 9364
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public EpicAccountId LocalUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref QueryFriendsOptions other) { }

	public void Set(ref Nullable<QueryFriendsOptions> other) { }

	public void Dispose() { }

}

