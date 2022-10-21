internal struct ShowFriendsOptionsInternal : ISettable<ShowFriendsOptions>, IDisposable // TypeDefIndex: 8370
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public EpicAccountId LocalUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref ShowFriendsOptions other) { }

	public void Set(ref Nullable<ShowFriendsOptions> other) { }

	public void Dispose() { }

}

