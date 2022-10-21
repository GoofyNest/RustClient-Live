internal struct AddNotifyRTCRoomConnectionChangedOptionsInternal : ISettable<AddNotifyRTCRoomConnectionChangedOptions>, IDisposable // TypeDefIndex: 9065
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyId_DEPRECATED; 
	private IntPtr m_LocalUserId_DEPRECATED; 

	public Utf8String LobbyId_DEPRECATED { set; }
	public ProductUserId LocalUserId_DEPRECATED { set; }


	public void set_LobbyId_DEPRECATED(Utf8String value) { }

	public void set_LocalUserId_DEPRECATED(ProductUserId value) { }

	public void Set(ref AddNotifyRTCRoomConnectionChangedOptions other) { }

	public void Set(ref Nullable<AddNotifyRTCRoomConnectionChangedOptions> other) { }

	public void Dispose() { }

}

