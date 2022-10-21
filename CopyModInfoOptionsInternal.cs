internal struct CopyModInfoOptionsInternal : ISettable<CopyModInfoOptions>, IDisposable // TypeDefIndex: 9001
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private ModEnumerationType m_Type; 

	public EpicAccountId LocalUserId { set; }
	public ModEnumerationType Type { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_Type(ModEnumerationType value) { }

	public void Set(ref CopyModInfoOptions other) { }

	public void Set(ref Nullable<CopyModInfoOptions> other) { }

	public void Dispose() { }

}

