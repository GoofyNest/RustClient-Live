internal struct GetStatusOptionsInternal : ISettable<GetStatusOptions>, IDisposable // TypeDefIndex: 9383
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref GetStatusOptions other) { }

	public void Set(ref Nullable<GetStatusOptions> other) { }

	public void Dispose() { }

}

