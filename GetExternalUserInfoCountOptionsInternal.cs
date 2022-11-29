internal struct GetExternalUserInfoCountOptionsInternal : ISettable<GetExternalUserInfoCountOptions>, IDisposable // TypeDefIndex: 8308
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref GetExternalUserInfoCountOptions other) { }

	public void Set(ref Nullable<GetExternalUserInfoCountOptions> other) { }

	public void Dispose() { }

}

