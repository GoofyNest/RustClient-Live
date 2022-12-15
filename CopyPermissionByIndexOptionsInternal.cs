internal struct CopyPermissionByIndexOptionsInternal : ISettable<CopyPermissionByIndexOptions>, IDisposable // TypeDefIndex: 9329
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private uint m_Index;

	public ProductUserId LocalUserId { set; }
	public uint Index { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Index(uint value) { }

	public void Set(ref CopyPermissionByIndexOptions other) { }

	public void Set(ref Nullable<CopyPermissionByIndexOptions> other) { }

	public void Dispose() { }

}

