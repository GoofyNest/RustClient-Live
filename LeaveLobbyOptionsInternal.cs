internal struct LeaveLobbyOptionsInternal : ISettable<LeaveLobbyOptions>, IDisposable // TypeDefIndex: 9128
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_LobbyId; 

	public ProductUserId LocalUserId { set; }
	public Utf8String LobbyId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_LobbyId(Utf8String value) { }

	public void Set(ref LeaveLobbyOptions other) { }

	public void Set(ref Nullable<LeaveLobbyOptions> other) { }

	public void Dispose() { }

}

