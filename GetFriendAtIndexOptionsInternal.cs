internal struct GetFriendAtIndexOptionsInternal : ISettable<GetFriendAtIndexOptions>, IDisposable // TypeDefIndex: 9379
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private int m_Index; 

	public EpicAccountId LocalUserId { set; }
	public int Index { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_Index(int value) { }

	public void Set(ref GetFriendAtIndexOptions other) { }

	public void Set(ref Nullable<GetFriendAtIndexOptions> other) { }

	public void Dispose() { }

}

