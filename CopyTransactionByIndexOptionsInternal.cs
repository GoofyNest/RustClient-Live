internal struct CopyTransactionByIndexOptionsInternal : ISettable<CopyTransactionByIndexOptions>, IDisposable // TypeDefIndex: 9454
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private uint m_TransactionIndex; 

	public EpicAccountId LocalUserId { set; }
	public uint TransactionIndex { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TransactionIndex(uint value) { }

	public void Set(ref CopyTransactionByIndexOptions other) { }

	public void Set(ref Nullable<CopyTransactionByIndexOptions> other) { }

	public void Dispose() { }

}

