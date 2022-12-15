internal struct CopyUserTokenByIndexOptionsInternal : ISettable<CopyUserTokenByIndexOptions>, IDisposable // TypeDefIndex: 8739
{
	private int m_ApiVersion;
	private uint m_UserTokenIndex;
	private uint m_QueryId;

	public uint UserTokenIndex { set; }
	public uint QueryId { set; }


	public void set_UserTokenIndex(uint value) { }

	public void set_QueryId(uint value) { }

	public void Set(ref CopyUserTokenByIndexOptions other) { }

	public void Set(ref Nullable<CopyUserTokenByIndexOptions> other) { }

	public void Dispose() { }

}

