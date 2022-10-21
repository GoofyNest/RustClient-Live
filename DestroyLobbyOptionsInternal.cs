internal struct DestroyLobbyOptionsInternal : ISettable<DestroyLobbyOptions>, IDisposable // TypeDefIndex: 9089
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_LobbyId; 

	public ProductUserId LocalUserId { set; }
	public Utf8String LobbyId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_LobbyId(Utf8String value) { }

	public void Set(ref DestroyLobbyOptions other) { }

	public void Set(ref Nullable<DestroyLobbyOptions> other) { }

	public void Dispose() { }

}

