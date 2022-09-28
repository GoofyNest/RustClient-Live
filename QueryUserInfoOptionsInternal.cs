internal struct QueryUserInfoOptionsInternal : ISettable<QueryUserInfoOptions>, IDisposable // TypeDefIndex: 8282
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref QueryUserInfoOptions other) { }

	public void Set(ref Nullable<QueryUserInfoOptions> other) { }

	public void Dispose() { }

}

