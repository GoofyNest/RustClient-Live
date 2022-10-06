internal struct CopyUserTokenByUserIdOptionsInternal : ISettable<CopyUserTokenByUserIdOptions>, IDisposable // TypeDefIndex: 8727
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private uint m_QueryId; 

	public ProductUserId TargetUserId { set; }
	public uint QueryId { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_QueryId(uint value) { }

	public void Set(ref CopyUserTokenByUserIdOptions other) { }

	public void Set(ref Nullable<CopyUserTokenByUserIdOptions> other) { }

	public void Dispose() { }

}

