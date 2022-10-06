internal struct ShowBlockPlayerOptionsInternal : ISettable<ShowBlockPlayerOptions>, IDisposable // TypeDefIndex: 8365
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref ShowBlockPlayerOptions other) { }

	public void Set(ref Nullable<ShowBlockPlayerOptions> other) { }

	public void Dispose() { }

}

