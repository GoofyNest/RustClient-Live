internal struct GetFriendsCountOptionsInternal : ISettable<GetFriendsCountOptions>, IDisposable // TypeDefIndex: 9381
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public EpicAccountId LocalUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref GetFriendsCountOptions other) { }

	public void Set(ref Nullable<GetFriendsCountOptions> other) { }

	public void Dispose() { }

}

