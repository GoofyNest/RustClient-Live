internal struct ShowReportPlayerOptionsInternal : ISettable<ShowReportPlayerOptions>, IDisposable // TypeDefIndex: 8372
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref ShowReportPlayerOptions other) { }

	public void Set(ref Nullable<ShowReportPlayerOptions> other) { }

	public void Dispose() { }

}

