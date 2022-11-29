internal struct CopyUserInfoOptionsInternal : ISettable<CopyUserInfoOptions>, IDisposable // TypeDefIndex: 8304
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref CopyUserInfoOptions other) { }

	public void Set(ref Nullable<CopyUserInfoOptions> other) { }

	public void Dispose() { }

}

