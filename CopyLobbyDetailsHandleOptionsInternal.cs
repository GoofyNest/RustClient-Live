internal struct CopyLobbyDetailsHandleOptionsInternal : ISettable<CopyLobbyDetailsHandleOptions>, IDisposable // TypeDefIndex: 9044
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyId; 
	private IntPtr m_LocalUserId; 

	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }


	public void set_LobbyId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref CopyLobbyDetailsHandleOptions other) { }

	public void Set(ref Nullable<CopyLobbyDetailsHandleOptions> other) { }

	public void Dispose() { }

}

