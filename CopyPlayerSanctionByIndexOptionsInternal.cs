internal struct CopyPlayerSanctionByIndexOptionsInternal : ISettable<CopyPlayerSanctionByIndexOptions>, IDisposable // TypeDefIndex: 8620
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private uint m_SanctionIndex; 

	public ProductUserId TargetUserId { set; }
	public uint SanctionIndex { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_SanctionIndex(uint value) { }

	public void Set(ref CopyPlayerSanctionByIndexOptions other) { }

	public void Set(ref Nullable<CopyPlayerSanctionByIndexOptions> other) { }

	public void Dispose() { }

}

