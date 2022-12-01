internal struct IsRTCRoomConnectedOptionsInternal : ISettable<IsRTCRoomConnectedOptions>, IDisposable // TypeDefIndex: 9112
{
	private int m_ApiVersion;
	private IntPtr m_LobbyId;
	private IntPtr m_LocalUserId;

	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }


	public void set_LobbyId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref IsRTCRoomConnectedOptions other) { }

	public void Set(ref Nullable<IsRTCRoomConnectedOptions> other) { }

	public void Dispose() { }

}

