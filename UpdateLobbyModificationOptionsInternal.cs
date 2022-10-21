internal struct UpdateLobbyModificationOptionsInternal : ISettable<UpdateLobbyModificationOptions>, IDisposable // TypeDefIndex: 9264
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_LobbyId; 

	public ProductUserId LocalUserId { set; }
	public Utf8String LobbyId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_LobbyId(Utf8String value) { }

	public void Set(ref UpdateLobbyModificationOptions other) { }

	public void Set(ref Nullable<UpdateLobbyModificationOptions> other) { }

	public void Dispose() { }

}

