internal struct GetTransactionCountOptionsInternal : ISettable<GetTransactionCountOptions>, IDisposable // TypeDefIndex: 9466
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public EpicAccountId LocalUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref GetTransactionCountOptions other) { }

	public void Set(ref Nullable<GetTransactionCountOptions> other) { }

	public void Dispose() { }

}

