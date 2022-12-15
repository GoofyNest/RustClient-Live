internal struct CopyProductUserExternalAccountByIndexOptionsInternal : ISettable<CopyProductUserExternalAccountByIndexOptions>, IDisposable // TypeDefIndex: 9566
{
	private int m_ApiVersion;
	private IntPtr m_TargetUserId;
	private uint m_ExternalAccountInfoIndex;

	public ProductUserId TargetUserId { set; }
	public uint ExternalAccountInfoIndex { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_ExternalAccountInfoIndex(uint value) { }

	public void Set(ref CopyProductUserExternalAccountByIndexOptions other) { }

	public void Set(ref Nullable<CopyProductUserExternalAccountByIndexOptions> other) { }

	public void Dispose() { }

}

