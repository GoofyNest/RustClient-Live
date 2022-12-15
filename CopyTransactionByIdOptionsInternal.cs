internal struct CopyTransactionByIdOptionsInternal : ISettable<CopyTransactionByIdOptions>, IDisposable // TypeDefIndex: 9456
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_TransactionId;

	public EpicAccountId LocalUserId { set; }
	public Utf8String TransactionId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TransactionId(Utf8String value) { }

	public void Set(ref CopyTransactionByIdOptions other) { }

	public void Set(ref Nullable<CopyTransactionByIdOptions> other) { }

	public void Dispose() { }

}

