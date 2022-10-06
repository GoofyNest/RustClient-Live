internal struct CopyStatByIndexOptionsInternal : ISettable<CopyStatByIndexOptions>, IDisposable // TypeDefIndex: 8417
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private uint m_StatIndex; 

	public ProductUserId TargetUserId { set; }
	public uint StatIndex { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_StatIndex(uint value) { }

	public void Set(ref CopyStatByIndexOptions other) { }

	public void Set(ref Nullable<CopyStatByIndexOptions> other) { }

	public void Dispose() { }

}

